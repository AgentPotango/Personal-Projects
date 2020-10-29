<html>

<!-- The practice of echoing PHP code is very common that there is a shorter form. -->
<body>
<p>This HTML will get delivered as is</p>
<?php echo "<p>PHP interprets this and turns it into HTML</p>";?>
<p>This HTML will get delivered as is</p>


<!-- Use <?= ?> as a quick way to do <?php echo ?> -->
<p>This HTML will get delivered as is</p>
<?="<p>PHP interprets this and turns it into HTML</p>";?>
<p>This HTML will get delivered as is</p>

</body>
</html>

<!-- Another example of shorthand notation -->
<h1>Learning PHP and HTML</h1>
<p>This first paragraph is standard HTML</p>
<?= "<p>Let's insert some text into our HTML using PHP!</p>";?>
<p>This last paragraph is also standard HTML</p>