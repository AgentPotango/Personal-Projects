public class MinimumBitWidth
{
  public static void main(String[] args)
  {
    int numberOfValues = Integer.parseInt(args[0]);
    int noOfBits = 0;
    int bitsToThePower = 1;
   
    while (bitsToThePower < numberOfValues)
    {
      noOfBits = noOfBits + 1;
      bitsToThePower = Math.pow(2, noOfBits);
    }
    
    System.out.println("You need " + noOfBits + " bits to represent "
                       + numberOfValues + " values"); 
  }
}
