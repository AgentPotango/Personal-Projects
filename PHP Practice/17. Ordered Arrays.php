<?php

namespace Codecademy; 
// Write your code below:
$first_array = array("hello", 1, "my name is", 2, "Kashif");
//counts how many index's are in use
echo count($first_array);




// Write your code below:
//long form of writing an array
$with_function = array("PHP", "popcorn", 555.55);
//short hand to create an array aka use square brackets
//can write values on an individual line after each comma for readability. 
$with_short = ["PHP", "popcorn", 555.55];




$message = ["Oh hey", " You're doing great", " Keep up the good work!\n"];

$favorite_nums = [7, 201, 33, 88, 91];
// Write your code below:

//concatenates the array elements. 
//glue appends value to end of each array element (can use comma or space etc)
$glue = "!";
echo implode($glue,$message);
//Oh hey! You're doing great! Keep up the good work!

//echos out the entire array with index listed and its values
print_r($favorite_nums);
/*
Array
(
    [0] => 7
    [1] => 201
    [2] => 33
    [3] => 88
    [4] => 91
)
*/



$round_one = ["X", "X", "first winner"];

$round_two = ["second winner", "X", "X", "X"];

$round_three = ["X", "X", "X", "X", "third winner"];

// Write your code below:

//use [] to reference index values. Remember it starts from 0!
$winners = [$round_one[2], $round_two[0], $round_three[4]];

//prints concatination of winners array
echo implode(",\n", $winners);
echo "\n";
//displays array in detail. 
print_r($winners);


$change_me = [3, 6, 9];
// Write your code below:

//appends "numbers" to the array in index 3
$change_me[] = "numbers";
//appends 12 to the array in index 4
$change_me[] = 12;
//changes first index value of array to "tadpole"
$change_me[1] = "tadpole";

print_r($change_me);



$my_array = ["tic", "tac", "toe"];
array_pop($my_array); 
// $my_array is now ["tic", "tac"]
$popped = array_pop($my_array); 
// $popped is "tac"
// $my_array is now ["tic"]
/* Note that array_pop() doesn’t just set the last element to NULL. It actually removes it from the array, meaning that array’s length will decrease by one (which we can verify using count()).
*/

$new_array = ["eeny"];
//appends to end of $new_array
$num_added = array_push($new_array, "meeny", "miny", "moe"); 
echo $num_added; // Prints: 4 (returns new total elements in array of $new_array)
echo implode(", ", $new_array); // Prints: eeny, meeny, miny, moe 

$stack = ["wild success", "failure", "struggle"];
// Write your code below:

//append new value to end of array
array_push($stack, "blocker", "impediment");

//remove 4 values from array starting from last value
array_pop($stack);
array_pop($stack);
array_pop($stack);
array_pop($stack);


$adjectives = ["bad", "good", "great", "fantastic"];
$removed = array_shift($adjectives); //removes value from beginning of array and stores it in removed. 
echo $removed; //Prints: bad
echo implode(", ", $adjectives); // Prints: good, great, fantastic 

$foods = ["pizza", "crackers", "apples", "carrots"];
$arr_len = array_unshift($foods, "pasta", "meatballs", "lettuce"); //adds to beginning of array
echo $arr_len; //Prints: 7
echo implode(", ", $foods); 
// Prints: pasta, meatballs, lettuce, pizza, crackers, apples, carrots



//Using array_unshift to add to beginning of array
//array_shift to remove from beginning of array
$record_holders = [];
// Write your code below:

//add records to array with Tim in 0, Maurice in 1 etc
array_unshift($record_holders, "Tim Montgomery", "Maurice Greene", "Donovan Bailey", "Leroy Burrell", "Carl Lewis");

//Does the same as the above but Tim as 4 etc
//array_unshift($record_holders, "Carl Lewis", "Leroy Burrell", "Donovan Bailey", "Maurice Greene", "Tim Montgomery");

//remove first element aka Tim
array_shift($record_holders);

array_unshift($record_holders, "Justin Gatlin", "Asafa Powell");

//removes Justin
array_shift($record_holders);

array_unshift($record_holders, "Usain Bolt");


//nested arrays:
$nested_arr = [[2, 4], [3, 9], [4, 16]];
$first_el = $nested_arr[0][0];
echo $first_el; // Prints: 2

$very_nested = [1, "b", 33, ["cat", 6.1, [9, "LOST!", 6], "mouse"], 7.1];
$very_nested[3][2][1] = "Found!";//changes "LOST!" to "Found!"

$treasure_hunt = ["garbage", "cat", 99, ["soda can", 8, ":)", "sludge", ["stuff", "lint", ["GOLD!"], "cave", "bat", "scorpion"], "rock"], "glitter", "moonlight", 2.11];
  
// Write your code below:
//finds "GOLD!"
echo $treasure_hunt[3][4][2][0];
