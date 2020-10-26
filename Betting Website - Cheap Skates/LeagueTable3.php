<!DOCTYPE html>
<html><head>
<meta http-equiv="content-type" content="text/html; charset=UTF-8">
<title>League Tables</title>
	
    <link rel="stylesheet" type="text/css" href="style.css" media="all">
</head>
<body>

<div id="navigation">
 <a href="http://soba.cs.man.ac.uk/%7Emillarc2/CheapStakes/Homepage.php">Home page</a>
 <a href="http://soba.cs.man.ac.uk/%7Emillarc2/CheapStakes/createEvent.html">Events</a>
 <a href="http://soba.cs.man.ac.uk/%7Emillarc2/CheapStakes/LeagueTable.html">LeaderBoard</a>
 <a href="http://soba.cs.man.ac.uk/%7Emillarc2/CheapStakes/MyBets.php">My Bets</a>
 <a href="http://soba.cs.man.ac.uk/%7Emillarc2/CheapStakes/Search.php">Search</a>
 <a href="http://soba.cs.man.ac.uk/%7Emillarc2/CheapStakes/Logout.php">Logout</a>
 <a href="http://soba.cs.man.ac.uk/%7Emillarc2/CheapStakes/csSignUp.html">Sign Up</a>
 <a href="http://soba.cs.man.ac.uk/%7Emillarc2/CheapStakes/csLogin.html">Login</a>
 
</div>

<div id="navigationLogo">

</div>

<div class="container">
<div id="templateMiddleBackground">
  <center><h1>League Table</h1></center>
  <div id="templateInnerBox">


  <table class="curvedEdges">
    <tr>


<th>Rank</th>
<th>Username</th>
<th>Avatar</th>
<th><button onclick="pointsSorting()">Points</button></th>
<th><button onclick="correctSort()">Correct</button></th>
<th><button onclick="accurracySort()">Accuracy</button></th>
<th><button onclick="streakSort()">Streak</button></th>
    </tr>


<script>
function pointsSorting()
{
alert("hello World");
}
</script>



<?php
$con = mysql_connect("ramen.cs.man.ac.uk", "13_COMP10120_M4", "vA2KzyNJs9HTWs5T")
    or die('Could not connect: ' . mysql_error());
mysql_select_db("13_COMP10120_M4", $con)
    or die('Could not select database');

$result = mysql_query("SELECT * FROM csBetStats ORDER BY CoinsWon DESC");
$chicken = 0;

while($row = mysql_fetch_array($result) and ($chicken < 20))
  {
  
  $username = $row['MemberID'];
  $resultLogin = mysql_query("SELECT Username FROM csLogin WHERE MemberID='$username'");
  $usernameValue = mysql_fetch_array($resultLogin);
   
   
  $resultStats = mysql_query("SELECT * FROM csUserInfo WHERE MemberID='$username'");
  $imageValue = mysql_fetch_array($resultStats);
  
  $image=$imageValue['Avatar'];
  
  $mime = null;
  if ($type=="pjpeg") // <<< where do you get $type btw?
    $mime = "image/jpeg";

  $image = "data:".$mime.";base64," . base64_encode($image);

  $chicken = $chicken + 1;
  echo "<tr><td>" . $chicken . "</td>";
  echo "<td>" . $usernameValue['Username'] . "</td>";
  echo "<td>" . '<img src="'.$image.'" alt="User Avatar" width="75" height="75" />' . "</td>";
  echo "<td>" . $row['CoinsWon'] . "</td>";
  echo "<td>" . $row['BetsWon'] . "</td>";
  echo "<td>" . $row['Accuracy'] . "</td>";
  echo "<td>" . $row['Streak'] . "</td>";
  echo "</tr>";
  }
  

mysql_close($con);
?> 
</table>

</div> 
</div>      
</div>


</body></html>

