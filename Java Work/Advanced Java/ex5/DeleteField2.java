import java.io.BufferedReader;
import java.io.FileReader;
import java.io.FileWriter;
import java.io.PrintWriter;
import java.io.IOException;

//reads each line from the input and copies the line to the output
//with out the field to delete
public class DeleteField2
{
 
  public static void main(String[] args) 
  {
     BufferedReader input = null;
     PrintWriter output = null;
         
    try
    {
      if (args.length != 3)
        throw new ArrayIndexOutOfBoundsException
        ("There must be exactly three arguments: fieldToDelete infile outfile");
      
      
      int fieldToDelete = Integer.parseInt(args[0]);
      input = new BufferedReader(new FileReader(args[1]));
      output = new PrintWriter(new FileWriter(args[2]));
     
      
      if (fieldToDelete <= 0)
        throw new NumberFormatException
                  ("The field to delete " + fieldToDelete + " must be greater"
                   + "than zero");
                   
      String inputLine;
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
       System.out.println("Please supply the field to delete, infile"
                          + "and outfile (3 arguments) only");
       System.out.println("Exception message was: '" 
                          + exception.getMessage() + "'");
       System.err.println(exception);
    }
    catch (NumberFormatException exception) 
    {
       System.out.println("The field to delete must be greater than 0!");
       System.out.println("Exception message was: '" 
                          + exception.getMessage() + "'");
       System.err.println(exception);
    }
    catch (IOException exception)
    {
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
