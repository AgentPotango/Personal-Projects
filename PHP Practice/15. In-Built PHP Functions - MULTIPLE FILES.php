<?php

//use Codecademy namespace meaning their built in functions no longer neeed
// Codecademy.var_dump etc.
namespace Codecademy;

$first = "Welcome to the magical world of built-in functions.";
  
$second = 82137012983; 

//Write your code below:

//returns type of variable e.g. string or int
echo gettype($first) . "\n";
echo gettype($second) . "\n";

//echos type of variable and length as well as prints string
//e.g. String(51) "...."
var_dump($first);
//echos type of variable with amount in brackets if string
//e.g. "int(82137012983)"
var_dump($second);



//reverses string
echo strrev("Hello, World!"); // Prints: !dlroW ,olleH
//lowercase string
echo strtolower("HeLLo"); // Prints: hello
//repeats for specified amount
echo str_repeat("hi", 10); // Prints: hihihihihihih

echo strrev(".pu ti peeK .taerg gniod er'uoY" . "\n");
echo strtolower("SOON, tHiS WILL Look NoRmAL." . "\n");
echo str_repeat("\nThere's no place like home.\n", 3);


//counts amount of substring in larger string. 
$story = "I was like, \"Dude, like just tell me what you like think because like everyone else is like being totally honest, and like I just want to know what you like think.\" So like I don't know...";

echo substr_count($story, "like"); // Prints: 8

$essay_one = "I really enjoyed the book. I thought the characters were really interesting. The plot of the novel was really engaging. I really felt the characters' emotions. They were really well-written. I really wish the ending had been different though.";
  
$essay_two = "Obviously this is a really good book. You obviously would not have made us read it if it wasn't. I felt like the ending was too obvious though. It was so obvious who did it right away. I think the thing with the light was obviously a metaphor for life. It would have been better if the characters were less obvious about their secrets.";  

// Write your code below:
//finds all copies of "really" in essay_one
echo substr_count($essay_one, "really");
echo "\n";

//counts both obvious and obviously. Doesn't care about characters before and after aka counts "obviously" 
//capitalization is IMPORTANT! Will not count first "Obviously". 
echo substr_count($essay_two, "obvious");


//using builtin absolute function to return the absolute distance between 2 distances
//regardless of which was entered as the 1st or 2nd argument. 
function calculateDistance($distance_one, $distance_two)
{
  return abs($distance_one - $distance_two);
}

echo calculateDistance(-1, 4) . "\n";
echo calculateDistance(4, -1) . "\n";
echo calculateDistance(3, 7) . "\n";
echo calculateDistance(7, 3) . "\n";


//calculates the new total price with the tip added onto it and rounds the value to the nearest Integer
//rounding follows general rounding rules 5 and up rounded up, 4 and below rounded down.  
function calculateTip($total_cost_meal)
{
  $new_total = round($total_cost_meal * (1 + 0.18));
  return $new_total; 
}

echo calculateTip(100) . "\n";
echo calculateTip(35) . "\n";
echo calculateTip(88.77) . "\n";

//Rand dunctions and randmax
//shows largets number that is possible to generate in this environment
$max = getrandmax();

echo $max;
echo "\n";
//fact: 2nd argument number can be larger than the getrandmax()!
echo rand(1, 2); // Prints either 1 or 2
echo "\n";
echo rand(5, 10); // Prints a number between 5 and 10 (inclusive!)
echo "\n";
echo rand(1, 100); // Prints a number between 1 and 100 (inclusive!)
echo "\n";

echo getrandmax();
echo "\n";
echo rand();
echo "\n";
echo rand(1,52);

//using documentation
//str_pad ( string $input , int $pad_length [, string $pad_string = " " [, int $pad_type = STR_PAD_RIGHT ]] ) : string

$a = 29; //total length
$b = "You did it!"; //string to pad
$c = STR_PAD_BOTH; //type of pad
$d = "*~*"; //what to pad it with so it reaches the desired length

// Write your code below:
echo str_pad($b, $a, $d, $c);


//

// Write your code below:
//convers tring to all uppercase. 
function convertToShout($string)
{
  $result  = strtoupper($string) . "!";
  return $result;
}
echo convertToShout("woah there, buddy") . "\n";
echo convertToShout("i just don't know") . "\n";
echo convertToShout("oh, ok, that's fine") . "\n";
echo convertToShout("it's nice to meet you"). "\n";

//ceil rounds up to the nearest integer which is what we want
//round would round down if < 4
function tipGenerously($meal_cost)
{
  $total_after_tip = ceil($meal_cost * (1+0.2));
  return $total_after_tip; 
}

echo tipGenerously(100.00) . "\n"; 
echo tipGenerously(982.27) . "\n"; 
echo tipGenerously(15.67) . "\n"; 
echo tipGenerously(66.18) . "\n"; 
echo tipGenerously(21.65) . "\n";

//gets area by doing radius^2 * pi()
function calculateCircleArea($diameter)
{
  $area = pi() * (($diameter/2) ** 2);
  return $area;
}

echo calculateCircleArea(25) . "\n";
echo calculateCircleArea(30) . "\n";
echo calculateCircleArea(872) . "\n";
echo calculateCircleArea(6) . "\n";
echo calculateCircleArea(29) . "\n";





