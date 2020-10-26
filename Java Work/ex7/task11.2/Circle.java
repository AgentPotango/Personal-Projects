/* Class which creates Circle objects and is used to calculate the
   perimeter and area of the circle as well as the new shifted circle
   Method also converts the circle corner coordinates to string
*/
public class Circle
{
  
  //Creates a new point for the centre of the circle
  private Point centre;
  
  //The radius value which (is not changed)
  private double radius;
  
  //Method used to generate a Circle which has a centre and a radius
  public Circle(Point centreCoordinates, double radiusValue)
  {
    centre = centreCoordinates;
    radius = radiusValue;
  }//Circle
  
  //Method used to calculate the perimeter of a Circle
  public double perimeter()
  {
    return 2 * Math.PI * radius;
  }//perimeter
  
  //Method used to calculate the new shifted centre point for the circle
  public Circle shift(double xShift, double yShift)
  {
    Point newCentre = centre.shift(xShift, yShift);
    return new Circle(newCentre, radius);
  }//shift
  
  //Method used to calculate the area of the circle
  public double area()
  {
   return Math.PI * Math.pow(radius,2);
  }//area
    
  //Method used to conver the Circle's centre coordinates and the radius
  //into string format
  public String toString()
  {
    return "Circle (" + centre + "," + radius + ")";
  }//toString
}//Class Circle
