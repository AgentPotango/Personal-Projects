import java.awt.Container;
import java.awt.GridLayout;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import javax.swing.JButton;
import javax.swing.JFrame;
import javax.swing.JLabel;

public class StopClock extends JFrame implements ActionListener
{
  //true if the clock is running
  private boolean isRunning = false;
  
  //the time when the clock started
  private long startTime = 0;
  
  //the time when the clock stopped
  private long stopTime = 0;
  
  //the time when the split button was pressed with referrence to the 
  //start time
  private long splitTime = 0;
  
  //label for start time
  private final JLabel startTimeJLabel = new JLabel("Not started");
  
  //label for stop time
  private final JLabel stopTimeJLabel = new JLabel("Not started");
  
  //label for split time
  private final JLabel splitTimeJLabel = new JLabel("Not started");
  
  //label for elapsed time
  private final JLabel elapsedTimeJLabel = new JLabel("Not started");
  
  //button to start/stop the clock
  private final JButton startStopJButton = new JButton("Start / Stop");
  
  //button to split the time
  private final JButton splitTimeJButton = new JButton("Split Time");
  
  //constructor
  public StopClock()
  {
    setTitle("Stop Clock");
    
    Container contents = getContentPane();
    contents.setLayout(new GridLayout(0, 1));
    
    contents.add(new JLabel("Started at:"));
    contents.add(startTimeJLabel);
    
    contents.add(new JLabel("Stopped at:"));
    contents.add(stopTimeJLabel);
    
    contents.add(new JLabel("Split time:"));
    contents.add(splitTimeJLabel);
    
    contents.add(new JLabel("Elapsed time (seconds):"));
    contents.add(elapsedTimeJLabel);
    
   // JButton startStopJButton = new JButton("Start / Stop");
    startStopJButton.addActionListener(this);
    contents.add(startStopJButton);
    
   // JButton splitTimeJButton = new JButton("Split Time");
    splitTimeJButton.addActionListener(this);
    contents.add(splitTimeJButton);
       
    setDefaultCloseOperation(EXIT_ON_CLOSE);
    pack();
  }//StopClock
  
  
  
  public void actionPerformed(ActionEvent event)
  {
    //If the clock is not running and the event source is the start/stop button
    //then start the clock and set is running to true 
    if (!isRunning && event.getSource() == startStopJButton)
    {
      // Start the clock
      startTime = System.currentTimeMillis();
      startTimeJLabel.setText("" + startTime);
      stopTimeJLabel.setText("Running...");
      elapsedTimeJLabel.setText("Running...");
      isRunning = true; 
    }//if
    
    //If the clock is running and the start/stop button is clicked again
    //the clock stops and the elapsed time label deisplays the amount of 
    //seconds that have passed
    //isRunning is set to false
    else if (isRunning && event.getSource() == startStopJButton)
    {
      stopTime = System.currentTimeMillis();
      stopTimeJLabel.setText("" + stopTime);
      long elapsedMilliSeconds = stopTime - startTime;
      elapsedTimeJLabel.setText("" + elapsedMilliSeconds / 1000.0);
      splitTimeJLabel.setText("Not Started");
      isRunning = false;
    }//else if
    
    //if the clock is running and splitTime button is pressed,
    //it calculates the time elapsed at the time and lets the clock
    //continue running
    else if (isRunning && event.getSource() == splitTimeJButton)
    {
      splitTime = System.currentTimeMillis();
      long elapsedSplitMilliSeconds = splitTime - startTime;
      splitTimeJLabel.setText("" + elapsedSplitMilliSeconds / 1000.0);
      isRunning = true; 
    }//else if
     
    pack();  
  }//actionPerformed
  
  //sets up the StopClock object
  public static void main(String[] args)
  {
    StopClock theStopClock = new StopClock();
    theStopClock.setVisible(true);
  }//main
  
}//class StopClock
   


