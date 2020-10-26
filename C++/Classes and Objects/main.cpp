#include <iostream>

using namespace std;

class MyClass{
    /* Access Specifiers.
        public:      Makes all functions under this public
        private:     Makes all the functions under this private
    */
        public:
            void someMessage()
            {
                cout << "This is my message" << endl;
            }
};

int main()
{
    /* myObject is an instance of MyClass and C++ knows that
        myObject is of type MyClass.
    */
    MyClass myObject;
    myObject.someMessage();
    return 0;
}
