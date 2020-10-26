<?php
include 'init.php';


$eventName = mysql_real_escape_string($_GET['eventname']);
$category = mysql_real_escape_string($_GET['Category']);
$subCategory = mysql_real_escape_string($_GET['SubCategory']);
$description = mysql_real_escape_string($_GET['Description']);
$day = mysql_real_escape_string($_GET['Day']);
$month = mysql_real_escape_string($_GET['Month']);
$year = mysql_real_escape_string($_GET['Year']);
$endDay = mysql_real_escape_string($_GET['EndDay']);
$endMonth = mysql_real_escape_string($_GET['EndMonth']);
$endYear = mysql_real_escape_string($_GET['EndYear']);
$startTime = mysql_real_escape_string($_GET['starttime']);
$endTime = mysql_real_escape_string($_GET['endtime']);

date_default_timezone_set('Europe/London');

if (empty($eventName) == true || empty($category) == true || empty($subCategory) == true  || 
   empty($description) == true || empty($day) == true || empty($month) == true  || 
   empty($year) == true  || empty($endDay) == true  || empty($endMonth) == true  || 
   empty($endYear) == true || empty($startTime) == true  || empty($endTime) == true )
{
echo 'Please Fill In All Fields' . "  ";
echo '<a href="createEvent.php">Go back</a>';
}
else
{

$choiceCount = 0;
$choice = array();
for ($i = 1; $i < 10; $i++)
{
  $choiceName = 'ch' . $i;
  $choice[$i]=mysql_real_escape_string($_GET[$choiceName]);
  
  if ($choice[$i] != "")
  {
    $choiceCount ++;
  }
}

if ($day < 10)
{ 
  $day = '0' . $day;
}
if ($month < 10)
{ 
  $month = '0' . $month;
}
if ($endMonth < 10)
{ 
  $endMonth = '0' . $endMonth;
}
if ($endDay < 10)
{ 
  $endDay = '0' . $endDay;
}


$startDate = $year . '-' . $month . '-' . $day;
$endDate = $endYear. '-' . $endMonth . '-' . $endDay;
//$startTime = $startTime . ':00';

$date = $startDate .' ' . $startTime;
$dateInfo = date_parse_from_format('Y-m-d H:i', $date);
$unixTimestamp = mktime(
    $dateInfo['hour'], $dateInfo['minute'], $dateInfo['second'],
    $dateInfo['month'], $dateInfo['day'], $dateInfo['year']
    
);
$startDateTime = date('Y-m-d H:i:s', $unixTimestamp);


$endDate1 = $endDate .' ' . $endTime;
$dateInfo2 = date_parse_from_format('Y-m-d H:i', $endDate1);
$unixTimestamp2 = mktime(
    $dateInfo2['hour'], $dateInfo2['minute'], $dateInfo2['second'],
    $dateInfo2['month'], $dateInfo2['day'], $dateInfo2['year']
);
$endDateTime = date('Y-m-d H:i:s', $unixTimestamp2);



//header('Location: admin.php');

$result = mysql_query("INSERT INTO csEvents (CatKey, EventName, EventDescription, StartDandT, EndDandT) VALUES ('$category','$eventName', '$description', '$startDateTime','$endDateTime')");
//use start date and time and end date and time to find the unique event. Then, find the event id and store it. 
$eventID;
$query = mysql_query("SELECT EventID FROM csEvents WHERE EventDescription = '$description' AND EventName = '$eventName' AND CatKey = '$category' AND StartDandT = '$startDateTime' AND EndDandT = '$endDateTime'");
//while ($row = mysql_fetch_array($query))
//{
//	$eventID = $row['EventID'];
//}
$result = mysql_fetch_array($query);
$eventID = $result['EventID'] ;
for ($i = 1; $i <= $choiceCount; $i++)
{
$choiceName = $choice[$i];
$result2 = mysql_query("INSERT INTO csChoices (EventID, ChoiceName, ChoiceOdds) VALUES ('$eventID','$choiceName', '2.0')");
}
if (!$result){
 echo 'Please Fill In All Fields';
 echo mysql_error();
 echo "\n";
 echo '<a href="createEvent.php">Go back</a>';
 }
else if (!$result2){
 echo 'Please Fill In All Fields';
 echo mysql_error();
 echo "\n";
 echo '<a href="createEvent.php">Go back</a>';
 }
else 
{
echo 'Event Created Successfully! ';
echo '<a href="EventPage.php?EventID='.$eventID.'">Go to event</a>';
}
}

 



?>


