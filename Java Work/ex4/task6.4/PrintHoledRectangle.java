//Program will create a rectangle with an odd x odd size
//Rectangle will have a hole in its centre

public class PrintHoledRectangle
{
  public static void main(String[] args)
  {
    //Makes sure width and height are odd numbers, if not, it adds 1
    int width = Integer.parseInt(args[0]) /2 * 2 + 1;
    int height = Integer.parseInt(args[1]) /2 * 2 + 1;
    
    //The tile number where there is a whole in the rectangle
    int sequenceNumber = (width * height) / 2 + 1;
    //the current tile number
    int currentSequence = 0;
     
     //Print out height number of rows   
    for (int row = 1; row <= height; row ++)
    {
      //print out width number of columns
      for (int column = 1; column <= width; column ++)
      { 
        //increment currentSequence
        currentSequence ++;
	//if the program is not on the tile where there is supposed to be 
	// a hole print a tile otherwise print a hole ( 3 spaces )
	if (currentSequence != sequenceNumber)
	  System.out.print("[_]");
	else
	 System.out.print("   ");
        
      }//for
      //End the line
      System.out.println();
    }//for
  }//main
}//class PrintHoledRectangle
    
