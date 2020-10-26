//Program which measures how much the mean of the integers from the
//command line arguments differ from the average of their minimum
//and maximim. 
//This program does not catch runTimeExceptions. 
public class MeanMinMaxMinusMean
{
  public static void main(String[] args) throws RuntimeException
  {
    int[] array = new int[args.length];
    for (int index =0; index < args.length; index ++)
      array[index] = Integer.parseInt(args[index]);
      
    Triple<Integer, Double> stats = IntArrayStats.getStats(array);
    int max = stats.getFirst().intValue();
    int min = stats.getSecond().intValue();
    double mean  = stats.getThird().doubleValue();
    System.out.println((min + max) / 2.0 - mean);
  }//main
}//MeanMinMaxMinusMean
    
    
    
    
    
