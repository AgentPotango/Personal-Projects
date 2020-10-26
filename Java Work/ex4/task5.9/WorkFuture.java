//This program will display each year left till retirement year
//The first argument is used to set the present year
//The second argument is used to set the birth year
public class WorkFuture
{
  public static void main(String[] args)
  {
    //The current Year
    int presentYear = Integer.parseInt(args[0]);
    
    //Person's birth Year
    int birthYear = Integer.parseInt(args[1]);
    
    //Person's Retirement Year
    int retireYear = birthYear + 68; 
            
    //Prints how many years left a person has to work
    System.out.println("You have " + (retireYear - presentYear) + " year(s)"
                       + " left to work");
    
    //The next Year
    int someYear = presentYear + 1;                 
    
    // Loop that continually prints a messages of the current years and
    // years left to work.
    while (someYear != retireYear)
    {   
      //Years of Work Remaining
      int yearsRemaining = retireYear - someYear;         
      //Prints message of the present year and the years left from retirement
      //from that year.
      System.out.println("In " + someYear + " you will have "
                         + yearsRemaining + " years left to work");
      //Moves present year 1 year further
      someYear ++;
    }//while
  }//main
}//class WorkFuture
    
   
