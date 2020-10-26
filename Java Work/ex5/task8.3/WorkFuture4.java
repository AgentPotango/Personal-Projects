//This program prints out how many years of work left 4 people have.
//A personNumber is assigned to create a referrence to each individual 
//person.
public class WorkFuture4
{
  //Method used to calculate how many years a person has left to work
  //personNumber identifies the person
  //Birthyear must be less than the present year
  private static void printWorkYearsLeft(int personNumber, int birthYear,
                                         int presentYear)
  {
    //Person's Retirement Year
    int retireYear = birthYear + 68; 
  
    //Prints how many years left a person has to work
    System.out.println("Person " + personNumber + " has " 
                       + (retireYear - presentYear) + " year(s) left to work");
    
    //The next Year
    int someYear = presentYear + 1; 
    
    // Loop that continually prints a messages of the current year and
    // years left to work.
    while (someYear != retireYear)
    {   
      //Years of Work Remaining
      int yearsRemaining = retireYear - someYear;         
      //Prints message of the present year and the years left from retirement
      //from that year.
      System.out.println("In " + someYear + " Person " + personNumber 
                         + " will have " + yearsRemaining 
                         + " years left to work");
      //Moves present year 1 year further
      someYear ++;
    }//while
    //Prints out the person's retire year
    System.out.println("Person " + personNumber + " will retire in " 
                       + retireYear);
  }//printWorkYearsLeft

 
  //The main method gets arguments and calls printWorkYearsleft
  public static void main(String[] args)
  {
    //The current Year
    int presentYear = Integer.parseInt(args[0]);
    
    //The four command line arguments obtaining birth years for 4 people
    //which must be less that than the present year
    int birthYear1 = Integer.parseInt(args[1]);
    int birthYear2 = Integer.parseInt(args[2]);
    int birthYear3 = Integer.parseInt(args[3]);
    int birthYear4 = Integer.parseInt(args[4]);
    
    //Prints how many years of Work each person has left to do
    printWorkYearsLeft(1, birthYear1, presentYear);
    printWorkYearsLeft(2, birthYear2, presentYear);
    printWorkYearsLeft(3, birthYear3, presentYear);
    printWorkYearsLeft(4, birthYear4, presentYear);                 
    
   
  }//main
  
}//class WorkFuture4     
