/** This class is used to create an Account for a mobile
 * 
 *  It calculates the balance after topups and calls are made
 *  It also returns the values for the Account names and the current balance
 *  The program also has a toString method which convers the object into 
 *  A string format
 *
 *  @author Kashif hussain
 */

public class Account
{
  //Constant for the charge rate per second
  public static final int CHARGE_PER_SECOND = 1;
  
  //Name of Acccount Service Provider
  private final String serviceName;
  
  //holds the value of the current balance for the mobile. 
  private int currentBalance = 0;
  
  /** Sets up an Account object
   *  
   *  @param nameOfService The name of the account specified  
   */
  public Account(String nameOfService)
  {
    serviceName = nameOfService;
  }//Account
  
  
  /** Method is used to increase the current balance and convert the pound
   *  and input into pennies to add to the balance.
   *
   *  @param amountInPounds The amount to top up in pounds
   */
   
  public void processTopUp(int amountInPounds)
  {
    int amountInPennies = amountInPounds * 100;
    currentBalance += amountInPennies;
  }//processTopUp
  
  /** Method is used to calculate how much has to be deducted from the balance
   *  for the call being made
   *
   *  @param requestedDuration The duration which is needed to work out the cost
   *                           for the duration
   *
   *  @return The duration of the call whose limit is the
   *         current balance
   */
  public int processCall(int requestedDuration)
  {
    int durationCost = requestedDuration * CHARGE_PER_SECOND;
    int actualDuration = requestedDuration;
   
    //if there is not enough balance, then the duration's limit is the balance.
    if (currentBalance >= durationCost)
      currentBalance -= durationCost;
    else
    {
      actualDuration = currentBalance;
      durationCost = actualDuration;
      currentBalance -= durationCost;
    }
    
    return actualDuration;
  }//processCall
  
  /** Method gets the account name
   *
   *  @return the name of the account
   */
  public String getAccountName()
  {
    return serviceName;
  }//getAccountName
  
  /** Method gets the account Balance
   *
   *  @return the account balance
   */
  public int getAccountBalance()
  {
    return currentBalance;
  }//getAccountBalance
  
  /** Method comnverts the Accont object into a string format
   *
   *  @return the account object 
   */
  public String toString()
  {
    return "Account(" + serviceName + "," + currentBalance + ")";
  }//toString
}//class Account
    
    
   
    
    
  
  
  
