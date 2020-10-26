import java.awt.Container;
import java.awt.GridLayout;
import javax.swing.JFrame;
import javax.swing.JLabel;

//Program creates a timetable for a specific number and up until a specified 
//number
public class TimesTable extends JFrame
{
  //Contstructor
  public TimesTable(int timesTable, int upUntil)
  {
    setTitle("Times Table");
    Container contents = getContentPane();
    
    //We want the times table to appear in a grid format
    contents.setLayout(new GridLayout(upUntil, upUntil, 50, 10));
    
    //Loop which creates the TimeTable text
    for (int count = 1; count <= upUntil; count ++)
    {
      contents.add(new JLabel("" + count));
      contents.add(new JLabel("X"));
      contents.add(new JLabel("" + timesTable));
      contents.add(new JLabel("="));
      contents.add(new JLabel("" + (count * timesTable)));
    }//for
    
    setDefaultCloseOperation(EXIT_ON_CLOSE);
    pack();
  }//TimeTable
  
  //Create a HelloFamily and make it appear on screen
  public static void main(String[] args)
  {
    int timesTable = Integer.parseInt(args[0]);
    int untilNumber = Integer.parseInt(args[1]);
    
    TimesTable theTimesTable = new TimesTable(timesTable, untilNumber);
    theTimesTable.setVisible(true);
  }//main
  
}//class TimeTable
      
      
