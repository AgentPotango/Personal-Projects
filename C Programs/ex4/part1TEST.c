#include <stdio.h> //includes standard input & output library (fopen, fclose..)
#include <stdlib.h> // exit, malloc, free, atoi, abs commands
#include <ctype.h> //type checking library

int findMax();

int main()
{
  int arraySize;
  int *array;
  int max;

  printf("Please enter an array size\n");
  
  if (scanf("%d", &arraySize) != 1)
  {
    printf("You must enter a number\n");
    exit(-1);
  }

  array = malloc(arraySize * sizeof(*array));
  
  printf("Please enter the %d values\n",arraySize);
  for (int i=0; i<arraySize; i++)
  {
        
    if (scanf("%d", &array[i]) != 1)
    {
      printf("You must enter a number\n");
      exit(-1);
    }

  }
 
  max = findMax(array, arraySize);
  printf("Max of the array is: %d\n", max);
  return 0;
}


int findMax(int array[], int sizeOfArray)
{
  int max = array[0];

  for (int i=1; i<sizeOfArray; i++)
  {
    if (array[i] > max)
    {
      max = array[i];
    }
  }
  
  return max;
}

