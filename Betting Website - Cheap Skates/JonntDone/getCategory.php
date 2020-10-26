<html>
<body>

<?php
  $EventID = $_GET['EventID'];

  //Extracting the required event name from the table, for the time being it'll be the event with ID number of 1.
  $getCatKey = mysql_query("SELECT CatKey FROM csEvents WHERE EventID=$EventID");
  
  while ($row = mysql_fetch_array($getCatKey))
  {
    if ($row['CatKey'] == 1)
      echo "Football";
    if ($row['CatKey'] == 2)
      echo "Rugby";
    if ($row['CatKey'] == 3)
      echo "Cricket";
    if ($row['CatKey'] == 4)
      echo "Tennis";
    if ($row['CatKey'] == 5)
      echo "Formula 1";
    if ($row['CatKey'] == 6)
      echo "Athletics";
    if ($row['CatKey'] == 7)
      echo "Golf";
  }//while
    
    

 
?>
