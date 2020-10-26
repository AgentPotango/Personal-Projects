<!DOCTYPE html>
<?php
include 'init.php';
?>
<html><head>
<meta http-equiv="content-type" content="text/html; charset=UTF-8">
<title>Search</title>
	
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
  <center><h1>Search</h1></center>
  <div id="templateInnerBox">


<h2>Search Box</h2>

Last name: <input type="text" name="TheSearch" value="Search"><br>
<select name="searchtype">
  <option value="Username">Username</option>
  <option value="Events">Events</option>
</select> 



<button style="border:solid 1px;
  -webkit-border-radius:10px;
  -moz-border-radius:10px;
  ms-border-radius:10px;
  -o-border-radius:10px;
  border-radius:10px; 
  background-color:rgb(153,153,153);
  font-size:0.9em;" onclick="thatPage()">Search</button>

  </div>
<script>
function thatPage()
{
  document.location.href="SearchResults.php";
}
</script>

  </div> 
</div> 
</div>      


</body></html>
