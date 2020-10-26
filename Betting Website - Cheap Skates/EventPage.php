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

          <?php include 'getChoices.php'; ?>
      </td>
      <td>
        
          <p align="right"><?php
			echo '<input type="text" style = "display: none;" name="EventID" value="'.mysql_real_escape_string($_GET['EventID']).'">';
			 include 'getCurrentPoints.php'; ?><br>
	<?php 
	
	
	if (isset($_SESSION['member_id']) and $currentTime < $startTime)
	{
        echo'  Your Bet: <input type="number" name="bet"><br>
          <input type="submit" value="Place your bet!"></p>';
	}?>
	
        </form>
      </td>
    </tr>
  </table>
  <?php include 'SDK.php';
	include 'javascriptSDK.php';?>
	
		<?php 
		if (isset($_SESSION['member_id']))
		{
		echo'
			<div class="fb-comments" data-href="http://potnoodle.cs.man.ac.uk/~hussaim2/CheapStakesFinal/EventPage.php?EventID='.$EventID.'" data-width="640" data-num-posts="10"></div>';
		}
		else
		echo' You must be logged in to see the comments and post a comment';?>
</div>
</div>
</body>
</html>
