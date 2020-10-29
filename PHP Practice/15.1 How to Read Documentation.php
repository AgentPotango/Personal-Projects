Documentation
In order to understand built-in functions we’ve never used before, we’ll want to get comfortable understanding how they are represented in the documentation. Documentation typically includes:

The name of the function.
The versions of the PHP language the function is available in.
An overview of how the function works.
Additional details on the parameters and return value.
Examples of the function in use.
User comments further explaining features of the function.
The description section can be confusing, so we’ll break that down.

Here’s the description for the abs() function:

abs ( mixed $number ) : number

Here we see the function name followed by parentheses. The parentheses contain information about the function’s parameter(s)—first the parameter’s type followed by its name. The parameter for abs() has the type mixed because there are multiple data types the function will accept (an integer or a float). The parameter for abs() is named $number. After the parentheses is a colon (:) followed by number; this is the data type the function will return.

A function that prints something but doesn’t return a value will have :void instead of a return type. Similarly, a function that doesn’t accept parameters will have void within its parentheses.

Let’s look at a more complicated example. Here’s the description for the substr_count() function:

substr_count ( string $haystack , string $needle [, int $offset = 0 [, int $length ]] ) : int

Earlier in this lesson, we invoked substr_count() with only the two string parameters ($haystack and $needle). But functions can have optional parameters. This means they’ll work with or without them. These parameters are wrapped in square brackets ([ ]) in the function’s description. An optional parameter may have a default value, this is the value that will be used if no argument is passed into the function. The default value is indicated with an equal sign (=).

The substr_count() function accepts two additional integer arguments—$offset and $length. $offset has a default value of 0. Take a look at the documentation and see if you can figure out what they do.

Let’s practice reading some function descriptions!

Finding Functions
In order to find out about built-in functions (and other language features), you’ll want to get comfortable exploring the PHP documentation. The docs can get a little overwhelming—for example, this seemingly infinite index of PHP functions is pretty unwieldy.

The documentation contains some lists organized by topic: this is a list of PHP string functions and this is a list of math functions.

It’s often faster to use Google to navigate to the right part of the official documentation (php.net). For example, when I googled “PHP absolute value” the first result was a link to the abs() function in the PHP documentation.

Let’s practice discovering new functions!