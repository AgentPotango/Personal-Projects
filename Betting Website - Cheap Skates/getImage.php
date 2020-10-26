<html>
<body>

<?php
  $EventID = mysql_real_escape_string($_GET['EventID']);

  $result = mysql_query("SELECT * FROM csEvents WHERE EventID=$EventID");

  while($row = mysql_fetch_array($result))
  {
    $image=$row['EventImage'];
	 $pic = $row['EventImageLocation'];
    $mime = null;
    if ($type=="pjpeg") // <<< where do you get $type btw?
      $mime = "image/jpeg";
     

    $image = "data:".$mime.";base64," . base64_encode($image);
    echo '<img src="'.$pic.'" alt="User Avatar" width="200" height="200" />';

  }



?>
