<!DOCTYPE html>
<?php include 'init.php'; ?>
<html>
   <head>
<link rel="stylesheet" type="text/css" href="style.css" media="all">
 <link rel="stylesheet" type="text/css" href="signupCSS.css" media="all">
    <script type="text/javascript" src="jquery.min.js"></script>

 </head>
<title> Event Page </title>

    
 
<header>
  <?php include 'header.php';?>
</header>
<body>
  
<div id="navigationLogo">

</div>
<div class="container">

<div id="templateMiddleBackground">
  <h1><?php include 'getEventName.php'; ?></h1>
  
  <table style="background-color:#909090;">
    <tr>
      <td><?php include 'getImage.php'; ?></td>
       <td style="background-color:#585858 ;"><p> <?php include 'getDescription.php'; ?></p></td>
    </tr>

    <tr>
      <td>
        <p><?php include 'getCategory.php'; ?></p></td>
      <td>
        <p><?php include 'getStartFinishTime.php'; ?></p></td>
      
      
    <tr>
      <td>
        <form action="placeBet.php" method="post">
          <input type="radio" name="prediction" value="1">Win(get odds from server)<br>
          <input type="radio" name="prediction" value="2">Loose(get odds from server)<br>
        
      </td>
      <td>
        
          <p align="right"><?php
			echo '<input type="text" style = "display: none;" name="EventID" value="'.$EventID.'">';
			 include 'getCurrentPoints.php'; ?><br>
          Your Bet: <input type="text" name="bet"><br>
          <input type="submit" value="Place your bet!"></p>
        </form>
      </td>
    </tr>
  </table>
</div>
</div>
</body>
</html>
