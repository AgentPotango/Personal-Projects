<?php include 'csAccessControl.php'; ?>
<!DOCTYPE html PUBLIC "-//W3C/DTD XHTML 1.0 Transitional//EN"
  "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
  <link rel="stylesheet" type="text/css" href="my.css">
  <title> Members-Only Page </title>
  <meta http-equiv="Content-Type"
    content="text/html; charset=iso-8859-1"
</head>
<body>
<div id="navigation">
 <a href="groupintro.html">Home page</a>
 <a href="groupimplementation.php">Implementation</a>
 <a href="Signup.html">Sign Up</a>
 <a href="Secret.php">Top Secret Stuff</a>
 <a href="Logout.php">Logout</a>
</div>

<div id="Header">
<h1>Welcome!</h1>
</div>

<p>Welcome, <?=$fullname?>! You have entered a members-only area
   of the site. Don't you feel special?</p>

</body>
</html>
