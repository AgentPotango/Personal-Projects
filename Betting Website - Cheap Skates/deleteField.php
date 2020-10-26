<?php
function deleteField($idnum, $action)
{
	 echo'Hello';
  if ($authenticated == true || 1==1)
  {
    switch($action)
    {
      case avatar:
        mysql_query("UPDATE csUserInfo SET AvatarLocation='./usrimg/default.jpg' WHERE MemberID=$idnum");
        break;
      
      case quote;
        mysql_query("UPDATE csUserInfo SET Quote='' WHERE MemberID=$idnum");
        break;
      
      default:
        echo "";
    }
  }
}
?> 
