<html>
<body>
<!-- This is part of 27. Multi-page.
	Information is passed here via the action
	infromation is parsed through the $_GET but $_POST could also have been used. 
-->
<p>Thanks!</p>
<p>Your name has been recorded as:</p>
<p><?= $_GET["first"] . " " . $_GET["last"]?></p>
<!-- Refreshed the previously linked page-->
<a href="27. Multi-Page $_Get and Actions.php">Reset</a>
</body>
</html>