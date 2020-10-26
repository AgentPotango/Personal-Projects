<html>
<body>
<h1>Updating settings...</h1>

<?php
  include 'init.php';
  
  $ID = $_SESSION['member_id'];
  $query = mysql_query("SELECT UserLevel from csLogin WHERE MemberID=$ID");
  $resultquery = mysql_fetch_array($query);
  $userlevel = $resultquery['UserLevel'];
  
  if($userlevel == 2){
  
  $USERID = mysql_real_escape_string($_GET['userID']);
  echo $USERID;
  if ($_GET['deleteQuote'] == "Yes")
    mysql_query("UPDATE csUserInfo SET Quote='' WHERE MemberID=$USERID");
    
  if ($_GET['deleteAvatar'] == "Yes")
    mysql_query("UPDATE csUserInfo SET AvatarLocation='./usrimg/default.jpg' WHERE MemberID=$USERID");
  
  if ($_GET['adminUser'] == "Yes")
    mysql_query("UPDATE csLogin SET UserLevel='2' WHERE MemberID=$USERID");
  
  if ($_GET['banUser'] == "Yes")
    mysql_query("UPDATE csLogin SET UserLevel='0' WHERE MemberID=$USERID");
  
  $passwordUnhashed = mysql_real_escape_string($_GET['updateUserPassword']);
  $password = md5($passwordUnhashed);
  $email = mysql_real_escape_string($_GET['updateUserEmail']);
  $username = mysql_real_escape_string($_GET['updateUserName']);
  
  if ($password != "")
    mysql_query("UPDATE csLogin SET Password='$password' WHERE MemberID=$USERID");
    
  if ($email != "")
    mysql_query("UPDATE csUserInfo SET Email='$email' WHERE MemberID=$USERID");
    
  if ($username != "")
    mysql_query("UPDATE csLogin SET Username='$username' WHERE MemberID=$USERID");

  header('Location: admin.php?tabindex=0');
  }
?>





</body>
</html>
