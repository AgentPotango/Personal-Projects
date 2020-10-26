//This program creates a calendar where you can modify the starting date
// and ending date. You can also enter a date to highlight
public class CalendarHighlight
{ 
  //This method generates the top line of hyphens of the table which are as
  // wide as the table but start and end the table with a space
  private static void printMonthLineOfHyphens()
  {
    System.out.print(" -");
    for (int dayColumnNo = 1; dayColumnNo <= 7; dayColumnNo ++)
    {
      if (dayColumnNo > 1)
        System.out.print("--");
      printDateHyphens();
    }
    System.out.println(" "); 
  }//printMonthLineOfHyphens
  
  //This method prints hyphens as wide as the date
  private static void printDateHypens()
  {
    System.out.print("---");
  }//printDayHyphens
  
  //this method prints the day name of a given day No
  private static void printDayName(int dayNo)
  {
    //the days are numbered from 1 to 7 starting with sunday
    switch (dayNo)
    {
      case 1: System.out.print("Su"); break;
      case 2: System.out.print("Mo"); break;
      case 3: System.out.print("Tu"); break;
      case 4: System.out.print("We"); break;
      case 5: System.out.print("Th"); break;
      case 6: System.out.print("Fr"); break;
      case 7: System.out.print("Sa"); break;
    }//switch
  }//printDayName
  
  //Prints the Day Names as column Headings. 
  private static void printDayNames()
  {
    System.out.print("| ");
    for (int dayColumnNo = 1; dayColumnNo <= 7; dayColumnNo ++)
    {
      if (dayColumnNo > 1)
        System.out.print("   ");
      printDayName(dayColumnNo);
    }//for
    System.out.println(" |");      
  }//printDayNames
  
  //prints spaces as wide as the date
  private static void printDateSpace()
  {
    System.out.print("   ");
  }
  
  //prints hyphens as wide as the date
  private static void printDateHyphens()
  {
    System.out.print("---");
  }
  
  //formats the date so they take up two characters and uses a leading zero
  //if another character is needed.
  private static void printDate(int date)
  {
    System.out.printf("%02d", date);
  }
  
  //Prints a calendar for a Month
  private static void printMonth(int firstDayOfMonth, int lastDayOfMonth,
                                 int dateToHighlight)
  {
    //keeps track of which is the next day, from 1-7, which
    //needs to be printed out
    int nextDayColumnToUse = firstDayOfMonth;
    
    //keeps track of the next date needed to print
    int nextDateToPrint = 1;
    
    //prints top line of the calendar
    printMonthLineOfHyphens();
    
    //prints the column headings (day names)
    printDayNames();
    
    
    //initallizes the number of Rows currently printed as 0
    int noOfRows = 0;
    
    //prints out a minimum of 6 rows and highlights the date specified
    while (nextDateToPrint <= lastDayOfMonth || noOfRows < 6)
    {
      //prints out one two
      System.out.print("|");
     
      for (int dayColumnNo = 1; dayColumnNo <= 7; dayColumnNo ++)
      { 
        /*prints 2 spaces between the date columns if the next date to
          print is not the date that that is needed to highlight
          else if the day column is currently set to 1, and the next date to
          be printed does not need to be highlighted then in prints a single
          space */
        if (dayColumnNo > 1 && nextDateToPrint != dateToHighlight)           
          System.out.print("  ");
        else if (dayColumnNo == 1 && nextDateToPrint != dateToHighlight)
          System.out.print(" ");
        
        //prints either a space, the date or the date and the highlight markers                      
        if (dayColumnNo != nextDayColumnToUse
            || nextDateToPrint > lastDayOfMonth)
         printDateSpace();
        else if (nextDateToPrint == dateToHighlight)
        {
         //if the next date to print neeeds to be highlighted and the day
         //column number is 1, then it prints a single arrow.
         //otherwise it prints a space and then a single arrow
         if (dayColumnNo == 1)
           System.out.print(">");
         else
           System.out.print(" >");
         printDate(nextDateToPrint);
         System.out.print("<");          
         nextDayColumnToUse ++;
         nextDateToPrint ++;
        }
        else
        {
          printDate(nextDateToPrint);
          System.out.print(" ");
          nextDayColumnToUse ++;
          nextDateToPrint ++;
        }//else
      }//for
      
      //ends the row
      System.out.println("|");
      noOfRows ++;
      
      //gets ready for the next row
      nextDayColumnToUse = 1;
    }//while
    
    //prints the bottom of the table
    printMonthLineOfHyphens();

  }//printMonth
  
  //uses 3 command line arguments to print the calendar.
  public static void main(String[] args)
  {
    printMonth(Integer.parseInt(args[0]), Integer.parseInt(args[1]),
               Integer.parseInt(args[2]));
  }
    
}
