<?php
require 'vendor/autoload.php';
# This logic handles connecting to the database, where we store our todo status
$pdo = new \PDO("sqlite:" . "db/sqlite.db");

# This PHP logic handles user actions
# New TODO
/*Upon pressing the "add" button which has name "submit", uses the "description" from the text box to update the database. 
$sth etc updates the database database with ':description' being binded to $description which is a STRING (PDO::PARAM_STR). 
INSERT INTO "Table name" (table coloumn) VALUE (valueYouWishToInput)
Executes the script
*/
if (isset($_POST['submit'])) 
{
  $description = $_POST['description'];
  $sth = $pdo->prepare("INSERT INTO todos (description) VALUES (:description)");
  $sth->bindValue(':description', $description, PDO::PARAM_STR);
  $sth->execute();
}
# Delete TODO
/*Uses the value from pressing the delete button which is now true and executes the if statement (as $_POST['delete'] is true)
$sth etc updates the database id (which has its value binded as an int) by deleteing the database entry. 
Executes the script
*/
elseif (isset($_POST['delete']))
{ 
  $id = $_POST['id'];
  $sth = $pdo->prepare("delete from todos where id = :id");
  $sth->bindValue(':id', $id, PDO::PARAM_INT);
  $sth->execute();
}
# Update completion status
/*Uses the value from pressing the complete button which is now true and executes the if statement (as $_POST['complete'] is true)
$sth etc updates the database id (which has its value binded as an int)
with the complete being set to 1 = TRUE.  
Executes the script
*/
elseif (isset($_POST['complete']))
{
    $id = $_POST['id'];
    $sth = $pdo->prepare("UPDATE todos SET complete = 1 where id = :id");
    $sth->bindValue(':id', $id, PDO::PARAM_INT);
    $sth->execute();
}
# Here is the HTML:
?>
<!DOCTYPE HTML>
<html lang="en">
<head>
  <title>Todo List</title>
</head>
<!--
Remember the container for the ToDoList form. 
-->
<body class="container">
  <h1>Todo List</h1>
  <!--
  form method = post = send the values
  -->
  <form method="post" action="">
    <input type="text" name="description" value="">
    <input type="submit" name="submit" value="Add">
  </form>
  <h2>Current Todos</h2>
  <!--creates a table-->
  <table class="table table-striped">
 <!--Creates 3 table headers to put Task, complete and delete buttons. -->
    <thead><th>Task</th><th></th><th></th></thead>
    <!--starts the body of the table now that the heads are created -->
    <tbody>
<!--Retrieves all todos currently inserted via the add button and order them by 
  id in decending order
-->
<?php
  # Entering PHP mode, 
  #retrieves all entries added. Does this after each execution of "add" effectively. 
$sth = $pdo->prepare("SELECT * FROM todos ORDER BY id DESC");
$sth->execute();
/*for each entry in the databse, declared as a newly created "row" variable. 
Note to self: this reconstructs all the rows always as it needs to push the others down. 
*/
foreach ($sth as $row) {
  # Exiting PHP Mode
    ?> 
<!--create a table row-->
<tr>
<!--input the first field with the description -->
  <td>
      <!-- This is PHP shorthand for inserting dynamic text into HTML -->
      <!-- 
      close the data field
      -->
      <?=htmlspecialchars($row['description'])?></td> 
      <!--
       in the next data field aka collumn, create the complete button
      -->
  <td>
    <?php # Here we are mixing HTML and PHP to get the desired 
    #if !complete = !0 = True then show the complete button
if (!$row['complete']) {
        ?>
    <!--form method is post as we are sending this value into a variable. -->
    <form method="POST">
    <!--Create the button -->
      <button type="submit" name="complete">Complete</button>
      <!--Give it a hidden id used to relate to the databse's id
      #What happens when you press the button, gives id the id of the row 
      #in the database
      -->
      <input type="hidden" name="id" value="<?=$row['id']?>">
      <!--
      #change the value of the id'd task to true on button press.
      #this is what happens when you press the button - sets "complete = true"
      -->
      <input type="hidden" name="complete" value="true">
    </form>
    <?php
    /*otherwise the form should state "Task Complete" instead of a button when
      complete has been checked. 
    */
} else {
        ?>
    Task Complete!
    <?php
    #closes else
}
    ?>
    <!--
    #closes the data value. 
    -->
  </td>
  <!--
  #creates a new data value for the other header (next column as there were 3)
  -->
  <td>
      <!--
      #form method is post as we are sending this value into a variable. 
      -->
    <form method="POST">
      <!--
      #Create a button with type "submit" called delete
      -->
      <button type="submit" name="delete">Delete</button>
      <!-- Give it a hidden id used to relate to the database's id
      What happens when you press the button, gives id the id of the row 
      in the database
      -->
         
      <input type="hidden" name="id" value="<?=$row['id']?>">
      <!--
      Changes the "delete" value of the id'd row to be true. 
      When the button is pressed, the value for the delete of id is set to true
      hence the if statement activates and deletes the variable
      -->
      <input type="hidden" name="delete" value="true">
      <!--
      completes the form 
      -->
    </form>
    <!--
    completes the data entry
    -->
  </td>
  <!--
  completes the row
  -->
</tr>
<!--
closes the for loop
-->
<?php
}
?>
    <!--
    closes table body
    -->
    </tbody>
    <!--
    closes table html element
    -->
  </table>
  <!--
  closes body of document
  -->
</body>
<!--
closes entrite html document
-->
</html>