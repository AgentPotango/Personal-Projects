//This program calculates the GCD of four commandline arguments (the ages)
//Using the GCD, it calculates the correct proportions of cake each age
//should get and then prints the number of slices the cake must be divided 
//into and the number of slices for each age
public class DivideCake4
{
  //This method is used to calculate the greatest common devisor of two
  //numbers which are supplied to it as arguments
  private static int greatestCommonDevisor(int multiple1OfGCD, 
                                           int multiple2OfGCD)
  {
    //This computes the GCD of multipleOf1GCD and multipleOf2GCD
    //While mulitple1OfGCD is not equal to  multiple2OfGCD
    //the difference between them is a multiple of the GCD
    while (multiple1OfGCD != multiple2OfGCD)
      if (multiple1OfGCD > multiple2OfGCD)
        multiple1OfGCD -= multiple2OfGCD;
      else
        multiple2OfGCD -= multiple1OfGCD;

    return multiple1OfGCD;
  }//greatestCommonDevisor                                       
                                         
  //The main method which uses the greatestCommonDevisor method to produce
  //results on how many slices of cake each age should get                                         
  public static void main(String[] args)
  {
    //All four ages must be positive
    //declares the first age as cmdline argument 0
    int age1 = Integer.parseInt(args[0]);
    //declares the second age as cmdline argument 1
    int age2 = Integer.parseInt(args[1]);
    //declares the third age as cmdline argument 2
    int age3 = Integer.parseInt(args[2]);
    //declares the fourth age as cmdline argument 3
    int age4 = Integer.parseInt(args[3]);
    
    //Calculates the GCD of the first two ages supplied (age and age2) 
    int twoAgesGCD = greatestCommonDevisor(age1,age2);
    
    //Calculates the GCD of the three ages by using twoAgesGCD 
    //(age1 and age2,age3)
    int threeAgesGCD = greatestCommonDevisor(twoAgesGCD, age3);
    
    //Calculates the GCD of all four ages by using threeAgesGCD
    //(age1 and age2 and age3, age4) 
    int allAgesGCD = greatestCommonDevisor(threeAgesGCD, age4);
        
    //This prints the GCD of all 3 ages as they are now all equal 
    System.out.println("The GCD of " + age1 + " and " + age2 + " and "
                      + age3 + " and " + age4 + " is " + allAgesGCD);
    
    //Calculates the number of portions for each age
    int noOfPortions1 = age1 / allAgesGCD;
    int noOfPortions2 = age2 / allAgesGCD;
    int noOfPortions3 = age3 / allAgesGCD;
    int noOfPortions4 = age4 / allAgesGCD;
    
    //prints how many portions the cake needs to be divived into
    System.out.println("So the cake should be divided into " 
                      + (noOfPortions1 + noOfPortions2 + noOfPortions3
                      + noOfPortions4));
                      
    //prints how many portions out of the total portions each age gets
    System.out.println("So the " + age1 + " year old gets " + noOfPortions1
                      + ", the " + age2 + " year old gets " + noOfPortions2
		      + ", the " + age3 + " year old gets " + noOfPortions3
		      + " and the " + age4 + " year old gets " 
		      + noOfPortions4);
  }//main
  
}//class DivideCake4
    
    
