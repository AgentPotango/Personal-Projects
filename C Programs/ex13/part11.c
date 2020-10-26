#include "graph.h"

//visited = d_state 
//discovered, target, undiscovered

typedef struct {
	 int size;
	Node **nodes;
}heap;

//heap heap_create(struct graph* g);
//struct node* heap_getmin(struct heap *h);
//void heapify(struct heap *h,  int i);
//void heap_free(struct heap *h);

int smaller(heap *h,  int node,  int otherNode)
{
	if (h->nodes[node]->visited < h->nodes[otherNode]->visited) {
		return 1;
	} else if (h->nodes[node]->visited > h->nodes[otherNode]->visited) {
		return 0;
	} else

   {
		if (h->nodes[node]->dist < h->nodes[otherNode]->dist) {
			return 1;
		} else {
			return 0;
		}
	}
}

void exchange( heap* h,  int node,  int otherNode)
{
	int index;
	 Node *target_node;

	target_node = h->nodes[node];
	h->nodes[node] = h->nodes[otherNode];
	h->nodes[otherNode] = target_node;

	index = h->nodes[node]->index;
	h->nodes[node]->index = h->nodes[otherNode]->index;
	h->nodes[otherNode]->index = index;
}

/* changes position of element with parent until children are bigger */
//using bitwise operator
int heap_up(heap *h,  int i)
{
	 int current = i;

	if (current != 0) {
		 int parent = (i - 1) >> 1;

		while (smaller(h, current, parent)) {
			exchange(h, current, parent);

			/* Try to reach the root node */
			current = parent;
			if (parent != 0) {
				parent = (parent - 1) >> 1;
			}
		}
	}

	return current;
}

/* changes position of element with children until parent is smaller */
int heap_down( heap *h,  int i)
{
	int current = i;

	int exchanged;
	do {
		 int child1 = (current + 1) * 2 - 1;
		 int child2 = (current + 1) * 2;
		 int smallerValue;
		exchanged = 0;

		/* exchange with smaller son */
		if (child1 < h->size && child2 < h->size) {
			if (smaller(h, child1, child2)) {
				smallerValue = child1;
			} else {
				smallerValue = child2;
			}
		} else if (child1 < h->size) {
			/* only one child node */
			smallerValue = child1;
		} else {
			/* finished */
			break;
		}

		/* only exchange when smaller */
		if (smaller(h, smallerValue, current)) {
			exchange(h, current, smallerValue);
			exchanged = 1;
			current = smallerValue;
		}
	} while (exchanged);

	return current;
}


/* reheapify element */
void heapify(heap *h,  int i)
{
	int cur = heap_up(h, i);
	heap_down(h, cur);
}

/* creates heap for graph */
heap heap_create(Graph *g) {
	heap h;
	Node *n;
	int i;

	h.size = 0;
	for (n = g->table; n != NULL; n++) {
		h.size++;
	}

	h.nodes = (Node**)malloc(sizeof(Node) * h.size);
	for (i = 0, n = g->table; n != NULL; i++, n++) {
		h.nodes[i] = n;
		h.nodes[i]->index = i;
	}


	/* sort elements */
	for (i = h.size; i > 0; i--) {
		heap_down(&h, i - 1);
	}

	return h;
}

/* free heap */
void heap_free( heap *h)
{
	free(h->nodes);
	h->nodes = NULL;
}

/* returns current minimum and removes it from heap */
 Node* heap_getmin(heap *h) {
	Node* n;
	if (h->size > 0) {
		n = h->nodes[0];
	} else {
		n = NULL;
	}

	if (n == NULL || n->visited != target) {
		return NULL;
	}

	if (h->size > 0) {
		if (h->size >= 2) {
			exchange(h, 0, h->size - 1);
			h->size--;
			heapify(h, 0);
		} else {
			h->size--;
		}
	}

	if (h->size == 0) {
		heap_free(h);
	}

	return n;
}

int dijkstra(Graph *g, Node start) {
	Node node, min, a;
	List *edge;
	heap h;
	int k = 0;

	for (node = g->table[k]; node != NULL; node = g->table[k++]) {
		node.dist = 10000;
		node.visited = undiscovered;
		node.used = NULL;
	}
	start.dist = 0;
	start.visited = target;
	h = heap_create(g);



	while ((min = heap_getmin(&h)) != NULL) {
	
		/* for all adjacent edges */
		for (edge = min->outlist; edge != NULL; edge = edge->next) {
			a = edge->next;

			/* if adjacent node is not discovered and can be reached (better) over the min node, set this */
			if (a->visited != discovered 
					&& ((((min->min + edge->outdegree) < a->min) || (a->min == 1)))) {
				a->used = edge;
				a->min = min->min + edge->outdegree;
				a->visited= target;
				heapify(&h, a->index);
			}
		}
		dist->visited = discovered;
	}

	if (h.size != 0) {
		fprintf(stderr, "Could not find route to %d nodes\n", h.size);
	}
	heap_free(&h);

	return(0);
}




