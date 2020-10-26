#include <stdio.h> //includes standard input & output library (fopen, fclose..)


int findMax();

int main()
{
  int arraySize;
  int array[] = {1,2,3,4,5};
  
  arraySize  = sizeof(array) / sizeof(int);
  findMax(array, arraySize);
  
  int array2[] = {1};
  arraySize  = sizeof(array2) / sizeof(int);
  findMax(array2, arraySize);
  
  int array3[] = {2147483647,-2147483648};
  arraySize  = sizeof(array3) / sizeof(int);
  findMax(array3, arraySize);
  
  int array4[] = {-5,-17,-4};
  arraySize  = sizeof(array4) / sizeof(int);
  findMax(array4, arraySize);
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
  
  printf("Array is: \n");
  
  for (int i=0; i < sizeOfArray; i++) 
  {
    printf("%d\n",array[i]);
  }
  
  printf("Max is: %d\n", max);
  
  return 0;
}

