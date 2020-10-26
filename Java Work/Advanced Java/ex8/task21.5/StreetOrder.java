import java.io.BufferedReader;
import java.io.File;
import java.io.FileReader;
import java.io.FileWriter;
import java.io.IOException;
import java.io.PrintWriter;
import java.util.Iterator;
import java.util.TreeSet;

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
      
      //Creates a Treest of type DeliveryHouseDetails
      TreeSet<DeliveryHouseDetails> lineSet =
      				    new TreeSet<DeliveryHouseDetails>();
      
      int lineNumber = 1;
      String currentLine;
      while((currentLine = input.readLine()) != null)
      {
        //adds a DeliveryHouseDetail object to the list
        lineSet.add(new DeliveryHouseDetails(lineNumber, currentLine));
	lineNumber ++;
      }
      //Outputs the personDetails of the TreeSet Items in natural ordering
      Iterator<DeliveryHouseDetails> iterator = lineSet.iterator();
      while(iterator.hasNext())
        output.println(iterator.next().getPersonDetails());
     
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
