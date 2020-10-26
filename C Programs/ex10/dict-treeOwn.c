#include <stdio.h>
#include <stdlib.h>
#include <ctype.h>
#define __USE_BSD
#include <string.h>

#include "speller.h"
#include "dict.h"
#define MAX_TREE_HEIGHT 10

typedef struct node * tree_ptr;

struct node {
  tree_ptr left, right;
  Key_Type element; // only data is the key itself
  signed char avl_balance; // the balance factor for an avl tree.
  // add anything else that you need
};

struct table {
  tree_ptr head; // points to the head of the tree
  // add anything else that you need
};

Table initialize_table(/*ignore parameter*/) {
  //allocate memory for the table
  Table initialisedTable=malloc(sizeof *initialisedTable);
  
  //Initialise the pointer to the head of the tree.
  initialisedTable->head = NULL;
  return initialisedTable;
} //initialize_table

//Function to insert an element into a binary tree
Table insertBST(Key_Type element, Table table) {
  tree_ptr currentNode, parentNode, nextNode, newNode;
  int direction; //-1 for left, 1 for right
  
  //Check for valid values.
  if ((element == NULL) || (table == NULL))
    return NULL;
  

  //Loop through the binary tree until we find an empty place to insert.
  for (parentNode=NULL, currentNode = table->head; currentNode != NULL; parentNode = currentNode, currentNode = nextNode)
  {
    int cmp = strcmp(element, currentNode->element);
    
    //If there is already an element with that value, there's nothing to be done.
    //printf("Comparing element %s and %s ", currentNode->element, element);
    //printf("Result of comparison is %d\n", cmp);
    if (cmp == 0)
    {
      printf("Node already exists: %s\n", currentNode->element);
      return table;
    } //if
    else if (cmp < 0)
    {
      nextNode = currentNode->left;
      direction = -1;
    } //else if
    else
    {
      nextNode = currentNode->right;
      direction = 1;
    } //else
  } //for
  
  //Initialize values for the node that is to be inserted.
  newNode = malloc (sizeof *newNode);
  newNode->element = strdup(element);
  newNode->left = NULL;
  newNode->right = NULL;
     
  //Place the new node where it needs to be.
  if (table->head==NULL)
  {
    table->head = newNode;
    printf("First element added %s\n",newNode->element);
  }
  else if (direction == -1)
  {
    parentNode->left = newNode;
    printf("New element added left: %s Parent node:%s\n",newNode->element, parentNode->element);
  }
  else if (direction == 1)
  {
    parentNode->right = newNode;
    printf("New element added right: %s Parent node:%s\n",newNode->element, parentNode->element);
  }
  return table;
} //insert

