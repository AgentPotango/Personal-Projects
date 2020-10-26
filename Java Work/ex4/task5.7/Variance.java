public class Variance
{
  public static void main(String[] args)
  {
    int sumSoFar = Integer.parseInt(args[0]);
    
    for (int index = 1; index < args.length; index ++)
      sumSoFar += Integer.parseInt(args[index]);
      
    double average = sumSoFar / args.length;
    double variance = 0.0;
    int deviation = 0;
    
    for (int index = 0; index < args.length; index ++)
      deviation += Math.pow(Integer.parseInt(args[index]) - average,2);
      variance = deviation / args.length;
           
    System.out.println("The Mean Average is " + average);
    System.out.println("The Variance is " + variance);
    
  }
}
    
    
   
