//Prints out a common factor table starting from 2 to 20
//If their greatest commong factor is greater than 1, it will display
// --# else it will display --|
public class CommonFactorsTable
{
  //The size of the table: The numbers of rows and Columns
  private static int tableSize = 20;
  
  //This method prints the Top Line for the table
  private static void printLine()
  {
    //print out first part of top line
    System.out.print("|-----|");
    //generates 3 dashes above each column and a single -| at the end.
    for (int column = 2; column <= tableSize; column ++)
      //3 characters for each column
      System.out.print("---");
    //Prints the right hand side  
    System.out.println("-|");
  }//printLine
  
  //This method prints the Column Headings for the program 
  private static void printColumnHeadings()
  {
    //prints the left hand side of the table
    System.out.print("|     |");
    //generates the numbers for the column headings
    for (int column = 2; column <= tableSize; column ++)
      //uses method printNumbers to print the Column Numbers
      printNumbers(column);
    //Prints the right hand side
    System.out.println(" |");
  }//printColumnHeadings
  
  //This method prints numbers with a maximum width of 3 characters   
  private static void printNumbers(int number)
  {
    //formats the number supplied to add leading spaces so it occupies
    //a width of 3 characters
    System.out.printf("%3d",number);
  }//printNumbers
  
  //The main method which makes use of all the private methods
  public static void main(String[] args)
  {
    
    //Prints the Top Line for the table
    printLine();
    
    //Prints the Column Headings for the table
    printColumnHeadings();
    
    //Prints the Bottom Line for the table
    printLine();
    
    //Prints out the rows for the table
    for (int row = 2; row <= tableSize; row ++)
    {
      //prints out the row numbers and the left and right hand side of the
      //numbers
      System.out.print("| ");
      printNumbers(row);
      System.out.print(" |");
      //calculating the largest GCD for each row and column pair
      for (int column = 2; column <= tableSize; column ++)
      {
        //GCD for row and colum are initially row and column respectively.
        int rowGCD = row;
        int columnGCD = column;
        //loop to find out the GCD of the row and column pair
        while (rowGCD != columnGCD)
          if (rowGCD > columnGCD)
            rowGCD -= columnGCD;
          else
            columnGCD -= rowGCD;
        //if GCD > 1 then prints a --# else it prints --|
        if (rowGCD > 1)
          System.out.print("--#");
        else
          System.out.print("--|");
      }//for
      //adding the right hand end of the table
      System.out.println(" |");
    }//for
    //Prints out the Bottom Line for the table
    printLine();
  }//main
  
}//CommonFactorsTable    
      
