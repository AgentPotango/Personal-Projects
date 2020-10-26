public class PassFailDistinction
{
  public static void main(String[] args)
  {
    double totalGraduateMark = Double.parseDouble(args[0]);
    
    if (totalGraduateMark >= 50)
      System.out.println("Pass");
    else
      System.out.println("Fail");
    
    if (totalGraduateMark >= 70)
      System.out.println("Distinction");
  }
}
