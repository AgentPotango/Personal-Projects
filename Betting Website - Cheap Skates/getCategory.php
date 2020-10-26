
<?php
  $EventID = mysql_real_escape_string($_GET['EventID']);

  //Extracting the required event name from the table, for the time being it'll be the event with ID number of 1.
  $getCatKey = mysql_query("SELECT * FROM csEvents WHERE EventID=$EventID");
  $row = mysql_fetch_array($getCatKey);
  $Key = $row['CatKey'];
  
  $getCategory = mysql_query("SELECT * FROM csCategories WHERE CatKey = '$Key' ");
  $CatName = mysql_fetch_array($getCategory);
  $name = $CatName['CategoryName'];
  echo $name;
  
 
  
 //echo "SELECT CategoryName FROM csCategories WHERE CatKey = '$Key' ";
  //echo $name;
        
    if (!$getCategory)
     echo mysql_error();
    

 
?>
