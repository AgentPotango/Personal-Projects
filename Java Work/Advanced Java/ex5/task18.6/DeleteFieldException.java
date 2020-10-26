public class DeleteFieldException extends RuntimeException
{
  //Parameterless Constructor
  public DeleteFieldException() 
  {
    super();
  }//DeleteFieldException

  //Constructor that accepts a message
  public DeleteFieldException(String message)
  {
    super(message);
  }//DeleteFieldException
  
  //Constructor that accespts a message and a cause
  public DeleteFieldException(String message, Throwable cause)
  {
    super(message, cause);
  }//DeleteFieldException
  
  public DeleteFieldException(Throwable cause)
  {
    super(cause);
  }//DeleteFieldException
  
}//DeleteFieldException
