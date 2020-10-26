import java.io.BufferedReader;
import java.io.File;
import java.io.FileReader;
import java.io.FileWriter;
import java.io.IOException;
import java.io.PrintWriter;
import java.util.ArrayList;
import java.util.List;

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
      
      List<String> lineList = new ArrayList<String>();
      
      String currentLine;
      //adds the currentline to the line list
      while((currentLine = input.readLine()) != null)
        lineList.add(currentLine);
      
      int listSize;
      //checks if the linelist size is odd or even
       if (lineList.size() % 2 == 0)
         listSize = lineList.size() - 1;
       else
         listSize = lineList.size() - 2;
      
      //outputs the odd numbered lines first in ascending order
      for (int index = 0; index < lineList.size(); index += 2)
        output.println(lineList.get(index));
      
      //outputs the even numbered lines after the odd lines in descending order
      for (int index = listSize; index >= 0; index -= 2)
        output.println(lineList.get(index));
           
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
