<html>
<body>

<?php
  $EventID = $_GET['EventID'];

  $result = mysql_query("SELECT EventImage FROM csEvents WHERE EventID=$EventID");

  while($row = mysql_fetch_array($result))
  {
    $image=$row['EventImage'];

    $mime = null;
    if ($type=="pjpeg") // <<< where do you get $type btw?
      $mime = "image/jpeg";

    $image = "data:".$mime.";base64," . base64_encode($image);
    echo '<img src="'.$image.'" alt="User Avatar" width="200" height="200" />';

  }



?>
