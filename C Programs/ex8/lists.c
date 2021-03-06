#include <stdio.h>
#include <stdlib.h>
#include <string.h>

/* these arrays are just used to give the parameters to 'insert',
   to create the 'people' array */
#define HOW_MANY 7
char *names[HOW_MANY]= {"Simon", "Suzie", "Alfred", "Chip", "John", "Tim",
		      "Harriet"};
int ages[HOW_MANY]= {22, 24, 106, 6, 18, 32, 24};

typedef enum {neither, student, staff} staff_or_student;

staff_or_student ID[HOW_MANY] = {neither,student,student,staff,staff,neither, staff};

typedef union
{
	char* room;
	char* prog;
	char* no_info;
}info;

enum staff_or_student;

/* declare your struct for a person here */
typedef struct person{
	char* name;
	unsigned int age;
	struct person *next;
	staff_or_student ID;
	info extraInfo;
} person;



person *insert_start(person *people, char *name, int age) {
  /* put name and age into the next free place in the array parameter here */
  person *newPerson = (person *)malloc(sizeof(person));
  if (newPerson == NULL)
    abort();
  newPerson->name = name;
  newPerson->age = age;
  newPerson->next = people;
  return newPerson;
  
}

int compare_people_by_name(person *first, person *second)
{
  return strcmp(first->name,second->name);
}

int compare_people_by_age(person *first, person *second)
{
  return (first->age - second->age);
}

person *insert_sorted(person *people, char *name, int age, staff_or_student ID, int (*cmp)(person *first, person *second)) {
  /* put name and age into the next free place in the array parameter here */
  person *newPerson = (person *)malloc(sizeof(person));
  //struct person *current;
  if (newPerson ==NULL)
    abort();
  newPerson->name = name;
  newPerson->age = age;
  newPerson->ID = ID;
  
  if (ID == neither)
  {
    newPerson->extraInfo.no_info = "No Info Available";
  }
  else if (ID == staff)
  {
    newPerson->extraInfo.room = "Kilburn 2.72";
  }
  else if (ID == student)
  {
  	newPerson->extraInfo.prog = "CM";
  }
  
  if (people == NULL || cmp(people,newPerson) > 0)
  {
  	newPerson->next = people;
    return newPerson;
  }
  else
  {
  	person *k = people;
		while (k->next!= NULL && cmp(k->next,newPerson) < 0)
    {
    	k = k->next;
    }
    //k->next = newPerson;
    newPerson->next = k->next;
    k->next = newPerson;
    return people;
 	}

}

person *insert_end(person *people, char *name, int age) {
  /* put name and age into the next free place in the array parameter here */
  person *newPerson = (person *)malloc(sizeof(person));
  //struct person *current;
  if (newPerson ==NULL)
    abort();
  newPerson->name = name;
  newPerson->age = age;
  if (people == NULL)
  {
  	newPerson->next = NULL;
    return newPerson;
  }
  else
  {
  	person *k = people;
		while (k->next!= NULL)
    {
    	k = k->next;
    }
    k->next = newPerson;
    newPerson->next = NULL;
    return people;
 	}

}

int main(int argc, char *argv[]) {
	
	int part = atoi(argv[1]);
  person *people = NULL; //Start of the List
  person *temp;
  person *p; 
  
  if (part == 1)
  {
		for (int i=0; i<HOW_MANY;i++) {
      people = insert_start(people, names[i], ages[i]);
  	}
  }
  
  if (part == 2)
  {
    for (int i=0; i<HOW_MANY;i++) {
      people = insert_end(people, names[i], ages[i]);
    }
  }
  
  if (part == 3)
  {
    for (int i=0; i<HOW_MANY;i++) {
      people = insert_sorted(people, names[i], ages[i], ID[i], compare_people_by_name);
    }
  }
  
  if (part == 4 || part == 5)
  {
    for (int i=0; i<HOW_MANY;i++) {
      people = insert_sorted(people, names[i], ages[i], ID[i], compare_people_by_age);
    }
  }
    
  p = people;
  if (part == 1 || part == 2)
  {
    while (p != NULL)
    {
      printf("Name %s Age %d\n",p->name, p->age);
      p = p->next;
    }
  }//if
  else
  {
    while (p != NULL)
    {
      printf("Name %s Age %d ",p->name, p->age);
      if (p->ID == neither)
        printf("%s\n", p->extraInfo.room);
      else if (p->ID == staff)
        printf("Room: %s\n", p->extraInfo.room);
      else if (p->ID == student)
        printf("Course: %s\n", p->extraInfo.prog);
      p = p->next;
    }
  }//else
  
  //free   
	while (people != NULL)
	{     
    temp = people;	
    people = people->next;    
    free(temp);            
	}
    
  return 0;
  

}
