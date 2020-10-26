<html>
<body>
<h1>Updating settings...</h1>

<?php
  include 'init.php';
  echo 'Hello';
  $EVENTID = mysql_real_escape_string($_POST['EventID']);
  $WINCHOICE = mysql_real_escape_string($_POST['WinningChoice']);
  
  $ID = $_SESSION['member_id'];
  $query = mysql_query("SELECT UserLevel from csLogin WHERE MemberID=$ID");
  $resultquery = mysql_fetch_array($query);
  $userlevel = $resultquery['UserLevel'];
  
  if ($userlevel == 2)
  {
  echo 'User level was 2';
  
  if ($WINCHOICE != "")
  {
    $query = mysql_query("UPDATE csEvents SET WinningChoice='$WINCHOICE' WHERE EventID=$EVENTID");
  }
  
  
  $winningChoiceQuery = mysql_query("SELECT * FROM csChoices WHERE ChoiceID = $WINCHOICE");
  $winningChoiceResult = mysql_fetch_array($winningChoiceQuery);
  $winningChoiceName = $winningChoiceResult['ChoiceName'];
  $winningChoiceOdds = $winningChoiceResult['ChoiceOdds'];
  
  $betsQuery = mysql_query("SELECT * FROM csBetPlaced WHERE EventID = $EVENTID"); // works
  while($betsRows = mysql_fetch_array($betsQuery))
  {
    $choiceName = $betsRows['Choice'];
    if ($choiceName == $winningChoiceName)
    {
      echo 'The choice name matched';
      //award the user who made that choice
      $pointsBet = $betsRows['BetAmount'];
      $pointsToAward = $pointsBet * $winningChoiceOdds;
      $userID = $betsRows['MemberID'];
      $userQuery = mysql_query("SELECT * FROM csBetStats WHERE MemberID = $userID");
      $userStats = mysql_fetch_array($userQuery);
      $currentCoins = $userStats['CurrentCoins'] + $pointsToAward;
      $coinsWon = $userStats['CoinsWon'] + $pointsToAward;
      $betsWon = $userStats['BetsWon'] + 1;
      $streak = $userStats['Streak'] + 1;
      if ($betsWon > 0)
        $accuracy = $betsWon /$userStats['BetsPlaced'];
      else
        $accuracy = 0;
      
      mysql_query("UPDATE csBetStats SET CurrentCoins=$currentCoins WHERE MemberID=$userID");
      mysql_query("UPDATE csBetStats SET CoinsWon = $coinsWon WHERE MemberID=$userID");
      mysql_query("UPDATE csBetStats SET BetsWon=$betsWon WHERE MemberID=$userID");
      mysql_query("UPDATE csBetStats SET Streak=$streak WHERE MemberID=$userID");
      mysql_query("UPDATE csBetStats SET Accuracy=$accuracy WHERE MemberID=$userID");
      
    }
    else
    {
      echo 'The choice name did not match';
      $userID = $betsRows['MemberID'];
      $userQuery = mysql_query("SELECT * FROM csBetStats WHERE MemberID = $userID");
      $userStats = mysql_fetch_array($userQuery);
      $betsWon = $userStats['BetsWon'];
      $streak = 0;
      if ($betsWon > 0)
        $accuracy = $betsWon /$userStats['BetsPlaced'];
      else
        $accuracy = 0;
        
      mysql_query("UPDATE csBetStats SET Streak=$streak WHERE MemberID=$userID");
      mysql_query("UPDATE csBetStats SET Accuracy=$accuracy WHERE MemberID=$userID");
    }
  }
      
  
  
  
  
  
  
  
  
  
  
  
  
  


  }
  header('Location: admin.php?tabindex=1');
?>





</body>
</html>
