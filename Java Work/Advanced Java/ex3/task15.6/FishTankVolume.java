//Program which throws customized exception messages when a user
//inputs something incorrecty

public class FishTankVolume
{
  public static void main(String[] args)
  {
    
    try
    {
      //produces an error if 3 arguments are not given
      if (args.length != 3)
      {
        throw new ArrayIndexOutOfBoundsException
                 ("You have supplied " + args.length + " arguments instead "
                  + "of three!");
      }
      
      int width = Integer.parseInt(args[0]);
      int depth = Integer.parseInt(args[1]);
      int height = Integer.parseInt(args[2]);
      
      //produces an error if atleast one of the values is negative 
      if (width < 0 || depth < 0 || height < 0)
      {
        throw new NumberFormatException("One or more of your values" 
                                         + " are negative!");
      }
                   
      int volume = width * depth * height;
      System.out.println("The volume of a tank with dimensions "
                         + "(" + width + "," + depth + "," + height + ") "
                         + "is " + volume);
  
   }//try
   
   //catches the ArrayIndexOutOfBoundsException and prints an error message
   catch (ArrayIndexOutOfBoundsException exception)
   {
     System.out.println("Please supply the width, height and depth and " 
                        + "nothing else");
     System.out.println("Exception message was: '" + exception.getMessage() 
                        + "'");
     System.err.println(exception);
   }//catch
   //catches the NumberFormatException and prints an error message
   catch (NumberFormatException exception)
   {
     System.out.println("The width, height and depth must all be non-negative " 
                        + "whole numbers");
     System.out.println("Exception message was: '" + exception.getMessage() 
                        + "'");
     System.err.println(exception);
   }//catch
   //catches any other exception and prints an error message
   catch (Exception exception)
   {
     System.out.println("Something unforseen has happened!");
     System.out.println("Exception message was: '" + exception.getMessage() 
                        + "'");
     System.err.println(exception);
   }//catch
                   
     
  }//main
  
 
  
}//FishTankVolume


    
