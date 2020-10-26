<!DOCTYPE html>
<script>
window.onload = function()
                {
                   showNewTable('CoinsWon');
                }
</script>
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
  <center><h1>League Table</h1></center>
  <div id="templateInnerBox">


 <!-- <center><table class="curvedEdges">
    <tr>


    <th>Rank</th>
    <th>Username</th>
    <th>Avatar</th>
    <th><button onclick="showNewTable('CoinsWon')">Points</button></th>
    <th><button onclick="showNewTable('BetsWon')">Correct</button></th>
    <th><button onclick="showNewTable('Accuracy')">Accuracy</button></th>
    <th><button onclick="showNewTable('Streak')">Streak</button></th>
    </tr> -->


<script>
function showNewTable(str)
{
if (str=="")
  {
  document.getElementById("tableOutput").innerHTML="";
  return;
  }

if (window.XMLHttpRequest)
  {// code for IE7+, Firefox, Chrome, Opera, Safari
  xmlhttp=new XMLHttpRequest();
  }
else
  {// code for IE6, IE5
  xmlhttp=new ActiveXObject("Microsoft.XMLHTTP");
  }
xmlhttp.onreadystatechange=function()
  {
  if (xmlhttp.readyState==4 && xmlhttp.status==200)
    {
    document.getElementById("tableOutput").innerHTML=xmlhttp.responseText;
    }
  }
xmlhttp.open("GET","ajax.php?q="+str);
xmlhttp.send();
}
</script>

<br>
<center><div id="tableOutput">
<!--<table class='curvedEdges'>
<tr>
<th>Rank</th>
<th>Username</th>
<th>Avatar</th>
<th><button onclick="showNewTable('CoinsWon')">Points</button></th>
<th><button onclick="showNewTable('BetsWon')">Correct</button></th>
<th><button onclick="showNewTable('Accuracy')">Accuracy</button></th>
<th><button onclick="showNewTable('Streak')">Streak</button></th>
</tr>-->
</div>
</center>


</div> 
</div>      
</div>

</body></html>

