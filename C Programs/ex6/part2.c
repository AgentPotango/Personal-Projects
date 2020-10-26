#include<stdio.h>
#include<stdlib.h>
//#define SHOWPASS
//code copied from http://en.wikipedia.org/wiki/Radix_sort

/*void print(int *a, int n)
{
  int i;
  for (i = 0; i < n; i++)
    printf("%d\t", a[i]);
}*/

 
void radixsort(int *a, int n)
{
  int i, b[n], m = a[0], exp = 1;
  for (i = 1; i < n; i++)
  {
    if (a[i] > m)
      m = a[i];
  }
 
  while (m / exp > 0)
  {
    int bucket[10] ={  0 };
    for (i = 0; i < n; i++)
      bucket[(a[i] / exp) % 10]++;
    for (i = 1; i < 10; i++)
      bucket[i] += bucket[i - 1];
    for (i = n - 1; i >= 0; i--)
      b[--bucket[(a[i] / exp) % 10]] = a[i];
    for (i = 0; i < n; i++)
      a[i] = b[i];
    exp *= 10;
 
    #ifdef SHOWPASS
      printf("\nPASS   : ");
      print(a, n);
    #endif
  }
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
  
  int value;
	int k = 0;
	for (int i =0; i < numbersInFile;i++)
	{
		//fscanf(inputFilePtr, "%d", &value);
	  /*if (value >= 1000000)
	  {*/
		 // numbers[k] = value;
		  //k++;
		/*}*/
		fscanf(inputFilePtr, "%d", &numbers[i]);
	}
 
  printf("%d",0);
  /*int numbers2[k];
	
	for (int i = 0; i < k; i++)
	{
	  numbers2[i] = numbers[i];
	}*/
	 
  //printf("\nARRAY  : ");
  //print(&numbers2[0], k);
  //printf("%d",numbers2[0]);
  radixsort(&numbers[0], k);
 
  //printf("\nSORTED : ");
  //print(&numbers2[0], k);
  //printf("\n");
  
  int intValue;
	if (numbers[0] == 0)
	  intValue = -1;
	else
		intValue = numbers[0];
	printf("The smallest number greater than the 90th Perctile number is:\n%d\n ", intValue); 
  return 0;
}

