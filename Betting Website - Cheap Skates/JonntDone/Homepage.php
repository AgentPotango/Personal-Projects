<!DOCTYPE html>
<?php
include 'init.php';
?>
<html><head>
<meta http-equiv="content-type" content="text/html; charset=UTF-8">
<title>Homepage</title>
	
    <link rel="stylesheet" type="text/css" href="style.css" media="all">
    <link rel="stylesheet" type="text/css" href="signupCSS.css" media="all">
    <script type="text/javascript" src="jquery.min.js"></script>
   <script type="text/javascript">
$(document).ready(function () {
$('.active-links').click(function () {
        if ($('#signin-dropdown').is(":visible")) {
            $('#signin-dropdown').hide()
			$('#session').removeClass('active');
        } else {
            $('#signin-dropdown').show()
			$('#session').addClass('active');
        }
		return false;
    });
	$('#signin-dropdown').click(function(e) {
        e.stopPropagation();
    });
    $(document).click(function() {
        $('#signin-dropdown').hide();
		$('#session').removeClass('active');
    });
});     
</script>
 <script type="text/javascript">
$(document).ready(function () {
$('.active-popup').click(function () {
        if ($('#signup-dropdown').is(":visible")) {
            $('#signup-dropdown').hide()
			$('#session').removeClass('active');
        } else {
            $('#signup-dropdown').show()
			$('#session').addClass('active');
        }
		return false;
    });
	$('#signup-dropdown').click(function(e) {
        e.stopPropagation();
    });
    $(document).click(function() {
        $('#signup-dropdown').hide();
		$('#session').removeClass('active');
    });
});     
</script>

</head>
<header>
<?php include 'header.php';
?>

</header>
<body>

<div id="navigationLogo">

</div>

<div class="container">
<div id="templateMiddleBackground">
  <center><h1>Homepage</h1></center>
  <div id="templateInnerBox">
  <h3>Categories</h3>

<ul class="images">
  <li><img src="SportsCategory.jpg" alt="Sports Category" width="225" height="175"></li>
  <li><img src="PoliticsCategory.jpg" alt="Politics Category" width="275" height="175"></li>
  <li><img src="EntertainmentCategory.jpg" alt="Entertainment Category" width="225" height="175"></li>
  <li><img src="SportsCategory.jpg" alt="Sports Category" width="225" height="175"></li>
  <li><img src="PoliticsCategory.jpg" alt="Politics Category" width="275" height="175"></li>
  <li><img src="EntertainmentCategory.jpg" alt="Entertainment Category" width="225" height="175"></li>
</ul>
</br>

  </div>
  <div id="templateInnerBox">
  <h3>Top Users</h3>


<table class="invisible">
    <tr>
    <td style="width:45%;height: 100%;">
    <table class ="curvedEdges" style="height: 100%; width: 100%;">
    <tr><td>
    <?php

$result = mysql_query("SELECT * FROM csBetStats ORDER BY CoinsWon DESC");
$chicken = 0;

while($row = mysql_fetch_array($result) and ($chicken < 1))
  {
  
  $username = $row['MemberID'];
  $resultLogin = mysql_query("SELECT Username FROM csLogin WHERE MemberID='$username'");
  $usernameValue = mysql_fetch_array($resultLogin);
   
   
  $resultStats = mysql_query("SELECT * FROM csUserInfo WHERE MemberID='$username'");
  $imageValue = mysql_fetch_array($resultStats);
  
  $image=$imageValue['AvatarLocation'];
  $link = "Profile.php?id="."$username";
  
  $chicken = $chicken + 1;
  echo "<h1><center>" . "$chicken" . "</center></h1></td></tr><tr><td>" ;
  echo "<center><a href='$link'><img src='$image' alt='User Avatar' width='150' height='150' /></a></center>";
  echo "</td></tr><tr><td><center>" . $usernameValue['Username'] . "</center></td>";
  }

?> 
    
    </td>
    </tr>
    </table>
    </td>
    <td>   

    
    
    <table class="curvedEdges">
    <tr>
    <th>Rank</th>
    <th>Username</th>
    <th>Avatar</th>
    </tr>

<?php

$result = mysql_query("SELECT * FROM csBetStats ORDER BY CoinsWon DESC");
$chicken = 0;

while($row = mysql_fetch_array($result) and ($chicken < 5))
  {
  
  $username = $row['MemberID'];
  $resultLogin = mysql_query("SELECT Username FROM csLogin WHERE MemberID='$username'");
  $usernameValue = mysql_fetch_array($resultLogin);
   
   
  $resultStats = mysql_query("SELECT * FROM csUserInfo WHERE MemberID='$username'");
  $imageValue = mysql_fetch_array($resultStats);
  
  $image=$imageValue['AvatarLocation'];
  $link = "Profile.php?id="."$username";
  
  $chicken = $chicken + 1;
  echo "<tr><td>" . $chicken . "</td>";
  echo "<td>" . $usernameValue['Username'] . "</td>";
  echo "<td><center><a href='$link'><img src='$image' alt='User Avatar' width='55' height='55' /></a></center></td>";
  echo "</tr>";
  }

?> 


    </table>

    
  </td>
  </tr>
  </table>


  </div>
  <div id="templateInnerBox">
  <h3>Events</h3>

  </div> 
</div> 
</div>      


</body></html>
