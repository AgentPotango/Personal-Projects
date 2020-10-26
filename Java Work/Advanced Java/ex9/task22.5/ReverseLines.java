import java.io.BufferedReader;
import java.io.InputStreamReader;
import java.io.PrintWriter;
import java.io.IOException;

/* Program reads all the lines from the standard input and ouputs them 
   in reverse order by using a recursive function.
*/ 
 
public class ReverseLines
{
  public static void main(String[] args) throws Exception
  {
    //setting up the input and outputs
    BufferedReader inputLines = null;
    PrintWriter outputLines = null;
    
    inputLines = new BufferedReader(new InputStreamReader(System.in));
    outputLines = new PrintWriter(System.out, true);
    
    //calling the recursive function and passing the BufferedReader and 
    //PrintWriter as arguments
    reverseOrder(inputLines, outputLines);
 
  }//main
  
  public static void reverseOrder(BufferedReader input, PrintWriter output)
                     throws Exception
  {
    //Stores the first line
    String headLine = input.readLine();
    
    //If the headLine is not the final line, execute the code
    if (headLine != null)
    {
      //recursively call the method and read the next line until you get to
      //the final line where (after reading the next line) the headline is null
      //then executes ouput.println(headLine) through all the other methods
      reverseOrder(input, output);
      output.println(headLine);
    }
  } 
}//ReverseLines
