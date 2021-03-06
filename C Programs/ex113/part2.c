#include "graph.h"
#include <math.h>

char* largestOutDegreeNode(Graph *mygraph)
{
	
  int outDegMax = mygraph->table[1].outdegree;
  char* nameMax = mygraph->table[1].name;

  //Loop through all and find max out deg
  for(int i = 1; i < mygraph->MaxSize + 1; i++)
  {
    if(outDegMax < (mygraph->table[i].outdegree))
    {
      nameMax = mygraph->table[i].name;
      outDegMax = mygraph->table[i].outdegree;
    }

  }
  if(outDegMax != 0)
  {
    //printf("The largest out-degree node is: %s\n",nameMax );
  }
  else
  {
    //printf("Largest out-degree was 0\n");
  }
  
  return(nameMax);
  
  
 }
 
void heuristic(Graph *graph, int source, int targetNode, int type)
 {
 		//int largest = 100;
 		int found = 0;
 		char* target;
 		
 		if (type == 1)
 		{
 			target = largestOutDegreeNode(graph);
 			printf("Target Node (Largest Outdegree Node): %s\n", target);
 		}
 		 		
 		
 		int current = source;
 		graph->table[current].visited = 2;
 		
 		while (found == 0 && graph->table[current].outlist != NULL)
 		{
 			//add to path
 			graph->table[current].visited = 2;
 			//find largest outdegree node
 			List *currentList = graph->table[current].outlist;
 			int Max = 0;
 			int maxNode;

 			for (int i = 0; i < graph->table[current].outdegree; i++)
 			{
 				if (graph->table[currentList->index].outdegree > Max)
 				{
 					Max  = graph->table[currentList->index].outdegree;
 					maxNode = currentList->index;
 				}
 				currentList = currentList->next;
 			}//find max
 			current = maxNode;
 			//printf("Current Node: %s\n", graph->table[current].name); 
 			if (graph->table[current].name == target)
 			{
 				found = 1;
 			}
 			
 		}
 		graph->table[current].visited = 2;

 	
 	
 		int c = 1;
 		for (int i = 1; i < graph->MaxSize+1; i ++)
 		{
 			if (graph->table[i].visited == 2)
 			{
 				printf("Path %d: Node: %s\n", c,graph->table[i].name);
 				c++;  
 			}
 		}
 		
}

int main(int argc,char *argv[])
{

 	Graph mygraph;

  read_graph(&mygraph,argv[1]);

  /* you take it from here */

  //print graph
  print_graph(&mygraph);
  
  heuristic(&mygraph,1,1,1);
}
 		
 		
	
