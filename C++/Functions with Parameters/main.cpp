#include <iostream>

using namespace std;

void printNumber(int fav_number);

int main()
{
    int fav;

    cout << "Please Enter your favourite Number \n";
    cin >> fav;

    printNumber(fav);
    return 0;
}

void printNumber(int fav_number)
{
    cout << "Your favourite number is " << fav_number << endl;
}
