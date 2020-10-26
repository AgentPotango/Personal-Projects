/* Program which creates a date and then prints out 5 more dates
   relative to it.
*/
  
public class TestRelativeDates
{
  public static void main(String[] args) throws Exception
  {
    try
    {
       Date referenceDate = new Date(1,1,2000);
       Date date1 = new Date(13,2,2001);
       Date date2 = new Date(27,11,2000);
       Date date3 = new Date(9,5,2001);
       Date date4 = new Date(31,12,2001);
       Date date5 = new Date(28,10,2000);
       
       //loops for 2 years
       System.out.println("Reference Date: " + referenceDate);
       while (referenceDate.getYear() != 2002)
       {
         
         if (referenceDate.equals(date1))
           System.out.println("Date 1: " + date1);
         else if (referenceDate.equals(date2))
           System.out.println("Date 2: " + date2);
         else if (referenceDate.equals(date3))
           System.out.println("Date 3: " + date3);
         else if (referenceDate.equals(date4))
           System.out.println("Date 4: " + date4);
         else if (referenceDate.equals(date5))
           System.out.println("Date 5: " + date5);
         
         referenceDate = referenceDate.addDay();
       }//while
     
   }//try    
    
   catch(Exception exception) 
   {
     System.out.println(exception.getMessage());
     System.out.println(exception);
     System.out.println("Date is not in Date Format");
     if (exception.getCause() != null)
       System.err.println("This error was caused by " + exception.getCause());
   }  //catch
       
      
  }//main
  
}//TestRelativesDates
      
