#include <iostream>

using namespace std;

int addNumbers(int number1, int number2);

int main()
{
    int a;
    int b;

    cout << "Please enter your first number to add with another \n";
    cin >> a;
    cout << "Please enter your second number to add with the first \n";
    cin >> b;

    cout << "Sum of your two numbers is " << addNumbers(a ,b);
    return 0;
}

int addNumbers(int number1, int number2)
{
    int answer = number1 + number2;
    return answer;
}
