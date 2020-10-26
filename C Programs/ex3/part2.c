#include <stdio.h>  // FILE stderr fopen fclose fprintf printf fgets
#include <stdlib.h> // exit malloc free atoi abs
#include <ctype.h> // character classification functions

int main(void)
{
  /*sets up variables to store related counts*/
  int character, charCount, upperCount, lowerCount;
  
  /*declares initial counts as 0*/
  charCount = 0;
  upperCount = 0;
  lowerCount = 0;
  
  /*creates 2 file pointers for borth input and output respectively*/
  FILE *inputFilePtr, *outputFilePtr;
 
  char inputFilename[25];
  char outputFilename[25];
  
  /*scans the standard input for the input filename*/
  printf("Please enter the input file name (less than 25 characters)\n"); 
  scanf("%s", inputFilename);
  
  /*opens a file in readonly mode*/
  inputFilePtr = fopen(inputFilename,"r");
  
  /*checks if the specified file can be opened*/
  if (!inputFilePtr)
  {
    fprintf(stderr, "can't open input for reading\n");
    exit(-1);
  }
  
  /*scans the standard input for the output filename*/
  printf("Please enter the output file name (less than 25 characters)\n"); 
  scanf("%s", outputFilename);
  
  /*opens a file ready to write onto*/ 
  outputFilePtr = fopen(outputFilename,"w");
  
  /*checks if the specified file can be opened*/
  if (!outputFilePtr)
  {
    fprintf(stderr, "can't open output for writing (it may be "
    	            "write protected)\n");
    exit(-1);
  }
  
  /*reads the first character from the input file*/
  character = getc(inputFilePtr);
    
  /*reads characters from the file till the end of the file)*/
  while(!feof(inputFilePtr) && !feof(outputFilePtr))
  {
    charCount +=1;
    
    /*checks if the character is lower and converts it to upper
      It then increments the upperCount
    */
    if (islower(character))
    {
      character = toupper(character);
      upperCount +=1;
    }
    
    /*checks if the character is upper and converts it to lower
      It then increments the lowerCount
    */
    else if (isupper(character))
    {
      character = tolower(character);
      lowerCount +=1;
    }
    
    /*puts the character in the outputfile and reads the next character
      from the inputfile.
    */
    putc(character, outputFilePtr);
    character=getc(inputFilePtr);
    
  }
  
  /*prints out how many characters were read, the upper count and lower count*/
  printf("Read %d characters in total, %d converted to upper-case, %d to "
  	 "lower-case",charCount, upperCount, lowerCount); 
  /*closes the input and output files*/
  fclose(inputFilePtr);
  fclose(outputFilePtr);
  return 0;
}
