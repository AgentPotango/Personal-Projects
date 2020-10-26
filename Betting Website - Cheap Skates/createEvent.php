<!DOCTYPE html>
<html>
<head>
<title>Create an Event Page!</title>
<?php
include 'init.php';
setcookie("Choices", "");
?>

	
    <link rel="stylesheet" type="text/css" href="style.css" media="all" />
    <link rel="stylesheet" type="text/css" href="signupCSS.css" media="all">
    <link rel="stylesheet" type="text/css" href="profile.css" media="all">
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
<body>

<header>
<?php include 'header.php';
?>
</header>

<div id="navigationLogo">

</div>

<div id="profileContainer">
<div id="content" class="clearfix">
<div id="titlebar">

<h1>Create Event:</h1>
    
</div>
<div id="textbox">
<div id="Name">

  <form id="event" action="makeEvent.php" method="get"> 
  
      <label for="eventname">Event Name: </label> 
       <input id="eventname" name="eventname" placeholder="Event Name" type="text"> 
      <div id ="choice">
      
  <label>Choices:</label>   <button type="button" onclick = 'javascript: add()'>Add Choices</button>
  <p></p>
	 </div>
    </div>

<p></p>
<div id="Category">

     <label>Category:</label>
         <select name="Category">
           <option value="">Category</option>
</div>
  <?php 
  
  $getCats = mysql_query("SELECT * FROM csCategories");
  while($category = mysql_fetch_array($getCats)) {
  	echo '<option value="'.$category['CatKey'].'">'.$category['CategoryName'].'</option>';
  	
  }
  
  ?>
          <!-- <option value="01">Football</option>
           <option value="02">Rugby</option>
           <option value="03">Cricket</option>
           <option value="04">Tennis</option>
           <option value="05">Formula 1</option>
           <option value="06">Athletics</option>
           <option value="07">Golf</option> -->
         </select>
       
        
        
 <div id="subCat">       
        <label>Sub Category:</label>
         <select name="SubCategory">
           <option value="">SubCategory</option>
          
 </div>
 <p></p>
      <?php 
     
      $getSubCats = mysql_query("SELECT * FROM csSubCategories ");
  while($subCategory = mysql_fetch_array($getSubCats)) {
  	echo '<option value="'.$subCategory['SubCatKey'].'">'.$subCategory['SubCatName'].'</option>';
  	
  	
  }
  
  ?>
   </select>
 <div id="Description">
    <label>Description:</label>

    <textarea id="Description" name="Description" rows="4" columns="60" maxlength="500"></textarea>
    </div>
      
      <div id="image">
     <label>Upload Image:</label> 
     <a href="#"><img src="img/eventDefault.jpg" width="300" height="300"></a>
     </div>
     <br>
     <!--<form enctype="multipart/form-data" action="upload_file.php" method="post">
     <input type="file" name="pix" size="80">
     <input type="hidden" name="MAX_FILE_SIZE" value="10000000000">
     <input type="button" name="upload" value="Upload image"></form>-->
     
    	
    	
    </div>
 
<div id="Date">
     <label>Start Date: </label>
          <select name="Day">
           <option value="">Day</option>';
          <?php
                for($day=1;$day<=31;$day++)
                {
                	echo '<option value= '.$day.'>'.$day.'</option>';
                }
                
	echo' </select>'; ?>


     <select name="Month">
     	<option value="">Month</option>
	<option value="1">January
	<option value="2">February
	<option value="3">March
	<option value="4">April
	<option value="5">May
	<option value="6">June
	<option value="7">July
	<option value="8">August
	<option value="9">September
	<option value="10">October
	<option value="11">November
	<option value="12">December
     </select>

     <select name="Year">
     	<option value="">Year</option>
	<option value="2013">2013
	<option value="2014">2014
	<option value="2015">2015
     </select>
</div>

<div id="EndDate">
     <label>End Date: </label>
          <select name="EndDay">
           <option value="">Day</option>';
          <?php
                for($day=1;$day<=31;$day++)
                {
                	echo '<option value= '.$day.'>'.$day.'</option>';
                }
                
	echo' </select>'; ?>


     <select name="EndMonth">
     	<option value="">Month</option>
	<option value="1">January
	<option value="2">February
	<option value="3">March
	<option value="4">April
	<option value="5">May
	<option value="6">June
	<option value="7">July
	<option value="8">August
	<option value="9">September
	<option value="10">October
	<option value="11">November
	<option value="12">December
     </select>

     <select name="EndYear">
     	<option value="">Year</option>
	<option value="2013">2013
	<option value="2014">2014

	<option value="2015">2015
     </select>
</div>

<div id="Time">
 <form id="starttime"> 
        <label for="starttime">Start Time: </label> 
        <input id="starttime" name="starttime" placeholder="19:45" type="number" size="1" maxlength=5px> 
</div>
<div id="EndTime">
      <form id="endtime"> 
        <label for="endtime">End Time: </label> 
        <input id="endtime" name="endtime" placeholder="21:30" type="number" size="1" maxlength=5px>
</div>



<script>
var i = 1;
function add()
{

  /* Get your form */
form = document.getElementById("event");
/*   Create your input element  */
input = document.createElement("input");
input.type="text";
input.name='ch'.concat(i) ;
/*    append to form */
form.appendChild(input);
i = i + 1;

}
</script>

<script>
function addChoice()
{
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
xmlhttp.open("GET","ajaxEvent.php");
xmlhttp.send();
}
</script>
<div id="tableOutput">

</div>


 <!--button type="button" onclick="addChoice()">Add More Choices</button>-->

 
<div id="button">
     <!-- <p> <input class="button" name="preview" id="submit"a value="Preview" type="button" style="width:200px; height:60px; margin-left:250px;"> -->

      <input class="submit" name="submit" id="submit" value="Submit Event" type="submit" style="width:200px; height:60px;"> 	 </p>
 </div>
   </form> 

</div>      
</div>
</div>
</body>
</html>
