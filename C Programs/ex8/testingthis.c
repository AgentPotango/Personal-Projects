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

struct person *previous = NULL;
struct person *head = NULL;
struct person *temp;

struct person *insert_start(person *people, char *name, int age) {
  /* put name and age into the next free place in the array parameter here */
  people = (person *)malloc(sizeof(struct person));
  if (people ==NULL)
    abort();
  people->name = name;
  people->age = age;
  people->next = previous;
  return people;
    
  
  /* modify nextfreeplace here */
  

}

struct person *insert_end(person *people, char *name, int age) {
  /* put name and age into the next free place in the array parameter here */
  people = (person *)malloc(sizeof(struct person));
  struct person *current;
  if (people ==NULL)
    abort();
  people->name = name;
  people->age = age;
  people->next = previous;
  if (previous == NULL)
  {
  	people->next = NULL;
  	head = people;
  	printf("Head: %p", people);
    return people;
  }
  else
  {
		current = people;
    while (people->next != NULL)
    {
    	if (people != NULL)
    	{
    	 printf("End Value for Person: Name: %s Age %d %p\n",people->name,people->age,people->next);
    		continue;
      }
    	else
    	  people = people->next;
    }
    people->next = previous;
    //printf("End Value for Person: Name: %s Age %d %p\n",people->name,people->age,people->next);
    current->next = NULL;
    //printf("End Value for Person: Name: %s Age %d %p\n",people->name,people->age,people->next);
    return people;
 	}
  /* modify nextfreeplace here */
  //return people;

}


int main(int argc, char **argv) {
	
  struct person *people = NULL;
  
	/* for (int i=0; i<HOW_MANY;i++) {
     previous = insert_start(people, names[i], ages[i]);
  }
  
  people = previous;
  while (people)
  {
  printf("Name %s Age %d\n",people->name, people->age);
  printf("%p\n",people);
  people = people->next;
  }*/
  
  
  
  for (int i=0; i<HOW_MANY;i++) {
     previous = insert_end(people, names[i], ages[i]);
  }
  
  people = head;
  while (people)
  {
  printf("Name %s Age %d\n",people->name, people->age);
  people = people->next;
  }
  
  //people = head;
  //printf("head = %p", head);          
	while (people != NULL)
	{     
    temp = people;	
    people = people->next;    
    free(temp);            
	}
	previous = NULL;   
    

   
	//free(people);
  return 0;
  

}
