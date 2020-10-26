//Prints out a common factor table starting from 2 to 20
//If their greatest commong factor is greater than 1, it will display
// --# else it will display --|
public class CommonFactorsTable
{
  public static void main(String[] args)
  {
    //print out first part of top line
    System.out.print("|-----|");
    //generates 3 dashes above each column and a single -| at the end.
    for (int column = 2; column <= 20; column ++)
      //3 characters for each column
      System.out.print("---");
    //the right hand side  
    System.out.println("-|");
    
    //column headings
    System.out.print("|     |");
    for (int column = 2; column <= 20; column ++)
      //column headings need to only take up at max 3 spaces
      if (column < 10)
        System.out.print("  " + column);
      else
        System.out.print(" " + column);
    System.out.println(" |");

    //Underline of column headings :- Same as Top Line
    System.out.print("|-----|");
    for (int column = 2; column <= 20; column ++)
      System.out.print("---");
    System.out.println("-|");
    
    //Prints out the rows for the table
    for (int row = 2; row <= 20; row ++)
    {
      //row numbers need to occupy at max 5 spaces
      if (row < 10)
        System.out.print("|   " + row + " |");
      else
        System.out.print("|  " + row + " |");
      //calculating the largest GCD for each row and column pair
      for (int column = 2; column <= 20; column ++)
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
    // adding the bottom line:- Same as Top Line
    System.out.print("|-----|");

    for (int column = 2; column <= 20; column ++)
      System.out.print("---");
    System.out.println("-|");
  }//main
}//class CommonFactorsTable
