<html>
<body>
<h1>Updating settings...</h1>

<?php
  include 'init.php';
  
  
  $ID = $_SESSION['member_id'];
  $query = mysql_query("SELECT UserLevel from csLogin WHERE MemberID=$ID");
  $resultquery = mysql_fetch_array($query);
  $userlevel = $resultquery['UserLevel'];
  
  if ($userlevel == 2)
  {
  
  $EVENTID = mysql_real_escape_string($_POST['EventID']);
  $WINCHOICE = mysql_real_escape_string($_POST['WinningChoice']);
  $resultEvent = mysql_fetch_array(mysql_query("SELECT * FROM csEvents WHERE EventID = $EVENTID"));
  $resultChoice = mysql_fetch_array(mysql_query("SELECT * FROM csChoices WHERE EventID = $EVENTID AND ChoiceID = $WINCHOICE"));
  echo "<h2>Are you sure these are correct?</h2>";
  echo "Event is ";
  echo $resultEvent['EventName'];
  echo ", winning choice is ";
  echo $resultChoice['ChoiceName'];
  echo ". Is this correct?<br>";
  
  echo '
  <form id="editEvent" action="eventupdate.php" method="post">
  <input name="EventID" id="" type="hidden" value="'.$EVENTID.'">
  <input name="WinningChoice" id="" type="hidden" value="'.$WINCHOICE.'">
  <button input type="submit">Yes</button>
  </form>';
  
  echo '<a href="admin.php">Go back</a>';


  }
?>





</body>
</html>
