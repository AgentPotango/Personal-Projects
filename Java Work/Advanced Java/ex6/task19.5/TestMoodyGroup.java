//creates moodypeople and changes their happiness

public class TestMoodyGroup
{
  public static void main(String[] args)
  {
    //group of teenagers
    MoodyGroup<Teenager> moodyChat = new MoodyGroup<Teenager>();
    
    Teenager teenager = new Teenager("Teen 2");
    moodyChat.addMoodyPerson(new Teenager("Teen 1"));
    moodyChat.addMoodyPerson(teenager);
    moodyChat.addMoodyPerson(new Teenager("Teen 3"));
    
    //sets all of moodychat happyness to false and prints out
    for (int count = 1; count <= moodyChat.getSize(); count ++)
    {
      moodyChat.setHappy(false);
    }//for
    System.out.printf("%s%n%n", moodyChat);
    
    //sets all of moodychat happyness to true and prints out
    for (int count = 1; count <= moodyChat.getSize(); count ++)
    {
      moodyChat.setHappy(true);
    }//for
    System.out.printf("%s%n%n", moodyChat);
   
    //group of moody people
    MoodyGroup<MoodyPerson> anyChat = new MoodyGroup<MoodyPerson>();
    
    anyChat.addMoodyPerson(new Worker("Worker 1"));
    anyChat.addMoodyPerson(teenager);
    
    //sets all of anychat happyness to true and prints out
    for (int count = 1; count <= anyChat.getSize(); count ++)
    {
      anyChat.setHappy(true);
    }//for
     System.out.printf("%s%n%n", anyChat);
    
    //sets all of anychat happyness to false and prints out
    for (int count = 1; count <= anyChat.getSize(); count ++)
    {
      anyChat.setHappy(false);
    }//for
    System.out.printf("%s%n%n", anyChat);
    
    //prints out moodychat one more time
    System.out.printf("%s%n%n", moodyChat);
    
  }//main
  
}//TestMoodyGroup  

    
    
    
    
    
    
    
