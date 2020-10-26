#include <stdio.h>  // FILE stderr fopen fclose fprintf printf fgets
#include <stdlib.h> // exit malloc free atoi abs
#include <ctype.h> // character classification functions
#include <math.h> //math functions.

int main(int argc, char *argv[])
{
  /*sets up variables to store related counts*/
  int charCount[255] = {0};
  int character;
  
  
  /*creates a file pointer for the input file*/
  FILE *inputFilePtr;
 
  char *inputFilename = argv[1];
   
  /*opens a file in readonly mode*/
  
  inputFilePtr = fopen(inputFilename,"r");
  
  /*checks if the specified file can be opened*/
  if (!inputFilePtr)
  {
    fprintf(stderr, "can't open input for reading\n");
    exit(-1);
  }
  
  /*reads the first character from the input file*/
  
  //printf("%#04x", character);
   
   
  /*reads characters from the file till the end of the file)*/
  while(!feof(inputFilePtr))
  {
    character = getc(inputFilePtr);
    charCount[character] = charCount[character] + 1;
        
  }
  
  for (int i = 0; i < sizeof(charCount)/sizeof(charCount[0]); i++)
  {
    if (charCount[i] > 0)
    {
      if (charCount[i] == 1)
        printf("%d instance of character %#04x (%c)\n", charCount[i], i, i);
      else
        printf("%d instances of character %#04x (%c)\n", charCount[i], i, i);
    }
      
  }
  

  
  
  fclose(inputFilePtr);
 
  return 0;
  
}
