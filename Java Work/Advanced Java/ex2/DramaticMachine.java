//This program creates a machine where all the balls 
//flash until the one to get ejected is chosen.

public class DramaticMachine extends Machine
{
  //Constructur for a DramaticMachine
  public DramaticMachine(String machineName, int machineSize)
  {
    super(machineName, machineSize);
  }//DramaticMachine
  
  //returns the name of the Machine
  public String getType()
  {
    return "Dramatic Machine";
  }//getType
    
  //makes all balls, before reaching the ball to be ejected, flash.
  //Then ejects the chosen ball.
  public Ball ejectBall()
  {
    
    if (getNoOfBalls() <= 0)
      return null;
    else
    {
      //Math.random() * getNoOfBalls yields a number
      //which is >= 0 and < number of Balls
      int ejectedBallIndex = (int) (Math.random() * getNoOfBalls());
      
      
      //Loop which makes each ball before the ejectedBallIndex Ball flash
      for (int count  = 0; count < ejectedBallIndex; count++)
      {
        Ball startingBalls = getBall(count);
        startingBalls.flash(4,5);
      }//for
      
      //ejects the ejected Ball and makes it flash
      Ball ejectedBall = getBall(ejectedBallIndex);
      ejectedBall.flash(4,5);
      
      //swaps the current ejectedBall position with the last ball's position
      //and then removes the last ball.
      swapBalls(ejectedBallIndex, getNoOfBalls() - 1);
      removeBall();
      
      return ejectedBall;
    }
  }//ejectBall
}//DramaticMachine  
  
      
