//class needs two types: Integer and Double

public class Triple<FirstType, SecondType>
{
  //The two integer objects
  private final FirstType first, second;
  
  //The double object
  private final SecondType third;
  
  //Constructor is given 3 objects
  public Triple(FirstType requiredFirst, FirstType requiredSecond, 
                SecondType requiredThird)
  {
    first = requiredFirst;
    second = requiredSecond;
    third = requiredThird;
  }//Triple
  
  //returns the first object
  public FirstType getFirst()
  {
    return first;
  }//getFirst
  
  //returns the second object
  public FirstType getSecond()
  {
    return second;
  }//getSecond
  
  //returns the third object
  public SecondType getThird()
  {
    return third;
  }//getThird

}//Triple
  
  
  
    
