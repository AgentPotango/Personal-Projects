public class FieldPerimeter
{
  public static void main(String[] args)
  {
    int fenceLength = Integer.parseInt(args[0]);
    int fenceWidth = Integer.parseInt(args[1]);
    int totalFenceLength = fenceLength + fenceLength + fenceWidth + fenceWidth;
    System.out.println("Fence Length is " + fenceLength);
    System.out.println("Fence Width is " + fenceWidth);
    System.out.println("Total Fence Length needed to enclose field: "
                          + totalFenceLength);
  }
}   
    
