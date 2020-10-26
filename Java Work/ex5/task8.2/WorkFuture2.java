//This program will display each year left till retirement year
//for two people. 
//The first argument is used to set the present year
//The second argument is used to set person 1's birth year
//The third argument is used to set person 2's birth year
public class WorkFuture2
{
  public static void main(String[] args)
  {
    //The current Year
    int presentYear = Integer.parseInt(args[0]);
    
    //Person 1's birth Year
    int birthYear1 = Integer.parseInt(args[1]);

    //Person 2's birth Year
    int birthYear2 = Integer.parseInt(args[2]);
    
    //Person 1's Retirement Year
    int retireYear1 = birthYear1 + 68; 

    //Person 2's Retirement Year 
    int retireYear2 = birthYear2 + 68;
                
    //Prints how many years left person 1 has to work
    System.out.println("Person 1 has " + (retireYear1 - presentYear)
                       + " year(s) left to work");
                       
      
    
    //The next Year referring to person 1
    int ageInSomeYear1 = presentYear + 1;                 
    
    // Loop that continually prints a messages of the current years and
    // years left to work for person 1
    while (ageInSomeYear1 != retireYear1)
    {   
      //Years of Work Remaining
      int yearsRemaining = retireYear1 - ageInSomeYear1;         
      //Prints message of the present year and the years left from retirement
      //from that year.
      System.out.println("In " + ageInSomeYear1 + " Person 1 will have "
                         + yearsRemaining + " years left to work");
      //Moves present year 1 year further
      ageInSomeYear1 ++;
    }//while
    
    
    
        
    //Prints how many years left person 2 has to work
    System.out.println("Person 2 has " + (retireYear2 - presentYear)
                       + " year(s) left to work");
    
    //The next year referring to person 2
    int ageInSomeYear2 = presentYear + 1;
    
    // Loop that continually prints a messages of the current years and
    // years left to work for person 2
    while (ageInSomeYear2 != retireYear2)
    {   
      //Years of Work Remaining
      int yearsRemaining = retireYear2 - ageInSomeYear2;         
      //Prints message of the present year and the years left from retirement
      //from that year.
      System.out.println("In " + ageInSomeYear2+ " Person 2 will have "
                         + yearsRemaining + " years left to work");
      //Moves present year 1 year further
      ageInSomeYear2 ++;
    }//while       
  }//main
  
}//class WorkFuture2
    
   

