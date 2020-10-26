//Creates an Anagram using the characters from the first command line 
//argument
public class Anagrams
{

  //Stores the permutations of the charcters from the characterArray
  private static char[] permutations;
  
  //Stores the characters from the argument
  private static char[] characterArray;
  
  //Used to check if a character has been ussed
  private static boolean[] charUsed;
  
  public static void main(String[] args)
  {
    //Stores the string from the cmd line argument into an array
    //by splitting them into chars
    characterArray = args[0].toCharArray();
        
    //creates a permutation array of the same length of the character array
    permutations = new char[characterArray.length];
    
    //Checks if the characters from the characterArray have been Used
    charUsed = new boolean[characterArray.length];
   
    //Calls the recursive function using the index 0 as a starting point.
    printPermutations(0);
   
       
   }//main
   
   //function takes the characters from the characterArray and prints out
   //the different combination of character ordering
   public static void printPermutations(int currentIndex)
   {
     //Prints the array if the array length has been exceeded
     if (currentIndex > permutations.length -1 )
     {
       System.out.println(permutations);       
     }
     else
     {
       //for every character in the character array, checks if the character
       //has been used. If not, it places the character inside the 
       //permutations array at the current index and then recursively
       //calls the function
       for (int index = 0; index < characterArray.length; index ++)
       {
         if (!charUsed[index])
         {
           charUsed[index] = true;
           permutations[currentIndex] = characterArray[index];
           printPermutations(currentIndex + 1);
           charUsed[index] = false;
         }//if
       }//for
     }//else
  }//printPermutations
 
}//Anagrams
