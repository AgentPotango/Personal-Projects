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
  while(qindex<= QueueSize/2)
  {
    j=qindex+qindex;
    if(j<QueueSize && pqueue[j].dist > pqueue[j+1].dist)
	    j++;
    if(temp_element.dist < pqueue[j].dist)
	    break;
    pqueue[qindex]=pqueue[j]; qindex=j;
  }
  
  pqueue[qindex]=temp_element;
}

Node removeMin()
{
  Node head=pqueue[1];
  pqueue[1]=pqueue[QueueSize--];
  downheap(1);
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
	bool check = false;
		
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
   			check = false;
   			for (int j = QueueSize; j > 0; j--)
   			{
   				if (pqueue(j) == currentList->next)
   				{
   					check = true;
   				}
   				
   			}
   		  if(check = true) 
   		  //{
   		    // distance stuff
   		    //printf("out degrees for node current%d\n", current.outdegree);
   		    altDistance = current.dist + 1;
   		    //printf("altdist %d\n", altDistance);
   		    if (altDistance < graph->table[currentList->index].dist)
   		    	graph->table[currentList->index].dist = altDistance;

   		  //}
   		  currentList = currentList->next;
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
   /*
   for (int i = 1; i < graph->MaxSize; i++)
   {
   		printf("Node %d distance: %d\n", i, graph->table[i].dist);
   }
   */
}



