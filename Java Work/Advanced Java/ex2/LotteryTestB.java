//This program creates a dramatic game and a dramatic machine which
//makes all the balls before the ejected ball flash

public class LotteryTestB
{
  public static void main(String args[])
  {
    //Adds a speed controller
    SpeedController speedController
      = new SpeedController(SpeedController.HALF_SPEED);

    //creates a GUI
    LotteryGUI gui = new LotteryGUI("TV Studio", speedController);
    
    //Creates a Worker but does not add it to the GUI
    Worker worker1 = new Worker("Bob");
    
    //Creates a Dramatic Game
    DramaticGame game1 = new DramaticGame("THE DRAMA!!!", 30,
                                          "Wow.. does that rack have 6...?", 6);
    //adds the dramatic game to the GUI
    gui.addGame(game1);
    
    //The worker fills the machine with balls
    worker1.fillMachine(game1);
    
    //makes the game delay before ejecting a ball if there
    //is enough rack space left.
    for (int count = 1; count <= game1.getRackSize(); count ++)
    {
      speedController.delay(50);
      game1.ejectBall();
    }//for
    
  }//main
}//LotteryTestB
    
