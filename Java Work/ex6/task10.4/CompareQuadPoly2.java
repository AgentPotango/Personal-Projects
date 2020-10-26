/*This program will take two polynomials and add them together by
making instances of the class type: "QuadPoly".
It will then print a message saying that the two polynomials entered
are either equal to each other or if the first is less than the other.*/
public class CompareQuadPoly
{
  //prints the polynomial                                    
  private static void printPolynomial(QuadPoly polynomial1)   
  {
    System.out.println("The Polynomial:     " + polynomial1.toString());
  }
  
  public static void main(String[] args)
  {
    //The first Quadpoly (referrence is stored)
    QuadPoly polynomial1 = new QuadPoly(Double.parseDouble(args[0]),
                                        Double.parseDouble(args[1]),
                                        Double.parseDouble(args[2]));
                                        
    //2nd Quadpoly (referrence is stored)                                  
    QuadPoly polynomial2 = new QuadPoly(Double.parseDouble(args[3]),
                                        Double.parseDouble(args[4]),
                                        Double.parseDouble(args[5]));
                                        
    //if the first polynomial is less than the 2nd then print
    //polynomial 1 is less than polynomial 2  
    
    printPolynomial(polynomial1);
    if (polynomial1.lessThan(polynomial2))
    {
      System.out.println("Is Less than :      " + polynomial2.toString());
    }
    
    //if the 2nd polynomials is less than the 1st then print
    //polynomial 1 is greater than polynomial 2   
    else if (polynomial2.lessThan(polynomial1))
    {
      System.out.println("Is Greater than :   " + polynomial2.toString());
    } 
    
    //if the two polynomials  then print that the two polynomials are equal
    else if (polynomial1.equals(polynomial2))
    {
      System.out.println("Is Equal to :       " + polynomial2.toString());
    }
         
  }
}
          
     
