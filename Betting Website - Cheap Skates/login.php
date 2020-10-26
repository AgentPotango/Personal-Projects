<?php
include 'init.php';

if (empty($_POST) == false){
	$username = $_POST['Username'];
	$password = $_POST['Password'];
	
	if (empty($username) == true || empty($password) == true){
		  $errors[] = 'You need to enter a username and password';
	}	else if (user_exists($username) == false) {
		  $errors[] = 'Username not found';
	}	else {
	
		  if (strlen($password) > 32) {
		  	$errors[] = 'Password too long';
		  }
		  
		  $login = login($username, $password);
          $userlevel = userlevel_from_username($username);
		  if ($login == false) {
		    $errors[] = 'Username and Password combination not recognised';
		  } else if ($userlevel == 0) {
            $errors[] = 'That account has been banned';
          } else {
		  	$_SESSION['member_id'] = $login;
		  	$_SESSION['username'] = $username;
           		 $_SESSION['userlevel'] = $userlevel;
		  	header('Location: Homepage.php');
		  	exit();
		  	//set the user session
		  	//redirect user to home
		  	
		}
	}


} else {
	$errors[] = "No Data Recieved";
}
echo output_errors($errors);
echo '<a href="Homepage.php">Go back</a>';
?>



	
	





