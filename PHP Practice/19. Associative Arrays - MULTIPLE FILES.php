<?php
namespace Codecademy;

$my_array = ["panda" => "very cute", "lizard" => "cute", "cockroach" => "not very cute"];

$about_me = array(
    "fullname" => "Aisle Nevertell",
    "social" => 123456789
);

$php_array = array(
  "language" => "PHP",
  "creator" => "Rasmus Lerdorf",
  "year_created" => 1995,
  "filename_extensions" => [".php", ".phtml", ".php3", ".php4", ".php5", ".php7", ".phps", ".php-s", ".pht", ".phar"]
);

//mapping key-> value in shorter notation. 
$php_short = [
  "language" => "PHP",
  "creator" => "Rasmus Lerdorf",
  "year_created" => 1995,
  "filename_extensions" => [".php", ".phtml", ".php3", ".php4", ".php5", ".php7", ".phps", ".php-s", ".pht", ".phar"]
];


//creating a map
$september_hits = [
  "The Sixth Sense" => 22896967,
  "Stigmata" => 18309666,
  "Blue Streak" => 19208806,
  "Double Jeopardy" => 23162542
];

//imploding only the values
echo implode(", ", $september_hits);
echo "\n";
//prints entire array. 
print_r($september_hits);

//Prints:
/*
22896967, 18309666, 19208806, 23162542
Array
(
    [The Sixth Sense] => 22896967
    [Stigmata] => 18309666
    [Blue Streak] => 19208806
    [Double Jeopardy] => 23162542
)
*/

$favorites = ["favorite_food"=>"pizza", "favorite_place"=>"my dreams", "FAVORITE_CASE"=>"CAPS","favorite_person"=>"myself"];

echo  $favorites["favorite" . "_" . "food"]; 
// Prints: pizza

$key =  "favorite_place";
echo  $favorites[$key];  
// Prints: my dreams

echo $favorites[strtoupper("favorite_case")];
// Prints: CAPS

$assignment_one = ["Alex"=> 87, "Kenny"=> 91, "Natalia"=> 91, "Lily"=> 67, "Dan"=> 81, "Kat"=> 77, "Sara" => 65];

$assignment_two = ["Alex"=> 91, "Kenny"=> 99, "Natalia"=> 100, "Lily"=> 61, "Dan"=> 88, "Kat"=> 90];

$assignment_three = ["Alex"=> 78, "Kenny"=> 92, "Natalia"=> 94, "Lily"=> 79, "Dan"=> 73, "Sara" => 61];

$student_name = "Alex";
// Write your code below:

$assignment_two["Sara"] = 65;
$assignment_three["Kat"] = 97; 

//assigning dan's grades to its own array. 
$dans_grades = [$assignment_one["Dan"], $assignment_two["Dan"], $assignment_three["Dan"]];

echo $assignment_two[$student_name];


//how to change and unset values
$my_car = [
  "oil" => "black and clumpy",
  "brakes" => "new",
  "tires" => "old with worn treads",
  "filth" => "bird droppings", 
  "wiper fluid" => "full", 
  "headlights" => "bright"
];
print_r($my_car);

// Write your code below:
//changing values. 
$my_car["oil"] = "new and premium";
$my_car["tires"] = "new with deep treads";

//unsetting keys and values - specifically filth. 
unset($my_car["filth"]);

print_r($my_car);

//We can mix and match ordered arrays with key=>values
$ordered = [99, 1, 7, 8];
$ordered["special"] = "Cool!";
echo $ordered[3]; // Prints: 8
echo $ordered["special"]; // Prints: Cool!

/*
When we add an element to an array without specifying a key (e.g. using array_push()), PHP will associate it with the “next” integer key. If no integer keys have been used, it will associate it with the key 0, otherwise it will associate it one more than the largest integer used thus far
*/

$num_array = [1000 => "one thousand", 100 => "one hundred", 600 => "six hundred"];
$num_array[] = "New Element in \$num_array";
echo $num_array[1001]; // Prints: New Element in $num_array

$animals_array = ["panda"=>"very cute", "lizard"=>"cute", "cockroach"=>"not very cute"];
array_push($animals_array, "New Element in \$animals_array");
echo $animals_array[0]; // Prints: New Element in $animals_arra



$hybrid_array = ["Yes", "No", 50000, 30];
//$hybrid_array = ["Yes", "hungry" => "No", "money" => 50000, 30 => "Minutes in half an hour", "PS5"];
//adding to number of index's in $hybrid_array + 5 the value "five more"
$hybrid_array[8] = "five more";
print_r($hybrid_array); 

