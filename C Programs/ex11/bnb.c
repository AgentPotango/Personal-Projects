
// bnb.c
// (C) Joshua Knowles 2010-2013
// j.knowles@manchester.ac.uk

//branch and bound

//code adapted from cs-lab-man

#include <stdio.h>
#include <stdlib.h>
#include <assert.h>  // we are using assert.h to check some conditions remain true
#include <math.h>
#include <stdbool.h>

#define DOUB_MAX 10e30  // a large number, must be greater than max value of any solution
#define SIZE 100000 // an estimate of how large the priority queue could become
#define NITEMS 2000 // an upper limit of the number of items

FILE *fp;  // file pointer for reading the input files
int Capacity;     // capacity of the knapsack (total weight that can be stored)
int Nitems;    // number of items in the knapsack problem instance
int *item_weights;  // vector of item weights
int *item_values;  // vector of item profits or values
int *temp_indexes;  // temporary item indexes for sorting items by value/weight
int QueueSize=0; // the number of items currently stored in the priority queue
int QUIET=0; // can be set to 1 to suppress output
int j;
int weightW;

// the structure for a solution. All of this will be stored in the priority queue
typedef struct solution_structure
{
  int solution_vec[NITEMS+1];  // binary solution vector; 
  //e.g. solution_vec[1]=1 means first item is packed in knapsack.
  //     solution_vec[1]=0 means first item is NOT in knapsack. 
  // NB: solution_vec[0] is meaningless.
  
  int val;               // its value
  int fixed;             // the number of items that are fixed to either 0 or 1, not '*'
  double bound;          // the upper bound value of the solution
}struc_sol;

struc_sol *pqueue;  // the knapsack solutions. To be stored in a priority queue

// function prototypes
extern void read_knapsack_instance(char *filename);
extern void sort_by_ratio();
extern int check_evaluate_and_print_sol(int *sol,  int *total_value, int *total_weight);
void branch_and_bound(int *final_sol);
void copy_array(int *from, int *to);

// The following four functions implement a priority queue.
// They are based on the functions given in Robert Sedgwick's book, Algorithms in C.
void upheap(int qsize)
{
  // upheap reorders the elements in the heap (queue) after an insertion

  struc_sol temp_element;
  temp_element=pqueue[qsize]; pqueue[0].bound=DOUB_MAX;
  
  while (pqueue[qsize/2].bound<=temp_element.bound)
    {
      pqueue[qsize]=pqueue[qsize/2]; qsize=qsize/2;
    }
  pqueue[qsize]=temp_element;
}

void insert(struc_sol element)
{
  assert(QueueSize<SIZE-1);
  pqueue[++QueueSize]=element;
  upheap(QueueSize);
}

void downheap(int qindex)
{
  // down heap reorders the elements in the heap (queue) after a removal

  int j;
  struc_sol temp_element;
  temp_element = pqueue[qindex];
  while(qindex<= QueueSize/2)
    {
      j=qindex+qindex;
      if(j<QueueSize && pqueue[j].bound<pqueue[j+1].bound)
	j++;
      if(temp_element.bound>=pqueue[j].bound)
	break;
      pqueue[qindex]=pqueue[j]; qindex=j;
    }
  pqueue[qindex]=temp_element;
}

struc_sol removeMax()
{
  struc_sol head=pqueue[1];
  pqueue[1]=pqueue[QueueSize--];
  downheap(1);
  return head;
}
// End priority queue functions.


void print_sol(struc_sol *sol)
{
  // prints a solution in the form 000100xxxx etc 
  // with x's denoting the part of the solution not yet fixed (determined)

  int i;
  printf("%d %g ", sol->val, sol->bound);
  for(i=1;i<=sol->fixed;i++)
    printf("%d", sol->solution_vec[i]);
  while(i<=Nitems)
    {
      printf("x");
      i++;
    }    
  printf("\n");
}

void frac_bound(struc_sol *sol, int fix)
{
  // Updates the values sol->val and sol->bound

  // Computes the fractional knapsack upper bound
  // given a binary vector of items (sol->solution_vec), 
  // where the first
  // "fix" of them are fixed. All that must be done
  // is compute the value of the fixed part; then
  // add to that the value obtained by adding in
  // items beyond the fixed part until the capacity
  // is exceeded. For the exceeded capacity, the fraction
  // of the last item added which would just fill the knapsack
  // is taken. This fraction of profit/value is added to the
  // total. This is the required upper bound.

  // Everything above assumes items are sorted in decreasing
  // profit/weight ratio

 
  //Total Weight
  weightW = 0;

  //Add the weights + values of the items in the solution
  for (int i=1; i<=fix; i++)
  {
    if(sol-> solution_vec[i] == 1)
    {
      sol -> val += item_values[temp_indexes[i]];
      weightW += item_weights[temp_indexes[i]];
    }
  }

  //current fix amount
  int fixAmount = fix;

  //Keep fixing to generate a bound and update weights and values
  while(weightW + item_weights[temp_indexes[fixAmount+1]] < Capacity && fixAmount < Nitems)
  {
    fixAmount++;
    sol -> bound += item_values[temp_indexes[fixAmount]];
    weightW += item_weights[temp_indexes[fixAmount]];
  }

  //Add to the bound the current solution value
  sol -> bound += sol -> val;

  //If all the weight has not been used, use a fraction of it
  if ((Capacity - weightW) > 0)
  {
    double leftWeight = (double)(Capacity - weightW)/(double)(item_weights[temp_indexes[fixAmount+1]]);
    sol->bound += leftWeight * (double)item_values[temp_indexes[fixAmount+1]];
  }

}

