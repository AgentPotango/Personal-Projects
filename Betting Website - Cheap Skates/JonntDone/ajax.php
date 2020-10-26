<?php
$q = $_GET["q"];
$con = mysql_connect("ramen.cs.man.ac.uk", "13_COMP10120_M4", "vA2KzyNJs9HTWs5T")
    or die('Could not connect: ' . mysql_error());
mysql_select_db("13_COMP10120_M4", $con)
    or die('Could not select database');
    
$result = mysql_query("SELECT * FROM csBetStats ORDER BY $q DESC");

?>
<html>
<table class='curvedEdges'>
<tr>
<th>Rank</th>
<th>Username</th>
<th>Avatar</th>
<th><button onclick="showNewTable('CoinsWon')">Points</button></th>
<th><button onclick="showNewTable('BetsWon')">Correct</button></th>
<th><button onclick="showNewTable('Accuracy')">Accuracy</button></th>
<th><button onclick="showNewTable('Streak')">Streak</button></th>
</tr>
</html>
<?php
$chicken = 0;

while($row = mysql_fetch_array($result) and ($chicken < 20))
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
  echo "<td>" . "<a href='$link'><img src='$image' alt='User Avatar' width='75' height='75' /></a>" . "</td>";
  echo "<td>" . $row['CoinsWon'] . "</td>";
  echo "<td>" . $row['BetsWon'] . "</td>";
  echo "<td>" . $row['Accuracy'] . "</td>";
  echo "<td>" . $row['Streak'] . "</td>";
  echo "</tr>";
  }
echo "</table>";

mysql_close($con);
?> 
