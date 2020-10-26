#include <stdio.h>
#include <stdlib.h>

/* these arrays are just used to give the parameters to 'insert',
   to create the 'people' array */
#define HOW_MANY 7
char *names[HOW_MANY]= {"Simon", "Suzie", "Alfred", "Chip", "John", "Tim",
		      "Harriet"};
int ages[HOW_MANY]= {22, 24, 106, 6, 18, 32, 24};

/* declare your struct for a person here */
typedef struct person{
	char* name;
	unsigned int age;
	struct person *next;
} person;

struct person *headptr = NULL;

static void insert(person *people, char *name, int age) {
  /* put name and age into the next free place in the array parameter here */
	people = (person *)malloc(sizeof(struct person));
	if (people ==NULL)
		abort();
  people->name =  name;
  people->age = age;
  people->next = headptr;
  headptr = people;
  
  //return people;
  /* modify nextfreeplace here */
  

}

int main(int argc, char **argv) {

  struct person *people = NULL;
  
	 for (int i=0; i<HOW_MANY;i++) {
     insert(people, names[i], ages[i]);
  }

  /* print the people array here*/

	for (int i=0; i<HOW_MANY;i++) {
    printf("Name: %s Age: %d\n", people->name,people->age);
  }
  
   // free memory
	/*for (int i = 0; i <HOW_MANY ; i++) {
    free(people[i]);
	}*/
	free(people);
  return 0;
  

}
