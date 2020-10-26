<html>
<head>
<title>Welcome</title>
</head>
<body>
<h1>Welcome!</h1>
<?php 

//code copied from tutorial
$connection = mysql_connect("ramen.cs.man.ac.uk", "hussaim2", "Applesftw3")
    or die('Could not connect: ' . mysql_error());
mysql_select_db("S02_hussaim2", $connection)
    or die('Could not select database');

$name = $_POST["fname"];
$emailaddress = $_POST["email"];
$pattern = "/^([a-zA-Z0-9])+@([a-zA-Z0-9_-])+(\.[a-zA-Z0-9_-]+)+/";

$query = "SELECT * FROM CS Login Info WHERE Name = '" . $name . "'";
$result = mysql_query($query);

if (mysql_num_rows($result) > 0)
{
  echo "Hi " .$name. ", you are part of the group.";
  echo "<br>\n Your email address stored in the databse is in the
  correct format";
}
else
{
  echo "Welcome " .$name. " you aren't part of the group.";
  echo "<br>\nYour name and email address may be added to the database if your email address is valid";
  //code copied from stackoverflow tutorial
  if (preg_match($pattern, $emailaddress))
  {
  echo "<br>\nYour email address is in the correct format and it is " .$emailaddress;
  mysql_query("INSERT INTO groupmembers (Name, EmailAddress) VALUES ('$name', '$emailaddress')");   
  return true;
}
else
{
  echo "<br>\nYour email address is in the wrong format; you entered: " .$emailaddress;
  echo "<br>\nIt cannot be added to the database.";
  return false;
}
  
}

mysql_close($connection);


?>

</body> 
</html>  

