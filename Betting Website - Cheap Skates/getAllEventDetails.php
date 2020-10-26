<?php
$currentTimeUnix = mktime();
$currentTime = date('Y-m-d H:i:s', $currentTimeUnix);
  $getCatKey = mysql_query("SELECT * FROM csEvents WHERE StartDandT > '$currentTime' ORDER BY StartDandT ASC");  
  echo '<h1>Events</h1>';

echo"<table class='curvedEdges'>
<tr>";

$chicken = 0;

while($row = mysql_fetch_array($getCatKey) and ($chicken < 12))
  {
  echo '<td><table class="invisible">';
  
  $username=$row['EventID'];
  
  $image=$row['EventImageLocation'];
  $link = "EventPage.php?EventID="."$username";

  if ($chicken % 2)
  {
   echo '<tr style="background-color:#c5c5c5"><td>';
   echo '<h2>' . $row['EventName'] . "</h2></td></tr>";
   echo '<tr style="background-color:#c5c5c5"><td>' . "<a href='".$link."'><img src='".$image."' alt='User Avatar' width='75' height='75' /></a>" . '</td></tr>';
   echo '<tr style="background-color:#c5c5c5"><td><p>' . $row['EventDescription'] . '</p></td></tr>';
   echo '</tr>';
  }
  else
  {
   echo '<tr><td>';
   echo '<h2>' . $row['EventName'] . "</h2></td></tr>";
   echo '<tr><td>' . "<a href='".$link."'><img src='".$image."' alt='User Avatar' width='75' height='75' /></a>" . '</td></tr>';
   echo '<tr><td><p>' . $row['EventDescription'] . '</p></td></tr>';
  }
  $chicken = $chicken + 1;
  echo '</table></td>';
  if($chicken % 3 == 0)
  {
   echo '</tr><tr>';
  }
  }
 if($chicken==0)
 {
   echo"<tr><td><h2>There are no Events currently in this Category</h2></td>";
 }  
  
echo "</tr></table>";

mysql_close($con);
?>
