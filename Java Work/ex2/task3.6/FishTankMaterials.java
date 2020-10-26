public class FishTankMaterials
{
  public static void main(String[] args)
  {
    int width = Integer.parseInt(args[0]);
    int depth = Integer.parseInt(args[1]);
    int height = Integer.parseInt(args[2]);
    
    int surfaceArea = 2 * ((width * depth) + (height * depth)) 
                      + (width * height);
    
    int edgesLength = (height + width + depth) * 4;
    
    System.out.println("The surface area of a tank with dimensions "
    	               + "(" + width + "," + depth + "," + height + ") "
		       + "is " + surfaceArea);
    
    System.out.println("The length of the edges of a tank with dimenstions "
                       + "(" + width + "," + depth + "," + height + ") "
		       + "is " + edgesLength);
  }
}
		       
    
