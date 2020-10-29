<html>
<body>

<!-- This form method uses _$POST. 
	When using POST to submit forms, you will not see the URL change. 
	The form data is sent using the headers of the HTTP request instead of URL parameters.
	To use the data from the form in PHP, each input needs to have a unique name attribute.
-->
<!-- This form posts first and last as keys with the values inserted via the form -->
<form method="post">
First name: <input type="text" name="first">
<br>
Last name: <input type="text" name="last">
<br>
<input type="submit" value="Submit Name">
</form>
<br>

<!-- Form uses post method to display food and color via _$POST array -->
<form method="post">
Favorite Color:
<input type="text" name="color">
<br>
Favorite Food:
<input type="text" name="food">
<br>
<input type="submit" value="Submit">
</form>
<br>
<p>Best food is: <?= $_POST["food"];?></p>
<p>Best color is: <?= $_POST["color"];?></p>
<a href="index.php">Reset</a>


</body>
</html>