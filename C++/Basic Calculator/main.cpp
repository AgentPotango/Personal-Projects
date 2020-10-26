#include <iostream>

using namespace std;

int main()
{
    int a;
    int b;
    int sum;

    cout << "Enter a number! \n";

    /* The cin (Input Stream object) takes the user's input and >> is the
        stream extraction object */
    cin >> a;

    cout << "Enter another number \n";
    cin >> b;

    sum =  a + b

    /* Using the insertion operatoar allows you to add different types to the
        same line*/
    cout << "The sum of those numbers is " << sum << endl;



    return 0;
}
