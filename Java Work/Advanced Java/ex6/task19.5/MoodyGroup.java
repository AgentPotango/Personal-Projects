public class MoodyGroup<MoodyPersonType extends MoodyPerson>
{
  //Initial size and resize factor.
  private static final int INITIAL_ARRAY_SIZE = 2, ARRAY_RESIZE_FACTOR = 2;
  
  //The array, together withg the nummber of MoodyPerson objects in it
  private MoodyPerson[] moodyPersons = new MoodyPerson[INITIAL_ARRAY_SIZE];
  private int noOfMoodyPersons = 0;
  
  public MoodyGroup()
  {
  }//MoodyGroup
  
  //Add the given MoodyPerson to the array
  public void addMoodyPerson(MoodyPersonType newMoodyPerson)
  {
    if (noOfMoodyPersons == 0)
    {
      MoodyPerson[]  biggerArray = new MoodyPerson[moodyPersons.length 
                                                   * ARRAY_RESIZE_FACTOR];
      for (int index = 0; index <  moodyPersons.length; index ++)
        biggerArray[index] = moodyPersons[index];
      moodyPersons = biggerArray;
      
    }//if
    moodyPersons[noOfMoodyPersons] = newMoodyPerson;
    noOfMoodyPersons ++;
  }//addMoodyPerson
  
  public int getSize()
  {
    return noOfMoodyPersons;
  }//getSize
  
  private int nextToSetHappy = 0;
  
  public void setHappy(boolean moodToSet)
  {
    if (noOfMoodyPersons > 0)
    {
      moodyPersons[nextToSetHappy].setHappy(moodToSet);
      nextToSetHappy = (nextToSetHappy + 1) % noOfMoodyPersons;
    }//if
  }// setHappy
  
  //For Testing
  @Override
  public String toString()
  {
    String result = noOfMoodyPersons == 0 ? "" : "" + moodyPersons[0];
    for (int index = 1; index < noOfMoodyPersons; index ++)
      result += String.format("%n%s", moodyPersons[index]);
    return result;
  }//toString
  
}//MoodyGroup  
  
  
    
      
                                                
