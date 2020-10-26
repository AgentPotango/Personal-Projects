/* Class which creates Rectangle objects and is used to calculate the
   perimeter and area of the rectangle as well as the new shifted rectangle.
   Method also converts the rectangle corner coordinates to string
*/
public class Rectangle
{
  
  //points for two corners of the rectangle
  private Point corner, oppositeCorner;
  
  //Method used to create new rectangle corner points
  public Rectangle(Point edge1, Point edge2)
  {
    corner = edge1;
    oppositeCorner = edge2;
  }//Rectangle
  
  //Method used to calculate the perimeter of the rectangle
  public double perimeter()
  {
    //Third corner point created to find the distance between the 3 points
    Point corner1 = new Point(corner.getX(),oppositeCorner.getY());
   
    //Calculates the 1st side length by finding the distance between 
    //the third point and the 1st point
    double sideLength1 = corner1.distanceBetweenPoints(corner);
    
    //Calculates the 2nd side length by finding the distance between
    //the third point and the 2nd point
    double sideLength2 = corner1.distanceBetweenPoints(oppositeCorner);
    
    return 2 * sideLength1 + 2 * sideLength2;
  }//perimeter
  
  //Method used to generate the newly shifted rectangle corner points
  public Rectangle shift(double xShift, double yShift)
  {
    Point newCorner1 = corner.shift(xShift,yShift);
    Point newCorner2 = oppositeCorner.shift(xShift,yShift);
    
    return new Rectangle(newCorner1,newCorner2);
  }//shift
  
  //Method used to calculate the rectangle area
  public double area()
  {
    //Third corner point created to find the distance between the 3 points
    Point corner1 = new Point(corner.getX(),oppositeCorner.getY());
   
    //calculates the slide lengths
    double sideLength1 = corner1.distanceBetweenPoints(corner);
    double sideLength2 = corner1.distanceBetweenPoints(oppositeCorner);
    
    return sideLength1 * sideLength2;
  }//area
  
  //Method used to convert Rectangle points into string format  
  public String toString()
  {
    return "Rectangle (" + corner + "," + oppositeCorner + ")";
  }//toString
}//Class Rectangle
