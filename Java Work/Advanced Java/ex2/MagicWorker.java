import java.awt.Color;
//This class exteneds worker and is intended to make magicBalls
//and have the ability to change all a workers magicBalls state.
public class MagicWorker extends Worker
{
  //stores how many balls are currently stored
  int noOfBallsStored = 0;
  
  //creates a new array to store magic balls
  MagicBall [] workersBalls = new MagicBall[1];
 
  //constructs a magic worker
  public MagicWorker(String name)
  {
    super(name);
  }//MagicWorker
  
  //returns the type of person a magic worker is
  public String getPersonType()
  {
    return "Magic " + super.getPersonType();
  } // getPersonType

  //returns  a new image for the magic worker
  public PersonImage makeImage()
  {
    return new MagicWorkerImage(this);
  }//makeImage
  
  //returns the class Hierarchy for the magic worker
  public String getClassHierarchy()
  {
    return "MagicWorker>" + super.getClassHierarchy();
  }//getClassHierarchy
  
  //creates a new magic ball
  public Ball makeNewBall(int number, Color colour)
  {
    
    //checks if the array is full and creates a bigger array
    //to store the magic balls
    if (noOfBallsStored == workersBalls.length)
    {
      MagicBall [] biggerArray = new MagicBall[workersBalls.length + 1];
      for (int index = 0; index < workersBalls.length; index++)
        biggerArray[index] = workersBalls[index];
      workersBalls = biggerArray;
    }//if
    
    //adds the magic balls to the array and returns the magicBall
    for (int count = noOfBallsStored; count < workersBalls.length; count++)
    {
      workersBalls[noOfBallsStored] = new MagicBall(number,colour);
      noOfBallsStored++;
      return workersBalls[noOfBallsStored - 1];
    }//for
    
    //returns null if no balls are stored
    return null;
   }//makeNewBall
  
  //Method which makes all the workers magic balls change state
  //depending on the input spellNumber  
  public void doMagic(int spellNumber)
  {
    for (int count = 0; count < workersBalls.length; count ++)
    {
      workersBalls[count].doMagic(spellNumber);
    }//for
    
  }//doMagic
     
}//MagicWorker
