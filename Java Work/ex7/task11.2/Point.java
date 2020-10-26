/* Class which creates point objects and is used to calculate distances
   between points and also shifts point.
*/
public class Point
{
  //Variables used to give points x-coordinate and y-coordinate
  private double x, y;
  
  //Method used to create a point object
  public Point(double xValue, double yValue)
  {
    x = xValue;
    y = yValue;
  }//Point
  
  //Method used to calculate the distance between two points
  public double distanceBetweenPoints(Point otherPoint)
  {
    double newX = otherPoint.x - x;
    double newY = otherPoint.y - y;
    
    //formula to calculate the distance
    return Math.sqrt(Math.pow(newX,2) + Math.pow(newY,2));
  }//distanceBetweenPoints
  
  //method used to shift all points by xShift and yShift
  public Point shift(double xShift, double yShift)
  {
    double xShifted = x + xShift;
    double yShifted = y + yShift;
    
    //creates a new point which has been shifted by xShift and yShift
    return new Point(xShifted,yShifted);
  }//shift
  
  //Method that allows other classes to use the x value
  public double getX()
  {
    return x;
  }//getX
  
  //Method that allows other classes to use the y VALUSE
  public double getY()
  {
    return y;
  }//getY
  
  //method used to convert point into a string format
  public String toString()
  {
    return "(" + x + "," + y + ")";
  }//toString
}//Class Point
