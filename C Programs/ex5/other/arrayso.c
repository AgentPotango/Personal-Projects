#include <stdio.h>
#include <stdlib.h>

/* these arrays are just used to give the parameters to 'insert',
   to create the 'people' array */
#define HOW_MANY 7
char *names[HOW_MANY]= {"Simon", "Suzie", "Alfred", "Chip", "John", "Tim",
		      "Harriet"};
int ages[HOW_MANY]= {22, 24, 106, 6, 18, 32, 24};

/* declare your struct for a person here */
typedef struct{
	char* name;
	unsigned int age;
} person;

static void insert(person *people, char *name, int age) {
  static int nextfreeplace = 0;
  /* put name and age into the next free place in the array parameter here */
  people->name = name;
  people->age = age;
  /* modify nextfreeplace here */
  nextfreeplace ++;
  

}

int main(int argc, char **argv) {

  /* declare the people array here */
	person people[HOW_MANY];
	
  for (int i=0; i<HOW_MANY;i++) {
    insert(&people[i], names[i], ages[i]);
  }

  /* print the people array here*/

	for (int i=0; i<HOW_MANY;i++) {
    printf("Name: %s Age: %d\n", people[i].name, people[i].age);
  }
  return 0;
}
