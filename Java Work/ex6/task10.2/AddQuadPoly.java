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
    //is stored as a referrence                                       
    QuadPoly result = new QuadPoly(polynomial1.xSquared + polynomial2.xSquared,
                                   polynomial1.xSingle + polynomial2.xSingle,
                                   polynomial1.constant + polynomial2.constant);
    //Prints polynomial 1
    System.out.println("Polynomial:     " + polynomial1.xSquared + "x^2 + " + 
                       polynomial1.xSingle + "x + " + polynomial1.constant);
    //Prints polynmial 2
    System.out.println("Added to:       " + polynomial2.xSquared + "x^2 + " + 
                       polynomial2.xSingle + "x + " + polynomial2.constant);
    //Prints the result                    
    System.out.println("Results in:     " + result.xSquared + "x^2 + " + 
                       result.xSingle + "x + " + result.constant);
  }
}
          
     
