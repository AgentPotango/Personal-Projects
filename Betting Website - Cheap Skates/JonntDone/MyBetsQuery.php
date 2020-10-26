<html>
<body>
<?php 

  
  //Gets the id of the current who is currently logged in
  $currentUser = $_SESSION['member_id'];
  $EventIDsArray = array();
  $index = 0;
  
  //Order the events the user has placed bet on in descending order from when
  //the bet was placed
  $orderRequest = mysql_query("SELECT * FROM csBetPlaced 
                              ORDER BY BetPlacedOn DESC");

  //Checks the ordered table for a matching member id. Then put the event ID
  //that the user has made a bet on into an array.
  while ($row = mysql_fetch_array($orderRequest))
  {
    if ($row['MemberID'] == $currentUser)
    {
      $EventIDsArray[$index] = $row['EventID'];
      $index = $index + 1;
      
    }//if
  }//while

  $numberOfEventsBettedOn = $index;
  $EventIDList = join(',',$EventIDsArray);
					
					

  //Goes through array and outputs each required property of each event.
  for ($i = 0; $i < $numberOfEventsBettedOn; $i++)
  {
    echo'<tr>';
    //Output image.
    $imageQuery = mysql_query("SELECT EventImage FROM csEvents 
                              WHERE EventID=$EventIDsArray[$i]");

    while($row = mysql_fetch_array($imageQuery))
    {
      $image=$row['EventImage'];

      $mime = null;
      if ($type=="pjpeg") // <<< where do you get $type btw?
        $mime = "image/jpeg";

      $image = "data:".$mime.";base64," . base64_encode($image);
      echo '<td><img src="'.$image.'" alt="User Avatar" width="50" height="50" /></td>';

    }//while

    //Output event name
    $nameQuery = mysql_query("SELECT EventName FROM csEvents
                             WHERE EventID=$EventIDsArray[$i]");

    while ($row = mysql_fetch_array($nameQuery))
      echo'<td><a href="EventPage.php?EventID='.$EventIDsArray[$i].'">'.$row['EventName'].'</a></td>';
    
    //Output the perdiction the user has made (win/draw/loss).
    $predictionQuery = mysql_query("SELECT BetPlacedID FROM csBetPlaced
                                   WHERE EventID=$EventIDsArray[$i]
                                   AND MemberID=$currentUser");

    while ($row = mysql_fetch_array($predictionQuery))
    {
      if ($row['BetPlacedID'] == 1)
        echo '<td>Win</td>';
      if ($row['BetPlacedID'] == 2)
        echo '<td>Draw</td>';
      if ($row['BetPlacedID'] == 3)
        echo '<td>Loose</td>';
    }//while

    //Finally the amount of coins staked is outputed.
    $coinsBettedQuery = mysql_query("SELECT BetAmount FROM csBetPlaced
                                     WHERE EventID=$EventIDsArray[$i]
                                     AND MemberID=$currentUser"); 

    while ($row = mysql_fetch_array($coinsBettedQuery))
      echo '<td>'.$row['BetAmount'].'</td>';

    //Display the date the bet was placed
    $dateQuery = mysql_query("SELECT BetPlacedOn FROM csBetPlaced
                              WHERE EventID=$EventIDsArray[$i]
                              AND MemberID=$currentUser");
	
    while ($row = mysql_fetch_array($dateQuery))
    {
      $dateOfBet = DATE($row['BetPlacedOn']);
      echo'<td>'.$dateOfBet.'</td>';
    }//while

   echo '</tr>';
  }//for
?>
