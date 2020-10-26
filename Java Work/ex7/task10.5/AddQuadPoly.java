/*This program will take two polynomials and add them together by
making instances of the class type: "QuadPoly" and then prints the two
polynomials and the resulting polynomial when they are added together */
public class AddQuadPoly
{
  public static void main(String[] args)
  {
    //First polynomial stored as a referrence
    QuadPoly polynomial1 = new QuadPoly(Double.parseDouble(args[0]),
                                        Double.parseDouble(args[1]),
                                        Double.parseDouble(args[2]));
                                        
    //2nd polynomial stored as a referrence                                    
    QuadPoly polynomial2 = new QuadPoly(Double.parseDouble(args[3]),
                                        Double.parseDouble(args[4]),
                                        Double.parseDouble(args[5]));
    //the resulting polynomial when polynomials 1 and 2 are added together
    //is stored as a referrence using the addedTo instance method    
    QuadPoly result = polynomial1.addedTo(polynomial2);
    
    //Prints polynomial 1
    System.out.println("Polynomial:     " + polynomial1);
    //Prints polynmial 2
    System.out.println("Added to:       " + polynomial2);
    //Prints the result                   
    System.out.println("Results in:     " + result);
  }
}
          
     
