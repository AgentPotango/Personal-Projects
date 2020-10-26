
#include <stdio.h>
#include <stdlib.h>
#include <assert.h>  // we are using assert.h to check some conditions remain true
#include <math.h>
#include <stdbool.h>
#include "graph.h"

#define DOUB_MAX 10e30  // a large number, must be greater than max value of any solution
#define SIZE 100000000 // an estimate of how large the priority queue could become


int QueueSize = 0;
Node *pqueue;

void upheap(int qsize)
{
  // upheap reorders the elements in the heap (queue) after an insertion
  Node temp_element;
  temp_element=pqueue[qsize]; 
  pqueue[0].dist=DOUB_MAX;
  
  while (pqueue[qsize/2].dist<=temp_element.dist)
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
      if(j<QueueSize && pqueue[j].dist<pqueue[j+1].dist)
	j++;
      if(temp_element.dist>=pqueue[j].dist)
	break;
      pqueue[qindex]=pqueue[j]; 
      qindex=j;
    }
  pqueue[qindex]=temp_element;
}

Node removeMax()
{
  Node head=pqueue[1];
  pqueue[1]=pqueue[QueueSize--];
  downheap(1);
  return head;
}

int main(int argc,char *argv[])
{
  Graph mygraph;

  read_graph(&mygraph,argv[1]);

  /* you take it from here */

  //print graph
  print_graph(&mygraph);
  
  int src;

  int size = mygraph.MaxSize;
  for (int i = 0; i < size; i++)
  {
    mygraph.table[i].dist = 0;
    insert(mygraph.table[i]);
  }


}
