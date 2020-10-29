<?php

/*
Request Superglobals
Since PHP was built with web development as a primary use case, it has functionality to ease processing of HTML requests. When the front end client makes a request to a backend PHP server, several superglobals related to the request are available to the PHP script. Superglobals are automatic global variables which are available in all scopes throughout a script.

The list of superglobals in PHP includes the following:

$GLOBALS
$_SERVER
$_GET
$_POST
$_FILES
$_COOKIE
$_SESSION
$_REQUEST
$_ENV
For this lesson, we are focusing on three of these:

$_GET - this contains an associative array of variables passed to the current script using query parameters in the URL
$_POST - this contains an associative array of variables passed to the current script using a form submitted using the “POST” method
$_REQUEST - this contains the contents of $_GET, $_POST, and $_COOKIE
*/
?>

<html>

<body>
	<!-- Prints arrays that hold key => value maps-->
    $_REQUEST:
    <?php print_r($_REQUEST);?>
    <br>
    $_GET:
    <?php print_r($_GET); ?>
    <br>
    $_POST:
    <?php print_r($_POST); ?>
    <!-- _GET form with key set to get_name -->
    <form method="get">
        GET Form: <input type="text" name="get_name">
        <input type="submit" value="Submit GET">
    </form>
    <!-- _POST form with key set to post_name -->
    <form method="post">
        POST Form: <input type="text" name="post_name">
        <input type="submit" value="Submit POST">
    </form>
    <a href="index.php">Reset</a>
</body>

</html>

