public class LargestSquare2
{
  public static void main(String[] args)
  {
    int positiveInteger = Integer.parseInt(args[0]);
    int largestSquareNumber = 0;
    
    while (Math.pow(largestSquareNumber, 2) <= positiveInteger)
        largestSquareNumber = largestSquareNumber + 1;
    
    if (Math.pow(largestSquareNumber, 2) > positiveInteger)
      largestSquareNumber = largestSquareNumber -1;
      
    System.out.println("Largest Square Number less than or equal to "
                        + positiveInteger + " is " 
			+ Math.pow(largestSquareNumber, 2));
  }
} 
      
