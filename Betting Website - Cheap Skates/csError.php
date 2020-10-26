
<?php // common.php
//copied from  http://www.sitepoint.com/users-php-sessions-mysql/

//creates an error message
function error($msg) {
?>
<html>
<head>
  <script language="JavaScript">
  <!--
  alert("<?=$msg?>");
  history.back();
  //-->
  </script>
</head>
<body>
</body>
</html>
<?
exit;
}
?>
