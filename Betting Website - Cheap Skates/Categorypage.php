<!DOCTYPE html>
<?php include 'init.php';

$categoryID = mysql_real_escape_string($_GET['CatKey']);
?>
<html><head>
<meta http-equiv="content-type" content="text/html; charset=UTF-8">
<title>Categories</title>
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
</script>
 </head>

 
<header>
  <?php include 'header.php';?>
</header>
<body>
  
<div id="navigationLogo">

</div>
<div class="container">

<div id="templateMiddleBackground">

<?php 
if($categoryID == "")
{
  include 'getAllEventDetails.php';
}
else 
{
  include 'getCategoryDetails.php';
} 
?>

</div>
</div>
</body>
</html>
