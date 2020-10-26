//representation of a quadratic polynomial
public class QuadPoly
{ 
  //coefficients of x^2, x and the constant
  public double xSquared, xSingle, constant;
  
  //Constructs a polynomial given the 3 coefficients
  public QuadPoly(double coefficient1, double coefficient2, 
                  double coefficient3)
  {
    xSquared = coefficient1;
    xSingle = coefficient2;
    constant = coefficient3;
  }//QuadPoly
  
  //Compares the first quadpoly with another and returns true if they
  //are equal
  public boolean equals(QuadPoly other)
  {
    return xSquared == other.xSquared && xSingle == other.xSingle
           && constant == other.constant;
  }//equals
  
  //Compares the first quadpoly with the other and returns true if the first
  //quadpoly is less than the other
  public boolean lessThan(QuadPoly other)
  {
    return xSquared < other.xSquared || xSquared == other.xSquared 
           && (xSingle < other.xSingle || xSingle == other.xSingle
              && constant < other.constant);
  }//lessThan
  
  //Returns the 3 coefficients in the form of a polynomial
  public String toString()
  {
    return xSquared + "x^2 + " + xSingle + "x + " + constant;
  }//toString
         
}//QuadPoly
  
  
  
