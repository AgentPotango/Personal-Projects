<?php

 $currentUser = $_SESSION['member_id'];
/*	
  if (empty($currentUser) = null)
  {  
    echo "You must be logged in to place a bet!";
  }//if
  else
  {*/
    $result = mysql_query("SELECT CurrentCoins FROM csBetStats WHERE MemberID=$currentUser");
	
    while ($row = mysql_fetch_array($result))
    {
      echo "Avaliable Points: " . $row['CurrentCoins'];
    }//while
	
 /* }//else

*/
?> 
