import java.io.InputStreamReader;
import java.io.IOException;

// Program which counts the number of words on the standard input
// and reports it on the standard output

public class WordCount
{
  public static void main (String[] args)
  {
    
    // Not allowed to used an array list so used an array size of an
    // arbitrary amount (large enough for most inputs)
    // which just happens to be the same size as the amount
    // of character values (2^16)
    // Inital values will be zero
    int[] currentCharacter = new int[65536];
     
    //Reads the input
    InputStreamReader input = new InputStreamReader(System.in);
    
    //The total number of words found so far
    int allWordsCount = 0;
    
    try
    {
      int index = 1;
     
     //loops until it reaches the end of the file
      while ((currentCharacter[index] = input.read()) != -1)
      {
        //if the current character isn't a space and either its
        //the beginning of the file or the previous character
        //was a space, then it increments the word count
        if (!Character.isWhitespace(currentCharacter[index]) 
            && (allWordsCount == 0 
            || Character.isWhitespace(currentCharacter[index - 1])))
            
           allWordsCount ++;
       
       index ++;
      }//while
    }//try
    catch (IOException exception)
    {
      System.err.println(exception);
    }//catch
    finally
    {
      try
      {
        input.close();
      }//try
      catch (IOException exception)
      {
        System.err.println("Could not close input " + exception);
      }//catch
    }//finally
    
    //returns the result
    System.out.println("The number of words read was " 
                       + allWordsCount);
  }//main
}//WordCount
    

    
