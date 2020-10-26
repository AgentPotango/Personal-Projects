public class DegreeCategory
{
  public static void main(String[] args)
  {
    double totalAssessmentMark = Double.parseDouble(args[0]);
    
    if (totalAssessmentMark >= 70)
      System.out.println("Honours, first class");
    else if (totalAssessmentMark < 70 && totalAssessmentMark >= 60)
      System.out.println("Honours, second class, division one");
    else if (totalAssessmentMark < 60 && totalAssessmentMark >= 50)
      System.out.println("Honours, second class, division two");
    else if (totalAssessmentMark < 50 && totalAssessmentMark >= 40)
      System.out.println("Honours, third class");
    else if (totalAssessmentMark < 40 && totalAssessmentMark >= 32)
      System.out.println("Pass/Ordinary Degree");
    else
      System.out.println("Fail");
      
  }
}
