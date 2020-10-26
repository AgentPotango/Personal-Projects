<?php
include 'init.php';

if (empty($_POST) == false){

	$username = mysql_real_escape_string($_POST['Username']);
	$password = mysql_real_escape_string($_POST['Password']);
	$passcheck = mysql_real_escape_string($_POST['Repassword']);
	$email = mysql_real_escape_string($_POST['Email']);
	$day = mysql_real_escape_string($_POST['Day']);
	$month = mysql_real_escape_string($_POST['Month']);
	$year = mysql_real_escape_string($_POST['Year']);
	$gender = mysql_real_escape_string($_POST['Gender']);
	$country = mysql_real_escape_string($_POST['Country']);
	$birthday =  $year . '-' . $month . '-' .$day;
	$timezone = date_default_timezone_set('Europe/London');
	$currentdate = date('Y-m-d');
	
		
	if (empty($username) == true || empty($password) == true
	|| empty($passcheck) == true || empty($email) == true 
	|| empty($day) == true || empty($month) == true
	|| empty($year) == true || empty($gender) == true
	|| empty($country) == true)
	{
		  $errors[] = 'You must fill in all the fields';
	}	else if (user_exists($username) == true) {
		  $errors[] = 'Username ' .$username. ' is already in use: please choose another.';
	}	else if ($password != $passcheck) {
		  $errors[] = 'Your passwords do not match. Please enter the
		  		same passwords in both fields';
	}	
		/*else if (!valid_email($email)) {*/
		else if(filter_var($email,FILTER_VALIDATE_EMAIL) === false) {
		  $errors[] = 'Your email address is in an incorrect format';
	
	}	else if (!checkdate($month, $day, $year)) {
		  $errors[] = 'There is no day ' .$day . ' in ' .$month. ' in the year ' .$year;
	
	}	else if (strlen($password) >= 16) {
		   $errors[] = 'Password must be less than or equal to 16 characters';
	
	}	else  if (strlen($username) >= 32) {
		   $errors[] = 'Username must be less than or equal to 32 characters';
		  	
		} else {
			$passwordhash = md5($password);	
		   mysql_query("INSERT INTO csLogin (Username, Password, UserLevel) VALUES ('$username','$passwordhash','1')");
		   
		   $findID=mysql_query("SELECT MemberID FROM csLogin WHERE Username = '$username'");
		   $ID=mysql_fetch_array($findID);
		   $memberid = $ID['MemberID'];
		   
		   mysql_query("INSERT INTO csUserInfo (MemberID, Birthday, JoinDate, Country, Email, Quote, Gender) VALUES ('$memberid','$birthday','$currentdate','$country','$email','Enter Your Own Quote', '$gender')");
		
		   mysql_query("INSERT INTO csBetStats VALUES('$memberid','0','0','0','0','0','100')");
		   header('Location: Homepage.php');
		   exit();
		     
		   
		   
		   
		   
	}
} 
/*

} else {
	$errors[] = "No Data Recieved";
}
*/
if (!empty($errors)){

echo output_errors($errors);
}

?>



	
	





