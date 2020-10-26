/*This class is used to create an Account for a mobile
  It calculates the balance after topups and calls are made
*/

public class Account
{
  //Constant for the charge rate per second
  public static final int CHARGE_PER_SECOND = 1;
  
  //Name of Acccount Service Provider
  private final String serviceName;
  
  //holds the value of the current balance for the mobile. 
  private int currentBalance = 0;
  
  //Sets up an Account object
  public Account(String nameOfService)
  {
    serviceName = nameOfService;
  }//Account
  
  //Method is used to increase the current balance and convert the pound
  //input into pennies to add to the balance.
  public void processTopUp(int amountInPounds)
  {
    int amountInPennies = amountInPounds * 100;
    currentBalance += amountInPennies;
  }//processTopUp
  
  //Method is used to calculate how much has to be deducted from the balance
  //for the call being made
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
  
  //returns the account name
  public String getAccountName()
  {
    return serviceName;
  }//getAccountName
  
  //returns the account balance
  public int getAccountBalance()
  {
    return currentBalance;
  }//getAccountBalance
  
  //translates the object into a string format
  public String toString()
  {
    return "Account(" + serviceName + "," + currentBalance + ")";
  }//toString
}//class Account
    
    
   
    
    
  
  
  
