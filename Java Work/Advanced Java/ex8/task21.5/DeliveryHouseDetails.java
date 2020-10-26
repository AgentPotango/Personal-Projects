//Creates a DeliveryHouseDetails Object
public class DeliveryHouseDetails implements Comparable<DeliveryHouseDetails>
{
  //Stores the house Number
  private final int houseNumber;
  
  //Stores the name and house Number
  private final String personDetails;
  
  //Constructor for the object
  public DeliveryHouseDetails(int requiredHouseNumber, 
  			      String requiredPersonDetails)
  {
    houseNumber = requiredHouseNumber;
    personDetails = requiredPersonDetails;
  }//DeliveryHouseDetails
  
  //Returns the personDetails  
  public String getPersonDetails()
  {
    return personDetails;
  }//getPersonDetails
  
  //Compares DeliveryHouse objects
  public int compareTo(DeliveryHouseDetails other)
  {
    if (this.houseNumber % 2 == 1 && other.houseNumber % 2 == 1)
      return this.houseNumber - other.houseNumber;
    else if (this.houseNumber % 2 == 0 && other.houseNumber % 2 ==0)
      return other.houseNumber - this.houseNumber;
    else if (this.houseNumber % 2 == 1)
      return -1;
    else
      return 1;
  }//compareTo
  //Equivalence test, consistent with compareTo
  @Override
  public boolean equals(Object other)
  {
    if (other instanceof DeliveryHouseDetails)
      return houseNumber == ((DeliveryHouseDetails)other).houseNumber;
    else
      return super.equals(other);
  }// equals
}//class DeliveryHouseDetails
