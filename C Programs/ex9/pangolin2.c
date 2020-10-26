#include <stdlib.h>
#include <stdio.h>
#include <string.h>
#include <ctype.h>

#define maxSize 200

struct node {
  char *object; 
  char *question;
  struct node *yes_ptr; // only NULL for objects
  struct node *no_ptr; // only NULL for objects
};

 	
/*void treePrint(struct node *ptr) {
  
  if (ptr == NULL)
  {
  }
  else {
  	struct node *yesNode = ptr->yes_ptr;
    struct node *noNode = ptr->no_ptr;
    if (ptr->question == NULL)
    {
      printf("Object: %s\n" ,ptr->object);
  	  printf("Question: [NOTHING]\n");
    }
    else if (ptr->object == NULL)
    {
      printf("Object: [NOTHING]\n");
  	  printf("Question: %s\n", ptr->question);
      if (yesNode->question == NULL)
        printf("Yes: %s\n", yesNode->object);
      else
        printf("Yes: %s\n",yesNode->question);

      if (noNode->question == NULL)
        printf("No: %s\n", noNode->object);
      else
        printf("No: %s\n",noNode->question);
    }
  	  
    treePrint(ptr->yes_ptr);
    treePrint(ptr->no_ptr);
  }
}*/

void treePrint(struct node *ptr, FILE *input) {
  
  if (ptr == NULL)
  {
  }
  else 
  {
    if (ptr->question != NULL)
    {
 		  //printf("question: %s\n",ptr->question);
 		  fprintf(input, "question: %s\n",ptr->question);
 		  treePrint(ptr->yes_ptr, input);
 		  treePrint(ptr->no_ptr, input);
    }
    else
    {
      //printf("object: %s\n",ptr->object);
      fprintf(input, "object: %s\n",ptr->object);
    }
  }
}

void treeFree(struct node *ptr)
{
	if (ptr == NULL)
  {
  }
  else 
  {
    if (ptr->question != NULL)
    {
 		  //printf("question: %s\n",ptr->question);
 		  treeFree(ptr->yes_ptr);
 		  treeFree(ptr->no_ptr);
 		  free(ptr);
    }
    else
    {
      //printf("object: %s\n",ptr->object);
      free(ptr);
    }
  }
}


/*
struct node *treeRead(FILE *input, char **line) {
	
	//fgets(line, maxSize, input);
	while(fgets(*line,maxSize,input)!=NULL)
	{
	  if (strcmp(*line,"") == 0)
		  return NULL;
  	else
	  {
		  struct node *ptr = malloc(sizeof(struct node));
		  if (strstr(line[maxSize],"question:") != NULL)
		  {
		    ptr->question = line[maxSize];
		    ptr->yes_ptr = treeRead(input, line);
		    ptr->no_ptr = treeRead(input, line);
		  }
		  else
		  {
		    ptr->object = line[maxSize];
		    ptr->yes_ptr = NULL;
		    ptr->no_ptr = NULL;
		  }
	  }
	}
}
	*/


void lower(char *str)
{
  for(int i = 0; str[i]; i++){
    str[i] = tolower(str[i]);
  }
}

void insert_sorted(struct node *prevNode, struct node *newQuestion, int check) {
                          
  if (check == 0)
    prevNode->yes_ptr = newQuestion;
  else
    prevNode->no_ptr = newQuestion;
}

void chomp(char *s) 
{   
	while(*s && *s != '\n' && *s != '\r') 
	s++;     
	*s = 0;
}

int status(char *answer, char **responseArray)
{
	lower(answer);
	for (int i = 0; i < 7; i++)
  {
    if (strcmp(answer, responseArray[i])== 0) 
   		return 1;
  }
  return 0;
}

