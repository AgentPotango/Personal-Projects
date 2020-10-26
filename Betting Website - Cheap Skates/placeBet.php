
<?php
  include 'init.php';
  
  //Variables to keep track of current user logged in and their bet.
  $EventID = $_POST['EventID'];
  $currentUser = $_SESSION['member_id'];
  
  $bet = $_POST['bet'];
  $betID = $_POST['prediction'];
 
  //Variables for the current time and the start time of the event.
  $currentTime = mktime();
  $startTime;
  $endTime;
  $winningChoice;
  $currentCoins;
  $startTimeQuery = mysql_query("SELECT * FROM csEvents WHERE EventID=$EventID");
  while ($row = mysql_fetch_array($startTimeQuery))
  {  
    global $startTime;
    $startTime = strtotime($row['StartD&T']);
    $endTime = strtotime($row['EndD&T']);
    $winningChoice = $row['WinningChoice'];
  }//while

  $currentCoinsQuery = mysql_query("SELECT CurrentCoins FROM csBetStats 
                                   WHERE MemberID=$currentUser");
  while ($row = mysql_fetch_array($currentCoinsQuery))
  { 
    global $currentCoins; 
    $currentCoins = $row['CurrentCoins'];
  }//while
  
  if (!ctype_digit($bet))
    echo 'Please supply a whole number of coins! <a href="EventPage.php?EventID='.$EventID.'">Go Back</a>'; 
  
  else if ($betID == "")
    echo 'Please select a choice! <a href="EventPage.php?EventID='.$EventID.'">Go Back</a>';

  else if ($currentCoins < $bet)
  {  
    //Gray out form and radio buttons. Display message if possible.
    echo 'You do not have enough coins to make that bet! <a href="EventPage.php?EventID='.$EventID.'">Go Back</a>';
  }//else if
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
      echo 'You have already placed a bet on this event! <a href="EventPage.php?EventID='.$EventID.'">Go Back</a>';
    else
    {
             
      //Adds the bet to the database.
      mysql_query("INSERT INTO csBetPlaced (MemberID, EventID, BetAmount, Choice)
                  VALUES ('$currentUser', '$EventID', '$bet', '$betID')");
    
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
      

      $currentCoinsUpdate = ($currentCoins - $bet);

      

      mysql_query("UPDATE csBetStats SET BetsPlaced=$totalBetsUpdate
                    WHERE MemberID=$currentUser");
      mysql_query("UPDATE csBetStats SET CurrentCoins=$currentCoinsUpdate
                    WHERE MemberID=$currentUser"); 

      //Adds one to the number of people who have gone for the chosen prediction.
      
      
      $choiceVotesUpdate;
      $choiceVotesQuery = mysql_query("SELECT ChoiceVotes FROM csChoices
                                      WHERE ChoiceName=$betID
                                      AND EventID=$EventID");
 
      while ($row = mysql_fetch_array($choiceVotesQuery))
        $choiceVotesUpdate = $row['ChoiceVotes'] + 1;
	
	echo $choiceVotesUpdate;
      mysql_query("UPDATE csChoices SET ChoiceVotes='$choiceVotesUpdate'
                  WHERE ChoiceName='$betID' AND EventID='$EventID'");
 
      
      echo 'Bet placed successfully! <a href="EventPage.php?EventID='.$EventID.'">Go Back</a>';
    }//else
  }//else
  


?>
</body>
</html>
    


    

    


