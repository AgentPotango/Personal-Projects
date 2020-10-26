<html>
<body>

<?php
  $EventID = mysql_real_escape_string($_GET['EventID']);
  $winningChoice = $_GET['WinningChoice'];
  $winningUsersArray = array();
  $index = 0;

  $winningUsersQuery = mysql_query("SELECT * FROM csBetPlaced WHERE EventID=$EventID
                                   AND Choice=$winningChoice");

  while ($row = mysql_fetch_array($winningUsersQuery))
  {  
    $winningUsersArray[$index] = $row['MemberID'];
    $index = $index + 1;
  }//while

  $numberOfWinningUsers = $index + 1;
  for ($i = 0; $i < $numberOfWinningUsers; $i++)
  {
    $oddsQuery = mysql_query("SELECT ChoiceOdds FROM csChoices
                             WHERE EventID=$EventID AND
                             ChoiceName=$winningChoices");
   
    $odds;
    while ($row = mysql_fetch_array($oddsQuery))
    {  
      $odds = $row['ChoiceOdds'];
    }//while

    //Get current Coins
    $currentCoinsQuery = mysql_query("SELECT CurrentCoins FROM csBetStats
                                   WHERE MemberID=$winningUsersArray[$i]");

    $currentCoins;
    while ($row = mysql_fetch_array($currentCoinQuery))
    {  
      $currentCoins = $row['CurrentCoins'];
    }//while

    //Get number of points betted
    $betAmountQuery = mysql_query("SELECT * FROM csBetPlaced
                               WHERE EventID=$EventID AND
                               MemberID=$winningUsersArray[$i]");
   
    $betAmount;
    while ($row = mysql_fetch_array($betAmountQuery))
    {  
      $betAmount = $row['BetAmount'];
    }//while


    $currentPointsUpdate = $betAmount * $odds;

    mysql_query("UPDATE csBetStats SET CurrentCoins=$currentPointsUpdate WHERE MemberID=$winningUsersArray[$i]");
  }//for
?>
 
  
