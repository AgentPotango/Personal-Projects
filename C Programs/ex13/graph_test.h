enum {
	D_STATE_discovered,
	D_STATE_candidate,
	D_STATE_undiscovered
};

struct node {
	uint64_t id;
	struct edge *edges;
	struct node *next;
	/* for Routing */
	int host;
	/* for Dijkstra */
	int64_t min;
	int d_state;
	int heap_id;
	struct edge *used_edge;
};

struct edge {
	struct node *from, *to;
	struct edge *adj_next;
	struct edge *g_next;
	/* for Dijkstra & Routing */
	int64_t len;
	/* for multigraphs :-) */
	uint64_t id;
};

struct graph {
	struct node *nodes;
	struct edge *edges;
	int nodes_n, hosts_n, edges_n;
