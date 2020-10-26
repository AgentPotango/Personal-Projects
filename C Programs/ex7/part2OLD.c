
#include <stdlib.h>
#include <stdio.h>
#include <math.h>

FILE *fp;

typedef struct book{
  double rating;
  double price;
  double relevance;
  int ID;
}B;

B *list;

/* 
 *We need 2 arrays 'a' and 'b', of equal size
 *Here 'a' is the primary array (i.e which contains initial 
     input, and final output)
 *And 'b' is the temporary array,
     used for merging 2 sorted half's in 'a' 
 */
 
/* code copied from
http://vinayakgarg.wordpress.com/2012/11/08/merge-sort-program-in-c/
*/
  
void merge(int low, int mid, int high, int(*compar)(const void *, const void *))
{
	  
	  
	 //Sizes of the two sublists
	 //(low starts from 0 and high = N)
	  int lowSize = mid - low + 1;
	  int highSize = high - mid;
	  
	  //dynamically assigning array size
	  B *lowerList = (B*) malloc(lowSize * sizeof(B));
    B *higherList = (B*) malloc(highSize * sizeof(B));
    
    //declaring variables to hold list indexes due to compiler not being
    //c99
    int i,j,k;
    
    //making lowerlist
    for (i = 0; i < lowSize; i++)
      lowerList[i] = list[low + i];

		//making upperlist
    for (j = 0; j < highSize; j++)
      higherList[j] = list[mid + j + 1];
    	
  	//reseting the counts because of the previous sublist forloops
    i = 0; j = 0;
    

  	//completing indexing of mergesort
  	for (k = low; k <= high; k++)
    {
      if (j == highSize)
        list[k] = lowerList[i++];
      else if (i == lowSize)
        list[k] = higherList[j++];
      // here we call the given comparision function
      //check this
      else if (compar(&lowerList[i], &higherList[j]) <= 0)
        list[k] = lowerList[i++];
      else
        list[k] = higherList[j++];
    }
	
	free(lowerList);
	free(higherList);
}

    
  
void mergesort(int low, int high, int(*compar)(const void *, const void *))
{
	if (low < high)
  {
    // find the pivot point
    int mid = (low + high) / 2;

    // recursive step
    mergesort(low, mid, compar);
    mergesort(mid + 1, high, compar);

    // merge resulting sublists
    merge(low, mid, high, compar);
   
  }
}


int read_file(char* infile, int N)
{
  int c;
  if((fp=fopen(infile, "rb")))
    {
      fscanf(fp, "%*s\t%*s\t%*s\t%*s\n");
      c=0;
      while((!feof(fp))&&(c<N))
	{
	  fscanf(fp, "%lf\t%lf\t%lf\t%d\n", &list[c].rating,  &list[c].price, &list[c].relevance, &list[c].ID);	  
	  c++;
	}
      fclose(fp);      
    }
  else
    {
      fprintf(stderr,"%s did not open. Exiting.\n",infile);
      exit(-1);
    }
  return(c);
}

int comp_on_rating(const void *a, const void *b)
{
  if ((*(B *)a).rating < (*(B *)b).rating)
    return -1;
  else if ((*(B *)a).rating > (*(B *)b).rating)
    return 1;
  else
    return 0;  
}

int comp_on_relev(const void *a, const void *b)
{
 
  if ((*(B *)a).relevance < (*(B *)b).relevance)
    return -1;
  else if ((*(B *)a).relevance > (*(B *)b).relevance)
    return 1;
  else
    return 0;  
}

int comp_on_price(const void *a, const void *b)
{
 
  if ((*(B *)a).price < (*(B *)b).price)
    return 1;
  else if ((*(B *)a).price > (*(B *)b).price)
    return -1;
  else
    return 0;  
}

