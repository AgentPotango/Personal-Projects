<?php
// Write your code below:
  
function praisePHP()
{
echo "praise toucan";
}

// executes function
function inflateEgo()
{
  $best = "I am the best";
  echo $best . " and you know it!\n";
}
inflateEgo();
inflateEgo();

//returns a number which can be echo'd
function printStringReturnNumber()
{
  echo "This is a spooky number: \n";
  return 13;
}

$my_num = printStringReturnNumber();
echo $my_num; 


//This set of code was just explaining how RETURN placed BEFORE the echo statements ends the function
//As a result, the "echo" strings would not be displayed, hence you must but return at end if you want
//everything else to function. 
function notFound()
{
  echo "ERROR: Page not found!\n";
  return 404;
}

function greetLearner()
{
  echo "Hello, Learner!\n";
  echo "I hope you're (still) enjoying PHP!\n";
  echo "Love, Codecademy\n";
  return "<3";
}

// Don't change the code below:

$error = notFound(); 
$heart = greetLearner();

echo "I received a $error, but it's ok because I also received $heart.";

//Returns the concatenated string in 1 line. 
function first()
{
  return "You did it!\n";
}

function second()
{
  return "You're amazing!\n";
}

function third()
{
  return "You're a coding hero!\n";
}

// Write your code below:
echo first() . second() . third();


//creates a function which returns nothing
// when NULL is returned, it returns a 0!
function createVacuum()
{
  echo "I need to vacuum this evening \n";
}
  
echo createVacuum() * 10;



function increaseEnthusiasm($string)
{
  return "$string!";
};
echo increaseEnthusiasm("Hello");

function repeatThreeTimes($repeatable)
{
  return $repeatable . $repeatable . $repeatable;
};

echo repeatThreeTimes("\nHello");
//makes it enthusiastic before repeating
echo repeatThreeTimes(increaseEnthusiasm("\nYou are fat"));
//repeats first before adding enthusiasm on end
echo increaseEnthusiasm(repeatThreeTimes("\nNo you aren't"));


//passing multiple parameters. 
function calculateArea($height, $width)
{
  $area = $height  * $width;
  return $area;
}

echo "Area: " . calculateArea(10, 2);

function calculateVolume($height, $width, $depth)
{
  $volume = $height  * $width * $depth;
  return $volume;
}

echo "\nVolume: ". calculateVolume(10,2,5);



//you can add default arguments to parameters which are used when nothing is supplied. 
function calculateTip($cost_of_meal, $tip_percent = 20)
{
  $total = $cost_of_meal * (1 + $tip_percent/100); 
  return $total;
};

echo calculateTip(100,25); 
echo "\n" . calculateTip(100);
echo "\n" . calculateTip(65,15);

//using a reference as a parameter permanently changes the passed parameter:

$string_one = "you have teeth";
$string_two = "toads are nice";
$string_three = "brown is my favorite color";

// Write your code below:
//reference passed denoted by &
//string rewritten  as you are re-writing the referrence address specifically
// as a result, anything passed to it has its referrence address's value changed. 
function convertToQuestion(&$string)
{
  $string = "Do you think " . $string . "?\n";
  return $string;
}

$hypothesis = "Katib is fat";
convertToQuestion($hypothesis);
echo $hypothesis;

convertToQuestion($string_one);
echo $string_one;
convertToQuestion($string_two);
echo $string_two;
convertToQuestion($string_three);
echo $string_three;

//Variable Scope
//Functions variables have a local scope - only used in that function
//global tells php to look for the global variable declared outside of the function
//note that this does make it harder to understand the dependencies of a function. 
//you don't have to prepend functions with "global" as it can be used in same document once declared 
// even inside functions. 
$language = "PHP";
$topic = "scope";

function generateLessonName($concept)
{
  global $language;
  return $language . ": " . $concept;
}

echo generateLessonName($topic);
