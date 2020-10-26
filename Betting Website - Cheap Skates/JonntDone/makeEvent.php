<?php
include 'init.php';


$eventName = mysql_real_escape_string(mysql_real_escape_string($_POST['eventname']);
$category = mysql_real_escape_string(mysql_real_escape_string($_POST['Category']);
$subCategory = mysql_real_escape_string($_POST['SubCategory']);
$description = mysql_real_escape_string($_POST['Description']);
$day = mysql_real_escape_string($_POST['Day']);
$month = mysql_real_escape_string($_POST['Month']);
$year = mysql_real_escape_string($_POST['Year']);
$endDay = mysql_real_escape_string($_POST['EndDay']);
$endMonth = mysql_real_escape_string($_POST['EndMonth']);
$endYear = mysql_real_escape_string($_POST['EndYear']);
$startTime = mysql_real_escape_string($_POST['starttime']);
$endTime = mysql_real_escape_string($_POST['endtime']);
$ch1 = mysql_real_escape_string($_POST['ch1']);
$ch2 = mysql_real_escape_string($_POST['ch2']);
$ch3 = mysql_real_escape_string($_POST['ch3']);

$startDayAndTime =  $year . '-' . $month . '-' .$day . ' ' . $startTime . ':00';
$endDayAndTime  = $endYear . '-' . $endMonth . '-' .$endDay . ' ' . $endTime . ':00';


$insertEvent = mysql_query("INSERT INTO csEvents (CatKey, EventName, EventImage, EventDescription, StartD&T, EndD&T) VALUES ('$category','$eventName','$eventImage', '$description', $startDayAndTime', '$endDayAndTime')");

?>

















?>
