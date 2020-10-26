//A class for representing a student
//comprising of a students name and their mark
public class Student
{
  //the name of the student
  private final String student;
  
  //their mark
  private final int mark;
  
  //the constructor method
  public Student(String requiredStudent, int requiredMark)
  {
    student = requiredStudent;
    mark = requiredMark;
  }//student
  
  //get the Student
  public String getStudent()
  {
    return student;
  }//getStudent
  
  //get the Mark
  public int getMark()
  {
    return mark;
  }//getStudent
  
  //Compare this mark with a given other
  //basing the comparison on the marks, then the students.
  //Returns the -ve, 0 or +ve int. =ve means this one is the smallest.
  public int compareTo(Student other)
  {
    if (mark == other.mark)
      return student.compareTo(other.student);
    else
      return mark - other.mark;
  }//compareTo
  
  //return the string representation.
  public String toString()
  {
    return String.format("%-10s got %3d", student, mark);
  }//toString

}//class Student
      
