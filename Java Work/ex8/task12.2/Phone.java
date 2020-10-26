/** This class is used to create phone objects as well as record the
 *  total duration of all calls made.
 *  It also calls the account class to run methods such as:
 *  topUp, makeCall.
 *
 *  @author Kashif Hussain
 */

public class Phone
{
  //Name of phone is fixed 
  private final String name;
  
  //used to store call duration
  private int totalDuration = 0;
  
  //Used to store the account information which is fixed
  private final Account serviceProvider;
  
  /** Method used to create a phone object
   *
   *  @param phoneName the name of the phone specified
   *  @param accountName the Account object specified
   */
  public Phone(String phoneName, Account accountName)
  {
    name = phoneName;
    serviceProvider = accountName;
  }//Phone
  
  /** Method used to call the account class to add to the phone balance
   *
   *  @param amountInPounds the amount to be topped up by in pounds
   */
  public void topUp(int amountInPounds)
  {
   serviceProvider.processTopUp(amountInPounds);
  }//topUp
  
  /** Method used to call the account class to reduce the account balance
   *  with respect to duration
   *
   *  @param requiredDuration The duration which is needed to call the account
   *                         method to calculate the duration
   */
  public void makeCall(int requiredDuration)
  {
    totalDuration += serviceProvider.processCall(requiredDuration);
  }//makeCall
  
  /** Method used to return the Phone Name
   *
   *  @return the phone name
   */
  public String getPhoneName()
  {
    return name;
  }//getPhoneName
  
  /** Method used to convert the Phone object into string format
   *
   *  @return the phone object
   */
  public String toString()
  {
    return "Phone(" + name + "," + totalDuration + "," + serviceProvider + ")";
  }//toString
}//class Phone
  
  
  
    
       
  
  
  
