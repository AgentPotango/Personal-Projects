//Program creates a GUI which creates an instance of each person
//to demonstrate that getClassHierarchy is producing the right 
//class Hierarchy

public class LotteryTestA
{
  public static void main(String args[])
  {
    //speed controller for GUI
    SpeedController speedController
      = new SpeedController(SpeedController.HALF_SPEED);
    
    //Creating a new GUI
    LotteryGUI gui = new LotteryGUI("TV Studio", speedController);
    
    //creating a new TV Host and adding it to the GUI
    TVHost tvHost = new TVHost("Terry Bill Woah B'Gorne");
    gui.addPerson(tvHost);
    
    //creating a new AudienceMember and adding it to the GUI
    AudienceMember audienceMember1 = new AudienceMember("Ivana Di Yowt");
    gui.addPerson(audienceMember1);
    
    //creating a new Punter and adding it to the GUI
    Punter punter1 = new Punter("Ian Arushfa Rishly Ving");
    gui.addPerson(punter1);
    
    //creating a new Psychic and adding it to the GUI
    Psychic psychic = new Psychic("Miss T. Peg de Gowt");
    gui.addPerson(psychic);
    
    //creating a new Director and adding it to the GUI
    Director director = new Director("Sir Lance Earl Otto");
    gui.addPerson(director);
    
    //creating a new CleverPunter and adding it to the GUI
    CleverPunter cleverPunter1 = new CleverPunter("Wendy Athinkile-Win");
    gui.addPerson(cleverPunter1);
    
    //creating a new TraineeWorker and adding it to the GUI
    Worker worker1 = new TraineeWorker("Jim", 0);
    gui.addPerson(worker1);
    
    //creating a new Worker and adding it to the GUI
    Worker worker2 = new Worker("Bob");
    gui.addPerson(worker2);
    
    //creating a new Teenager and adding it to the GUI
    Teenager teenager1 = new Teenager("Harry");
    gui.addPerson(teenager1);
    
  }//main
}//LotteryTestA
