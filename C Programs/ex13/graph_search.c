#include "graph.h"
/* Good luck */

/* Assistance from http://www.c-program-example.com/2011/10/c-program-to-implement-breadth-first.html */

void depth_first(Graph * newGraph, int currentNode, searchValues *values, int noOutDegNodes)
{
  
  //Get current node's outlist
  List *currentList;
  currentList = (List*)malloc(sizeof(List));
  currentList = newGraph->table[currentNode].outlist;

  //Visited current node
  newGraph->table[currentNode].visited = 1;

  
  while(currentList != NULL)
  {
    //if we haven't visited the adjacent node
    if((newGraph->table[currentList-> index].visited) == 0)
    {
       values->nodesCanReach ++;

        //find node with maximum amount of outdeg nodes that can reach
       if (noOutDegNodes <  newGraph-> table[currentNode].outdegree)
       {
         values-> largestOutDegNode = currentNode;
         noOutDegNodes = newGraph-> table[currentNode].outdegree;
       }
      
       depth_first(newGraph, currentList -> index, values, noOutDegNodes);
    }
    else
    {
      //go to next list
      currentList = currentList -> next;
      
    }
  }    
}

void breadth_first(Graph * newGraph, int currentNode,  searchValues *values)
{  

  //Create Queue array
  int bQueue[newGraph-> MaxSize + 1];

  //set Queue and visited index to 0;
  for(int index = 0; index < newGraph-> MaxSize + 1; index++)
  {
    newGraph->table[index].visited = 0;
    bQueue[index] = 0;
  }

  //Visit first node
  newGraph->table[currentNode].visited = 1;;

  int i = 0;
  int j = -1;

  int noOutDegNodes = 0;

  //create list for node
  List *currentList;
  currentList = (List*)malloc(sizeof(List));
  currentList = newGraph->table[currentNode].outlist;  

 
  while(1)
  {
    //
    if(currentList == NULL)
    {
      if(bQueue[i] == 0 || i > newGraph-> MaxSize)
      {
        break;
      }
      else
      {
        //set currentList to the graph with Queue!=0
        currentList = newGraph->table[bQueue[i]].outlist;
        i++;
      }
    }
    else
    {
      while(currentList != NULL)
      {
        //visit adjacent nodes
        if(newGraph->table[currentList-> index].visited == 0)
        {
          newGraph->table[currentList-> index].visited = 1;
          bQueue[++j] = currentList-> index;
          values-> nodesCanReach++;

          //Get highest reachable out-deg node
          if (noOutDegNodes < newGraph-> table[currentList-> index].outdegree)
          {
            noOutDegNodes = newGraph-> table[currentList-> index].outdegree;
            values-> largestOutDegNode = currentList-> index;
          }
        }
        currentList = currentList-> next;
      }
      
    }  
  }
}



