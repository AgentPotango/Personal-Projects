import java.awt.Container;
import java.awt.FlowLayout;
import javax.swing.JFrame;
import javax.swing.JLabel;

//Program which prints out greetings to family members
public class HelloFamily extends JFrame
{
  //Constructor
  public HelloFamily()
  {
    setTitle("Hello Family");
    Container contents = getContentPane();
    
    //We want the family names to appear in one line
    contents.setLayout(new FlowLayout());
    
    contents.add(new JLabel("Hello Ibrahim"));
    contents.add(new JLabel("Hello Imran!"));
    contents.add(new JLabel("Hello Kashif!"));
    contents.add(new JLabel("Hello Katib!"));
    contents.add(new JLabel("Hello Qasim!"));
    contents.add(new JLabel("Hello Zahrah!"));
    contents.add(new JLabel("Hello Zaibah!"));
    contents.add(new JLabel("Hello Zainab!"));
    contents.add(new JLabel("Hello Zak!"));
    contents.add(new JLabel("Hello Zunairah!"));
 
    setDefaultCloseOperation(EXIT_ON_CLOSE);
    pack();
  }//HelloFamily
  
  //Create a HelloFamily and make it appear on screen
  public static void main(String[] args)
  {
    HelloFamily theHelloFamily = new HelloFamily();
    theHelloFamily.setVisible(true);
  }
  
}//class HelloFamily 
  
