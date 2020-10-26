/* This program uses 3 classes which are used to tell a story
   
   The program is used to assign students a mobile phone which each
   come with an account.
   You can then top up your mobile phone and make calls with it if you
   have enough balance in your account
*/
public class StudentsCalling
{
  public static void main(String[] args)
  {
    //Used to setup Phone and Account 1
    Account account1 = new Account("World@1");
    Phone phone1 = new Phone("Snotia BIFR", account1);
    
    //Used to setup Phone and Account 2
    Account account2 = new Account("4FRN Touch");
    Phone phone2 = new Phone("Cyoo L8TR0N", account2);
    
    //Used to setup Phone and Account 3
    Account account3 = new Account("Foney Friends");
    Phone phone3 = new Phone("Tisonly 14U", account3);
    
    //Used to setup Phone and Account 4
    Account account4 = new Account("VerTuleTyat");
    Phone phone4 = new Phone("Simm UL8R", account4);
    
    //Creates student1 and prints out the object
    System.out.println("Creating Student: Chatty Charlie");
    Student student1 = new Student("Chatty Charlie");
    printResult(student1);
    
    //Creates student2 and prints out the object
    System.out.println("Creating Student: Norman No Friends");
    Student student2 = new Student("Norman No Friends");
    printResult(student2);
    
    //Creates student3 and prints out the object
    System.out.println("Creating Student: Popular Penny");
    Student student3 = new Student("Popular Penny");
    printResult(student3);
    
    //Student1 attempts to makes a call for 300 seconds, but he doesn't have 
    //a phone
    makeCall(student1,300, account1);
    
    //student2 attempts to topup a phone. However, he doesn't own one. 
    getTopUp(student2, 20);
    
    //All 3 students purchace a phone
    buyingPhone(student1, phone1, account1);
    buyingPhone(student2, phone2, account2);
    buyingPhone(student3, phone3, account3);
    
    //all 3 students top up there phones with £10, £20 and £30 respectively
    getTopUp(student1, 10);
    getTopUp(student2, 20);
    getTopUp(student3, 30);
    
    //The story progresses with student 1 making a call
    makeCall(student1, 300, account1);
    
    //The next call the student makes is over his balance limit
    //and so the duration of the call is limited to his balance
    //instead of the 1200 the student requested
    makeCall(student1, 1200, account1);
    makeCall(student1, 10, account1);
    makeCall(student2, 10, account2);
    makeCall(student3, 65, account3);
    makeCall(student3, 115, account3);
    makeCall(student3, 488, account3);
    makeCall(student3, 302, account3);
    makeCall(student3, 510, account3);
    makeCall(student3, 250, account3);
    
    //Student 3 decides to buy a new phone
    buyingPhone(student3, phone4, account4);
    
    
    
    
  }//main
  
  //Method used to print repeating piece of code which prints out
  //the student object
  private static void printResult(Student student)
  {
    System.out.println("Result:");
    System.out.println(student);
    System.out.println();
  }//printResult
  
  //Method used to TopUp the student's mobiles
  private static void getTopUp(Student student, int topUpAmount)
  {
   //If they don't have one, then they can't top up
   if (student.getMobile() == null)
   {
     System.out.println("This next top up has no effect, as has no phone!");
   }
   //prints out how much student is topping up
   System.out.println(student);
   System.out.println("is topping up by " + topUpAmount);
   student.topUp(topUpAmount);
   printResult(student);
       
  }//getTopUp 
  
  //Method used to buy a phone
  private static void buyingPhone(Student student, Phone newPhone, 
                                  Account account)
  {
    //If they own a phone already when attempting to buy one,
    //they must discard the other one
    if (student.getMobile() != null)
    {
      System.out.println("Now let us discard a phone");
    }
    
    //Prints out phone and account to buy
    System.out.println(student);
    System.out.println("is buying phone " + newPhone.getPhoneName());
    System.out.println("with account " + account.getAccountName());
    student.buyNewPhone(newPhone);
    printResult(student);
    
  }//buyingPhone 
  
  //Method used to make a call on the phone
  private static void makeCall(Student student, int duration, Account account)
  {
    //If the person does not own a mobile then they cannot make a call
    if (student.getMobile() == null)
      System.out.println("This next call has no effect, as has no phone!");
    
    //if the person's call duration is larger than they have money to pay for
    //then truncate the duration of the call
    if (duration > account.getAccountBalance())
    {
      duration = account.getAccountBalance();
      System.out.println("This next call should be truncated to " 
                         + duration + " seconds");
    }
    
   System.out.println(student);
   System.out.println("is making a call for desired " + duration + " seconds");
   student.attemptCall(duration);                      
   printResult(student);
  }//make call     
      
}//class StudentsCalling
  
     
  
