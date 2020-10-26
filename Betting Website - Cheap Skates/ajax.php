<?php
$q = $_GET["q"];
setcookie("Wanted","");

$con = mysql_connect("ramen.cs.man.ac.uk", "13_COMP10120_M4", "vA2KzyNJs9HTWs5T")
    or die('Could not connect: ' . mysql_error());
mysql_select_db("13_COMP10120_M4", $con)
    or die('Could not select database');
if(($q!='CoinsWon') && ($q!='BetsWon') && ($q!='Accuracy') && ($q!='Streak'))
{
  $q = $_COOKIE["SortVar"];
}
if ($wanted < $_COOKIE["Wanted"])
{
  $wanted = $_COOKIE["Wanted"];
}
else
{
  $wanted = 12;
}
$result = mysql_query("SELECT * FROM csBetStats ORDER BY $q DESC");
setcookie("SortVar", $q);
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
$wanted = $wanted + $_GET['ExtraUsers'];
setcookie("Wanted",$wanted);
while($row = mysql_fetch_array($result) and ($chicken < $wanted))
  {
  
  $username = $row['MemberID'];
  $resultLogin = mysql_query("SELECT Username FROM csLogin WHERE MemberID='$username'");
  $usernameValue = mysql_fetch_array($resultLogin);
   
   
  $resultStats = mysql_query("SELECT * FROM csUserInfo WHERE MemberID='$username'");
  $imageValue = mysql_fetch_array($resultStats);
  
  $image=$imageValue['AvatarLocation'];
  $link = "Profile.php?id="."$username";
  
  if ($chicken % 2)
  {
   $chicken = $chicken + 1;
   echo "<tr style='background-color:#c5c5c5'>";
   echo "<td style='background-color:#d5d5d5'>" . $chicken . "</td>";
   echo "<td>" . $usernameValue['Username'] . "</td>";
   echo "<td style='background-color:#d5d5d5'>" . "<a href='$link'><img src='$image' alt='User Avatar' width='75' height='75' /></a>" . "</td>";
   echo "<td>" . $row['CoinsWon'] . "</td>";
   echo "<td style='background-color:#d5d5d5'>" . $row['BetsWon'] . "</td>";
   echo "<td>" . $row['Accuracy'] . "</td>";
   echo "<td style='background-color:#d5d5d5'>" . $row['Streak'] . "</td>";
  echo "</tr>";
  }
  else
  {
   $chicken = $chicken + 1;
   echo "<tr>";
   echo "<td>" . $chicken . "</td>";
   echo "<td style='background-color:#E5E5E5'>" . $usernameValue['Username'] . "</td>";
   echo "<td>" . "<a href='$link'><img src='$image' alt='User Avatar' width='75' height='75' /></a>" . "</td>";
   echo "<td style='background-color:#E5E5E5'>" . $row['CoinsWon'] . "</td>";
   echo "<td>" . $row['BetsWon'] . "</td>";
   echo "<td style='background-color:#E5E5E5'>" . $row['Accuracy'] . "</td>";
   echo "<td>" . $row['Streak'] . "</td>";
   echo "</tr>";
  }
  }
echo "</table>";

mysql_close($con);
?> 
