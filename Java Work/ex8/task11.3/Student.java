/* This class is used to create student objects and allows you
   to add new phones, topup and make calls by referrencing the mobile class
*/

public class Student
{
  //Sets the name for the Student which cannot be changed
  private final String name;
  
  //The students mobile which is initially null
  private Phone mobile = null;
  
  //Methods used to create a student object
  public Student(String requiredName)
  {
    name = requiredName;
  }//Student
  
  //Method used to assign a new Phone to a user
  public void buyNewPhone(Phone newMobile)
  {
    mobile = newMobile;
  }//buyNewPhone

  //Method used to reference the phone class to top up the phone
  public void topUp(int amount)
  {
    if (mobile == null)
      return;
   
    mobile.topUp(amount);
  }//topUp
  
  //Method used to reference the phone class to make calls
  public void attemptCall(int duration)
  {
    if (mobile == null)
      return;
    
    mobile.makeCall(duration);
    
  }//attemptCall
  
  //Method used to return the mobile object
  public Phone getMobile()
  {
    return mobile;
  }//Phone
  
  //Method used to convert the student object into a string format
  public String toString()
  {
    return "Student(" + name + "," + mobile  + ")";
  }//toString
}  
  
  
  
  
