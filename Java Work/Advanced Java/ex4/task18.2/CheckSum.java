import java.io.InputStream;
import java.io.IOException;

//This program reads all the bytes from the standard input and 
//displays the amount of bytes to the standard output

public class CheckSum
{
  public static void main (String[] args)
  {
    InputStream inputData = null;
    int checkSum = 0;
    try
    {
      inputData = System.in;
      int currentByte;
      while ((currentByte = inputData.read()) != -1)
      {
        //If the number is even, half it. If odd, half it and add 32768
        if (checkSum % 2 == 0)
          checkSum /= 2;
        else
        {
          checkSum /= 2;
          checkSum += 32768;
        }
        checkSum += currentByte;
        //if the check sum is greater than 16 bits, reduce back to 16 bits
        //by reducing it by 65536
        if (checkSum >= 65536)
          checkSum -= 65536;
      }//while
      System.out.println(checkSum);
    }//try
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
        if (inputData != null) 
          inputData.close(); 
      }//try
      catch (IOException exception)
      {
        System.err.println("Could not close input "  + exception);
      }//catch
    }//finally
  }//main
}//CheckSum
