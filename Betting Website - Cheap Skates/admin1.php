<!DOCTYPE html>
<html lang="en">
<head>

<link rel="stylesheet" type="text/css" href="adminPanel.css">
<h1>Welcome to the admin panel</h1>


<?php include 'init.php'; 


$ID = $_SESSION['member_id'];
$query = mysql_query("SELECT UserLevel from csLogin WHERE MemberID=$ID");
$resultquery = mysql_fetch_array($query);
$userlevel = $resultquery['UserLevel'];



if ($userlevel != 2) //If the user is not an admin
{
  echo '<iframe width="1200" height="700" src="http://www.youtube.com/embed/dQw4w9WgXcQ?autoplay=1" frameborder="0"  allowfullscreen></iframe>';
  $authenticated = false;
  exit;
} // not admin

else //If the user is an admin
{
  $authenticated = true;
  
} // admin

if (!isset($_GET['tabindex']) || $_GET['tabindex'] == 0)
  $tabindex == 0;
else
  $tabindex = $_GET['tabindex'];


if ($_GET['start'] != "")
{
  if ($_GET['tabindex'] == 0 || !isset($_GET['tabindex'])) // user
    $startID = mysql_real_escape_string($_GET['start']);
  else
    $eventStartID = mysql_real_escape_string($_GET['start']); // event
}
else
{
  $startID = 10000;
  $eventStartID=1;
}

if ($_GET['end'] != "")
{
  if ($_GET['tabindex'] == 0 || !isset($_GET['tabindex'])) // user
    $endID = mysql_real_escape_string($_GET['end']);
  else
    $eventEndID = mysql_real_escape_string($_GET['end']); // event
}
else
{
  $endID = $startID + 20;
  $eventEndID = $eventStartID + 20;
}
?>

</head>



<?php
    require_once('tabs.php');
    ?>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.01//EN" "http://www.w3.org/TR/html4/strict.dtd">
<html>
<head>
<?php tabs_header(); ?>
</head>

<body>
<div style="width:600px;">
<?php tabs_start(); ?>
<?php tab('User Management'); ?>
<p>
  Use these controls to edit a particular user. You may select a range of IDs 
  with the start and end box to view those users,  then enter a User's ID below 
  and mark any changes you wish to make. Leave a field or checkbox blank to make 
  no changes.
</p>

<h2>Select a range of users</h2>
<form id="startend" action="admin.php"> 
<div class="inputBoxes">
  
      <label for="start">StartID:</label> 
       <input id="start" name="start" placeholder="<?php echo $startID;?>" type="text"> 
      
  
      <label for="end">EndID:</label> 
       <input id="end" name="end" placeholder="<?php echo $endID;?>" type="text"> 
      
      <button input type="submit">Go</button>
</div>
</form>




<?php
  if (authenticated == true)
  {
  echo '<center><table class="alternating">
          <tr><td>ID</td> <td>Name</td> <td>Level</td> <td>Password</td> </tr>
        </center>';
        

  for ($i = $startID; $i <= $endID; $i ++)
  {
    //Print out a table of each user with id "$i"
    $loginQuery = mysql_query("SELECT * from csLogin WHERE MemberID = $i");
    $infoQuery = mysql_query("SELECT * from csUserInfo WHERE MemberID = $i");
    
    $loginResult = mysql_fetch_array($loginQuery);
    $infoResult = mysql_fetch_array($infoQuery);
    
    $linkToProfile = "Profile.php?id=".$i;
    $levelNumber = $loginResult['UserLevel'];
    $levelString = "";
    
    if ($levelNumber == 0)
      {$levelString = "Banned";}
    elseif ($levelNumber == 1)
      {$levelString = "User";}
    elseif ($levelNumber == 2)
      {$levelString = "Admin";}
    
    $name = $loginResult['Username'];
    
    $password = $loginResult['Password'];
    
    $passcensor = "";
    $firstChar = substr($password, 0, 1);
    $lastChar = substr($password, -1, 1);
    
    
    $passcensor = $passcensor.$firstChar;
    $passcensor = $passcensor."*******";
    $passcensor = $passcensor.$lastChar;
    echo "<tr>";
    echo "<td>$i</td>";
    echo "<td><a href='$linkToProfile'>$name</a></td>";
    echo "<td>($levelNumber)$levelString</td>";
    echo "<td>$passcensor</td>";
    echo "</tr>";
  }//for
  echo "</table></center>";
  }//is authenticated
 ?>
