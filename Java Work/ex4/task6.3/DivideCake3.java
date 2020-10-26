//This program calculates the GCD of three commandline arguments (the ages)
//Using the GCD, it calculates the correct proportions of cake each age
//should get and then prints the number of slices the cake must be divided 
//into and the number of slices for each age
public class DivideCake3
{
  public static void main(String[] args)
  {
    //All three ages must be positive
    //declares the first age as cmdline argument 0
    int age1 = Integer.parseInt(args[0]);
    //declares the second age as cmdline argument 1
    int age2 = Integer.parseInt(args[1]);
    //deckares the third ages as cmdline argument 2
    int age3 = Integer.parseInt(args[2]);
    
    //This is a multiple of the GCD, initially age1
    int multiple1OfGCD = age1;
    //This is a multiple of the GCD, initially age2
    int multiple2OfGCD = age2;
    //This is a multiple of the GCD, initially age3
    int multiple3OfGCD = age3;
   
   
    //This computes the GCD of multipleOf1GCD and multipleOf2GCD
    //While mulitple1OfGCD is not equal to  multiple2OfGCD
    //the difference between them is a multiple of the GCD
    while (multiple1OfGCD != multiple2OfGCD)
      if (multiple1OfGCD > multiple2OfGCD)
        multiple1OfGCD -= multiple2OfGCD;
      else
        multiple2OfGCD -= multiple1OfGCD;
	
    //This computes the GCD of multipleOf1GCD and multipleOf3GCD
    //While mulitple1OfGCD is not equal to  multiple3OfGCD
    //the difference between them is a multiple of the GCD 
    while(multiple1OfGCD != multiple3OfGCD)
      if (multiple1OfGCD > multiple3OfGCD)
        multiple1OfGCD -= multiple3OfGCD;
      else
        multiple3OfGCD -= multiple1OfGCD;
    
    //This changes the multiple2OfGCD to the new GCD which is equal for all
    // 3 of the ages (multiple1OfGCD)
    multiple2OfGCD = multiple1OfGCD;
       
    //This prints the GCD of all 3 ages as they are now all equal 
    System.out.println("The GCD of " + age1 + " and " + age2 + " and "
                      + age3 + " is " + multiple1OfGCD);
    
    //Calculates the number of portions for each age
    int noOfPortions1 = age1 / multiple1OfGCD;
    int noOfPortions2 = age2 / multiple2OfGCD;
    int noOfPortions3 = age3 / multiple3OfGCD;
    
    //prints how many portions the cake needs to be divived into
    System.out.println("So the cake should be divided into " 
                      + (noOfPortions1 + noOfPortions2 + noOfPortions3));
    //prints how many portions out of the total portions each age gets
    System.out.println("So the " + age1 + " year old gets " + noOfPortions1
                      + ", the " + age2 + " year old gets " + noOfPortions2
		      + " and the " + age3 + " year old gets " 
		      + noOfPortions3);
  }//main
}//class DivideCake3
    
    



