public class Power
{
  public static void main(String[] args)
  {
    int initialNumber = Integer.parseInt(args[0]);
    int thePowerTo = Integer.parseInt(args[1]);
    int poweredNumber = initialNumber;
              
    for (int count = 1; count < thePowerTo; count = count + 1)
      poweredNumber *= initialNumber;
      
    if (thePowerTo == 0)
      poweredNumber = 1;
                   
    System.out.println(initialNumber + " raised to the power to " 
                       + thePowerTo + " is " + poweredNumber);
  }
}  	    
