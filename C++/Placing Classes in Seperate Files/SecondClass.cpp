#include "SecondClass.h"
#include <iostream>

using namespace std;

/* This will contain the method body of the functions
 :: is called the binary scope resolutioon operator
 The constructor 'SecondClass' is a member of the class 'SecondClass'

*/

/* the header file and the main cpp file is split because if you are working
  in a team, your cpp file does not need to be touched if everything
  is working perfectly.
  The cpp file will then be compiled and the other people won't be able
  to change the function bodies.
  They will, however, be able to have access to the functions through
  the header file.
*/
SecondClass::SecondClass()

{
    cout << "I am a bannana" << endl;
}
