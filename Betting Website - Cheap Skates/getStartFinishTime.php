<html>
<body>

<?php
  $EventID = mysql_real_escape_string($_GET['EventID']);

  $currentTimeUnix = mktime();
  $currentTime = date('Y-m-d H:i:s', $currentTimeUnix);

  //Get the start time from the database.
  $startTimeQuery = mysql_query("SELECT * FROM csEvents WHERE EventID=$EventID");
  $row = mysql_fetch_array($startTimeQuery);
  $startTime = $row['StartDandT'];

  //Get the end time from the database.
  $endTimeQuery = mysql_query("SELECT * FROM csEvents WHERE EventID=$EventID");
  $row = mysql_fetch_array($endTimeQuery);
  $endTime = $row['EndDandT'];
  $winningChoice = $row['WinningChoice'];
  
  $choiceQuery = mysql_query("SELECT * FROM csChoices WHERE EventID=$EventID");
  $choiceResult = mysql_fetch_array($choiceQuery);
  $choiceName = $choiceResult['ChoiceName'];

  //Displays start time before event starts
  if ($currentTime < $startTime)
  {
    echo "The event starts at $startTime </br>";
    echo "Betting is open until then!";
  }//if
  else
  {
    //If event has start check to see if it's finished.
    if ($currentTime < $endTime)
    {
      echo "The event has started! Betting is now closed. </br>";
      echo "The event will finish at $endTime";
    }//if
    else
    {  
      if ($winningChoice == 0)
        echo 'The event has finished! Waiting for results...';
      else  
        echo "The event has finished! The winning choice was ".$choiceName;
    

      //...code to reward users who got the bests right.. will need odds to do
      //this but have an idea :)
    }//else
  }//else
      

  
?>
</body>
</html>
