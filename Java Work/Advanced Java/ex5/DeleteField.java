import java.io.BufferedReader;
import java.io.InputStreamReader;
import java.io.IOException;

//reads each line from the input and copies the line to the output
//with out the field to delete
public class DeleteField
{
 
  public static void main(String[] args) 
  {
     BufferedReader input = 
         new BufferedReader(new InputStreamReader(System.in));
    try
    {
      int fieldToDelete = Integer.parseInt(args[0]);
      
      //Only 1 argument must be entered
      if (args.length != 1)
        throw new ArrayIndexOutOfBoundsException
                 ("Your have supplied " + args.length + " arguments");
      
      //The argument must be non-negative
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
      
        System.out.print(editedLine);
        
      }//while
    }//try
    catch (ArrayIndexOutOfBoundsException exception ) 
    {
       System.out.println("Please supply the field to delete"
                          + " (1 argument) only");
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
    }//finally
  }//main
}//DeleteField