int main(int argc, char *argv[]) {
	
	//char *filename = argv[1];
	//char **lines[maxSize];
	FILE *inputFilePtr;
	inputFilePtr = fopen("readTree","w");
	
	if (!inputFilePtr)
  {
    fprintf(stderr, "can't open input for writing\n");
    exit(-1);
  }
  
 
	//treeRead(inputFilePtr, lines[maxSize]);
	
	struct node *node1 = malloc(sizeof(struct node)); //assigned memory
	struct node *node2 = malloc(sizeof(struct node));
	struct node *node3 = malloc(sizeof(struct node));
	struct node *node4 = malloc(sizeof(struct node));
	struct node *node5 = malloc(sizeof(struct node));
	struct node *node6 = malloc(sizeof(struct node));
	struct node *node7 = malloc(sizeof(struct node));
	
	node4->object = "Sky";
	node4->yes_ptr = NULL;
	node4->no_ptr = NULL;

	node5->object = "Blue screen of death.";
	node5->yes_ptr = NULL;
	node5->no_ptr = NULL;

	node6->object = "Sun";
	node6->yes_ptr = NULL;
	node4->no_ptr = NULL;
	
	node7->object = "Purple";
	node7->yes_ptr = NULL;
	node7->no_ptr = NULL;
	
	
	node1->question = "is it blue?";
	node1->yes_ptr = node2;
	node1->no_ptr = node3;
	
	node2->question = "Does it have clouds";
	node2->yes_ptr = node4;
	node2->no_ptr = node5;
	
	node3->question = "is it yellow?";
	node3->yes_ptr = node6;
	node3->no_ptr = node7;
	
	//treePrint(node1, inputFilePtr);
	 
	
  struct node *currentNode = malloc(sizeof(struct node));
  struct node *newObjectNode = malloc(sizeof(struct node));
  struct node *newQuestionNode = malloc(sizeof(struct node));
  struct node *prev;
  int check;
  char response[maxSize];
  char newObject[maxSize];
  char newQuestion[maxSize];
  char answer[maxSize];
  char *yesResponse[7] = {"yes","y","correct","yep","right", "absolutely",
  												"totally"};
  //char *noResponse[5] = {"no","n","incorrect","nope","wrong"};
	currentNode = node1;
	
  while (currentNode != NULL) {
    if (currentNode->object != NULL) { // object node
      printf("Is it %s\n", currentNode->object);
      fgets(response, maxSize, stdin);
      chomp(response);
      if (status(response,yesResponse) == 1) {
      printf("Yay, I win\n");
      } else {
        printf("Awww, you win... What were you thinking of?\n");
        fgets(newObject,maxSize,stdin);
        chomp(newObject);
        printf("Please give me a question about %s, so I can tell the "
        "difference between %s and %s\n",newObject,newObject,
        																					currentNode->object);
        fgets(newQuestion,maxSize,stdin);
        chomp(newQuestion);
        printf("What is the answer for %s?\n", newObject);
        fgets(answer,maxSize,stdin);
        chomp(answer);
        newObjectNode->object = newObject;
        newQuestionNode->question = newQuestion;
        if (status(answer,yesResponse) == 1)
        {
          newQuestionNode->yes_ptr = newObjectNode;
          newQuestionNode->no_ptr = currentNode;
        }
        else
        {
          newQuestionNode->no_ptr = newObjectNode;
          newQuestionNode->yes_ptr = currentNode;
        }
        
        insert_sorted(prev,newQuestionNode,check);
        //treePrint(node1, inputFilePtr);
        //fclose(inputFilePtr);
     }
     printf("Want to play a new game?\n");
     treePrint(node1, inputFilePtr);
     fgets(response,maxSize,stdin);
     chomp(response);
     if (status(response, yesResponse) == 1)
     {
     	printf("\n\n");
      currentNode = node1;
     }
     else
     {
     	free(newObjectNode);
			free(newQuestionNode);
      currentNode = NULL;
     }
     
    } else { // question node
      prev = currentNode;
      printf("%s\n",currentNode->question);      
      fgets(response,maxSize,stdin);
      chomp(response);
      if (status(response, yesResponse)== 1)
      {
        check = 0;
        currentNode = currentNode->yes_ptr;
      }
      else
      {
        check = 1;
        currentNode = currentNode->no_ptr;
      }
    }
  }
	
	treeFree(node1);
	
	free(currentNode);
  fclose(inputFilePtr);
	
	return 0;
}
	
	
	
	
	
	
	
	
	
 	

  	



