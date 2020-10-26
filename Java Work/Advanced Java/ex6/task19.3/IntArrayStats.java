public class IntArrayStats
{
  //Finds the largest & smallest number in the given arguments
  //Calculates the mran and returns a triple containing all 3 values
  //throws an illegal argument  exception is array is empty or not initialized
  public static Triple<Integer, Double> getStats(int[] intArray)
                                        throws IllegalArgumentException
  {
    if (intArray == null || intArray.length == 0)
      throw new IllegalArgumentException("Array must exist and be non-empty");
    
    //sets the three values to the initial value in the array
    int max = intArray[0];
    int min = intArray[0];
    int total = intArray[0];
    double mean;
    //starting from the next value in the array, calculates min max and total
    for (int index = 1; index < intArray.length; index ++)
    {  
      if (intArray[index] > max)
        max = intArray[index];
      else if (intArray[index] < min)
        min = intArray[index];
      
      total  += intArray[index];
    }//if
    mean = (double)total / intArray.length;
    return new Triple<Integer, Double>(new Integer(max), new Integer(min), 
                                       new Double(mean));
    
  }//getStats
}//IntArrayStats
    
    
    
    
    
