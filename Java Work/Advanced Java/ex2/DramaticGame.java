//This program creates a game where the balls flash until
//it reaches the ball to be ejected and ejects that ball.
public class DramaticGame extends Game
{
  //constructur for  Dramatic Game
  public DramaticGame(String machineName, int machineSize,
              String rackName, int rackSize)
  {
    super(machineName, machineSize, rackName, rackSize);
  }//DramaticGame
  
  //creates a DramaticMachine
  public Machine makeMachine(String machineName, int machineSize)
  {
    return new DramaticMachine(machineName, machineSize);
  }//makeMachine
  
      
}//DramaticGame
  
    
