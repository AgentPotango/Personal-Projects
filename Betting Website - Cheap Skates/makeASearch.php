<?php
if (isset($_POST['search'])) {
//This is only displayed if they have submitted the form
if ($searching == "yes")
{
    echo "<h2>Results</h2><p>";
    
    //If did not enter a search term we give them an error
    if ($find == "")
    {
        echo "<p>You forgot to enter a search term";
        exit;
    }
    
    
    // We preform a bit of filtering
    $find = strtoupper($find);
    $find = strip_tags($find);
    $find = trim ($find);
    
    //Now we search for our search term, in the field the user specified
    $data = mysql_query("SELECT * FROM users WHERE upper($field) LIKE'%$find%'");
    
    //And we display the results
    while($result = mysql_fetch_array( $data ))
    {
        echo $result['uname'];
        echo "<br>";
        //echo $result['ename'];
        //echo "<br>";
        //echo "<br>";
    }
    
    //This counts the number or results - and if there wasn't any it gives them a little message explaining that
    $anymatches=mysql_num_rows($data);
    if ($anymatches == 0)
    {
        echo "Sorry, but we can not find an entry to match your query<br><br>";
    } 
    
    //And we remind them what they searched for 
    echo "<b>Searched For:</b> " .$find;
}
}
?>
