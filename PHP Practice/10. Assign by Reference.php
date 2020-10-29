<?php
/* Imagine a lot of code here */  
  $very_bad_unclear_name = "15 chicken wings";

// Write your code here:
$order =& $very_bad_unclear_name;
$order .= ", 2 beef steaks, 3 gallons of mango juice";

  // Don't change the line below
  echo "\nYour order is: $very_bad_unclear_name.";
// =& provides a referrence to the storage area of another variable
// as a result, changing this variable $very_bad would ALSO change $order.

