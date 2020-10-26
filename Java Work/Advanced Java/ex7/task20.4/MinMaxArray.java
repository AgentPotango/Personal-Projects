import java.util.Arrays;

//Program takes an any Array type which is comparable and then
//after sorting the array into a natural order; it finds its natural max
//and natural minimum
public class MinMaxArray 
{
  public static <ArrayType extends Comparable<ArrayType>>
  		Pair<ArrayType, ArrayType> getMinMax(ArrayType[] anArray)
  		throws IllegalArgumentException
  {
    
    if (anArray == null)
      throw new IllegalArgumentException("Array must exist");
    
    if (anArray.length == 0)
      throw new IllegalArgumentException("Array must be non-empty");
    
    //sorts the array starting from 0 to the end of the array
    Arrays.sort(anArray, 0, anArray.length);
    ArrayType min = anArray[0];
    ArrayType max = anArray[0];
    
    //for loop which searches for the natural min and max
    for (int index = 1; index < anArray.length ; index++)
    {
      if (min.compareTo(anArray[index]) > 0)
        min = anArray[index];
      
      if (max.compareTo(anArray[index]) < 0)
        max = anArray[index];
        
    }
    
    //returns the min and max as a pair
    return new Pair<ArrayType, ArrayType>(min, max);
  }//main
}//MinMaxArray
      
      
    
  
