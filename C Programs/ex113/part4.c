#include "graph.h"
#include <assert.h>  // we are using assert.h to check some conditions remain true
#include <math.h>
#include <stdbool.h>

#define SIZE 10000000 // an estimate of how large the priority queue could become

int QueueSize = 0;
Node *pqueue;

void algorithm(Graph *graph, int source);

void upheap(int qsize)
{
  // upheap reorders the elements in the heap (queue) after an insertion

  Node temp_element;
  temp_element = pqueue[qsize]; 
  pqueue[0].dist=-1;
  
  while (pqueue[qsize/2].dist > temp_element.dist)
    {
      pqueue[qsize]=pqueue[qsize/2]; 
      qsize=qsize/2;
    }
  pqueue[qsize]=temp_element;
}

void insert(Node element)
{
  assert(QueueSize<SIZE-1);
  pqueue[++QueueSize]=element;
  upheap(QueueSize);
}

void downheap(int qindex)
{
  // down heap reorders the elements in the heap (queue) after a removal

  int j;
  Node temp_element;
  temp_element = pqueue[qindex];
  //printf("Down heap first element is: %s\n", pqueue[qindex].name);
  while(qindex<= QueueSize/2)
  {
    j=qindex+qindex;
    if(j<QueueSize && pqueue[j].dist > pqueue[j+1].dist)
	    j++;
    if(temp_element.dist < pqueue[j].dist)
	    break;
    pqueue[qindex]=pqueue[j];
    qindex=j;
  }
  
  pqueue[qindex]=temp_element;
   //printf("first element is: %s\n", pqueue[1].name);
}

Node removeMin()
{
  Node head=pqueue[1];
  //printf("Head is: %s\n", head.name);
  pqueue[1]=pqueue[QueueSize--];
  downheap(1);
  //printf("Down heap first element is: %s\n", pqueue[1].name);
  return head;
}
// End priority queue functions.

int main(int argc, char *argv[1])
{
	
	Graph mygraph;

  read_graph(&mygraph,argv[1]);

  //print graph
  print_graph(&mygraph);

  //int outDegMax = mygraph.table[1].outdegree;
  //char* nameMax = mygraph.table[1].

  if((pqueue = (Node *)malloc(sizeof(Node)*SIZE))==NULL)
    {      
      fprintf(stderr,"Problem allocating memory for priority queue. Reduce SIZE.\n");
      exit(1);
    }
    //List *current = mygraph.table[1].outlist;
		
		algorithm(&mygraph, 1);
}

void algorithm(Graph *graph, int source)
{
	int altDistance;
	bool check;
		
	graph->table[source].dist = 0;
	for (int i = 1; i < graph->MaxSize; i++)
	{
	  if(i != source)
      graph->table[i].dist = graph->MaxSize+1;
    	insert(graph->table[i]);
  }

     
   while (QueueSize != 0)
   {		
   		Node current = removeMin();
   		List* currentList = current.outlist;
   		
   	  for(int i = 0; i < current.outdegree; i++)
   		{
   				check = true;
   				
   			/*for (int j = QueueSize; j > 0; j--)
   			{
   			
   				List* nextList = pqueue[j].outlist;
   				if (nextList->index == currentList->index)
   				{
   					check = true;
   				}
   				
   				}
   				*/
   				if (check == true)
   				{
   					printf("Source Node %s, edge %d,  distance is %d \n", current.name, currentList->index, current.dist);
   					printf("Actual graph dist is: %d\n", graph->table[atoi(current.name)].dist);
   					
   					//using graph->table to change distances as current.dist points to an incorrect value i.e. Node 3 has distance 1 
   					//but when current is on node 3, it has distance 11
   					altDistance = graph->table[atoi(current.name)].dist + 1;
   					//printf("Node 3 distance is :  %d\n", graph->table[3].dist);
   					if (altDistance < graph->table[currentList->index].dist)
   					{
   					printf(" edge %d, distance was %d \n", currentList->index, graph->table[currentList->index].dist);
   						graph->table[currentList->index].dist = altDistance;
   						}
   				
   				}
   				//printf("Next Node %d %s \n", currentList->index, current.name);
   				currentList = currentList->next;
   			//	if (currentList != NULL)
   			//		printf("Next Node %d \n", currentList->index);
   				

   		}
   		
   		Node *array = malloc(sizeof(Node) * QueueSize);
   		int l = 0;
   		//printf("Queue Size %d\n", QueueSize);
   		while(QueueSize != 0)
   		{
   			array[l] = removeMin();
   			l++;
   		}
   		
   		//printf("Queue Size %d\n", QueueSize);
   		for (int i = 0; i < l; i++)
   		{
   			insert(array[i]);
   		}
   		//printf("Queue Size %d\n", QueueSize);
   		
   		free(array);
   		
 
   }
   
   int count = 0;
   for (int i = 1; i < graph->MaxSize; i++)
   {
   		printf("Node %d distance: %d\n", i, graph->table[i].dist);
   		if (graph->table[i].dist == graph->MaxSize+1 )
   		{
   			count ++;
   		}
   }
 
   
}