//Add a rand value to 9th index cause we added something to the 8th index.
//array_push uses the next highest array index or 0 if there are none. 
array_push($hybrid_array, rand());
//prints the random number
echo $hybrid_array[9];

/*
The $animal_rankings we created above will have each of the key=>value pairs from $my_array. In addition, it will contain the key=>value pairs from $more_rankings: "capybara"=>"cutest" and "dog"=>"max cuteness". However, since "lizard" is not a unique key, $animal_rankings["lizard"] will retain the value of $my_array["lizard"] (which is "cute").
*/
$my_array = ["panda" => "very cute", "lizard" => "cute", "cockroach" => "not very cute"];
$more_rankings = ["capybara" => "cutest", "lizard" => "not cute", "dog" => "max cuteness"];
$animal_rankings = $my_array + $more_rankings;

/*
Union_array has the elements 8, 3, and 7. Since the two arrays being joined have identical keys (0, 1, and 2), no values from the second array, $string_array, are included in $union_array.
*/
$number_array = [8, 3, 7];
$string_array = ["first element", "second element", "third element"];
$union_array = $number_array + $string_array;

$giraffe_foods = ["dip"=>"guacamole", "chips"=>"corn", "entree"=>"grilled chicken"];

$impala_foods = ["dessert"=>"cookies", "vegetable"=>"asparagus", "side"=>"mashed potatoes"];

$rat_foods = ["dip"=>"mashed earth worms", "entree"=>"trash pizza", "dessert"=>"sugar cubes", "drink"=>"lemon water"];

// Write your code below:
//creates array combining the 2 arrays.
$potluck = $giraffe_foods + $impala_foods; 

print_r($potluck);

//only adds drink from rat_foods as everything else has a key/value pair. 
$potluck += $rat_foods; 

print_r($potluck);

/*
Array
(
    [dip] => guacamole
    [chips] => corn
    [entree] => grilled chicken
    [dessert] => cookies
    [vegetable] => asparagus
    [side] => mashed potatoes
    [drink] => lemon water
)
*/

/*
By value—this creates two variables which hold copies of the same value but remain independent entities.
By reference—this creates two variable names (aliases) which point to the same space in memory. They cannot be modified separately!
*/
$favorites = ["food"=>"pizza", "person"=>"myself", "dog"=>"Tadpole"];
$copy = $favorites;
$alias =& $favorites;
$favorites["food"] = "NEW!";

echo $favorites["food"]; // Prints: NEW!
echo $copy["food"]; // Prints: pizza
echo $alias["food"]; // Prints: NEW!

//prints green as we are passing a COPY of the arrat and not a reference. 
//hence we are not modifying the object array directly. 
function changeColor ($arr) 
{
  $arr["color"] = "red";    
}
$object = ["shape"=>"square", "size"=>"small", "color"=>"green"];
changeColor ($object);
echo $object["color"]; // Prints: green

//this changes the value of the object array. 
function reallyChangeColor (&$arr) 
{
  $arr["color"] = "red";    
}
$object = ["shape"=>"square", "size"=>"small", "color"=>"green"];
reallyChangeColor ($object);
echo $object["color"]; // Prints: red


$doge_meme = ["top_text" => "Such Python", "bottom_text" => "Very language. Wow.", "img" => "very-cute-dog.jpg", "description" => "An adorable doge looks confused."];

$bad_meme = ["top_text" => "i don't know", "bottom_text" => "i can't think of anything", "img" => "very-fat-cat.jpg", "description" => "A very fat cat looks happy."];

// Write your code below:

function createMeme($arr)
{
  $arr["top_text"] = "Much PHP";
  $arr["bottom_text"] = "Very programming. Wow.";
  return $arr; 
}

$meme = ["top_text" => "zero", "bottom_text" => "hello", "img" => "nothing", "description" => "long"];

createMeme($meme); 

//stores copy of the doge meme array but does not alter it permanently.
echo "Copy which was changed: \n";
$php_doge = createMeme($doge_meme);
print_r($php_doge);

//original doge array:
echo "Original: \n";
print_r($doge_meme);

//permanently alters array passed into it. 
function fixMeme(&$arr)
{
  $arr["top_text"] = "top";
  $arr["bottom_text"] = "bot";
}

//alters meme array
echo "Original: \n";
print_r($meme);
echo "After Perm modification: \n";
fixMeme($meme);
print_r($meme);

//alters bad_meme array
fixMeme($bad_meme);
print_r($bad_meme);
