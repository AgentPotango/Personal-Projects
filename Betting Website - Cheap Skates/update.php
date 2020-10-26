<html>
<body>
<h1>Updating settings...</h1>

<?php
  include 'init.php';
  $quote = mysql_real_escape_string($_POST["Quote"]);
  $email = mysql_real_escape_string($_POST["Email"]);
  $email2 = mysql_real_escape_string($_POST["Email2"]);
  $password = mysql_real_escape_string($_POST["Password"]);
  $password2 = mysql_real_escape_string($_POST["Repassword"]);
  $birthday = mysql_real_escape_string($_POST["Birthday"]);
  $gender = mysql_real_escape_string($_POST["Gender"]);
  $country = mysql_real_escape_string($_POST["Country"]);
  $MemberID = $_SESSION['member_id'];
  $birthday = "";
  
  //Update quote
  
  if ($quote != "")
  {
    echo $quote;
    $query = mysql_query("UPDATE csUserInfo SET Quote='$quote' WHERE MemberID=$MemberID");
  }
  
  //Update email
  
  if ($email != "")
  {
    if ($email == $email2)
    {
      $query = mysql_query("UPDATE csUserInfo SET Email='$email' WHERE MemberID=$MemberID");
      echo "\"".$email."\"</br>";
    } // if emails match
    else
    {
      echo "The emails did not match!";
    } // else
  } // if email is non-empty
  
  //Update password
  
  if ($password != "")
  {
    if ($password == $password2)
    {
      $query = mysql_query("UPDATE csLogin SET Password='$password' WHERE MemberID=$MemberID");
      echo "Password:";
      $firstChar = substr($password, 0, 1);
      $lastChar = substr($password, -1, 1);
      echo $firstChar;
      for($i = 0; $i < strlen($_POST["Password"]) - 1; $i ++)
      {
        echo "*";
      }
      echo $lastChar;
      
    } // if they matched
    else
    {
      echo "Passwords did not match!";
    } // if did not match
  } // if password field wasn't empty
  
  //Update birthday
  
  if ($month != "" && $day != "" && $year != "")
  {
    echo "updating..";
    if (checkdate($month, $day, $year))
    {
      $birthday = $year."-".$month."-".$year;
      echo $birthday;
      $query = mysql_query("UPDATE csUserInfo SET Birthday='$birthday' WHERE MemberID=$MemberID");
    } // if the date is valid
    else
    {
      echo "That birthday was invalid";
    } // date is invalid
  }
  
  //Update gender
  
  if ($country != "")
  {
    $query = mysql_query("UPDATE csUserInfo SET Country='$country' WHERE MemberID=$MemberID");
  }
  
  //Update gender
  
  if ($gender != "")
  {
    $query = mysql_query("UPDATE csUserInfo SET Gender='$gender' WHERE MemberID=$MemberID");
  }


header('Location: Profile.php?id='.$MemberID);
?>





</body>
</html>
