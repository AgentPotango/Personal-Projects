//Two objects grouped into a pair
public class Pair<FirstType, SecondType>
{
  //The First Object
  private final FirstType first;
  
  //The Second Object
  private final SecondType second;
  
  //Constructor is given the two objects
  public Pair(FirstType requiredFirst, SecondType requiredSecond)
  {
    first = requiredFirst;
    second = requiredSecond;
  }//Pair
  
  //Returns the first type
  public FirstType getFirst()
  {
    return first;
  }//getFirst
  
  //Returns the second type
  public SecondType getSecond()
  {
    return second;
  }//getSecond
  
}//class Pair
