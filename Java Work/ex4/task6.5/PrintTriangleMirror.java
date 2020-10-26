//Prints a mirrored 90 degree isosceles triangle with its longest row
// at the top and the triangle on the right hand side
public class PrintTriangleMirror
{
  public static void main(String[] args)
  {
   //Specifies what the height of the triangle is (must be possitive integer)
   int height = Integer.parseInt(args[0]);
   //Print out height number of rows whilst row is greater than 0
   for (int row = height; row > 0; row --)
   {
     //print out (height - row) amount of spaces
     for(int space = 0; space < (height - row); space ++)
       System.out.print("   ");
     //print out row amount of cells   
     for (int column = 1; column <= row; column ++)
       System.out.print("[_]");
     //end the line
     System.out.println();
   }//for
  }//main
}//class PrintTriangleMirror
