import java.io.BufferedReader;
import java.io.File;
import java.io.FileReader;
import java.io.FileWriter;
import java.io.IOException;
import java.io.PrintWriter;
import java.util.ArrayList;
import java.util.List;
import java.util.Collections;

//Program which sortrs the lines of a file placing the odd numbers first in
//ascending order and then follows it with even numbers in descending order.

public class StreetOrder
{
  public static void main(String[] args)
  {
    BufferedReader input = null;
    PrintWriter output = null;
    try
    {
      if (args.length != 2 )
        throw new IllegalArgumentException("there must be exactly 2 arguments");
      
      if (!new File(args[0]).exists())
      	throw new Exception( args[0] + " Does Not Exist!");
          	
      input = new BufferedReader(new FileReader(args[0]));
      output = new PrintWriter(new FileWriter(args[1]));
      
      List<DeliveryHouseDetails> lineList = 
                                 new ArrayList<DeliveryHouseDetails>();
      
      int lineNumber = 1;
      String currentLine;
      while((currentLine = input.readLine()) != null)
      {
        //adds a DeliveryHouseDetail object to the list
        lineList.add(new DeliveryHouseDetails(lineNumber, currentLine));
	lineNumber ++;
      }
      
      //Sorts the lineList
      Collections.sort(lineList);
      
      //outputs the list
      for (int index = 0; index < lineList.size(); index ++)
        output.println(lineList.get(index).getPersonDetails());
        
    }//try
    catch (Exception exception)
    {
      System.err.println(exception);
    }//catch
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
  
}//class Reverse
