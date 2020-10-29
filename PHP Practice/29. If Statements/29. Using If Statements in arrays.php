<?php
namespace Codecademy;

$learner_one = ["is_correct"=>FALSE, "box"=>["shape"=>"none", "color"=>"none"]];
   
$learner_two = ["is_correct"=>TRUE, "box"=>["shape"=>"none", "color"=>"none"]];

#function to mark the answer - NOTE the referrence to the array implying a permanent change. 
function markAnswer($outcome, &$arr)
{
	#could have simply passed $arr and made changes via $arr["box"]["shape"]

	#if True
  if ($outcome)
  {
  	#change the array's shape and colour to the below values
    $arr["shape"] = "checkmark";
    $arr["color"] = "green";
  } else { #execute when false
    $arr["shape"] = "x";
    $arr["color"] = "red";
  }
} 

#executes function and changes answer
markAnswer($learner_one["is_correct"], $learner_one["box"]);
markAnswer($learner_two["is_correct"], $learner_two["box"]);
#prints results
print_r($learner_one["box"]);
print_r($learner_two["box"]);


#---------------------------------------------------------------------------------------------

function chooseCheckoutLane($number)
{
  #12 or fewer gets express, any amount over gets regular
  if ($number <= 12)
  {
    return "express lane";
  } else {
    return "regular lane";
  }

}

function canIVote($age)
{
	#vote if 18 or over
  if ($age >= 18)
  {
    return "yes";
  } else {
    return "no";
  }
}

echo chooseCheckoutLane(12);
echo "\n";
echo chooseCheckoutLane(13);
echo "\n";
echo canIVote(18);
echo "\n";
echo canIVote(17);
echo "\n";

#---------------------------------------------------------------------------------------------

/*
$num = 5;
$num === 5; // Evaluates to: TRUE
10 === 10; // Evaluates to: TRUE
$num === 20; // Evaluates to: FALSE

$greeting = "hello";
$greeting === "hello"; // Evaluates to: TRUE
"hello" === "hel" . "lo";   // Evaluates to: TRUE
$greeting === "HELLO"; // Evaluates to: FALSE

$num = 5;
$num !== 5; // Evaluates to: FALSE
10 !== 10; // Evaluates to: FALSE
$num !== 20; // Evaluates to: TRUE

$greeting = "hello";
"hello" !== "hello"; // Evaluates to: FALSE
$greeting !== "HELLO"; // Evaluates to: TRUE
*/


//function to check if two strings match
function agreeOrDisagree($string_one, $string_two)
{
  //note the triple equals for equality
  if ($string_one === $string_two)
  {
    return "You agree!";
  } else {
    return "You disagree!";
  }
}

echo agreeOrDisagree("hello", "hello") . "\n";
echo agreeOrDisagree("HELLO", "hello") . "\n";

//if renewal month is not this month, then welcome
//otherwise time to renew. 
// note the double equals.
function checkRenewalMonth($renewal_month)
{
  //this is the full text version of the months as dictated by PHP functions
  if ($renewal_month !== date("F"))
  {
    return "Welcome!";
  } else {
    return "Time to renew";
  }
}

echo checkRenewalMonth("January") . "\n";
echo checkRenewalMonth("October") . "\n";

#---------------------------------------------------------------------------------------------
/*
$grade = 88;
if ($grade < 60) {
  echo "You got an F";
} elseif ($grade < 70) {
  echo "You got a D";
} elseif ($grade < 80) {
  echo "You got a C";
} elseif ($grade < 90) {
  echo "You got a B";
} else {
  echo "You got an A";
}
Notice that the order of our conditionals is important. 
The grade 55 would satisfy the condition $grade < 90, but it meets the condition intended for it, $grade < 60 first. 
What if the elseif statements were in a different order?
If 90 was at top, it would display B because it will execute the first TRUE condition. 
*/

//keep in mind regarding the ordering of if and else if. First true is executed first
//using print function in php functions. 
function whatRelation($percent)
{
  if ($percent === 0)
  {
    print "not genetically related\n";
  } else if ($percent <=2) {
    print "third cousins\n";
  } else if ($percent <=5){
    print "second cousins\n";
  } else if ($percent <=13) {
    print "first cousins\n";
  } else if ($percent <=34) {
    print "grandparent and grandchild, aunt/uncle and niece/nephew, or half siblings\n";
  } else if ($percent <=99) {
    print "parent and child or full siblings\n";
  } else if ($percent === 100) {
    print "identical twins\n";
  }
}
whatRelation(0);
whatRelation(2);
whatRelation(5);
whatRelation(9);
whatRelation(30);
whatRelation(85);
whatRelation(100);

#---------------------------------------------------------------------------------------------

//Can use switch instead of if/else if

