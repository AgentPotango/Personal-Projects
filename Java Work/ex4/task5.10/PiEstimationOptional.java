public class PiEstimationOptional
{
  public static void main(String[] args)
  {
    //The tolerance is the minimum difference between successive
    //terms before we stop estimating.
    double tolerance = Double.parseDouble(args[0]);
        
    //The value of the previous estimate, initially 0 for 0 terms
    //double previousEstimate = 0;
    
    //The result from our latest estimate, eventually the final result.
    double latestEstimate = 4;
        
    //We count the terms, initially 1 for the 4.
    int termCount = 1;
    
    //The value for the next term denominator, initially 3.
    double nextDenominator = 3;
    
    //The sign of the next term, initially -ve.
    double nextNumeratorSign = -1;
    
    double latestTerm = 0;
        
   for (int count = 0; count < 200000001; count++)
   { 
     for (latestTerm = latestEstimate; latestTerm < tolerance;
         latestTerm += nextNumeratorSign * 4.0 / nextDenominator)
         latestEstimate = latestTerm;
     termCount++;
     nextNumeratorSign *= -1;
     nextDenominator += 2;
   }  
      
    
    System.out.println("The estimated value of Pi to tolerance " + tolerance 
                       + " is " + latestEstimate);
    System.out.println("The estimate used " + termCount + " terms");
    System.out.println("The libray value of pi is " + Math.PI);
  }//main
}//class PiEstimation	       
      
