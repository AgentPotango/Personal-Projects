<!DOCTYPE html>
<html lang="en">
<head>
<?php include 'init.php'; 

$ID = $_SESSION['member_id'];


$imageQuery = mysql_query("SELECT AvatarLocation from csUserInfo WHERE MemberID=$ID");
$imageArray = mysql_fetch_array($imageQuery);
$image = $imageArray['AvatarLocation'];

echo "<img src='$image'  width='150' height='150' />";

?>

Hello
</head>
</html>