<h2>Edit a user:</h2>
<div class=inputBoxes>
<form id="edituser" action="adminupdate.php">
  <fieldset>
    <dl>
      <label for="userID">ID</label>
      <input name="userID" id=""  placeholder="Must select an ID number!" required="Must select an ID!" type="text"> </br>
      
      <label for="deleteAvatar">Delete Avatar?</label>
      <input name="deleteAvatar" type="checkbox" value="Yes"></br>
      
      <label for="deleteQuote">Delete Quote?</label>
      <input name="deleteQuote" type="checkbox" value="Yes"></br>
      
      <label for="banUser">Ban User?</label>
      <input name="banUser" type="checkbox" value="Yes"></br>
      
      <label for="adminUser">Make User An Admin?</label>
      <input name="adminUser" type="checkbox" value="Yes"></br>
    </dl>
    
    <dl>
      <dt><label for="updateUserName">Set Username</label></dt>
      <dd><input name="updateUserName" id=""  type="text"></dd>
      <dt><label for="updateUserEmail">Set Email</label></dt>
      <dd><input name="updateUserEmail" id=""  type="text"></dd>
      <dt><label for="updateUserPassword">Set Password</label></dt>
      <dd><input name="updateUserPassword" id=""  placeholder="*******"  type="text"></dd>
    </dl>
    
    <button input type="submit">Go</button>
  </fieldset>
  
  <!--Page to go back to-->
  <?php
    $tabToPost = mysql_real_escape_string($_GET['tabindex']);
    $startToPost = mysql_real_escape_string($_GET['start']);
    $endToPost = mysql_real_escape_string($_GET['end']);
    //Input these into the form
    if ($tabToPost == "")
      $tabToPost = 0;
    echo '
      <input name="tab" type="hidden" value="'.$tabToPost.'">
      <input name="start" type="hidden" value="'.$startToPost.'">
      <input name="end" type="hidden" value="'.$endToPost.'">
         '
  ?>
</form>
</div>
  
  




<?php tab('User Lists'); ?>
<p>The list of all users goes here</p>








<!-- EVENT EDITING ////////////////////////////////////////////////////////////////////////////////////// -->
<?php tab('Edit Events'); ?>
<p>The page where results are added goes here.</p>

<?php
  if (authenticated == true)
  {
  echo '<center><table border="1"><td>eventID</td><td>EventName</id>
        <td>StartDate</td><td>EndDate</td><td>WinningChoice</td><tr>';
  
  $currentTimeUnix = mktime();
  $currentTime = date('Y-m-d H:i:s', $currentTimeUnix);
  $eventQuery = mysql_query("SELECT EventID, EventName, StartDandT, EndDandT, WinningChoice from csEvents WHERE EndDandT < '$currentTime' AND WinningChoice = '0' ORDER BY EndDandT ASC");
  $string = "SELECT EventID, EventName, StartDandT, EndDandT, WinningChoice from csEvents WHERE EndDandT < '$currentTime' AND WinningChoice = '0' ORDER BY EndDandT ASC";
  echo $string;
  $eventResult = mysql_fetch_array($eventQuery);
  
  $numberOfEvents = mysql_num_rows($eventQuery);
  
  while ($row = mysql_fetch_array($eventQuery)) {
    foreach ($row as $columnName => $columnData) {
        echo 'Column name: ' . $columnName . ' Column data: ' . $columnData . '<br />';
    }
}
  
  for ($i = 0; $i < $numberOfEvents * 5; $i +=5)
  {
                                                                              
    $idOfEvent = $eventResult[$i];
    
    $eventName = $eventResult[$i+1];
    
    echo $idOfEvent;
    $startTime = $eventResult[$i+2];
    
    $endTime = $eventResult[$i+3];
    
    $winningChoice = $eventResult[$i+4];
    
    
    
    echo "<td>$idOfEvent</td>";
    echo "<td>$eventName</td>";
    echo "<td>$startTime</td>";
    echo "<td>$endTime</td>";
    echo "<td>$winningChoice</td>";
    
    
    
    
    //echo "<td><input type='button' name='abc' id='abc' onclick='return deleteField($i, avatar);/></td>";
    //echo "<td><button type='button' formaction='deleteField.php?id=$i&action=Quote'>Delete Quote</button></td>";
    
    echo "<tr>";
  }//for
  echo "</table></center>";
  
  
  
  }//is authenticated
 ?>
 
 <form id="editEvent" action="eventupdate.php">
  ID:<input name="EventID" id=""  placeholder="Must select an Event ID number!"  type="text"> </br>

  Set Winning Choice:<input name="WinningChoice" id=""  placeholder="#"  type="text"> </br>
  
  <button input type="submit">Go</button>
</form>
<?php tabs_end(); ?>
</body>


 




</html>