//Function to insert an element into an AVL tree
Table insertAVL(Key_Type element, Table table)
{
  tree_ptr currentNode, parentNode, nextNode, newNode, recentNode, parentRecentNode;
  int direction = 0; //0 for left, 1 for right
  int index = 0; // counter for direction
  
  //Record each direction descended starting from parentRecent Node in order to arrive at currentNode.
  unsigned char directionDescended[MAX_TREE_HEIGHT];
    
  //Check for valid values.
  if ((element == NULL) || (table == NULL))
    return NULL;
  
  parentRecentNode = (tree_ptr)&table->head;
  recentNode = table->head;
  
  //Loop through the binary tree until we find an empty place to insert.
  for(parentNode = parentRecentNode, currentNode = recentNode; currentNode != NULL; parentNode = currentNode, currentNode = nextNode)
  {
    int cmp = strcmp(element, currentNode->element);

    if (cmp == 0)
      return table;
      
    if (currentNode->avl_balance != 0)
    {
      parentRecentNode = parentNode;
      recentNode = currentNode;
      index = 0;
    } //if

    if (cmp > 0)
    {
      direction = 1;
      nextNode = currentNode->right;
    }//if
    else if (cmp < 0)
    {
      direction = 0;
      nextNode = currentNode->left;
    }//else if
    directionDescended[index++]=direction;
  }// for
  
  //Initialize values for the node that is to be inserted.
  check(newNode = malloc (sizeof *newNode));
  check(newNode->element = strdup(element));
    
  //Create and initialize a new node as a child of parentNode on side left/right
  //according to direction and store a pointer to it in newNode.
  if (direction == 1)
    parentNode->right = newNode;
  else
    parentNode->left = newNode;
    
  if (newNode == NULL)
    return table;
   
  newNode->avl_balance = 0;
  newNode->left = NULL;
  newNode->right = NULL;
  
  if (recentNode == NULL)
    return table;
    
  //Update balance factors.
  for (currentNode = recentNode, index = 0; currentNode != newNode; currentNode=nextNode, index++)
  {
    if (directionDescended[index] == 0)
      currentNode->avl_balance--;
    else
      currentNode->avl_balance++;
      
    if (directionDescended[index] > 0)
      nextNode = currentNode->right;
    else
      nextNode = currentNode->left;
  } //for
  
  tree_ptr newRoot; // New root of rebalanced tree.
  
  //Rebalance tree.
  if (recentNode->avl_balance == -2)
  {
    //Rebalance AVL tree after insertion in left subtree.
    tree_ptr leftChild = recentNode->left;
    
    if (leftChild->avl_balance == -1)
    {
      //Rotate right at recentNode in AVL tree.
      newRoot = leftChild;
      recentNode->left = leftChild->right;
      newRoot->right = recentNode;
      recentNode->avl_balance = 0;
      newRoot->avl_balance = 0;
    }//if
    else
    {
      //Eotate left at leftChild then right at recentNode in AVL tree.
      if (leftChild->avl_balance != 1)
        return table;
      newRoot = leftChild->right;
      leftChild->right = newRoot->left;
      newRoot->left = leftChild;
      recentNode->left = newRoot->right;
      newRoot->right = recentNode;
      if (newRoot->avl_balance == -1)
      {
        leftChild->avl_balance = 0;
recentNode->avl_balance = 1;
      }//if
      else if (newRoot->avl_balance == 0)
      {
        leftChild->avl_balance = 0;
recentNode->avl_balance = 0;
      }//else if
      else
      {
        leftChild->avl_balance = -1;
recentNode->avl_balance = 0;
      }//else
      newRoot->avl_balance = 0;
    }//else
  }//if
  
  else if (recentNode->avl_balance == 2)
  {
    //Rebalance AVL tree after insertion in right subtree.
    
    tree_ptr rightChild = recentNode->right;
    if (rightChild->avl_balance == 1)
    {
      newRoot = rightChild;
      recentNode->right = rightChild->left;
      rightChild->left = recentNode;
      recentNode->avl_balance = 0;
      rightChild->avl_balance = 0;
    } //if
    else
    {
      if (rightChild->avl_balance != -1)
        return table;
      newRoot = rightChild->left;
      rightChild->left = newRoot->right;
      newRoot->right = rightChild;
      recentNode->right = newRoot->left;
      newRoot->left = recentNode;
      if (newRoot->avl_balance == 1)
      {
        rightChild->avl_balance = 0;
recentNode->avl_balance = -1;
      }//if
      else if (newRoot->avl_balance == 0)
      {
        rightChild->avl_balance = 0;
recentNode->avl_balance = 0;
      }//else if
      else
      {
        rightChild->avl_balance = 1;
recentNode->avl_balance = 0;
      }//else
      newRoot->avl_balance = 0;
    }//else
  }//else if
  else
    return table;
  
  direction = (recentNode != parentRecentNode->left);
  if (direction == 0)
    parentRecentNode->left = newRoot;
  else if (direction == 1)
    parentRecentNode->right = newRoot;
    
  return table;
  
} //insertAVL

Table insert(Key_Type element, Table table)
{
  switch(mode)
  {
    case 0: table = insertBST(element, table);
     break;
    case 1: table = insertAVL(element, table);
     break;
    default: insertBST(element, table);
  } //switch mode
  return table;
}// insert

//Look in the binary tree for a given value.
Boolean find(Key_Type element, Table table)
{
  tree_ptr currentNode;

  //Check for valid values.
  if ((element == NULL) || (table == NULL))
    return FALSE;
    
  for (currentNode=table->head; currentNode!=NULL;)
  {
    int cmp = strcmp(element, currentNode->element);
    
    if (cmp < 0) // item less than the current one so move to the left.
      currentNode = currentNode->left;
    else if (cmp > 0) //item greater than the current one so move to the right.
      currentNode = currentNode->right;
    else
      return TRUE; // item found when cmp == 0.
  } //for
  return FALSE; // in case no match was found.
} //find

//List the contents of a tree.
void print_tree(tree_ptr node)
{
  if (node == NULL)
    return;
  print_tree(node->left);
  printf("%s \n", node->element);
  print_tree(node->right);
}//print_tree

//List the contents of a table.
void print_table(Table table)
{
  tree_ptr currentNode;

  //Check for valid values.
  if (table == NULL)
   exit(0);
  
  currentNode = table->head;
  print_tree(currentNode);
    
}//print_table
void freeNode(tree_ptr node)
{
  if (node == NULL)
    return;
  freeNode(node->left);
  freeNode(node->right);
  free(node->element);
  free(node);
} //freeNode

void freeTable(Table table)
{
  tree_ptr currentNode;
  
  //Check for valid values.
  if (table == NULL)
   exit(0);
  
  currentNode = table->head;
  freeNode(currentNode);
  free(table);
} //freeTable


int getHeight(tree_ptr head)
{
  //Check for valid values.
  if (head == NULL)
   return 0;
  else
  {
    //get the height of the children.
    int leftHeight = getHeight(head->left);
    int rightHeight = getHeight(head->right);
    
    //return the highest value + 1 for the parent.
    if (rightHeight > leftHeight)
      return rightHeight+1;
    else
      return leftHeight+1;
    
  }//else
 
}//getHeight

void print_stats (Table table)
{
  printf("The height of the tree is: %d\n",getHeight(table->head));
}//print_stats


