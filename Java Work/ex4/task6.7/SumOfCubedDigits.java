//This program finds the four 3 digit numbers whose 3 digits cubed is equal to
//the number itself
public class SumOfCubedDigits
{
  public static void main(String[] args)
  {
    //These nested for loops check the numbers from 100 to 900
    for (int number1 = 1; number1 <= 9; number1 ++)
      for (int number2 = 0; number2 <= 9; number2 ++)
        for (int number3 = 0; number3 <= 9; number3 ++)
        {
          //Calculates the value of the sum of the individual integers cubed.
          double numbersCubed = (Math.pow(number1, 3) + Math.pow(number2, 3)
                                + Math.pow(number3, 3));
          //Stores the 3 digit number which is formed by placing the 3
          //numbers next to each other
          double threeDigitNo = Double.parseDouble("" + number1 + number2
                                                   + number3);
          //If the numbers are equal, a 3 digit number has
          //found whose integer's cubed make the number itself                        
          if (numbersCubed == threeDigitNo)
            System.out.println(number1 + " cubed + " + number2 + " cubed + "
                               + number3 + " cubed gives " + numbersCubed);   
        }//for
  }//main
}//class SumOfCubedDigits
      
