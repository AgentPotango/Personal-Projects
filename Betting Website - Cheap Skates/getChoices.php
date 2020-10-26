<html>
<body>

<?php
  $EventID = mysql_real_escape_string($_GET['EventID']);

  $choiceQuery = mysql_query("SELECT * FROM csChoices
                             WHERE EventID=$EventID");
  //output each radio button
  while ($row = mysql_fetch_array($choiceQuery))
  {
    
    echo '<input type="radio" name="prediction" value="'.$row['ChoiceName'].'">'.$row['ChoiceName'].' (Odds: '.$row['ChoiceOdds'].')<br>';
  }//while
?>
