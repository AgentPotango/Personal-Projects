public class MaxTwoDoubles
{
  public static void main(String[] args)
  {
    double inputNumber1 = Double.parseDouble(args[0]);
    double inputNumber2 = Double.parseDouble(args[1]);
    
    if (inputNumber1 > inputNumber2)
      System.out.println(inputNumber1 + " is greater than " + inputNumber2);
    else
     System.out.println(inputNumber2 + " is greater than " + inputNumber1);
  }
}
 
