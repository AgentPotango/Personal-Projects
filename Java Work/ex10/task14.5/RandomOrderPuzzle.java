import java.io.File;
import java.util.Scanner;

/* This program will create a puzzle game whwere the lines of a text file
   are put into an array. This array is then copied to a second array
   and the lines are rearranged in this second array.
   When the lines are equal to the original order (before they are rearranged)
   the game ends. 
 */
public class RandomOrderPuzzle
{
  //creates the array which contains the randomized lines
  private String[] randomizedOrderLines;
  
  //creates the array which contrains the original order of the lines
  private String[] lines;
  
  //main method which runs the helped classes to make the game work
  public static void main(String[] args) throws Exception
  {
    //Uses the file given as an argument
    Scanner fileScanner = new Scanner(new File(args[0]));
    RandomOrderPuzzle puzzle = new RandomOrderPuzzle(fileScanner);
    
    Scanner inputScanner = new Scanner(System.in);
    System.out.println(puzzle);
    int moveCount = 0;
    //while the puzzle is not sorted, ask the user to swap a line.
    while (! puzzle.isSorted())
    {
      System.out.print("Enter a line number to swap with the last one: ");
      puzzle.swapLine(inputScanner.nextInt());
      System.out.println(puzzle);
      moveCount++;
    }//while
    System.out.println("Game over in " + moveCount + " moves.");
  }//main
  
  /* This method stores lines of the text into an individual array element
     If the array is too small, it makes the array larger
     Once the lines are stored, the array which contains the original order
     of the lines is copied into the randomizedOrderLines array which is then
     rearranged 
   */
  public RandomOrderPuzzle(Scanner scanner)
  {
     //Initializes the array by giving it a size
      lines = new String[1];
     
      //counts the amount of lines stored
      int noOfLinesStored = 0;
     
     //Checks if the file has a next line which has some text on it.
     while (scanner.hasNextLine())
     {
       //if the number of lines stores is equal to the array length,
       //then make the array bigger by 1
       if (noOfLinesStored == lines.length)
       {
         String[] biggerArray = new String[lines.length + 1];
         for (int index = 0; index < lines.length; index++)
           biggerArray[index] = lines[index];
         lines = biggerArray;
       }//if
       
       //obtains the lines and stores in the array.
       for (int count = noOfLinesStored; count < lines.length; count++)
       {
         lines[noOfLinesStored] = scanner.nextLine();
         noOfLinesStored++;
       }//for
        
     }//while
     
     //create an array of the same size of that of the original
     randomizedOrderLines = new String[lines.length];
     
     //copy each line from the original array into the second one.
     for (int index = 0; index < lines.length; index++)
       randomizedOrderLines[index] = lines[index];
    
     //randomize the line order for the array
     randomizeStringArrayOrder(randomizedOrderLines);
     
  }//RandomOrderPuzzle
  
  //Checks if the lines in the randomizedOrderLines array are in the same
  //order as in the lines array.
  //If not, return false. Else, return true.
  public boolean isSorted()
  {
    for (int index = 0; index < randomizedOrderLines.length; index++)
      if (randomizedOrderLines[index] != lines[index])
        return false;
     
    return true;
  }//isSorted
  
  //Method used to swap the lines in an array
  public void swapLine(int number)
  {
   //copies the last line in the array to swap
   //sets the last line in the array with the text of the line to swap
   //sets the line to swap with the text of the last line in the array
   String temp_string =  randomizedOrderLines[randomizedOrderLines.length - 1];
   randomizedOrderLines[randomizedOrderLines.length- 1] 
                       = randomizedOrderLines[number];
   randomizedOrderLines[number] = temp_string;
  }//swapLine
  
  //Method to print out the puzzle
  //prints out the line number and the line and prints them on a new line each
  public String toString()
  {
    String result = "";
    for (int count = 0; count < randomizedOrderLines.length; count++)
    {
      result += String.format("%-5s %s \n", count, randomizedOrderLines[count]);
    }//for
    return result;
  }//toString
  
  //Method to randomize the order of the lines in the 
  //randomizedOrderLines array
  private void randomizeStringArrayOrder(String[] anArray)
  {
    for (int itemsRemaining = anArray.length; itemsRemaining > 0; 
         itemsRemaining--)
    {
      int anIndex = (int) (Math.random() * itemsRemaining);
      String itemAtAnIndex = anArray[anIndex];
      anArray[anIndex] = anArray[anArray.length - 1];
      anArray[anArray.length - 1] = itemAtAnIndex;
    }//for
  }//randomizeStringArrayOrder

}//class RandomOrderPuzzle
    
