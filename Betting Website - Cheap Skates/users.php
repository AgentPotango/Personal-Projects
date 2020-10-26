<?php

function logged_in() {
	return (isset($_SESSION['member_id'])) ? true : false;
}

function user_exists($username) {
	$username = sanitize($username);
	$query = mysql_query("SELECT COUNT('MemberID') FROM csLogin WHERE Username = '$username'"); 
	return (mysql_result($query, 0) == 1) ? true : false;
}

function member_id_from_username($username) {
	$username = sanitize($username);
	$query2 = mysql_query("SELECT MemberID FROM csLogin WHERE Username = '$username'");
	return mysql_result($query2, 0, MemberID); 
}

function login($username, $password) {
	$member_id = member_id_from_username($username);
	$username = sanitize($username);
	$password = md5($password);
	$query = mysql_query("SELECT COUNT('MemberID') FROM csLogin WHERE Username = '$username' AND Password = '$password'"); 
	return (mysql_result($query, 0) == 1) ? $member_id : false;
}
// Function that returns the user level from the supplied username
function userlevel_from_username($username) {
    $username = sanitize($username);
    $query = mysql_query("SELECT UserLevel FROM csLogin WHERE Username ='$username'");
    return mysql_result($query, 0, UserLevel);

	

}
	
?>
