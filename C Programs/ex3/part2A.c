#include <stdio.h>  // FILE stderr fopen fclose fprintf printf fgets
#include <stdlib.h> // exit malloc free atoi abs
#include <ctype.h> // character classification functions


int main(void)
{
  int character, charCount, upperCount, lowerCount;
  
  charCount = 0;
  upperCount = 0;
  lowerCount = 0;
  
  /*FILE *inputFilePtr;
  inputFilePtr = fopen("input","r");*/
  
  
  while ((character = getchar()) != EOF)
  {
    charCount +=1;
    if (islower(character))
    {
      character = toupper(character);
      upperCount +=1;
    }
    else if (isupper(character))
    {
      character = tolower(character);
      lowerCount +=1;
    }
    putchar(character);
  }
  printf("Read %d characters in total, %d converted to upper-case, %d to "
  	 "lower-case",charCount, upperCount, lowerCount); 
    
  /*fclose(inputFilePtr);*/
  return 0;
}