/*
if ($letter_grade === "A"){
  echo "Terrific";
} elseif ($letter_grade === "B") {
  echo "Good";
} elseif ($letter_grade === "C") {
  echo "Fair";
} elseif ($letter_grade === "D") {
  echo "Needs Improvement";
} elseif ($letter_grade === "F") {
  echo "See me!";
} else {
  echo "Invalid grade"; 
}
vs
switch ($letter_grade){
  case "A":
    echo "Terrific";
    break;
  case "B":
    echo "Good";
    break;
  case "C":
    echo "Fair";
    break;
  case "D":
    echo "Needs Improvement";
    break;
  case "F":
    echo "See me!";
    break;
  default:
    echo "Invalid grade"; 
}
For each case, we provide code that should run if that case matches. 
After each case, we include the keyword break to break out of the switch statement.
We can provide a default that should run if none of the provided cases match.

Switch statement is a good example of code that might be preferable not because it’s shorter, 
but rather because it clearly indicates the purpose of the code; 
when looking at a switch statement we can quickly identify the important aspects of the code; 
this makes it easier to understand, extend, and debug.
*/

//switch statements for aiequality. Note the : is after the text
//break is used after the text to exit the switch
//default is the default value when it matches none of the switch cases
function airQuality($color)
{
  switch ($color){
    case "green":
      print "good";
      break;
    case "yellow":
      print "moderate";
      break;
    case "orange":
      print "unhealthy for sensitive groups";
      break;
    case "red":
      print "unhealthy";
      break;
    case "purple":
      print "very unhealthy";
      break;
    case "maroon":
      print "hazardous";
      break;
    default: 
      print "invalid color";
  }
}
airQuality("orange") ;
echo "\n";
airQuality("green") ;
echo "\n";
airQuality("yellow") ;
echo "\n";
airQuality("red") ;
echo "\n";
airQuality("purple") ;
echo "\n";
airQuality("maroon") ;
echo "\n";
airQuality("black") ;
echo "\n";

#---------------------------------------------------------------------------------------------

//function which utilizes switch statement fall throughs
//if December is printed, follows down list until it reached "break"
//only exists switch once a break is found. 
function returnSeason($month_in_full)
{
  switch ($month_in_full) {
    case "December":
    case "January":
    case "February":
      return "winter";
      break;
    case "March":
    case "April":
    case "May":
      return "spring";
      break;
    case "June":
    case "July":
    case "August":
      return "summer";
      break;
    case "September":
    case "October":
    case "November":
      return "fall";
      break;
  }
}



#---------------------------------------------------------------------------------------------

//short hand for quick if statement if/else
//put ternary if after = to store the result into result. 
function ternaryCheckout($number)
{
  $result = ($number <= 12) ? "express lane" :"regular lane";
  return $result; 
}

function ternaryVote($age)
{
  $result = ($age >= 18) ? "yes" : "no";
  return $result;
}

echo ternaryCheckout(12) ."\n";
echo ternaryCheckout(13) ."\n";

echo ternaryVote(12) ."\n";
echo ternaryVote(18) ."\n";

#---------------------------------------------------------------------------------------------

/*
Most values and expressions are treated as truthy, so we’ll focus on those that are falsy:
(Truthy = if(truthy) = TRUE and falsy = if(falsy) = FALSE)
Falsy:

Empty strings
null
an undefined or undeclared variable
an empty array
the number 0
the string "0"
*/


#---------------------------------------------------------------------------------------------

//user inputs via readline()
//readline(">> ") inputs a >> on the bash indicating something needs to be entered. 
//to run programs via bash make sure you write php <directory>/<pagename>.php etc

/*
echo "Hi, I'm Aisle Nevertell. What's your name?\n";
$name = readline(">> ");
echo "\nNice to meet you, $name";
//Prints "Hi, I'm Aisle Nevertell. What's your name?"

//prints favourite colour.
echo "\nWhat's your favorite color?\n";
$color = readline(">> ");
if ($color === "green"){
  echo "\nCool, that's my favorite too!";
} else {
  echo "\nOh, $color is nice, I guess…";
}
*/

//evaluates if a function would return true or not
function truthyOrFalsy($val)
{
  $result = $val ? "True" : "False";
  return $result;
}

echo truthyOrFalsy("") . "\n";
echo truthyOrFalsy("0") . "\n";
echo truthyOrFalsy(null) . "\n";
echo truthyOrFalsy([]) . "\n";
echo truthyOrFalsy(0) . "\n";
echo truthyOrFalsy("Hello") . "\n";
echo truthyOrFalsy("1") . "\n";
echo truthyOrFalsy("0.5") . "\n";
echo truthyOrFalsy("[25]") . "\n";
echo truthyOrFalsy("!null") . "\n";


echo "Hello, there. What's your first name?\n";
$text = readline(">> ");

//method one
if (strlen($text) > 8){
   print "Hi, ${text}. That's a long name.";
} elseif (strlen($text)>=4){
    print "Hi, ${text}.";
} else {
    print "Hi, ${text}. That's a short name.";
}
echo "\n";

//method two
//note the brackets around the 2nd conditional if statement
strlen($text) > 8 ? print "Hi, ${text}. That's a long name." : 
(strlen($text) >= 4 ? print "Hi, ${text}." : print "Hi, ${text}. That's a short name.");
echo "\n";
