#include <stdio.h> //includes standard input & output library (fopen, fclose..)
#include <stdlib.h> // exit, malloc, free, atoi, abs commands
#include <ctype.h> //type checking library
#include <math.h> //math functions.

void makeBoard(int *array[], int height, int width);

int main()
{
  int width;
  int **array;
  int height;
  
  printf("Please enter the width for the chessboard\n");
  
  if (scanf("%d", &width) != 1 || width > 2147483647 || width < 0)
  {
    printf("You must enter a positive number up to  2,147,483,647\n");
    exit(-1);
  }
  
  printf("Please enter the height for the chessboard\n");
  
  if (scanf("%d", &height) != 1 || height > 2147483647 || height < 0)
  {
    printf("You must enter a positive number up to  2,147,483,647\n");
    exit(-1);
  }
  
  array = malloc(width * sizeof(*array));
  for (int i = 0; i < height; i++)
    array[i] = malloc(height * sizeof(*array));
  
  makeBoard(array, height, width);
  
  return 0;
 }
 
void makeBoard(int *array[], int height, int width)
{
 
  int sum;
   
  enum colours {white, black};
   
  for (int i=0; i < height; i++)
  {
    for (int j=0; j < width; j++)
    {
      sum = i + j;
      //black pieces are odd numbered (prints 1 out due to enum indexing)
      if (sum % 2 == 1)
      {
        array[i][j] = black;
        printf("%d ", array[i][j]);
      }
      //white pieces are even numbered (prints 0 out due to enum)
      else
      {
        array[i][j] = white;
        printf("%d ", array[i][j]);
      }
    }
    printf("\n");
  }
} 

