/* Class which creates triangle objects and is used to calculate the
   perimeter and area of the triangle as well as the new shifted triangle.
   Method also converts the triangle coordinates to string
*/
public class Triangle
{
  //Coordinate points for the 3 corners of the triangle
  private Point corner1, corner2, corner3;
  
  //Method used to create Triangle coordinate points for each corner
  public Triangle(Point pointA, Point pointB, Point pointC)
  {
    corner1 = pointA;
    corner2 = pointB;
    corner3 = pointC;
  }//Triangle
  
  //Method used to calculate the perimeter of the triangle
  public double perimeter()
  {
    //Calculates the lengths of the 3 sides
    double sideLength1 = corner1.distanceBetweenPoints(corner2);
    double sideLength2 = corner1.distanceBetweenPoints(corner3);
    double sideLength3 = corner2.distanceBetweenPoints(corner3);
    //Calculates the perimeter
    double perimeter =  (sideLength1 + sideLength2 + sideLength3);
  
    return perimeter;
  }//perimeter
  
  //Method to generate the newly shifted Triangle corner points
  public Triangle shift(double xShift, double yShift)
  {
    //Shifts all 3 points
    Point newPointA = corner1.shift(xShift,yShift);
    Point newPointB = corner2.shift(xShift,yShift);
    Point newPointC = corner3.shift(xShift,yShift);
    
    return new Triangle(newPointA,newPointB,newPointC);
  }//shift
  
  //Method to calculate the area of the Triangle 
  public double area()
  { 
    //Calculates the semi-Perimeter
    double semiPerimeter = perimeter()/2;
    
    //Calculates the length of the 3 sides
    double sideLength1 = corner1.distanceBetweenPoints(corner2);
    double sideLength2 = corner1.distanceBetweenPoints(corner3);
    double sideLength3 = corner2.distanceBetweenPoints(corner3);
    
    return Math.abs(Math.sqrt(semiPerimeter * (semiPerimeter - sideLength1)
                              * (semiPerimeter - sideLength2)
                              * (semiPerimeter - sideLength3)));
  }//area
     
  //Method to convert all the triangle points to strings
  public String toString()
  {
    return "Triangle (" + corner1 + "," + corner2 + "," + corner3 + ")";
  }//toString
}//Class Triangle
  
   
 
