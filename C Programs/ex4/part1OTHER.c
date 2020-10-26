#include <stdio.h> //includes standard input & output library (fopen, fclose..)


int findMax();

int main()
{
  int arraySize;
  int array[] = {1,2,3,4,5};
  
  arraySize  = sizeof(array) / sizeof(int);
  findMax(array[], arraySize);
  
  array[] = {1}
  arraySize  = sizeof(array) / sizeof(int);
  findMax(array[], arraySize);
  


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
  
  printf("Array is: ");
  
  for (i=0; i < arraySize; i++) 
  {
    printf("%d\n",array[i]);
  }
  
  printf("Max is: %d", max);
  
  return 0;
}

