<?php // accesscontrol.php

//code copied and manipulated from 
//http://www.sitepoint.com/users-php-sessions-mysql/
include_once 'csError.php';
include_once 'csDatabase.php';

session_start();

$username = isset($_POST['username']) ? $_POST['username'] : $_SESSION['username'];
$pass = isset($_POST['pass']) ? $_POST['pass'] : $_SESSION['pass'];


if(!isset($username)) {
?>
<!DOCTYPE html PUBLIC "-//W3C/DTD XHTML 1.0 Transitional//EN"
"http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
<link rel="stylesheet" type="text/css" href="my.css">
<title> Please Log In for Access </title>
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
<h1>Login Required </h1>
</div>

<p>You must log in to access this area of the site. If you are
not a registered user, go to the <a href="Signup.html">Sign up page</a>
to sign up for instant access!</p>
<p><form method="post" action="Secret.php">
Username: <input type="text" name="username" size="8" /><br />
Password: <input type="password" name="pass" SIZE="8" /><br />
<input type="submit" value="Log in" />
</form></p>
</body>
</html>
<?php
exit;
}

$_SESSION['username'] = $username;
$_SESSION['pass'] = $pass;

dbConnect("13_COMP10120_M4");
$sql = "SELECT * FROM csLogin WHERE
        (Username = '$username' AND Password = '$pass')";
$result = mysql_query($sql);
if (!$result) {
unset($_SESSION['username']);
unset($_SESSION['pass']);
  error('A database error occurred while checking your '.
        'login details.\\nIf this error persists, please '.
        'contact hussaim2@cs.man.ac.uk');
}

if (mysql_num_rows($result) == 0) {
  unset($_SESSION['username']);
  unset($_SESSION['pass']);
  ?>
  <!DOCTYPE html PUBLIC "-//W3C/DTD XHTML 1.0 Transitional//EN"
    "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
  <html xmlns="http://www.w3.org/1999/xhtml">
  <head>
    <title> Access Denied </title>
    <meta http-equiv="Content-Type"
      content="text/html; charset=iso-8859-1" />
  </head>
  <body>
  <h1> Access Denied </h1>
  <p>Your username or password is incorrect, or you are not a
     registered user on this site. To try logging in again, click
     <a href="Secret.php">Login</a>. To register for instant
     access, click <a href="Signup.html">Sign Up</a>.</p>
  </body>
  </html>
  <?php
  exit;
}

$fullname = mysql_result($result,0,'fullname');
?>
