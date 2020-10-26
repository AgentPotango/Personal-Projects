#include <stdio.h>
#include <stdlib.h>
#include <math.h>

/* Check with the following:
	 sort -n data1M|pr -t -T -n10|tail -100001|head -10
	 part1 1000000 data1M
*/

/*quicksort code from http://rosettacode.org/wiki/Sorting_algorithms/Quicksort#C
	quicksort algorithm works by swapping elements within the array, to avoid 
	the memory allocation of more arrays. 
	More Info read: http://en.wikipedia.org/wiki/Quicksort
*/

/* continue statement passes control to the next iteration of the nearest 
	 enclosing do, for, or while statement in which it appears, bypassing any 
	 remaining statements in the do, for, or while statement body.
*/
void quick_sort (int *a, int n) 
{
  if (n < 2)
    return;
    //pivot is middle element
    int p = a[n / 2];
    //left array (first index of array)
    int *l = a;
    //right array (last index of array)
    int *r = a + n - 1;
    while (l <= r) 
    {
      if (*l < p) 
      {
        l++;
        continue;
      }
      if (*r > p) 
      {
        r--;
        continue; 
        // we need to check the condition (l <= r) every time we change the value of l or r
      }
      //holds left temporarily
      int t = *l;
      //increments left
      //decrements right
      //swaps array[left] with array[right
      *l++ = *r;
      *r-- = t;
    }
    //quicksort array from 1st index to right
    quick_sort(a, r - a + 1);
    //quicksort array from left to last indez
    quick_sort(l, a + n - l);
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

	int n = sizeof numbers/sizeof(numbers[0]);	 
	quick_sort(numbers,n);
	
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
	return 0;	
}

