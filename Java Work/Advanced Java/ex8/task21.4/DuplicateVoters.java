import java.io.BufferedReader;
import java.io.FileReader;
import java.io.PrintWriter;
import java.io.FileWriter;
import java.io.IOException;
import java.util.HashSet;
import java.util.Set;

//Program which creates a HashSet of Strings and checks if a duplicate line
//from the input is detected. If it is, it reports it in the output file

public class DuplicateVoters
{
  public static void main(String[] args)
  {
  
    BufferedReader input = null;
    PrintWriter output = null;
    
    try
    {
      //checks if there are too many arguments
      if (args.length > 2)
        throw new ArrayIndexOutOfBoundsException("Too many Arguments");
      
      //Reads the data from the the file supplied from the first argument
      input = new BufferedReader(new FileReader(args[0]));
      
      //Prints the data to a new file which stores the duplicate voters
      output = new PrintWriter(new FileWriter(args[1]));
      
      //Creates a new hashset of strings
      Set<String> voterIdentity = new HashSet<String>();
      
      //counts the number of duplicates
      int duplicateCount = 0;
      
      //counts the number of lines
      int lineNumber = 0;
      
      //Stores the current line 
      String inputLine;
      //Checks every even numbered line to see if there are duplicates
      //and if there are, it prints out in the output file which people
      //made duplicate votes
      while ((inputLine = input.readLine()) != null)
      {
        //checks even numbered lines and checks if the hashset already
        //contains an identical value for the value input
        if (lineNumber % 2 == 0)
        {
          if (voterIdentity.add(inputLine) == false)
          {
            duplicateCount++;
            output.println(inputLine);
          }//If
        }//if
        lineNumber++;       
      }//while
      if (duplicateCount == 0)
        output.println("No Duplicates Found");
      else
        output.println("There were " + duplicateCount + " duplicate votes");
    }//try  
    catch (ArrayIndexOutOfBoundsException exception) 
    {
      //too many arguments exception
      System.out.println("You have entered " + args.length + " arguments!");
      System.out.println("Exception message was: '" 
                         + exception.getMessage() + "'");
      System.err.println(exception);
    }//catch
     catch (IOException exception)
    {
      //other exceptions go to the standard output
      System.err.println("Something has gone wrong! " + exception.getMessage());
    }//catch
    //closes the input. If it does not work, it reports that it can't and
    //the exception causing it not to close the input
    finally
    {
      try 
      { 
        if (input != null) 
          input.close(); 
      }//try
      catch (IOException exception)
      {
        System.err.println("Could not close input "  + exception);
      }//catch
      
      if (output != null) 
      {
        output.close(); 
        if (output.checkError())
          System.err.println("Something went wrong with the output");
      }//if
    }//finally
  }//main
}//DuplicateVoters
 
