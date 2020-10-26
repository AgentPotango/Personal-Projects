import java.util.Scanner;
/* This program analyses the interger marks entered by the user.
   It outputs each mark and stunde, the mean of the marks, 
   the minimum mark, and the maximum mark. 
   The mark entered must be greater than than 0.
   It also sorts the marks into ascending order
   It makes use of the student class to also give each student a name
  */
public class MarkAnalysis
{
  public static void main(String[] args)
  {
    //Scabber used to enter either the student name or the mark of the student
    Scanner inputScanner = new Scanner(System.in);
    
    System.out.print("Enter the number of Students: ");
    
    int numberOfStudents = inputScanner.nextInt();
    //Skip past the end of that line
    inputScanner.nextLine();
    
    //We keep the students in an array
    Student[] students = new Student[numberOfStudents];
           
    //read the data in pairs,
    //build the student objects and store them in the students array
    for (int studentCount = 1; studentCount <= numberOfStudents; studentCount++)
    {
      System.out.print("Enter the name of student " + studentCount + ": ");
      String student = inputScanner.nextLine();
      System.out.print("Enter mark for '" + student + "': ");
      int validMark = inputScanner.nextInt();
     
      //check if the mark is greater than 0
      //if not, display error and exit.      
      if (validMark <= 0)
      {
        System.out.println("Please enter a mark greater than one");
        System.exit(0);
      }
      else
        students[studentCount - 1] = new Student(student, validMark);
        //Skip past the end of that line
        inputScanner.nextLine();
      
    }//for
    

      
    //Calculate the sum of the marks
    int sumOfMarks = 0;
    for (Student student : students)
      sumOfMarks += student.getMark();
    
    
    int minimumMark = min(numberOfStudents, students);
    int maximumMark = max(numberOfStudents, students);
    //calculate the mean which is a double
    double meanMark = sumOfMarks/ (double) numberOfStudents;
           
    //Sort the marks into ascending order
    sort(students);
    
    //print the mark results out    
    System.out.println();
    System.out.println("The mean Mark is:\t" + meanMark);
    System.out.println("The minimum Mark is:\t" + minimumMark);
    System.out.println("The maximum Mark is:\t" + maximumMark);
    System.out.println();
    
    //Header for table
    System.out.println("Person and Score   | Difference from Mean");
    
    //calcualte the difference from the mean for each mark
    //print out the results in a table format
    for (Student student : students)
    {
      double differenceFromMean = student.getMark() - meanMark;
      System.out.printf("%s | %6.2f%n",student, differenceFromMean);
    }//for
  }//main
  
  //sort the given array of students using compareTo on the student Objects.
  private static void sort(Student[] anArray)
  {
    //Each pass of the sort resduces the unsorted length by one.
    int unsortedLength = anArray.length;
    boolean changedOnThisPass;
    do
    {
      changedOnThisPass = false;
      for (int pairLeftIndex = 0; pairLeftIndex < unsortedLength - 1;
           pairLeftIndex++)
        if (anArray[pairLeftIndex].compareTo(anArray[pairLeftIndex + 1]) > 0)
        {
          Student originalPairLeftIndex = anArray[pairLeftIndex];
          anArray[pairLeftIndex] = anArray[pairLeftIndex + 1];
          anArray[pairLeftIndex + 1] = originalPairLeftIndex;
          changedOnThisPass = true;
        }//of
      unsortedLength--;
    }while (changedOnThisPass);
  }//sort
  
  //returns the maximum Mark
  private static int max(int numberOfMarks, Student[] anArray)
  {
    int maxMark = anArray[0].getMark();
    for (int index = 0; index < numberOfMarks; index++)
    {
     if (anArray[index].getMark() > maxMark)
       maxMark = anArray[index].getMark();
    }//for
    return maxMark;
  }//
    
  //returns the minimum mark    
  private static int min(int numberOfMarks, Student[] anArray)
  {
    int minMark = anArray[0].getMark();
    for (int index = 0; index < numberOfMarks; index++)
    {
      if (anArray[index].getMark() < minMark)
        minMark = anArray[index].getMark();
    }//for
    return minMark;
  }//min
  
}//class MarkAnalysis

