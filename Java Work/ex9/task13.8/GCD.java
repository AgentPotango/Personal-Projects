import java.awt.Container;
import java.awt.GridLayout;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import javax.swing.JButton;
import javax.swing.JFrame;
import javax.swing.JLabel;
import javax.swing.JTextField;

//Calculates the GCD of two integers.
public class GCD extends JFrame implements ActionListener
{
  //A JTextField for each number
  private final JTextField number1JTextField = new JTextField(20);
  private final JTextField number2JTextField = new JTextField(20);
  private final JTextField number3JTextField = new JTextField(20);
  
  //A JTextField for the result.
  private final JTextField resultJTextField = new JTextField(20);
  
  //Constructor
  public GCD()
  {
    setTitle("GCD");
    Container contents = getContentPane();
    contents.setLayout(new GridLayout(0, 1));
    
    contents.add(new JLabel("Number 1"));
    contents.add(number1JTextField);
    contents.add(new JLabel("Number 2"));
    contents.add(number2JTextField);
    contents.add(new JLabel("Number 3"));
    contents.add(number3JTextField);
    
    JButton computeJButton = new JButton("Compute");
    contents.add(computeJButton);
    computeJButton.addActionListener(this);
    
    contents.add(new JLabel("GCD of Number 1, Number 2 and Number 3"));
    contents.add(resultJTextField);
    
    setDefaultCloseOperation(EXIT_ON_CLOSE);
    pack();
  }//GCD
  
  //Act upon the button being pressed
  public void actionPerformed(ActionEvent event)
  {
    int number1 = Integer.parseInt(number1JTextField.getText());
    int number2 = Integer.parseInt(number2JTextField.getText());
    int number3 = Integer.parseInt(number3JTextField.getText());
    
    //calculates the GCD of 2 numbers
    int theGCDOfTwoNumbers = MyMath.greatestCommonDivisor(number1, number2);
    
    //calculates the GCD of all the numbers
    int theGCDOfAllNumbers = MyMath.greatestCommonDivisor(theGCDOfTwoNumbers,
                                                          number3);
                        
    resultJTextField.setText("" + theGCDOfAllNumbers);
  }//actionPerformed
  
  //Create a GCD and make it appear on screen
  public static void main(String[] args)
  {
    GCD theGCD = new GCD();
    theGCD.setVisible(true);
  }//main

}//class GCD
