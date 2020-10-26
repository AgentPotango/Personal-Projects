//Program will find the Max Number from a list of Numbers
//It will display that number and its index
//If there are two numbers which are max, the one with the lowest index
// will be displayed.
public class MaxList
{
  public static void main(String[] args)
  {
    //assuming that the 1st number is the maximum number
    double maxNumber = Double.parseDouble(args[0]);
    
    //setting the list index to 0
    int maxIndex = 0;
    
    //Declaring the comparison number as a double
    double compareNumber = 0.0;
    
    
    //Loop to find the max number by comparing the next numbers
    //in the list and updating both maxIndex and MaxNumber
    for (int index = 1; index < args.length; index++)
    {  
      //This is the comparison number (the next one)
      compareNumber = Double.parseDouble(args[index]);
       
      //if statement to update maxNumber and maxIndex if the statement
      // is true     
      if (compareNumber > maxNumber)
      {
        maxNumber = compareNumber;
	maxIndex = index;
      }//if
    }//for
    
    //print out the max number and its index
    System.out.println("Max number from list is " + maxNumber + " with"
                       + " index " + maxIndex);
  }//main
}//class MaxList	       
       
       
   
    
