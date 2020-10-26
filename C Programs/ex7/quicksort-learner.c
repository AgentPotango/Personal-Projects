/*
Compile:
gcc quicksort-learner.c -o qs -lm

Run: 
./qs
*/


#include <stdlib.h>
#include <stdio.h>
#include <math.h>

FILE *fp;

int N;
int gswap=0;
int gcalls=0;

// Adapted from Robert Sedgwick, Algorithms in C.
sedgewick_qs(int *a, int l, int r)
{
  gcalls++;
  int v, i, j, t, k;
  if(r>l)
    {
      v=a[r]; i=l-1; j=r;
      printf("piv=%d\n",v);
      for(;;)
	{
	  while(a[++i]<v);
	  while(a[--j]>v);
	  if(i>=j)
	    break;
	  //just for info - not part of the algorithm
	  if(i!=j)
	    {
	      printf("swap ");
	      gswap++;
	    }
	  //END just for info
	  t=a[i]; a[i]=a[j]; a[j]=t;
	}
       //just for info - not part of the algorithm
      if(i!=r)
	{
	  printf("swap\n");
	  gswap++;
	}
      //END just for info
      t=a[i]; a[i]=a[r]; a[r]=t;


      for(k=0;k<l;k++)
	printf("__ ");
      for(k=l;k<=r;k++)
	printf("%2d ",a[k]);
      for(k=r+1;k<N;k++)
	printf("__ ");
      printf("\n");


      sedgewick_qs(a, l, i-1);
      sedgewick_qs(a, i+1, r);
    }

}
 

int main(int argc, char *argv[])
{
  int i;
  int A[10];
  char c[5];
  int choice;
  printf("Look at how quicksort works on some different inputs\n\n");
  
  printf("Choose from the following\n");
  printf("Ascending ordered input (1)\n");
  printf("Descending ordered input (2)\n");
  printf("Many repeated values in the input (3)\n");
  printf("Random (standard) input (4)\n\n");

  printf("Select your choice (1,2,3,4).\n");
  fgets(c,5,stdin);
  choice = atoi(c);
  
  //  printf("%d\n", choice);

  switch(choice)
    {
    case 1:      // Input is ascending order
      {
	printf("Your choice: Ascending order\n");
	for(i=0;i<10;i++)
	  A[i]=i+1;
	break;
      }
    case 2:
      {
	// Input is descending order
	printf("Your choice: Descending order\n");
	for(i=0;i<10;i++)
	  A[i]=10-i;
	break;
      }
    case 3:
      {
	// Input is all the same value
	printf("Your choice: Repeated values\n");
	for(i=0;i<10;i++)
	  A[i]=2;
	break;
      }      
    case 4:
      {
	// Create some random-looking order
	printf("Your choice: Random input\n");
	for(i=0;i<10;i++)
	  A[i]=(i*7)%13;
	break;
      }
    default:
      { // another random looking order
	printf("Default choice: Random input\n");
	for(i=0;i<10;i++)
	  A[i]=(i*12)%17;
      }
    }

  


  for(i=0;i<10;i++)
    printf("%2d ",A[i]);
  printf("\n");

 
  N=10;
  sedgewick_qs(A, 0, 9);
  
  for(i=0;i<10;i++)
    printf("%2d ",A[i]);
  printf("\n");

  printf("%d recursive calls\n",gcalls);
  printf("%d swaps\n");
  

}


