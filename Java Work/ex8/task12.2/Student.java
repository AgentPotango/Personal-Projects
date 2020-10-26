/** This class is used to create student objects and allows you
 *  to add new phones, topup and make calls by referrencing the mobile class
 *  The class also returns the student's mobile and convers the student
 *  class into a string format
 *
 *  @author Kashif Hussain
*/

public class Student
{
  //Sets the name for the Student which cannot be changed
  private final String name;
  
  //The students mobile which is initially null
  private Phone mobile = null;
  
  /** Method sets up a Student object
   *  
   *  @param requiredName The name of the student specified  
   */
  public Student(String requiredName)
  {
    name = requiredName;
  }//Student
  
  /** Method used to assign a new Phone to a user
   *
   *  @param newMobile sets which mobile the student owns
   */
  public void buyNewPhone(Phone newMobile)
  {
    mobile = newMobile;
  }//buyNewPhone

  /** Method used to reference the phone class to top up the phone
   *  It exits if the student does not own a phone
   *
   *  @param amount the amount the student whats to top up by
   */
  public void topUp(int amount)
  {
    if (mobile == null)
      return;
   
    mobile.topUp(amount);
  }//topUp
  
  /** Method used to reference the phone class to make calls
   *  It exits if the student does not own a phone
   *
   *  @param duration the duration of the call the student wants to make
   */
  public void attemptCall(int duration)
  {
    if (mobile == null)
      return;
    
    mobile.makeCall(duration);
    
  }//attemptCall
  
  /** Method used to return the mobile object
   *
   *  @return the mobile which the student owns
   */
  public Phone getMobile()
  {
    return mobile;
  }//Phone
  
  /** Method comnverts the Student object into a string format
   *
   *  @return the student object 
   */
  public String toString()
  {
    return "Student(" + name + "," + mobile  + ")";
  }//toString
}  
  
  
  
  
