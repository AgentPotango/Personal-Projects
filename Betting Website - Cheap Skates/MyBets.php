<!DOCTYPE html>
<?php include 'init.php';?>
<html>
   <head>
<link rel="stylesheet" type="text/css" href="style.css" media="all">
 <link rel="stylesheet" type="text/css" href="signupCSS.css" media="all">
    <script type="text/javascript" src="jquery.min.js"></script>

 </head>
<title> My Bets </title>

 
<header>
  <?php include 'header.php';?>
</header>
<body>
  
<div id="navigationLogo">

</div>
<div class="container">

<div id="templateMiddleBackground">

<center><h1> Your Most Recent Bets </h1></center>
<table border="1" style="background-color:#909090;">
<tr>
<th>Avatar</th>
<th>Event</th>
<th>Your Prediction</th>
<th>Your Stake</th>
<th>Date</th>
</tr>

<?php include 'MyBetsQuery.php'; ?>

</table>
</div>
</div>
</body>
</html>
