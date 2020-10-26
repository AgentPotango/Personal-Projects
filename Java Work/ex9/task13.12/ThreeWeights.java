import java.awt.Container;
import java.awt.BorderLayout;
import java.awt.GridLayout;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import javax.swing.JButton;
import javax.swing.JFrame;
import javax.swing.JLabel;
import javax.swing.JTextField;
import javax.swing.JTextArea;
import javax.swing.JScrollPane;
import javax.swing.JPanel;


//Calculates the GCD of two integers.
public class ThreeWeights extends JFrame implements ActionListener
{
  //A JTextField for each number
  private final JTextField weight1JTextField = new JTextField(2);
  private final JTextField weight2JTextField = new JTextField(2);
  private final JTextField weight3JTextField = new JTextField(2);
  
  //A text Area for the resulting weights table 27 lines of 25 chars
  private final JTextArea displayJTextArea = new JTextArea(27, 25);
  
  //Constructor
  public ThreeWeights()
  {
    setTitle("Three Weights");
    Container contents = getContentPane();
    contents.setLayout(new BorderLayout());
    
    //A JPanel for the three text fields
    //It will be a GridLayout at te top of the JFrame contents
    JPanel weightsPanel = new JPanel(new GridLayout(3,0));
    contents.add(weightsPanel, BorderLayout.NORTH);
    
    //Adds three JLabels and three JTextFields to the weightsPanel
    weightsPanel.add(new JLabel("Weight 1"));
    weightsPanel.add(weight1JTextField);
    weightsPanel.add(new JLabel("Weight 2"));
    weightsPanel.add(weight2JTextField);
    weightsPanel.add(new JLabel("Weight 3"));
    weightsPanel.add(weight3JTextField);
    
    
    //The result JScrollPane/JTextArea goes in the centre
    contents.add(new JScrollPane(displayJTextArea), BorderLayout.CENTER);
    
    //the JButton goes at the bottom
    JButton computeJButton = new JButton("Compute");
    contents.add(computeJButton, BorderLayout.SOUTH);
    computeJButton.addActionListener(this);
    
    setDefaultCloseOperation(EXIT_ON_CLOSE);
    pack();
  }//GCD
  
  //Act upon the button being pressed
  public void actionPerformed(ActionEvent event)
  {
    //Empty the text Area to remove any previous result
    displayJTextArea.setText("");
    
    //get the values from the text fields
    int weight1 = Integer.parseInt(weight1JTextField.getText());
    int weight2 = Integer.parseInt(weight2JTextField.getText());
    int weight3 = Integer.parseInt(weight3JTextField.getText());
    
    //create top part of the table
    displayJTextArea.append("---------------------------\n");
    displayJTextArea.append("| Compute Weight Combinations |" + "\n");
    displayJTextArea.append("---------------------------\n");
   
    //Displays the 27 weight combinations when they are added together
    //with multiples -1, 0 and 1
    for (int multiplier1 = -1; multiplier1 <= 1; multiplier1++)
      for (int multiplier2 = -1; multiplier2 <=1; multiplier2++)
        for (int multiplier3 = -1; multiplier3 <=1; multiplier3++)
          displayJTextArea.append("" + (weight1 * multiplier1) +  " + " 
                                  + (weight2 * multiplier2) + " + " 
                                  + (weight3 * multiplier3) + " = "
                                  + ((weight1 * multiplier1) 
                                  + (multiplier2 * multiplier2)
                                  + (weight3 * multiplier3)) + "\n") ;
    
  }//actionPerformed
  
  //Create a threeWeights table and make it appear on screen
  public static void main(String[] args)
  {
    ThreeWeights theThreeWeights = new ThreeWeights();
    theThreeWeights.setVisible(true);
  }//main

}//class GCD
