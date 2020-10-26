public class YearsBeforeRetirement
{
  public static void main(String[] args)
  {
    int myCurrentAge = Integer.parseInt(args[0]);
    int myRetirementAge = 68;
    int yearsLeftWorking = myRetirementAge - myCurrentAge; 
    System.out.println("My age now is " + myCurrentAge);
    System.out.println("I will retire at the age of " + myRetirementAge);
    System.out.println("Years left working is " + yearsLeftWorking);
  }
}
