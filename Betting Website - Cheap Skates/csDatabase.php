
<?php 
 
$dbhost = "ramen.cs.man.ac.uk";
$dbuser = "13_COMP10120_M4";
$dbpass = "vA2KzyNJs9HTWs5T";
$connect_error = 'Sorry we\'re experienceing connection issues.';
mysql_connect($dbhost, $dbuser, $dbpass) or die(mysql_error($connect_error));
mysql_select_db($dbuser) or die($connect_error);

?>

