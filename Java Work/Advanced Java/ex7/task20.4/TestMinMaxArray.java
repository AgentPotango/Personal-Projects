import java.util.Arrays;

//Program which creates arrays to test Min Max Array
public class TestMinMaxArray
{
  public static void main(String[] args)
  {
    //Creating array
    String[] fruitArray = {"orange", "banana", "apple", "plum", "peach"};
    System.out.println("The Array is: ");
    System.out.println(Arrays.toString(fruitArray)); 
    
    //ordering array and getting min and max
    String fruitArrayMin = MinMaxArray.getMinMax(fruitArray).getFirst();
    String fruitArrayMax = MinMaxArray.getMinMax(fruitArray).getSecond();
    
    //printing out values of array
    System.out.println("After Ordering: ");
    System.out.println(Arrays.toString(fruitArray)); 
       
    System.out.println("Min according to natural array order: " 
    			+ fruitArrayMin);
    System.out.println("Max according to natural array order: "  
                       + fruitArrayMax);
    
    System.out.println("--------------------------------------");
    
    //Creating array
    String[] countries = {"England", "China", "Denmark", "Cuba", "Spain",
    			  "Italy", "France", "Germany"}; 
    			
    System.out.println("The Array is: ");
    System.out.println(Arrays.toString(countries)); 
    
     //ordering array and getting min and max
    String countriesMin = MinMaxArray.getMinMax(countries).getFirst();
    String countriesMax = MinMaxArray.getMinMax(countries).getSecond();
    
    System.out.println("After Ordering: ");
    System.out.println(Arrays.toString(countries)); 
    
    //printing out values of array 
    System.out.println("Min according to natural array order: " + countriesMin);
    System.out.println("Max according to natural array order: " + countriesMax);
    
    //creating an empty array to test for exception testing
    String[] emptyArray= {};
    
    //code which should cause "empty array" exception(null)
    String emptyArrayMin = MinMaxArray.getMinMax(emptyArray).getFirst();
  }//main

}// class TestMinMaxArray

