import java.awt.Color;

//Class used to construct a Magic Ball which inherits Ball.
//it can change into 4 states and updates its image.
public class MagicBall extends Ball
{
  
  //used to stored the Magic Ball image 
  private BallImage image;
  
  //used to store the original ball value
  private int originalGetValue;
  
  //used to store the value of the magic ball which is displayed
  private int displayValue;
  
  //used to store the currentState
  private int currentState;
  
  //used to define the states of the ball
  private int ordinaryBall = 1;
  private int invisibleBall = 2;
  private int flashingBall = 3;
  private int countingBall = 4;
  
  //used to construct a MagicBall
  public MagicBall(int requiredValue, Color requiredColour)
  {
    //sends the variables to the super class to make the class
    super(requiredValue, requiredColour);
    
    //sets the value to the requiredValue
    displayValue = requiredValue;
    
    //initialises the current state as the ordinaryBall
    currentState = ordinaryBall;
    
    //creates the image for the magic ball
    image = makeImage();
  }//MagicBall
  
  //creates an image for the magic ball
  public BallImage makeImage()
  {
    return new MagicBallImage(this);
  }//makeImage
  
  //returns the value of the Ball
  public int getValue()
  {
    //if the ball is currently in the counting state,
    //it increments the display value until 99.
    //otherwise, if it is 99, it returns 0
    if (currentState == countingBall)
    {
      if (displayValue < 99)
      {
        displayValue ++;
        return displayValue;
      }
      else
      {
        displayValue = 0;
        return displayValue;
      }
    }
    //if the current state is NOT countingBall then
    //it displays the original getValue
    else
    {
      originalGetValue = super.getValue();
      return originalGetValue;
    }
    
  }//getValue
  
  //method which changes the state of the ball
  //depending on which mouse button is clicked
  public void doMagic(int spellNumber)
  {
    //if the right mouse button is clicked and the currentState is
    //less than 4, increments the current state and updates the ball
    //image. If it is greater than 4, it sets current state back to 0.
    
    if (spellNumber == 1)
    {
      if (currentState < 4)
      {
        currentState ++;
        getImage().update();
        
      }      
      else
      {
        currentState = ordinaryBall;
        getImage().update();
      }
    }
    
    //if the middle button is clicked, it sets the current state of the 
    //ball back to ordinary Ball
    else if (spellNumber == 2)
    {
      currentState = ordinaryBall;;
      getImage().update();
    }      
    
  }//doMagic
  
  //boolean to check if the ball is visible.
  public boolean isVisible()
  {
    return currentState != invisibleBall;
  }//isVisible
  
  //boolean to check if the ball is in a flashing state
  public boolean isFlashing()
  {
    return currentState == flashingBall || currentState == countingBall;
  }//isFlashing
  
}//magicBall
    
  
  
