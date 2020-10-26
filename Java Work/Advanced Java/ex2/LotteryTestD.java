//This program creates 2 games and 2 magic workers which each load up their
//own game with magic balls. When you click on a magic worker, their 
//respective game's balls will change state and update their image

public class LotteryTestD
{
  public static void main(String args[])
  {
    //speed controller for GUI
    SpeedController speedController
      = new SpeedController(SpeedController.HALF_SPEED);
    
    //Creating a new GUI
    LotteryGUI gui = new LotteryGUI("TV Studio", speedController);
    
    //creating a new MagicWorker and adding it to the GUI
    MagicWorker worker1 = new MagicWorker("Jordan");
    gui.addPerson(worker1);
    
    //creating another new MagicWorker and addit it to the GUI
    MagicWorker worker2 = new MagicWorker("Bob");
    gui.addPerson(worker2);
    
    //creates the first game
    Game game1 = new Game("Lott O'Luck Larry", 20,
                          "Slippery's Mile", 5);
    //adds the game to the GUI                 
    gui.addGame(game1);
    
    //creates the second game
    Game game2 = new Game("Second Time Lucky", 14,
                          "Oooz OK Lose", 3);
    
    //adds the second game to the GUI
    gui.addGame(game2);
    
    //worker1 fills the machine   
    worker1.fillMachine(game1);
     
     //loop which ejects the same amount of balls as the size of the 
    //rack size for game 1
    for (int count = 1; count <= game1.getRackSize(); count ++)
    {
      game1.ejectBall();
    }//for
    
    //worker 2 fills the machine
    worker2.fillMachine(game2);
    
    //loop which ejects the same amount of balls as the size of the 
    //rack size for game 2
    for (int count = 1; count <= game2.getRackSize(); count ++)
    {
      game2.ejectBall();
    }//for
    
  }//main
 
}//LotteryTestD
        
