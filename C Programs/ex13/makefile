CC=gcc
CFLAGS=-Wall -g -std=c99
LDFLAGS=-lm
HEADERS=graph.h

%.o: $(HEADERS)
 
part1: part1.o graph_functions.o

part2: part2.o graph_functions.o graph_search.o

part3: part3.o graph_functions.o

part4: part4.o graph_functions.o graph_search.o

clean:
	rm -f part1 part2 part3 part4 part1.o part2.o part3.o part4.o graph_functions.o graph_search.o
