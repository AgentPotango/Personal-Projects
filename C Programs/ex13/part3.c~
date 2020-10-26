#include "graph.h"

int main(int argc,char *argv[])
{
  Graph mygraph;

  read_graph(&mygraph,argv[1]);

  /* you take it from here */

  //print graph
  print_graph(&mygraph);

  int outDegMax = mygraph.table[1].outdegree;
  char* nameMax = mygraph.table[1].name;


  //Loop through all and find max out deg
  for(int i = 1; i < mygraph.MaxSize + 1; i++)
  {
    if(outDegMax < (mygraph.table[i].outdegree))
    {
      nameMax = mygraph.table[i].name;
      outDegMax = mygraph.table[i].outdegree;
    }

  }
  if(outDegMax != 0)
  {
    printf("The largest out-degree node is: %s\n",nameMax );
  }
  else
  {
    printf("Largest out-degree was 0\n");
  }


  int listIn[mygraph.MaxSize + 1];
 
  int inDegMax = 0;
  int MaxIn = 0;
 
  int inDegMin = 0;
  int MinIn = 0;
 
  
  for(int j = 0; j < mygraph.MaxSize + 1; j++)
  {
    listIn[j] = 0;
  }
 
  // Record all List in-degrees (i.e. targets of edges)
  for(int i = 1; i < mygraph.MaxSize + 1; i++)
  {
    //Make a List of the outlist for each source node
    List* sourceGraph = mygraph.table[i].outlist;    

    //Find out the targets and increment the target's in-list by 1
    while(sourceGraph != NULL)
    {
      listIn[sourceGraph-> index] += 1;
      sourceGraph = sourceGraph-> next;      
    }
  }


  inDegMin = listIn[1];

  for(int i = 1; i < mygraph.MaxSize + 1; i++)
  {
    //Find the largest in-degree with it's index
    if(inDegMax < listIn[i])
    {
      MaxIn = i;
      inDegMax = listIn[i];
    }   

    //Find the minimum in-deg which isn't 0 with it's index     
    if((inDegMin > listIn[i] || inDegMin == 0) && listIn[i] != 0)
    {
      MinIn = i;
      inDegMin = listIn[i];
    }
  }
  if(inDegMax != 0)
  {
    printf("The largest in-degree node is: %s\n",mygraph.table[MaxIn].name);
  }
  else
  {
    printf("largest in-degree was 0\n");
  }
  if(inDegMin != 0)
  {
    printf("The smallest in-degree node is: %s\n",mygraph.table[MinIn].name);
  }
  else
  {
    printf("Smallest in-degree was 0\n");
  }  
  return(0);
}



