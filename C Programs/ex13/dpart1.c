#include "graph.h"

int main(int argc,char *argv[])
{
  Graph mygraph;

  read_graph(&mygraph,argv[1]);

  print_graph(&mygraph);

  Node *pqueue;

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