<?php
include 'init.php';
$ID = $_SESSION['member_id'];

if (!isset($_POST['upload']))
{
  include ("Settings.php"); //shows form if it's not been posted
  echo "It was not posted </br>";
}

else
{
  if($_FILES['pix']['tmp_name'] == "none")
  {
  echo "<b>File not successfully uploaded. Maybe check the filesize limit.</b>";
  include ("Settings.php");
  exit();
  }

  if(!ereg("image",$_FILES['pix']['type']))
  {
  echo "<b>File is not an image - try another file.</b>";
  include ("Settings.php");
  exit(); 
  }

  else
  {
    $uploadDir = 'usrimg/';
    echo "Upload Dir:".$uploadDir."</br>"; 
    $destination = $uploadDir.basename($_FILES['pix']['name']);
    echo "Destination Dir:".$destination."</br>";
    $temp_file = $_FILES['pix']['tmp_name'];
    echo $temp_file."</br>";

  //VVVVVVVVVVVV THIS IS BAD

    if ( move_uploaded_file ($temp_file,$destination) )
    {
      echo '<p>The file has been successfully uploaded!</p>'; 
      $query = mysql_query("UPDATE csUserInfo SET AvatarLocation='$destination' WHERE MemberID=$ID");
      header('Location: MyProfile.php');
    }
    else
    {
      echo "uh-oh - it didn't work!";
    }
  } // end of else
} // end of else
?>
