#include <iostream>
#include <string>
using namespace std;

class MyClass
{
private:
    string name;
public:
    MyClass(string name)
    {
        setName(name);
    }
    void setName(string chosenName)
    {
        name = chosenName;
    }
    string getName()
    {
        return name;
    }

};


int main()
{
   MyClass myObject("Kash");
   cout << "The name you entered was ... " << myObject.getName() << endl;

   MyClass myObject2("King");
   cout << "The name you entered was ... " << myObject2.getName();
    return 0;
}

