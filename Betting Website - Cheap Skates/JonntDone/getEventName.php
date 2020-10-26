<html>
<body>

<?php
  
  $EventID = $_GET['EventID'];
  
  //Extracting the required event name from the table, for the time being it'll be the event with ID number of 1.
  $getEventName = mysql_query("SELECT EventName FROM csEvents WHERE EventID=$EventID");
  
  while ($row = mysql_fetch_array($getEventName))
    echo $row['EventName'];


?>
