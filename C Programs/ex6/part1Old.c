#include <stdio.h>
#include <stdlib.h>
#include <math.h>

/* Check with the following:
	 sort -n data1M|pr -t -T -n10|tail -100001|head -10
	 part1 1000000 data1M
*/


/* code from http://www.tutorialspoint.com/c_standard_library/c_function_qsort.htm */
//Complexity unspecified
//quicksorts are generally linearithmic in num, on average, calling compar approximately num*log2/(num) times.
//referrence http://www.cplusplus.com/reference/cstdlib/qsort/

int cmpfunc(const void * a, const void * b)
{
    return(*(int*)a - *(int*)b);
}

int main(int argc, char *argv[])
{
	
	//Atoi converts character pointer to int
	int numbersInFile = atoi(argv[1]);
	int numbers[numbersInFile];
	char *filename = argv[2];
	
	FILE *inputFilePtr;
	 /*opens a file in readonly mode*/
  inputFilePtr = fopen(filename,"r");
  
  /*checks if the specified file can be opened*/
  if (!inputFilePtr)
  {
    fprintf(stderr, "can't open input for reading\n");
    exit(-1);
  }
	
	for (int i =0; i < numbersInFile; i++)
		fscanf(inputFilePtr, "%d", &numbers[i]);

	//qsort function part of the standard library	
	//1st param -> Array to be sorted
	//2nd param -> Number of items in array
	//3rd param -> size in bytes of each element in the array
	//4th param -> Function which compares the elements 	 
	qsort(numbers,numbersInFile,sizeof(int),cmpfunc);
	
	int ninetyPercentileArrayNo = floor(numbersInFile * 0.9)-1;
	int nextInteger = ninetyPercentileArrayNo + 1;
	
	
	int found = 0;
	int intValue;
	while (found == 0) 
	{	
	  if (numbers[nextInteger] > numbers[ninetyPercentileArrayNo])
	  {
	    intValue = numbers[nextInteger];
	    found = 1;
	  }
	  else
	  {
	    nextInteger = nextInteger +1;
	  }
	  
	  if (nextInteger == numbersInFile)
	  {
	    intValue = -1;
	  	found = 1;
	  }
	}
	
	printf("The smallest number greater than the 90th Perctile number is:\n%d\n ", intValue); 
	
	
	fclose(inputFilePtr);
	
}

