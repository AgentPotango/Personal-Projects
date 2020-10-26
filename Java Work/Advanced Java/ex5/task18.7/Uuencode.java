import java.io.FileInputStream;
import java.io.IOException;

public class Uuencode
{
 
  //writes a single result byte as a printable character.
  //Each Byte is 6-bit i.e. range 0...63
  //Therefore, adding 32 makes it printable, except for 0 which would become
  //a space. So we need to add 96 instead -- a left single quote (').
  private static void writeByteAsChar(int thisByte)
  {
    System.out.print((char)(thisByte == 0 ? 96 : thisByte + 32));
  }//writeByteAsChar
  
  public static void main(String[] args)
  {
    FileInputStream inputFile = null; 
    String filename = null;
    try
    {
      //checks if only yhe input file is given
      if (args.length != 1)
        throw new ArrayIndexOutOfBoundsException("Only enter the input file");
      
      //creates an array of size 45
      int[] lineBytes = new int[45];
      //stores the file name
      filename = args[0];
      //used to hold the bytes from the FileInputStream
      inputFile = new FileInputStream(filename);
      //prints the header
      System.out.println("begin 600 " + filename);
     
      //reads the first byte and stores it
      int currentByte = inputFile.read();
      //while the byte is not at the end of the file
      while (currentByte != -1)
      {
        //set bytes in Array to 0
        int bytesInArray = 0;
        //while the byte is not at the end of the file and bytesInArray is
        //less than the array length then store the current bytes
        // and read another one until bytesInArray  is = to array length
        while(currentByte != -1 
              && bytesInArray < lineBytes.length)
        {
          lineBytes[bytesInArray] = currentByte;
          currentByte = inputFile.read();
          bytesInArray ++;
        }//while
        //writes the bytes in the array as the first character
        writeByteAsChar(bytesInArray);
        
      
        //Calculate the 4 resulting bytes from the 3 input bytes
        for (int byteGroupIndex = 0; byteGroupIndex < bytesInArray; 
             byteGroupIndex +=3)
        {
          int byte1 = lineBytes[byteGroupIndex] >> 2;
          int byte2 = (lineBytes[byteGroupIndex] & 0x3) << 4
                       | (lineBytes[byteGroupIndex + 1] >> 4);
          int byte3 =  (lineBytes[byteGroupIndex + 1] & 0xf) << 2
  	      	        | lineBytes[byteGroupIndex + 2] >> 6;
          int byte4 = lineBytes[byteGroupIndex + 2] & 0x3f;
          // Now write those result bytes.
          writeByteAsChar(byte1);
          writeByteAsChar(byte2);
          writeByteAsChar(byte3);
          writeByteAsChar(byte4);
          //loop
          
        }
        System.out.println();
      }//while
      //prints the end of the file
      System.out.println("`");
      System.out.println("end");
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
        if (inputFile != null) 
          inputFile.close(); 
      }//try
      catch (IOException exception)
      {
        System.err.println("Could not close input "  + exception);
      }//catch
    }//finally
  }//main
}//Uuencode  

    
    
      
    
   
    

