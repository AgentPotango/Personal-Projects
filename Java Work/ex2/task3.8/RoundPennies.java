public class RoundPennies
{
  public static void main(String[] args)
  {
    int noOfPennis = Integer.parseInt(args[0]);
    int nearestPound = (noOfPennis + 50)/100;
    System.out.println("Nearest pound is: " + nearestPound);
  }
}
