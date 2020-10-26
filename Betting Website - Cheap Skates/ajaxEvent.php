<?php
$numberOfChoices = $_COOKIE["Choices"];
if ($numberOfChoices == "")
{
  setcookie("Choices","1");
  $numberOfChoices = 1;
}
else
{
  $numberOfChoices++;
  setCookie("Choices","$numberOfChoices");
}
  $numberOfChoices = $_COOKIE['Choices']; 
  
  for ($i = 1; $i <= $numberOfChoices + 1; $i++)
  {
  echo '
	<div id="choice">
       <label for="Choice'. $i .'">Choice ' .$i.': </label> 
       <input id="ch'.$i.'" name="ch'.$i.'" placeholder="ch'.$i.'" required=""
       type="text"></br> 
       </div>
      ';
   }
  
?>
