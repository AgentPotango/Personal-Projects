import java.io.FileInputStream;
import java.io.FileNotFoundException;
import java.io.IOException;

public class Bmp2Txt
{
  private static final String SHADES_STRING = "#@*+. ";
  
  private static final char[] SHADE_CHARS = SHADES_STRING.toCharArray();
  
  private static FileInputStream inputImage;
  
  private static int inputHeight, inputWidth;
  
  private static int outputHeight, outputWidth;
  
  private static int[][] outputImage;
  
  private static int readByte() throws IOException
  {
    int result = inputImage.read();
    
    if (result == -1)
      throw new IOException("Unexpected end of file");
    return result;
  }//readByte
  
  private static void skipIrrelevantBytes(int skipCount) throws IOException
  {
    for (int count = 1; count <= skipCount; count ++)
      readByte();
  }//skipIrrelevantBytes
  
  private static int readInt() throws IOException
  {
    return readByte() | readByte() << 8 | readByte() << 16 | readByte() << 24;
  }//readInt
  
  private static int readPixelBrightness() throws IOException
  {
    int red = readByte();
    int green = readByte();
    int blue = readByte();
    return (red * 299 + green * 587 + blue * 114) / 1000;
  }//readPixelBrightness
  
  private static void readImage() throws IOException
  {
    for (int inputY = 0; inputY < inputHeight; inputY ++)
    {
      for (int inputX = 0; inputX < inputWidth; inputX ++)
      {
        int pixelValue = readPixelBrightness();
        int outputX = inputX * outputWidth / inputWidth;
        int outputY = inputY * outputHeight/ inputHeight;
        outputImage[outputX][outputY] += pixelValue;
      }//for
      skipIrrelevantBytes(inputWidth % 4);
    }//for
  }//readImage
  
  private static int maxOutputBrightness()
  {
    int maxBrightnessSoFar = 0;
    for (int y = 0; y < outputHeight; y ++)
      for (int x = 0; x < outputWidth; x ++)
        if (outputImage[x][y] > maxBrightnessSoFar)
          maxBrightnessSoFar = outputImage[x][y];
    return maxBrightnessSoFar;
  }//maxOutputBrightness
  
  private static void writeTextImage()
  {
    int maxBrightness = maxOutputBrightness();
    for (int y = outputHeight - 1; y >= 0; y --)
    {
      for (int x = 0; x < outputWidth; x ++)
        System.out.print(SHADE_CHARS[outputImage[x][y] * SHADE_CHARS.length
                                                       / (maxBrightness + 1)]);
      System.out.println();
    }//for
  }//writeTextImage
  
  public static void main(String[] args)
  {
    String filename = null;
    try
    {
      // 
      if (args.length != 3) 
        throw new ArrayIndexOutOfBoundsException();
      
      outputWidth = Integer.parseInt(args[0]);
      outputHeight = Integer.parseInt(args[1]);
      outputImage = new int[outputWidth][outputHeight];
      
      filename = args[2];
      inputImage = new FileInputStream(filename);
      
      skipIrrelevantBytes(18);
      inputWidth = readInt();
      inputHeight = readInt();
      skipIrrelevantBytes(28);
      
      if (inputImage.read() != -1)
        throw new IOException("Data after end of image");
        
      writeTextImage();
      
    }//try
    catch (ArrayIndexOutOfBoundsException exception)
    {
      System.err.println("Please (only) supply: width height filename");
    }//catch
    catch (NumberFormatException exception)
    {
      System.err.println("Supplied dimension is not a number: " 
                         + exception.getMessage());
    }//catch
    catch (FileNotFoundException exception)
    {
      System.err.println("Cannot open image file " + filename);
    }//catch
    catch (IOException exception)
    {
      System.err.println("Problem reading Image file: " 
                         + exception.getMessage());
    }//catch 
    finally
    {
      try
      {
        if (inputImage != null)
          inputImage.close();
      }//try
      catch (IOException exception) 
      {
        System.err.println("Could not close image file " + exception);
      }//catch
    }//finally
  }//main
}//Bmp2Txt

      
    
       
    
