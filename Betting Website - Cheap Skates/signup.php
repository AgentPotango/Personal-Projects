<?php // signup.php
include 'error.php';
include 'database.php';

if (!isset($_POST['submitok'])):
// Display the user signup form
?>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN"
"http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
<title>New User Registration</title>

<?php
else:
// Process signup submission
dbConnect('S02_hussaim2');

if ($_POST['newusername']=='' or $_POST['newname']==''
or $_POST['newemail']=='' or $_POST['newpassword']=='') {
error('One or more required fields were left blank.\\n'.
'Please fill them in and try again.');
}

//Check for existing user with the new username
$sql = "SELECT * FROM groupM42k12 WHERE Username = '$_POST[newusername]'";
$result = mysql_query($sql);
if (!$result) {
error('A database error occurred in processing your '.
'submission.\\nIf this error persists, please '.
'contact hussaim2@cs.man.ac.uk');
}
if (@mysql_result($result,0,0)>0) {
error('A user already exists with your chosen username.\\n'.
'Please try another.');
}

$sql = "INSERT INTO groupM42k12 SET
Username = '$_POST[newusername]',
Password = '$_POST[newpassword]',
Fullname = '$_POST[newname]',
Email = '$_POST[newemail]'";

if (!mysql_query($sql))
error('A database error occurred in processing your '.
'submission.\\nIf this error persists, please '.
'contact hussaim2@cs.man.ac.uk.');

 
/*if (mail($_POST['newemail'],"Your Password for the Website",$message))
 echo "What";
else
  echo "NO";
*/
 ?>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN"
"http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
<link rel="stylesheet" type="text/css" href="my.css">
<title> Registration Complete </title>
<meta http-equiv="Content-Type"
content="text/html; charset=iso-8859-1" />
</head>
<body>

<div id="navigation">
 <a href="groupintro.html">Home page</a>
 <a href="groupimplementation.php">Implementation</a>
 <a href="Signup.html">Sign Up</a>
 <a href="Secret.php">Top Secret Stuff</a>
 <a href="Logout.php">Logout</a>
</div>
<div id="HeaderLeft">
<h1>User Registration Successful!</h1>
</div>

<?php

// Email the new password to the person.
echo "Hi!<br><br>
 
Your personal account for the Group Web Site
has been created! To log in, proceed to the
following address:<br><br>
"?>
<a href="http://soba.cs.man.ac.uk/~hussaim2/login.html">Login Page</a><br><br>
<?php
 
echo "Your personal login Username and password are as follows:<br><br>
 
Username: $_POST[newusername]<br>
Password: $_POST[newpassword]<br><br>
 
You aren't stuck with this password! You can change it at any time after you have logged in.<br><br>
 
If you have any problems, feel free to contact me at hussaim2@cs.man.ac.uk.<br><br>
 
~Kash<br>
Your Site Webmaster
";
?>
<!--<p>Your Username and Password have been emailed to <strong><?=$_POST[newemail]?>
</strong>, the email address you just provided in your registration form. 
To log in, use <a href="login.php">Login Page</a> to return to the login page, and 
enter your new personal Username and Password.</p>
</body>-->
</html>
<?php
endif;
?>
