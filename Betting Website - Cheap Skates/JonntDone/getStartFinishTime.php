<html>
<body>

<?php
  $EventID = $_GET['EventID'];

  $currentTime = mktime();
  $startTime;
  $endTime;
  $startTimeSeconds;
  $endTimeSeconds;

  //Get the start time from the database.
  $startTimeQuery = mysql_query("SELECT * FROM csEvents WHERE EventID=$EventID");
  while ($row = mysql_fetch_array($startTimeQuery))
  {
    global $startTime;
    global $startTimeSeconds;
    $startTime = $row['StartD&T'];
    $startTimeSeconds = strtotime($startTime);
  }//while

  //Get the end time from the database.
  $endTimeQuery = mysql_query("SELECT * FROM csEvents WHERE EventID=$EventID");
  while ($row = mysql_fetch_array($endTimeQuery))
  {
    global $endTime;
    global $endTimeSeconds;
    $endTime = $row['EndD&T'];
    $endTimeSeconds = strtotime($endTime);
  }//while

  //Displays start time before event starts
  if ($currentTime < $startTimeSeconds)
  {
    echo "The event starts at $startTime </br>";
    echo "Betting is open until then!";
  }//if
  else
  {
    //If event has start check to see if it's finished.
    if ($currentTime < $endTimeSeconds)
    {
      echo "The event has started! Betting is now closed. </br>";
      echo "The event will finish at $endTime";
    }//if
    else
    {  
      echo "The results are in!";

      //...code to reward users who got the bests right.. will need odds to do
      //this but have an idea :)
    }//else
  }//else
      

  
?>
