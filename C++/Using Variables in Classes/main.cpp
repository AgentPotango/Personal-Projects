#include <iostream>
#include <string>

using namespace std;

class MyClass
{
private:
    string name;
public:
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
   MyClass myObject;
   myObject.setName("Cat");
   cout << "The name you entered was ... " << myObject.getName();
    return 0;
}
