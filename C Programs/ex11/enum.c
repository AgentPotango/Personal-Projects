
// enum - full enumeration of knapsack solutions
// (C) Joshua Knowles, 2010-2013
// for issues: email j.knowles@manchester.ac.uk

#include <stdio.h>
#include <stdlib.h>
#include <math.h>
#include <stdbool.h>

FILE *fp;  // file pointer for reading the input files
int Capacity;     // capacity of the knapsack (total weight that can be stored)
int Nitems;    // number of items available
int *item_weights;  // vector of item weights
int *item_values;  // vector of item profits or values
int *temp_indexes;  // list of temporary item indexes for sorting items by value/weight
int QUIET=0; // this can be set to 1 to suppress output

extern void read_knapsack_instance(char *filename);
extern void print_instance();
extern void sort_by_ratio();
extern int check_evaluate_and_print_sol(int *sol,  int *total_value, int *total_weight);
void enumerate();
int next_binary(int *str, int Nitems);


int main(int argc, char *argv[])
{
  read_knapsack_instance(argv[1]);
  print_instance();
  enumerate();
  return(0);
}

void enumerate()
{
  // Do an exhaustive search (aka enumeration) of all possible ways to pack
  // the knapsack.
  // This is achieved by creating every binary solution vector of length Nitems.
  // For each solution vector, its value and weight is calculated.


  int i;  // item index
  int solution[Nitems+1];   // (binary) solution vector representing items packed
  int best_solution[Nitems+1];  // (binary) solution vector for best solution found
  int best_value; // total value packed in the best solution
  //double j=0;
  int total_value, total_weight; // total value and total weight of current knapsack solution
  int infeasible;  // 0 means feasible; -1 means infeasible (violates the capacity constraint)
  //int solutionNo;
  int count = 0;

  // set the knapsack initially empty
  for(i=1;i<=Nitems;i++)
    solution[i]=0;

  QUIET=1;

  best_value=0;



 while(!(next_binary(&solution[1], Nitems)))
	 {
	 	count ++;
	 	printf("Percentage Complete: %f \n", count/(pow(2,20) -1) *100);

	    /* ADD CODE IN HERE TO KEEP TRACK OF FRACTION OF ENUMERATION DONE */


      infeasible=check_evaluate_and_print_sol(solution, &total_value, &total_weight);  // calculates the value and weight and feasibility
      /* ADD CODE IN HERE TO KEEP TRACK OF BEST SOLUTION FOUND*/
       if (!infeasible)
        {
           if (total_value > best_value)
           {
              for (int w = 1; w <= Nitems; w ++)
              {
                best_solution[w] = solution[w];
                //printf("Item %d: %d\n", i, best_solution[i]);
              }
                best_value = total_value; 
           }
        }
    
      


    
 /* ADD CODE TO PRINT OUT BEST SOLUTION */
        int totalW = 0;
        int totalV = 0;
	if (count == pow(2,20) -1)
 	{
 		printf("Best Solution: \n");
 		for(int item = 1; item <= Nitems; item++)
    	{
      		if(best_solution[item]==1)
      		{
      			totalW += item_weights[item];
      			totalV += item_values[item];
      			printf("Item: %d Weight: %d, Value: %d\n", item, item_weights[item], item_values[item]);
     		}
      	
		}
 		printf("Total Value: %d Total Weight: %d\n", totalV, totalW);
 	}
 


  }
}



int next_binary(int *str, int Nitems)
{
  // Called with a binary string of length Nitems, this 
  // function adds "1" to the string, e.g. 0001 would turn to 0010.
  // If the string overflows, then the function returns 1, else it returns 0.
  int i=Nitems-1;
  while(i>=0)
    {
      if(str[i]==1)
	{
	  str[i]=0;
	  i--;
	}
      else
	{
	  str[i]=1;
	  break;
	}
    }
  if(i==-1)
    return(1);
  else
    return(0);

}
