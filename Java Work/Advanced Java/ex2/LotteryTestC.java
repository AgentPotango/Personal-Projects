import java.awt.Color;

//Program which creates a game full of magic balls which change state
//when you click on the balls
public class LotteryTestC
{
  public static void main(String args[])
  {
    //adds a speedcontroller
    SpeedController speedController
      = new SpeedController(SpeedController.HALF_SPEED);

    //creates the gui
    LotteryGUI gui = new LotteryGUI("TV Studio", speedController);
    
    //adds a worker
    Worker worker1 = new Worker("Bob");
    
    //holds the amount of balls to be added to the game
    int noOfBalls = 15;
    
    //holds the ball Colour
    Color ballColour;
    
    //creates a new group of colours
    Color [] colourGroupColours
      = new Color [] {Color.red, Color.orange, Color.yellow,
                      Color.green, Color.blue, Color.pink,
                      Color.magenta};
    
        
    //creates a new game
    Game game1 = new Game("Lott O'Luck Larry", noOfBalls,
                          "Slippery's Mile", 4);
    
    //adds the game to the gui         
    gui.addGame(game1);
   
    //creates an array to hold the magic balls
    MagicBall [] ball = new MagicBall[noOfBalls];
    
    //Array to add the magic balls giving them all a colour from the 
    //colour group
    for (int count = 1; count <= noOfBalls; count ++)
    {
      int colourGroup = (int) ((count - 1.0) / (double) noOfBalls
                               * (double) colourGroupColours.length);
      ballColour = colourGroupColours[colourGroup];
      ball[count - 1] = new MagicBall(count, ballColour);
      game1.machineAddBall(ball[count -1]);
    }//fill machine
      
    //loop which ejects the same amount of balls as the size of the 
    //rack size. Adds a delay before each eject
    for (int count = 1; count <= game1.getRackSize(); count ++)
    {
      speedController.delay(50);
      game1.ejectBall();
    }//for
    
  }//main
      
}//LotteryTestC
