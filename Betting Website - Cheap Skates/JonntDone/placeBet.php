
<?php
  include 'init.php';
  
  //Variables to keep track of current user logged in and their bet.
  $EventID = $_GET['EventID'];
  $currentUser = $_SESSION['member_id'];
  
  $bet = $_POST['bet'];
  $betID = $_POST['prediction'];
 
  //Variables for the current time and the start time of the event.
  $currentTime = mktime();
  $startTime;
  $startTimeQuery = mysql_query("SELECT * FROM csEvents WHERE EventID=$EventID");
  while ($row = mysql_fetch_array($startTimeQuery))
  {  
    global $startTime;
    $startTime = strtotime($row['StartD&T']);
  }//while
  
  if ($currentTime < $startTime)
  {  
    //Gray out options
    echo "TIMES UP!";
    
  }//if
  else
  {
    if ($currentUser == "")
    {  
      //Gray out form and radio buttons. Display message if possible.
      echo "You must be logged in to bet!";
      
    }//if
    else
    {
      //Checks to see if user has already made a bet
      $numberOfBetsOnEvent = 0;
      $pastBetQuery = mysql_query("SELECT * FROM csBetPlaced
                                  WHERE MemberID=$currentUser
                                  AND EventID=$EventID");
      while($row = mysql_fetch_array($pastBetQuery))
      {
        global $numberOfBetsOnEvent;
        $numberOfBetsOnEvent = $numberOfBetsOnEvent + 1;
      }//while

      if ($numberOfBetsOnEvent != 0)
        echo "You have already placed a bet on this event!";
      else
      {
        /*$bet = $_POST['bet'];
        $betID = $_POST['prediction'];*/
        
        //Adds the bet to the database.
        mysql_query("INSERT INTO csBetPlaced (BetPlacedID, MemberID, EventID, BetAmount)
                    VALUES ($betID, $currentUser, $EventID, $bet)");
    
        //Aquires the total number of bets placed and subracted the number of
        //points staked.
        
        $totalBets;
        $totalBetsQuery = mysql_query("SELECT * FROM csBetStats
                                      WHERE MemberID=$currentUser");
        while ($row = mysql_fetch_array($totalBetsQuery))
        {
          global $totalBets;
          $totalBets = $row['BetsPlaced'];
        }//while
	
        $totalBetsUpdate = $totalBets + 1;
        $currentCoins;
        $currentCoinsQuery = mysql_query("SELECT * FROM csBetStats
                                         WHERE MemberID=$currentUser");
        while ($row = mysql_fetch_array($currentCoinsQuery))
        {
          global $currentCoins;
          $currentCoins = $row['CurrentCoins'];
echo $currentCoins;
        }//while

        $currentCoinsUpdate = ($currentCoins - $bet);

        mysql_query("UPDATE csBetStats SET BetsPlaced=$totalBetsUpdate
                    WHERE MemberID=$currentUser");
        mysql_query("UPDATE csBetStats SET CurrentCoins=$currentCoinsUpdate
                    WHERE MemberID=$currentUser"); 
       
      }//else
    }//else
  }//else


?>
</body>
</html>
    


    

    


