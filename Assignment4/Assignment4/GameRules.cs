using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    class GameRules
    {
        private Player playerOne = new Player("Player1", 'X');
        private Player playerTwo = new Player("Player2", 'O');
        private Player cat = new Player("Cat");
        private char[,] gameBoard = new char[3, 3];
        private Boolean playerOneTurn = true;
        public int CountToCat = 1;

        /// <summary>
        /// Checks the Player turn and returns the symbol of the player Changes game text box status.
        /// </summary>
        /// <returns></returns>
        public char getPlayerSymbol()
        {
            if (playerOneTurn)
            {
                playerOneTurn = false;
                
                return playerOne.getSymbol();
            }
            else
            {
                playerOneTurn = true;
                //txtGameStatus.Text = playerOne.getName() + "'s Turn.";
                return playerTwo.getSymbol();
            }

        }

        public Boolean getPlayerTurn
        {
            get 
             { return playerOneTurn; }

            set
            {
                playerOneTurn = value; 
            }
            }

        /// <summary>
        /// THis revieces cell and row index for game board and places symbol in. 
        /// </summary>
        /// <param name="cell"></param>
        /// <param name="row"></param>
        /// <param name="col"></param>
        /// <returns>Players Char</returns>
        public char fillGameBoard(char[,] cell, int row, int col)
        {           
                cell[row,col]= getPlayerSymbol();
            return cell[row, col];

        }

        /// <summary>
        /// Cycles through the 2dArray and checks for a win. If not found return a -1 
        /// </summary>
        /// <param name="cell"></param>
        public int checkRowWinner(char[,] cell)
        {
            char checkValue=' ';
            //Check For Winner in Rows
            for(int i = 0; i < cell.GetLength(0); i++)
            {
                for(int j = 0; j < cell.GetLength(1); j++)
                {
                    if (j==0 && cell[i,j] !='\0' )
                    {
                        checkValue = cell[i, j];
                        continue;
                    }
                    
                    if (cell[i, j] != checkValue)
                    {
                        break;
                    }
                    else if (j == 2)
                    {
                        return i;
                    }
                }

            }
            return -1;
           
        }

        /// <summary>
        /// Cycles through the 2dArray and checks for a win. If not found return a -1 
        /// </summary>
        /// <param name="cell"></param>
        /// <returns></returns>
        public int checkColWinner(char[,] cell)
        {
            char checkValue = ' ';
            //Check for Winners in Cols 
            for (int j = 0; j < cell.GetLength(1); j++)
            {
                for (int i = 0; i < cell.GetLength(0); i++)
                {
                    if (i == 0  && cell[i, j] != '\0')
                    {
                        checkValue = cell[i, j];
                        continue;
                    }

                    if (cell[i, j] != checkValue)
                    {
                        break;
                    }
                    else if(i ==2)
                    {
                        return j; 
                    }
                }
            }
            return -1;
        }

        /// <summary>
        /// Cycles through the 2dArray and checks for a win. If not found return a -1 
        /// </summary>
        /// <param name="cell"></param>
        /// <returns></returns>
        public int checkDiagWinner(char[,] cell)
        {            //Check for Winner Diag 
            if(cell[0, 0] != '\0'&&cell[0,0] == cell[1,1] && cell[1,1] == cell[2, 2])
            {
                // The Top left to Bottom Right wins
                return 0;
            }else if (cell[0, 2] != '\0' && cell[0,2] == cell[1,1] && cell[1,1] == cell[2, 0])
            {
                //The Top right to Bottom Left Wins
                return 1; 
            }else 
            return -1;
        }

        /// <summary>
        /// Add Player wins to respective player
        /// </summary>
        public void calcPlayerWin()
        { 
            if (CountToCat == 9)
            {
                cat.calculateWin();
            }
            else if (!playerOneTurn)
            {
                playerOne.calculateWin();
            }
            else
                playerTwo.calculateWin();
        }
        /// <summary>
        /// BUild Score board text
        /// </summary>
        /// <returns></returns>
        public String getScoreBoard()
        {
            String ScoreText;
            ScoreText = "Player 1: " + playerOne.getWinCount().ToString();
            ScoreText = ScoreText + "\nPlayer 2: " + playerTwo.getWinCount().ToString();
            ScoreText = ScoreText + "\nCat Games: " + cat.getWinCount().ToString();

            return ScoreText;

        }

    }
}
