import java.util.Scanner;
/* This program analyses the interger marks entered by the user.
   It outputs each mark, the mean of the marks, the minimum mark, and
   the maximum mark. The mark entered must be greater than than 0.
   It also sorts the marks into ascending order
  */
public class MarkAnalysis
{
  public static void main(String[] args)
  {
    //Scanner used to enter the mark
    Scanner marksScanner = new Scanner(System.in);
    
    System.out.print("Enter the number of Marks: ");
    int numberOfMarks = marksScanner.nextInt();
    
    //marks are ints which are stored in an array.
    int[] marks = new int [numberOfMarks];
   
    //obtain the marks from the input
    for (int index = 0; index < numberOfMarks; index++)
    {
      System.out.print("Enter mark # " + (index + 1) + ": ");
      int validMark = marksScanner.nextInt();
      
      //check if the mark is greater than 0
      //if not, display error and exit.
      if (validMark <= 0)
      {
        System.out.println("Please enter a mark greater than one");
        System.exit(0);
      }//if
      else
        marks[index] = validMark;
      
    }//for
    
    //calculate the sum, minimum and maximum mark
    int sumOfMarks = 0;
    
    
    for (int index = 0; index < numberOfMarks; index++)
      sumOfMarks += marks[index];
    
    int minimumMark = min(numberOfMarks, marks);
    int maximumMark = max(numberOfMarks, marks);
    //Sort the marks
    sort(marks);
    
    //calculate the mean which is a double
    double meanMark= sumOfMarks / (double) numberOfMarks;
    
    //print the mark results out
    System.out.println();
    System.out.println("The mean Mark is:\t" + meanMark);
    System.out.println("The minimum Mark is:\t" + minimumMark);
    System.out.println("The maximum Mark is:\t" + maximumMark);
    System.out.println();
    
    //Header for table
    System.out.println("Person | Score | Difference from Mean");
    
    //calcualte the difference from the mean for each mark
    //print out the results in a table format
    for (int index = 0; index < numberOfMarks; index++)
    {
      double differenceFromMean = marks[index] - meanMark;
      System.out.printf("%6s | %5s | %6.2f%n", (index + 1), marks[index],
                        differenceFromMean);
    }//for
  }//main
  
  //sort the array of ints into ascending order.
  private static void sort(int[] anArray)
  {
    //Each pass of the sort resduces the unsorted length by one.
    int unsortedLength = anArray.length;
    boolean changedOnThisPass;
    do
    {
      changedOnThisPass = false;
      for (int pairLeftIndex = 0; pairLeftIndex < unsortedLength - 1;
           pairLeftIndex++)
        if (anArray[pairLeftIndex] > anArray[pairLeftIndex + 1])
        {
          int originalPairLeftIndex = anArray[pairLeftIndex];
          anArray[pairLeftIndex] = anArray[pairLeftIndex + 1];
          anArray[pairLeftIndex + 1] = originalPairLeftIndex;
          changedOnThisPass = true;
        }//iff
      unsortedLength--;
    }while (changedOnThisPass);
  }//sort
  
  //returns the maximum Mark
  private static int max(int numberOfMarks, int[] anArray)
  {
    int maxMark = anArray[0];
    for (int index = 0; index < numberOfMarks; index++)
    {
     if (anArray[index] > maxMark)
       maxMark = anArray[index];
    }//for
    return maxMark;
  }//max
    
  //returns the minimum Mark   
  private static int min(int numberOfMarks, int[] anArray)
  {
    int minMark = anArray[0];
    for (int index = 0; index < numberOfMarks; index++)
    {
      if (anArray[index] < minMark)
        minMark = anArray[index];
    }//for
    return minMark;
  }//min
}//class MarkAnalysis
    
    
    
