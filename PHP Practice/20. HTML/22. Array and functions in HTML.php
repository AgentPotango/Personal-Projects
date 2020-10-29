<?php 
$about_me = [
  "name" => "Aisle Nevertell",
  "birth_year" => 1902,
  "favorite_food" => "pizza"
];

//calculates age of the person
//subtracts birthyear by current year. 
function calculateAge ($person_arr){
  //getts current year via Y
  $current_year = date("Y");
  //gets age
  $age = $current_year - $person_arr["birth_year"];
  return $age;
}
?>
<h1>Welcome!</h1>
<h2>About me:</h2>
<?php
#Add your code here
echo "<h3>My name is ${about_me[name]}.</h3>";
echo "<p>My age is " . calculateAge($about_me) ."</p>";
echo "<div>My favourite food is ${about_me[favorite_food]}</div>";
?>

<h2>Now tell me a little about you.</h2>
