//This program generates a truthtable
public class TruthTable34
{
  //sets up the first boolean
  private static boolean p1(boolean a, boolean b, boolean c, boolean d)
  {
    return (((a || b) && c) || ((b || c) && d)) && (a || d);
  }
   
   //sets up the second boolean
  private static boolean p2(boolean a, boolean b, boolean c, boolean d)
  {
    return a && c || b && d || c && d;
  }
  
  //sets up the third boolean
  private static boolean p3(boolean a, boolean b, boolean c, boolean d)
  {
    return (b || c) && (c || d) && (a || d);
  }
  
  //crprints a straight line used for the heading of the table
  private static void printStraightLine()
  {
    System.out.println(" _________________________________________________"
                       + "_____");
  }
  
  //prints the Column headings
  private static void printHeadings()
  {
    System.out.println("|   a   |   b   |   c   |   d   |  p1   |  p2   |"
                       + "   p3  |");
  }
  
  //prints the bottom of the column headings and the bottom of the table
  private static void printColumnLines()
  {
    System.out.println("|_______|_______|_______|_______|_______|_______|"
                       + "_______|");
  }
  
  //prints out the word "true" or "false" depending on the boolean input
  private static String formatRowItem(boolean rowItem)
  {
    return rowItem ? " true  " : " false ";
  }
  
  //adds true or false for each boolean depending on the answer to the 
  //returned answer from the method formatRowItem method
  private static void printRow(boolean a, boolean b, boolean c, boolean d)
  {
    System.out.println("|" + formatRowItem(a) + "|" + formatRowItem(b)
                       + "|" + formatRowItem(c) + "|" + formatRowItem(d)
                       + "|" + formatRowItem(p1(a,b,c,d)) 
                       + "|" + formatRowItem(p2(a,b,c,d))
                       + "|" + formatRowItem(p3(a,b,c,d)) + "|");
  }
  
  //creates the table
  public static void main(String[] args)
  {
    
    //generates the column headings and the top of the table
    printStraightLine();
    printHeadings();
    printColumnLines();
    
    //initially sets the booleans to true
    boolean a = true, b = true, c = true, d = true;
    
    //generates the rows of the table by performing booleans. At the 
    // end of a for loop, a boolean changes from true to false and does a
    // max of two loops
    for (int aCount = 1; aCount <= 2; aCount ++, a = !a)
      for (int bCount = 1; bCount <= 2; bCount ++, b = !b)
        for (int cCount = 1; cCount <= 2; cCount ++, c = !c)
          for (int dCount = 1; dCount <= 2; dCount ++, d = !d)
            printRow(a,b,c,d);
    
    //prints the bottom of the table
    printColumnLines();
  }

}
            
    
    
  
