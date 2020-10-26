import java.awt.Container;
import java.awt.GridLayout;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import javax.swing.JButton;
import javax.swing.JFrame;
import javax.swing.JLabel;
import javax.swing.JTextField;

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
  
  //uneditable text field which displays the start time
  private final JTextField startTimeJTextField = new JTextField("Not started");
  
  //uneditable text field which displays the stop time
  private final JTextField stopTimeJTextField = new JTextField("Not started");
  
  //uneditable text field which displays the split time
  private final JTextField splitTimeJTextField = new JTextField("Not started");
  
  //uneditable text field which displays the elapsed time
  private final JTextField elapsedTimeJTextField = new JTextField("Not start"
                                                                  + "ed");
  //button to start the clock
  private final JButton startStopJButton = new JButton("Start");
  
  //button to split the time   
  private final JButton splitTimeJButton = new JButton("Split Time");

  //Constructor
  public StopClock()
  {
    setTitle("Stop Clock");
    
    Container contents = getContentPane();
    contents.setLayout(new GridLayout(0, 1));
    
    contents.add(new JLabel("Started at:"));
    contents.add(startTimeJTextField);
    startTimeJTextField.setEnabled(false);
    
    contents.add(new JLabel("Stopped at:"));
    contents.add(stopTimeJTextField);
    stopTimeJTextField.setEnabled(false);
    
    contents.add(new JLabel("Split time:"));
    contents.add(splitTimeJTextField);
    splitTimeJTextField.setEnabled(false);
    
    
    contents.add(new JLabel("Elapsed time (seconds):"));
    contents.add(elapsedTimeJTextField);
    elapsedTimeJTextField.setEnabled(false);
    
    //gives the StartStop button a listener
    startStopJButton.addActionListener(this);
    contents.add(startStopJButton);
    
   //splitTime is initially enabled if the clock is not enabled
    splitTimeJButton.addActionListener(this);
    contents.add(splitTimeJButton);
    splitTimeJButton.setEnabled(false);
       
    setDefaultCloseOperation(EXIT_ON_CLOSE);
    pack();
  }//StopClock
  
  
  
  public void actionPerformed(ActionEvent event)
  {
    if (!isRunning && event.getSource() == startStopJButton)
    {
      // Start the clock
      //Clock is now running and enable the splitTime button
      //change Start button text to stop
      
      startTime = System.currentTimeMillis();
      startTimeJTextField.setText("" + startTime);
      stopTimeJTextField.setText("Running...");
      elapsedTimeJTextField.setText("Running...");
      isRunning = true; 
      splitTimeJButton.setEnabled(true);
      startStopJButton.setText("Stop");
    }
    else if (isRunning && event.getSource() == startStopJButton)
    {
      //stop the clock and set isRunning to false
      //change stop button text to start
      stopTime = System.currentTimeMillis();
      stopTimeJTextField.setText("" + stopTime);
      long elapsedMilliSeconds = stopTime - startTime;
      elapsedTimeJTextField.setText("" + elapsedMilliSeconds / 1000.0);
      splitTimeJTextField.setText("Not Started");
      isRunning = false;
      startStopJButton.setText("Start");
    }
    else if (isRunning && event.getSource() == splitTimeJButton)
    {
      //if the clock is running, calculate the split time
      splitTime = System.currentTimeMillis();
      long elapsedSplitMilliSeconds = splitTime - startTime;
      splitTimeJTextField.setText("" + elapsedSplitMilliSeconds / 1000.0);
      isRunning = true; 
    }
     
    pack();  
  }//actionPerformed
  
  public static void main(String[] args)
  {
    StopClock theStopClock = new StopClock();
    theStopClock.setVisible(true);
  }//main
  
}//class StopClock
   


