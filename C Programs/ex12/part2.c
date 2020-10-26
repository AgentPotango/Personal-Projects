#include "graph.h"
int main(int argc,char *argv[])
{
 
  Graph newGraph;

  int startNode = 1;
  read_graph(&newGraph,argv[1]);
  int nodeTotal = 0;

    searchValues values;
    values.nodesCanReach = 0;
    values.largestOutDegNode = 0;    

    searchValues valuesBF;
    valuesBF.nodesCanReach = 0;
    valuesBF.largestOutDegNode = 0;      

  
  int outDegMin = newGraph.table[1].outdegree;
  char* outDegMinName = newGraph.table[1].name;
  int minIndex = 1;

  int outDegMax = newGraph.table[1].outdegree;
  char* outDegMaxName = newGraph.table[1].name;
  int maxIndex = 1;

  //Get the minimum & maximum out degree
  for(int i = 2; i < newGraph.MaxSize + 1; i++)
  {
    if(newGraph.table[i].outdegree != 0)
    {
      if((outDegMin > newGraph.table[i].outdegree) || outDegMin == 0)
      {
        outDegMinName = newGraph.table[i].name;
        outDegMin = newGraph.table[i].outdegree;
        minIndex = i;
      }
      else if ((outDegMax < newGraph.table[i].outdegree))
      {
        outDegMaxName = newGraph.table[i].name;
        outDegMax = newGraph.table[i].outdegree;
        maxIndex = i;
      }
    }
  }

   //Set all nodes visited to 0
    for(int i = 1; i < newGraph.MaxSize + 1; i++)
    {
      newGraph.table[i].visited = 0;
    }
    
    int canReach = 0;

    depth_first(&newGraph, startNode, &values, nodeTotal);

    startNode = minIndex;
    printf("\nDF Search: \n");
    printf("The start point is %s (the node with the smallest amount of out-degrees)\n", outDegMinName);
    printf("It has %d out-degree nodes\n", outDegMin);
    printf("The node with the most out degree's is %s\n", outDegMaxName);
    printf("It has %d out-degree nodes\n", outDegMax);

    printf("\n\nThe number of nodes reachable is: %d\n", values.nodesCanReach);
    printf("The highest node it can reach with the most out-degree nodes is: %s\n", newGraph.table[values.largestOutDegNode].name);


    if (newGraph.table[maxIndex].visited == 1)
    {
      printf("The Lowest amount of out-degree node: %s can reach the one with the largest: %s\n", outDegMinName, outDegMaxName);
    }
    else 
    {
      char* nextLargestOutDegName = NULL;
      int nextLargestOutDeg = 0;
      int nextLargestIndex = 0;
      for(int i = 1; i < newGraph.MaxSize + 1; i++)
      {
        if (newGraph.table[i].visited == 1)
        {
          canReach ++;

          if (nextLargestOutDeg < newGraph.table[i].outdegree)
          {
            nextLargestOutDeg = newGraph.table[i].outdegree;
            nextLargestIndex = i;
            nextLargestOutDegName = newGraph.table[i].name;
          }
        }
      }
      printf("The Lowest amount of out-degrees node: %s can't reach the one with the largest: %s with %d out-degrees\n", outDegMinName, outDegMaxName, outDegMax);
      printf("The Lowest amount of out-degrees node: %s can reach one as large as: %d which is node: %s\n", outDegMinName, nextLargestOutDeg, nextLargestOutDegName);
      if (canReach == newGraph.MaxSize)
      {
        printf("The Lowest amount of out-degrees node: %s can reach all nodes\n", outDegMinName);
      }
      else
      {
        printf("The Lowest amount of out-degrees node: %s can't reach all nodes\n", outDegMinName);
      }

    }
    

    breadth_first(&newGraph, startNode, &valuesBF);
    printf("\nBF Search: \n");
    printf("The start point is %s (the node with the smallest amount of out-degrees)\n", outDegMinName);
    printf("It has %d out-degree nodes\n", outDegMin);
    printf("The node with the most out degree's is %s\n", outDegMaxName);
    printf("It has %d out-degree nodes\n", outDegMax);

    printf("\n\nThe number of nodes reachable is: %d\n", valuesBF.nodesCanReach);
    printf("The highest node it can reach with the most out-degree nodes is: %s\n", newGraph.table[valuesBF.largestOutDegNode].name);

    
}//main
