public class SinTable
{
  public static void main(String[] args)
  {
    int startDegree = Integer.parseInt(args[0]);
    int increase = Integer.parseInt(args[1]);
    int endDegree = Integer.parseInt(args[2]);

    System.out.println("--------------------------------------");
    System.out.println("Sin table from " + startDegree + " to " + endDegree
                       + " in steps of " + increase);
    System.out.println("--------------------------------------");
    
    for (int number = startDegree; number <= endDegree; number += increase)
      System.out.println("| sin(" + number + ") = " 
                         + Math.sin(Math.toRadians(number)));
    
    System.out.println("--------------------------------------");
  }
}

