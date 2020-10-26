public class PiEstimation
{
  public static void main(String[] args)
  {
    //The tolerance is the minimum difference between successive
    //terms before we stop estimating.
    double tolerance = Double.parseDouble(args[0]);
        
    //The value of the previous estimate, initially 0 for 0 terms
    double previousEstimate = 0;
    
    //The result from our latest estimate, eventually the final result.
    double latestEstimate = 4;
        
    //We count the terms, initially 1 for the 4.
    int termCount = 1;
    
    //The value for the next term denominator, initially 3.
    double nextDenominator = 3;
    
    //The sign of the next term, initially -ve.
    double nextNumeratorSign = -1;
                  
    //Keep adding terms until the latest term is within  tolerance
    while (Math.abs(latestEstimate - previousEstimate) > tolerance)
    {
      previousEstimate = latestEstimate;
      latestEstimate += nextNumeratorSign * 4.0 / nextDenominator;
      termCount ++;
      nextNumeratorSign *= -1;
      nextDenominator += 2;
    }//While
    
    System.out.println("The estimated value of Pi to tolerance " + tolerance 
                       + " is " + latestEstimate);
    System.out.println("The estimate used " + termCount + " terms");
    System.out.println("The libray value of pi is " + Math.PI);
  }//main
}//class PiEstimation	       
      
