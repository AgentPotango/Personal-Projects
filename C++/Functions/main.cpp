#include <iostream>

using namespace std;
/* C++ reads frop top to bottom so when it reaches printSomething,
    it does not know what it is and so one solution is copying the function
    and moving it above the main method. However, there is a 2nd method.

*/

void printSomething();

/* this is called prototyping a function  which tells C++ to
    expect such a function.

*/

int main()
{
    /* First thing you write is the return type of a function
        then you name the function.
    */

    printSomething();

    return 0;
}

void printSomething()
{
    cout << "this is some cool text"  << endl;
}
