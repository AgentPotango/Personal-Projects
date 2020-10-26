<?php
$con = mysql_connect("ramen.cs.man.ac.uk", "13_COMP10120_M4", "vA2KzyNJs9HTWs5T")
    or die('Could not connect: ' . mysql_error());
mysql_select_db("13_COMP10120_M4", $con)
    or die('Could not select database');

$result = mysql_query("SELECT * FROM csUserInfo");
$chicken = 0;

echo "<table class="curvedEdges">
    <tr>
    <th>Rank</th><th>Username</th><th>Avatar</th><th>Points</th><th>Correct</th><th>Accuracy</th>
    </tr>";

while($row = mysql_fetch_array($result) and ($chicken < 5))
  {
  $username = $row['MemberID'];
  $resultLogin = mysql_query("SELECT Username FROM csLogin WHERE MemberID='$username'");
  $usernameValue = mysql_fetch_array($resultLogin);
   
  $image=$row['Avatar'];
  
  $mime = null;
  if ($type=="pjpeg") // <<< where do you get $type btw?
    $mime = "image/jpeg";

  $image = "data:".$mime.";base64," . base64_encode($image);

  $chicken = $chicken + 1;
  echo "<tr><td>" . $chicken . "</td>";
  echo "<td>" . $usernameValue['Username'] . "</td>";
  echo "<td>" . '<img src="'.$image.'" alt="User Avatar" width="75" height="75" />' . "</td>";
  }
  
  echo "</table>";

mysql_close($con);
?> 
