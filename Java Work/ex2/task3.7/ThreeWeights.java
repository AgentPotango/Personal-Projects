public class ThreeWeights
{
  public static void main(String[] args)
  {
    int Weight1 = Integer.parseInt(args[0]);
    int Weight2 = Integer.parseInt(args[1]);
    int Weight3 = Integer.parseInt(args[2]);
    
    System.out.println(- Weight1 - Weight2 - Weight3);
    System.out.println(- Weight1 - Weight2);
    System.out.println(- Weight1 - Weight2 + Weight3);
    System.out.println(- Weight1 - Weight3);
    System.out.println(- Weight1);
    System.out.println(- Weight1 + Weight3);
    System.out.println(- Weight1 + Weight2 - Weight3);
    System.out.println(- Weight1 + Weight2);
    System.out.println(- Weight1 + Weight2 + Weight3);
    System.out.println(- Weight2 - Weight3);
    System.out.println(- Weight2);
    System.out.println(- Weight2 + Weight3);
    System.out.println(- Weight3);
    System.out.println("0");
    System.out.println(Weight3);
    System.out.println(Weight2 - Weight3);
    System.out.println(Weight2);
    System.out.println(Weight2 + Weight3);
    System.out.println(Weight1 - Weight2 - Weight3);
    System.out.println(Weight1 - Weight2);
    System.out.println(Weight1 - Weight2 + Weight3);
    System.out.println(Weight1 - Weight3);
    System.out.println(Weight1);
    System.out.println(Weight1 + Weight3);
    System.out.println(Weight1 + Weight2 - Weight3);
    System.out.println(Weight1 + Weight2);
    System.out.println(Weight1 + Weight2 + Weight3);
  }
}
