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
<?php include 'header.php'; ?>

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
    <td width="45%"></td><td><table class="curvedEdges">
    <tr>
    <th>Rank</th><th>Username</th><th>Avatar</th>
    </tr>
    <tr>
    <td>#1</td><td>Table cell 2</td><td>Table cell 2 </td>
    </tr>
    <td>#2</td><td>Table cell 2</td><td>Table cell 2</td>
    </tr>
    <td>#3</td><td>Table cell 2</td><td>Table cell 2</td>
    </tr>
    <td>#4</td><td>Table cell 2</td><td>Table cell 2</td>
    </tr>
    <td>#5</td><td>Table cell 2</td><td>Table cell 2</td>
    </tr>
    </td></tr>
    </table>
    </table>


  </div>
  <div id="templateInnerBox">
  <h3>Events</h3>

  </div> 
</div> 
</div>      
</div>


</body></html>

