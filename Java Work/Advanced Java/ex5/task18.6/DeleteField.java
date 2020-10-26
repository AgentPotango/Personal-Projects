import java.io.BufferedReader;
import java.io.File;
import java.io.FileReader;
import java.io.FileWriter;
import java.io.InputStreamReader;
import java.io.PrintWriter;
import java.io.IOException;

//Porgram reads each line from either the standard input or a file
//and prints it out on the standard output or in a file
//if a file name is missing, or is "-", then the standardinput/output is used 
public class DeleteField
{
  public static void main(String[] args) 
  {
    BufferedReader input = null;
    PrintWriter output = null;
         
    try
    {
      //checks if there are too many arguments
      if (args.length > 3)
        throw new ArrayIndexOutOfBoundsException("Too many Arguments");
      
      //used to delcare which field to delete
      int fieldToDelete = Integer.parseInt(args[0]);
      
      //if there is less than 2 arguments or argument 1 is a dash
      //it reads the atandard input. Else, it reads a file
      if (args.length < 2 || args[1].equals("-"))
        input = new BufferedReader(new InputStreamReader(System.in));
      else
        input = new BufferedReader(new FileReader(args[1]));
      
      //if there is less than 3 arguments or argument 2 is a dash
      //it prints to the atandard output. Else, it prints to a file
      if (args.length < 3 || args[2].equals("-"))
        output = new PrintWriter(System.out, true);
      else
      {
        if (new File(args[2]).exists())
          throw new DeleteFieldException("Output File " + args[2] + " already exists");
        
        output = new PrintWriter(new FileWriter(args[2]));
      }//else
      
      //if a negative or 0 argument is entered, then it throws an exception
      if (fieldToDelete <= 0)
        throw new NumberFormatException
                  ("The field to delete " + fieldToDelete + " must be greater"
                   + "than zero");
                   
      String inputLine;
      //copies the input to the output specified
      while ((inputLine = input.readLine()) != null)
      {
        //Divides the lines into fields using tab as a delimeter.
        String[] fields = inputLine.split("\t");
        String editedLine = "";
        if (fields.length < fieldToDelete) 
        { 
          editedLine = inputLine;
        }
        else
        {
          //We build the new line in parts
          //Add the fields before the one to be deleted.
          for (int index = 0; index < fieldToDelete -1; index ++)
            if (editedLine.equals(""))
              editedLine = fields[index];
            else
              editedLine += "\t" + fields[index];  
            //Add the fields after the one to be deleted
          for (int index = fieldToDelete; index < fields.length; index ++)
            if (editedLine.equals(""))
              editedLine = fields[index];
            else
              editedLine += "\t" + fields[index];
         }//else
      
        output.println(editedLine);
        
      }//while
    }//try
    catch (ArrayIndexOutOfBoundsException exception) 
    {
       //too many arguments exception
       System.out.println("You have entered " + args.length + " arguments!");
       System.out.println("Exception message was: '" 
                          + exception.getMessage() + "'");
       System.err.println(exception);
    }//catch
    catch (NumberFormatException exception) 
    {
       //Number must be greater than 0 exception
       System.out.println("The field to delete must be greater than 0!");
       System.out.println("Exception message was: '" 
                          + exception.getMessage() + "'");
       System.err.println(exception);
    }//catch
    catch (DeleteFieldException exception)
    {
      //The file already exists exception
      System.out.println("The file you want to output to already exists!");
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
}//DeleteField
