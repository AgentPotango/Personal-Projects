
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
void merge(int left, int mid, int right, int(*compar)(const void *, const void *))
{
  // sublist sizes
  int left_size = mid - left + 1;
  int right_size = right - mid;

  // counts
  int i, j, k;

  // create left and right arrays
  B *left_list = (B*) malloc(left_size*sizeof(B));
  B *right_list = (B*) malloc(right_size*sizeof(B));

  // copy sublists
  for (i = 0; i < left_size; i++)
    left_list[i] = list[left + i];

  for (j = 0; j < right_size; j++)
    right_list[j] = list[mid + j + 1];

  // reset counts
  i = 0; j = 0;

  for (k = left; k <= right; k++)
  {
    if (j == right_size)
      list[k] = left_list[i++];
    else if (i == left_size)
      list[k] = right_list[j++];
    // here we call the given comparision function
    else if (compar(&left_list[i], &right_list[j]) <= 0)
      list[k] = left_list[i++];
    else
      list[k] = right_list[j++];
  }
}

void sort(int left, int right, int(*compar)(const void *, const void *))
{
  if (left < right)
  {
    // find the pivot point
    int mid = (left + right) / 2;

    // recursive step
    sort(left, mid, compar);
    sort(mid + 1, right, compar);

    // merge resulting sublists
    merge(left, mid, right, compar);
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

  sort(0,N,comp_on_price);
  
  // For Part 2 this function
  // (1) asks the user if they would like to sort their search results
  // (2) asks for the most important field (or key), the next most etc
  // (3) calls your sort function
  

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

