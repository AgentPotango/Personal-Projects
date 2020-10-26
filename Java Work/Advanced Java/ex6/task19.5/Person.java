public class Person
{
  //the name of the person
  private final String personName;
  
  //The Person's latest saying;
  private String latestSaying;
  
  //Constructor is given the person's name
  public Person(String requiredPersonName)
  {
    personName = requiredPersonName;
    latestSaying = "I am " + personName;
  }//Person
  
  //Returns the persons Name
  public String getPersonName()
  {
    return personName;
  }//getPersonName
  
  //Returns the Person's latest saying
  public String getLatestSaying()
  {
    return latestSaying;
  }// getLatestSaying
  
  public String getPersonType()
  {
    return "Person";
  }// getPersonType
  
  //Returns whether or not the person is happy.
  public boolean isHappy()
  {
    return true;
  }//isHappy
  
  public String getCurrentSaying()
  {
    return "I have nothing to say";
  }//getCurrentSaying
  
  public void speak()
  {
    latestSaying = getCurrentSaying();
  }//speak
  
  public String toString()
  {
    return getPersonType() + " " + getPersonName()
           + " " + isHappy() + " " + getLatestSaying();
  }//toString
  
}//class Person
  
    
  
  
  