void user_interface(int N)
{

  // For Part 1 this function calls the sort function to sort on Price only

  //mergesort(0,N,comp_on_price);
	
	  // For Part 2 this function
  // (1) asks the user if they would like to sort their search results
  // (2) asks for the most important field (or key), the next most etc
  // (3) calls your sort function
  
  int choice;
  int noOfFields;
  int fieldChoice[4] = {0};
  printf("Would you like to sort this file?\n\n");
  printf("Yes (1)\n");
  printf("No (2)\n");
  
  scanf("%d",&choice);
  
	if (choice == 1)
  {
    
    printf("How many fields would you like to sort by?\n\n");
    printf("1 (1)\n");
    printf("2 (2)\n");
    printf("3 (3)\n");
    
    scanf("%d", &noOfFields);
		
		if (noOfFields != 1 && noOfFields !=2 && noOfFields!= 3)
		{
		  printf("Please choice numbers 1 to 3\n");
    	exit(-1);
    }
		
    if (noOfFields ==1)
    {
 		  printf("Which is the most important field you wish to sort by?\n\n"); 	
      printf("Price (1)\n");
 		  printf("Relevance (2)\n");
      printf("Rating (3)\n");
      scanf("%d", &fieldChoice[0]);
    
      if (fieldChoice[0] == 1)
      {
    	  fieldChoice[1] = 1;
      }
    	else if (fieldChoice[0] == 2)
    	{
      	fieldChoice[2] = 1;
    	}
    	else if (fieldChoice[0] == 3)
    	{
    		fieldChoice[3] = 1;
    	} 
    	else 
    	{
    		printf("Please choice numbers 1 to 3\n");
    		exit(-1);
    	}
    }
    else if (noOfFields >= 2)
    {
      printf("Which is the most important field you wish to sort by?\n\n"); 	
      printf("Price (1)\n");
 		  printf("Relevance (2)\n");
      printf("Rating (3)\n");
      scanf("%d", &fieldChoice[0]);
    
      if (fieldChoice[0] == 1)
      {
    	  fieldChoice[1] = 1;
      }
    	else if (fieldChoice[0] == 2)
    	{
      	fieldChoice[2] = 1;
    	}
    	else if (fieldChoice[0] == 3)
    	{
    		fieldChoice[3] = 1;
    	} 
    	else 
    	{
    		printf("Please choice numbers 1 to 3\n");
    		exit(-1);
    	}
    	printf("Which is the 2nd most important field you wish to sort by?\n\n"); 
   		if (fieldChoice[1] == 1)
   		{
   	 	 printf("Relevance (2)\n");
     	 printf("Rating (3)\n");    
    	}	
   		else if (fieldChoice[2] ==1)
   		{
   	  	printf("Price (1)\n");
 		  	printf("Rating (3)\n");
 			}
 			else
 			{
 		 	 printf("Price (1)\n");
 		  	printf("Relevance (2)\n");
    	}

   		scanf("%d", &fieldChoice[0]);
    
    	if (fieldChoice[0] == 1)
    	{
    		fieldChoice[1] = 2;
    	} 	
    	else if (fieldChoice[0] == 2)
    	{
      	fieldChoice[2] = 2;
   	  }
    	else if (fieldChoice[0] == 3)
    	{
    		fieldChoice[3] = 2;
    	}
    	else 
    	{
    		printf("Please choice numbers 1 to 3\n");
    		exit(-1);
    	}
    }
   
   //printf("choice 1: %d choice 2: %d choice3 %d \n",fieldChoice[1], 
   //fieldChoice[2],fieldChoice[3]);
   
   if (noOfFields == 3)
   {
     if (fieldChoice[1] == 0)
       mergesort(0,N-1,comp_on_price);
     else if (fieldChoice[2] == 0)
       mergesort(0,N-1,comp_on_relev);
     else if (fieldChoice[3] == 0)
       mergesort(0,N-1,comp_on_rating); 
   }
   
   if (fieldChoice[1] == 2)
     mergesort(0,N-1,comp_on_price);
   else if (fieldChoice[2] == 2)
     mergesort(0,N-1,comp_on_relev);
   else if (fieldChoice[3] == 2)
     mergesort(0,N-1,comp_on_rating);
   
   if (noOfFields == 1)
   {
  	 if (fieldChoice[1] == 1)
    	 mergesort(0,N-1,comp_on_price);
   	else if (fieldChoice[2] == 1)
    	 mergesort(0,N-1,comp_on_relev);
   	else if (fieldChoice[3] == 1)
    	 mergesort(0,N-1,comp_on_rating); 
   }
   
   if (noOfFields >= 2)
   {
     if (fieldChoice[1] == 2)
       mergesort(0,N-1,comp_on_price);
     else if (fieldChoice[2] == 2)
   	   mergesort(0,N-1,comp_on_relev);
   	 else if (fieldChoice[3] == 2)
       mergesort(0,N-1,comp_on_rating);
   
     if(fieldChoice[1] == 1)
    	 mergesort(0,N-1,comp_on_price);
   	 else if (fieldChoice[2] == 1)
    	 mergesort(0,N-1,comp_on_relev);
   	 else if (fieldChoice[3] == 1)
    	 mergesort(0,N-1,comp_on_rating);
   }
   
  
  }
  else
	{
	  printf("You must choose to sort or pick a number: either 1 or 2\n");
	  exit(-1);
	}
}
 

void print_results(int N)
{
  int i;
  if((fp=fopen("top20.txt","w")))
    {
      for(i=N-1;i>=N-20;i--)
	{
	  
	  printf("%g %g %g %d\n", list[i].rating, list[i].price, list[i].relevance, list[i].ID);
	  fprintf(fp, "%g %g %g %d\n", list[i].rating, list[i].price, list[i].relevance, list[i].ID);
	  
	}
      fclose(fp);
    }
  else
    {
      fprintf(stderr,"Trouble opening output file top20.txt\n");
      exit(-1);
    }

}


int main(int argc, char *argv[])
{
  int N;

  if(argc!=3)
    {
      fprintf(stderr, "./exec <input_size> <filename>\n");
      exit(-1);
    }

  N=atoi(argv[1]);

  list = (B *)malloc(N*sizeof(B));
  
  N=read_file(argv[2], N);
  
  user_interface(N);
  
  print_results(N);

  return(0);
}

