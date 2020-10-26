<html>
<body>

<?php
  $EventID = $_GET['EventID'];

  //Extracting the required event name from the table, for the time being it'll be the event with ID number of 1.
  $getEventDescription = mysql_query("SELECT EventDescription FROM csEvents WHERE EventID=$EventID");
  
  while ($row = mysql_fetch_array($getEventDescription))
    echo $row['EventDescription'];

  
?>