int main(int argc, char *argv[1])
{
  int *final_sol;    // binary solution vector indicating items to pack
  int total_value, total_weight;  // total value and total weight of items packed

  read_knapsack_instance(argv[1]);

  assert(NITEMS>=Nitems);
 
  if((final_sol = (int *)malloc((Nitems+1)*sizeof(int)))==NULL)
    {      
      fprintf(stderr,"Problem allocating solution vector final_sol\n");
      exit(1);
    }

  sort_by_ratio();

  if((pqueue = (struc_sol *)malloc(sizeof(struc_sol)*SIZE))==NULL)
    {      
      fprintf(stderr,"Problem allocating memory for priority queue. Reduce SIZE.\n");
      exit(1);
    }

  branch_and_bound(final_sol);
  printf("Branch and Bound Solution of Knapsack is:\n");
  check_evaluate_and_print_sol(final_sol,&total_value,&total_weight);
  return(0);
}


void branch_and_bound(int *final_sol)
{
  // branch and bound

  // start with the empty solution vector
  // compute its value and its bound
  // put current_best = to its value
  // store it in the priority queue
  
  // LOOP until upper bound is not greater than current_best:
  //   remove the first item in the queue
  //   construct two children, 1 with a 1 added, 1 with a O added
  //   FOREACH CHILD:
  //     if infeasible, discard child
  //     else
  //       compute the value and bound
  //       if value > current_best, set current_best to it, and copy child to final_sol
  //       add child to the queue
  // RETURN
  

  /* YOUR CODE GOES HERE */

  struc_sol parent, child1, child2;
  
  //empty solution vector
  for (int i=0; i<=Nitems; i++)
  {
    parent.solution_vec[i] = 0;
  }
  
  parent.val = 0;
  parent.fixed = 0;
  parent.bound = 0.0;

  //Compute value + bound
  frac_bound(&parent, parent.fixed);

  int current_best;

  //store bound
  current_best = parent.val;

  //inserted
  insert(parent);
 

  while(pqueue[1].bound > current_best)
  {
    
    //Construct 2 children
    child1 = pqueue[1];
    child2 = pqueue[1];

    //Initialize
    child1.val = 0;
    child1.fixed = pqueue[1].fixed + 1;
    child1.bound = 0.0;

    //initiliaze
    child2.val = 0;
    child2.fixed = pqueue[1].fixed + 1;
    child2.bound = 0.0;

    //Set child 1 to 1 and child 2 to 0
    child1.solution_vec[child1.fixed] = 1;
    child2.solution_vec[child2.fixed] = 0;

    //Remove first item
    removeMax();

    //compute value + bound
    frac_bound(&child1, child1.fixed);


    int total_weight1 = weightW;

    //if feasible and greater than current best Use child1 as currentBest 
    if (child1.val > current_best && total_weight1 <= Capacity)
    {
      current_best = child1.val;
   
        for(int i = 1;i <= Nitems; i++)
        {
          final_sol[i] = child1.solution_vec[i];
        }
    }
     
    //compute Value + bound
    frac_bound(&child2, child2.fixed);

    int total_weight2 = weightW;

    //If feasible and greater than current best Use child 2 as currentBest
    if (child2.val > current_best && total_weight2 <= Capacity)
    {
      current_best = child2.val;
     
      for(int i = 1; i <= Nitems; i++)
      {
        final_sol[i] = child2.solution_vec[i];
      }

    }


    //add child1 to queue if feasible
    if (total_weight1 <= Capacity)
    {
      insert(child1);
    }

    //add child2 to queue if feasible
   
    if (total_weight2 <= Capacity)
    {
      insert(child2);
    }
   
  }
}
  

void copy_array(int *from, int *to)
{
  // This copies Nitems elements of one integer array to another. 
  // Notice it should be called with "to" and "from" pointing to the first, not the
  // zeroth, element of the solution_vec array
  
  int i;
  for(i=0;i<Nitems;i++)
    {
      to[i]=from[i];
    }
}
