#include <stdio.h>
#include <stdlib.h>
#include <ctype.h>
#define __USE_BSD
#include <string.h>
#include <math.h>

#include "speller.h"
#include "dict.h"

typedef struct { // hash-table entry
Key_Type element; // only data is the key itself
enum {
empty, in_use, deleted
} state;
} cell;

typedef unsigned int Table_size; // type for size-of or index-into hash table

struct table {
cell *cells;
Table_size table_size; // cell cells [table_size];
Table_size num_entries; // number of cells in_use
// add anything else that you need
};

Table initialize_table(Table_size tableSize) {
//allocate memory for the table
Table initialisedTable = malloc(sizeof *initialisedTable);
//initialize an array of empty cells.
int i = 0;
int cellSize = sizeof(cell);
initialisedTable->cells = malloc(tableSize * cellSize);
initialisedTable->table_size = tableSize;
initialisedTable->num_entries = 0;
for (i = 0; i < tableSize; i++)
initialisedTable->cells[i].state = empty;

return initialisedTable;

} //initialize_table

//Hash function for words.
int hashFunction(Key_Type element, int tableSize) {
int a = 2;
double result = 0;
int index = 0;
for (index = 0; index < strlen(element); index++)
result += ((int) element[index]) * pow(a, strlen(element) - 1 - index);
return result;
} //hashFunction

Table linearProbing(Key_Type element, Table table) {
int j = 1;
cell *currentCell;
int index = hashFunction(element, table->table_size);
currentCell = &table->cells[index];
while (currentCell->state == in_use) {
index = (index + j) % (table->table_size);
currentCell = &table->cells[index];
j++;
} //while
} //linearProbing

Table openAddressing(Key_Type element, Table table) {
switch (mode) {
//linear probing
case 0:
linearProbing(element, table);
break;
case 1: //quadratic probing
break;
case 2: //double hashing
break;
default: //linear probing
break;
} //switch mode
return table;
} //openAddressing

Table insert(Key_Type element, Table table) {
int index;
cell *currentCell;
index = hashFunction(element, table->table_size);
currentCell = &table->cells[index];

//Find an empty slot to insert the value. If the current key alreay exists, ignore it.
if (currentCell->state != in_use) //ok to insert here
{
currentCell->state = in_use;
currentCell->element = strdup(element);
} //if
else
openAddressing(element, table);

return table;
} //insert

Boolean find(Key_Type element, Table table) {

return FALSE;
} //find

void print_table(Table table) {

} //print_table

void print_stats(Table table) {

} //print_stats

void freeTable(Table table) {
free(table->cells);
free(table);
} //freeTable
