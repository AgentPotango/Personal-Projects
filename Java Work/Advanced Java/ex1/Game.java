public class Game
{

// ----------------------------------------------------------------------
// Part a: the score message
  private String scoreMessage;
  
  //displays the score message
  public String getScoreMessage()
  
  {
    return scoreMessage;
  } // getScoreMessage

  //changes the scoremessage into the argument supplied
  public void setScoreMessage(String message)
  {
    scoreMessage = message;
  } // setScoreMessage

  //displays the author
  public String getAuthor()
  {
    return "Mr. Kashif Hussain";
  } // getAuthor


// ----------------------------------------------------------------------
// Part b: constructor and grid accessors
  
  //holds the gridsize
  private final int gridSize;
  //creates a new 2d cell array
  private final Cell [][] grid;
  
  //creates the game cells
  public Game(int requiredGridSize)
  {
    gridSize = requiredGridSize;
    grid = new Cell [gridSize][gridSize];
    
    //makes every cell into a new cell
    for (int column = 0; column < gridSize; column++)
      for (int row = 0; row < gridSize; row++)
        grid [column][row] = new Cell();
    
  } // Game

  //returns the gridsize
  public int getGridSize()
  {
    return gridSize;
  } // getGridSize

  // returns 
  public Cell getGridCell(int x, int y)
  {
    return grid [x][y];
  } // getGridCell


// ----------------------------------------------------------------------
// Part c: initial game state

// Part c-1: setInitialGameState method
  //initially sets the score to zero.
  private int snakeScore = 0;

  //creates an instance of the game
  public void setInitialGameState(int requiredTailX, int requiredTailY,
                                  int requiredLength, int requiredDirection)
  {
    //set snake score to 0 and tree count to 0
    snakeScore = 0;
    treeCount = 0;   
    
    //clears all the cells in the grid
    for (int column = 0; column < gridSize; column++)
      for (int row = 0; row < gridSize; row++)
        grid [column][row].setClear();
    
    //if trees are enabled, it places 1 more on the screen 
    //and sets tree count to 1  
    if (treesEnabled == true)
    {
      placeTree();
      treeCount = 1;
    }
    
    //places some food into the field
    placeFood();
    
    //places the snake in the field
    placeSnake(requiredTailX, requiredTailY, requiredLength, requiredDirection);
        
  } // setInitialGameState


// ----------------------------------------------------------------------
// Part c-2 place food

  //holds the column cell location
  private int column;
  
  //holds the row cell location
  private int row; 
  
  //places some food in the field if that random cell is clear
  private void placeFood()
  {
    do
    {
      column  = (int) (Math.random() * gridSize);
      row = (int) (Math.random() * gridSize);
    }//do
    while (grid [column][row].getType() != 1);
    grid [column][row].setFood();
  }
  

// ----------------------------------------------------------------------
// Part c-3: place snake
  //holds the tail position
  private int tailPosX;
  private int tailPosY;
  
  //holds the head positon
  private int headPosX;
  private int headPosY;
  
  //holds the snake Length
  private int snakeLength;
  
  //holds the snakeDirection
  private int snakeDirection;
    
  private void placeSnake(int requiredTailX, int requiredTailY, 
                          int requiredLength, int requiredDirection)
  {
    //initializes the tail position, snake length and direciton with the
    //arguments
    tailPosX = requiredTailX;
    tailPosY = requiredTailY;
    snakeLength = requiredLength;
    snakeDirection = requiredDirection;
   
    //sets the tail direction to be the direction the snake is travelling
    //in
    grid[tailPosX][tailPosY].setSnakeTail(Direction.opposite(snakeDirection), 
                                          snakeDirection);
    
    //calculated the next position the tail should be in
    int nextCellX = tailPosX + Direction.xDelta(snakeDirection);
    int nextCellY = tailPosY + Direction.yDelta(snakeDirection);
    
    //adds the snake body parts in accordance with the snake length
    for (int count = 1; count <= snakeLength - 2; count++)
    {
      grid[nextCellX][nextCellY].setSnakeBody(Direction.opposite(snakeDirection)
                                              ,snakeDirection);
      nextCellX += Direction.xDelta(snakeDirection);
      nextCellY += Direction.yDelta(snakeDirection);
    }//for
    
    //the head position is initialized with the final cell
    headPosX = nextCellX;
    headPosY = nextCellY;
    
    //adds the head to the end of the snake
    grid[headPosX][headPosY].setSnakeHead(Direction.opposite(snakeDirection), 
                                          snakeDirection);
   
  }


// ----------------------------------------------------------------------
// Part d: set snake direction
   
  //sets the snake direction
  public void setSnakeDirection(int requiredDirection)
  {
    
    //checks if you try to turn the snake head into itself
     if (requiredDirection == Direction.opposite(snakeDirection))
      {
        //currect code would remove the bottom line
        requiredDirection = snakeDirection;
        //resets the snake direction to the original and displays error
        setScoreMessage("U turns aren't allowed!");
      } //if
      //otherwise change the snake direction into the direction input
      else
      {
       //correct code: snakeDirection = requiredDirection;
       grid[headPosX][headPosY].setSnakeOutDirection(requiredDirection); 
              
  } // setSnakeDirection


// ----------------------------------------------------------------------
// Part e: snake movement

// Part e-1: move method

  //initializes the new head position
  private int newHeadPosX;
  private int newHeadPosY;
  
  //stores the old snake direction
  private int oldDirection;
  private int preCrashDirection = snakeDirection;

  public void move(int moveValue)
  {
    //if the snake is bloody, set the preCrashDirection to the old direciton
    //and set snakeWasBloody to true.
    if (grid[headPosX][headPosY].isSnakeBloody() == true)
    {
      preCrashDirection = oldDirection;
      snakeWasBloody = true;
    }//if
    
    //if the snake is not bloody, then set the old snake direction 
    //into the snake direction 
    if (grid[headPosX][headPosY].isSnakeBloody() == false)
    {
      oldDirection = snakeDirection;
    }//if 
    
    //changes the snake direction into the direction which the head
    //is facing
    snakeDirection = grid[headPosX][headPosY].getSnakeOutDirection();
    
    //if the snake isn't bloody, calculate the new head positon    
    if (grid[headPosX][headPosY].isSnakeBloody() == false)
    {
      newHeadPosX = headPosX + Direction.xDelta(snakeDirection);
      newHeadPosY = headPosY + Direction.yDelta(snakeDirection);
    }//if
    
    //if the snake crashes, do nothing
    if (snakeDidNotCrash(newHeadPosX,newHeadPosY) == false)
    {
      
    }
    else
    {
      //otherwise check if the next head position points to food
      boolean canEatFood = grid[newHeadPosX][newHeadPosY].getType() == 5;
      //move the snake to the new position
      moveSnakeHead(newHeadPosX,newHeadPosY);
      //reset the crashCountDown
      resetCountDown();
      //if there was food there, run the eatfood method to make the snake
      //grow. otherwise, just move the snake tail
      if (canEatFood)
        eatFood(moveValue);
      else
        moveSnakeTail();
      
    }//if
            
  } // move


// ----------------------------------------------------------------------
// Part e-2: move the snake head

  //checks if the snake was bloody prior to moving
  boolean snakeWasBloody;
  
  public void moveSnakeHead(int newHeadPosX, int newHeadPosY)
  {
    //change the new cell into a snakeHead
    grid[newHeadPosX][newHeadPosY].setSnakeHead(Direction
                                  .opposite(snakeDirection),snakeDirection);
    //if the snake was bloody prior to moving, update the direction
    if (snakeWasBloody == true)
    {
      //pressing the right key turns the snakebody to the right
      if (preCrashDirection == Direction.rightTurn(snakeDirection))
        grid[headPosX][headPosY].setSnakeBody(Direction
                                .leftTurn(snakeDirection),snakeDirection);
      //pressing the left key turns the snakebody to the left                                       
      else if (preCrashDirection == Direction.leftTurn(snakeDirection))
        grid[headPosX][headPosY].setSnakeBody(Direction
                                .rightTurn(snakeDirection),snakeDirection);
      //if it neither turns left or right, the snake body follows
      //the snake direction                                        
      else
      {
        grid[headPosX][headPosY].setSnakeBody(Direction
                                .opposite(snakeDirection),snakeDirection);
      }//else
      snakeWasBloody = false;
    }
    else
    {
      //pressing the right key turns the snakebody to the right
      if (oldDirection == Direction.rightTurn(snakeDirection))
        grid[headPosX][headPosY].setSnakeBody(Direction
                                .leftTurn(snakeDirection),snakeDirection);
      //pressing the left key turns the snakebody to the left                                       
      else if (oldDirection == Direction.leftTurn(snakeDirection))
        grid[headPosX][headPosY].setSnakeBody(Direction
                                .rightTurn(snakeDirection),snakeDirection);
      //if it neither turns left or right, the snake body follows
      //the snake direction                                        
      else
      {
        grid[headPosX][headPosY].setSnakeBody(Direction
                                .opposite(snakeDirection),snakeDirection);
      }
    }//if
    
    //updates the original headPosition to the new one
    //finds the next head position
    headPosX = newHeadPosX;
    headPosY = newHeadPosY;
    newHeadPosX = headPosX + Direction.xDelta(snakeDirection);
    newHeadPosY = headPosY + Direction.yDelta(snakeDirection);
    
  }//moveSnakeHead


// ----------------------------------------------------------------------
// Part e-3: move the snake tail
  //hold the X and Y positions of the tail
  private int newTailPosX;
  private int newTailPosY;
  
  //holds the tails outward direction
  private int tailOutDirection;
  
  //moves the snake tail
  public void moveSnakeTail()
  {
    //set the tail out direction to the current tail out direction 
    tailOutDirection = grid[tailPosX][tailPosY].getSnakeOutDirection();
    
    //set the new tail position to the next cell in the tail out direction
    newTailPosX = tailPosX + Direction.xDelta(tailOutDirection);
    newTailPosY = tailPosY + Direction.yDelta(tailOutDirection);
    
    //clear the previous tail cell
    grid[tailPosX][tailPosY].setClear();
    //add a snake tail to the new cell postion
    grid[newTailPosX][newTailPosY].setSnakeTail();
    
    //update the current tail position to the new one
    tailPosX = newTailPosX;
    tailPosY = newTailPosY;
    //recalculate the next tail position
    newTailPosX = tailPosX + Direction.xDelta(tailOutDirection);
    newTailPosY = tailPosY + Direction.yDelta(tailOutDirection);
    
    
  }//moveSnakeTail

// ----------------------------------------------------------------------
// Part e-4: check for and deal with crashes
  public boolean snakeDidNotCrash(int newPosX, int newPosY)
  {
    //if the snake's new head position is outside the gridsize then
    //start countdown. 

    if (newPosX < 0 || newPosX >= gridSize || newPosY < 0 
        || newPosY >= gridSize)
    {
      if (countDownDecrease() == true)
      {
        //Once crashed, set to bloody and change score message
        grid[headPosX][headPosY].setSnakeBloody(true);
        setScoreMessage("You can't go out of bounds!");
      }//if    
      //the snake crashed and now does nothing.
      return false;
    }
    //if the snake's new head position is in the same position as the 
    //tail or body then start crash countdown
    else if (grid[newPosX][newPosY].getType() == 3 
             || grid[newPosX][newPosY].getType() == 4)
            
    {
      if (countDownDecrease() == true)
      { 
        //makes the head and body part bloody and changes score message
        grid[headPosX][headPosY].setSnakeBloody(true);
        grid[newPosX][newPosY].setSnakeBloody(true);
        setScoreMessage("You can't eat yourself!");
      }//if  
      //the snake crashed and now does nothing.
      return false;
        
    }
    //if the snake crashes into a tree then start the countdown
    else if (grid[newPosX][newPosY].getType() == 6)
    {
      if (countDownDecrease() == true)
      {
        //make the head bloody and update score message
        grid[headPosX][headPosY].setSnakeBloody(true);
        setScoreMessage("Snakes can't eat trees!");
      }//if
      //the snake crashed and now does nothing.
      return false;
    }
    else 
    {
      //the snake has not yet crashes as the countdown has not reached 0
      //update currentCountdown to the noOfMoves
      currentCountDown = noOfMoves;
      //the snake has not crashed
      return true;
    }//if
  }//snakeDidNotCrash

// ----------------------------------------------------------------------
// Part e-5: eat the food
  //method used to calculate the score increase, and increases the snake length
  public void eatFood(int moveValue)
  {
    //increments the snake length
    snakeLength += 1;
    int treeScoreIncrease;
    //sets the score to increase by the following formula
    int scoreIncrease = moveValue * 
                        ((snakeLength/ (gridSize * gridSize / 36 + 1)) + 1); 
    //checks if trees are enabled and trees are currently in the field
    if (treesEnabled == true && treeCount > 0)
    {
      //stores the treeScore increase as a multiple of the scoreIncrease
      treeScoreIncrease = scoreIncrease * treeCount;
      //update scoreMessage
      setScoreMessage("Score Increased by " + scoreIncrease + " x " + treeCount 
                      + " = " + treeScoreIncrease + " due to " + treeCount 
                      + " trees on the field");
      //calculates the new snakeScore                
      snakeScore += treeScoreIncrease;
      //places another tree
      placeTree();
      //increments the tree count
      treeCount += 1;
    }
    //Checks if the trees  were enabled and the tree count is 0
    else if (treesEnabled == true && treeCount == 0)
    {
      //changes the treeScoreIncrease to equal just the scoreIncrease
      treeScoreIncrease = scoreIncrease;
      //updates the score message
      setScoreMessage("Your score has been increased by " + treeScoreIncrease);
      //calculates the new snakeScore
      snakeScore += treeScoreIncrease;
      //places another tree
      placeTree();
      //increments the tree count
      treeCount += 1;
    
    }
    else
    { 
      //increase the snake score by itself
      snakeScore += scoreIncrease;
      //update the score message
      setScoreMessage("Your score has been increased by " + scoreIncrease);
    }//if
    //places another piece of food
    placeFood();
        
  }//eatFood
  
  //returns the score
  public int getScore()
  {
    return snakeScore;
  } // getScore


// ----------------------------------------------------------------------
// Part f: cheat

  //method allows you to continue playing after you crash
  public void cheat()
  {
    //resets the countdown back to the max no. of moves
    resetCountDown();
    //updates the score message
    setScoreMessage("You have lost half your points (" + snakeScore/2 
                    + ") for cheating!");
    //halfs the current snake score               
    snakeScore -= snakeScore/2;
    //finds any blood cells and changes them so that they are no
    //longer bloody
    for (int column = 0; column < gridSize; column++)
      for (int row = 0; row < gridSize; row++)
      {
        if (grid[column][row].isSnakeBloody() == true)
          grid[column][row].setSnakeBloody(false);  
        
      }//for
          
    
  } // cheat


// ----------------------------------------------------------------------
// Part g: trees
  //holds the tree count
  private int treeCount;
  
  //initally sets trees enabled to be false
  private boolean treesEnabled = false;

  //toggles trees on the field
  public void toggleTrees()
  {
    //sets treesEnabled to be equal to the opposite value
    treesEnabled = !treesEnabled;
    //checks if trees are enabled and if they are, it places a tree and
    //increments the tree count
    if (treesEnabled)
    {
      placeTree();
      treeCount = 1;
    }
    //otherwise, it checks for any trees on the field and clears them
    //tree count is set to 0 after this.
    else 
    {
      for (int column = 0; column < gridSize; column++)
        for (int row = 0; row < gridSize; row++)
        {
          if (grid[column][row].getType() == 6)
             grid[column][row].setClear();
        }//for
        treeCount = 0;
    }//if
    
  } // toggleTrees
  
  //method to place a tree in the field
  private void placeTree()
  {
   //variables used to stored the cell position of the tree
   int newColumn;
   int newRow;
   //loop which places a tree at a randome cell location
    do
    {
      newColumn  = (int) (Math.random() * gridSize);
      newRow = (int) (Math.random() * gridSize);
    }//do
    while (grid [newColumn][newRow].getType() != 1);
    grid [newColumn][newRow].setTree();
  }//placeTree

// ----------------------------------------------------------------------
// Part h: crash countdown
  //initially sets the noOfMoves they need to make to 5
  private final int noOfMoves = 5;
  
  //sets the current countdown value to equal the number of moves.
  private int currentCountDown = noOfMoves;
  
  //resets the countdown
  private void resetCountDown()
  {
    //Checks if the current countdown is less than the number of moves
    if (currentCountDown <  noOfMoves)
      //updates the score message and sets the countdown to equal noOfMoves.
      setScoreMessage("You have escaped death by " 
                      + (noOfMoves - currentCountDown) + " moves!");
    currentCountDown = noOfMoves;   
  }//resetCountDown
  
  //method used to decrease the countdown
  private boolean countDownDecrease()
  {
    //decrements the countdown variable
    currentCountDown-= 1;
    //checks if the countdown is greater than 0 and if so, updates the score
    //message and returns false to the crash method
    if (currentCountDown > 0)
    {
      setScoreMessage("You only have " + currentCountDown 
                        + " moves before death so move quickly!");
      return false;
    }//if
    else
    //otherwise, returns true to the crash method which reports the snake
    //as crashed 
      return true;
    
  }//countDownDecrease
  
  
  

// ----------------------------------------------------------------------
// Part i: optional extras
  //method used to burn trees
  public void burnTrees()
  {
    //checks if the snake does not crash in the new head position
    if (snakeDidNotCrash(newHeadPosX,newHeadPosY) == false)
    {
      //checks if the new position is a tree
      if (grid[newHeadPosX][newHeadPosY].getType() == 6)
      {
        //if the new position is a tree, it clears the cell
        //and decrements the tree count
        grid[newHeadPosX][newHeadPosY].setClear();
        treeCount --;
      }//if
    
  }//if
  }//burnTrees
  
  //method used to move the food
  public void moveFood()
  {
    
  }
  
  //method used to activate gridtrails
  public void gridTrails()
  {
  
  }
  
  //method which adds text to the help interface for new key mappings
  public String optionalExtras()
  {
    
    return "Press b to burn trees!\nPress m to activate food movement!\n" +
           "Press g to activate grid trails!";
  } // optionalExtras

  //method which adds new key mappings
  public void optionalExtraInterface(char c)
  {
    //checks if the key pressed has a use and either performs its job or
    //returns a message saying the key is not recognized
    if (c > ' ' && c <= '~' && c != 'b' && c != 'm'  && c != 'g')
      setScoreMessage("Key " + new Character(c).toString()
                      + " is unrecognised (try h)");
    else if (c == 'b')
      burnTrees();
    else if (c == 'm')
      moveFood();
    else if (c == 'g')
      gridTrails();
  
  } // optionalExtraInterface

} // class Game
