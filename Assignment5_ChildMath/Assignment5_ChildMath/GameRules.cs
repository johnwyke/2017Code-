using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5_ChildMath
{
    /// <summary>
    /// The Background making the game work.
    /// </summary>
    public class GameRules
    {
        private int iAnswer;
        
        /// <summary>
        /// What Game Mode Player Chose.
        /// </summary>
        public static char gameMode { get; set; }
        /// <summary>
        /// First Number in the Equation.
        /// </summary>
        public static int iNumberOne { get; set; }
        /// <summary>
        /// Second Number in the Equation
        /// </summary>
        public static int iNumberTwo { get; set; }
        /// <summary>
        /// This is the players guess 
        /// </summary>
        public static int iGuess {get;set;}       

        /// <summary>
        /// Generate a random number 
        /// </summary>
        /// <returns></returns>
        public void GenerateNumbers()
        {
            Random RNDNUM = new Random();
            iNumberOne = RNDNUM.Next(0, 10);

            if (gameMode == '/')
            {               
                iNumberTwo = RNDNUM.Next(1, 10);
            } else if (gameMode =='-')
            {
                iNumberTwo = RNDNUM.Next(0, iNumberOne);
            }
            else
            {
                iNumberTwo = RNDNUM.Next(0, 10);
            }        
            
        }
        /// <summary>
        /// Check to see If players Guess is correct If so add to total Score. 
        /// </summary>
        /// <param name="PlayerGuess"></param>
        public void correctAnswer(int PlayerGuess)
        {
            if(PlayerGuess == iAnswer)
            {
                Player.iTotalCorrect++;
            }

        }

        /// <summary>
        /// Generates the answer to the specific equation. Based on the Game Mode. 
        /// </summary>
        public void MathFunction()
        {
            GenerateNumbers();
            if (gameMode == '+')
            {
                iAnswer = iNumberOne + iNumberTwo; 
            }else if(gameMode == '-')
            {
                iAnswer = iNumberOne - iNumberTwo; 
            }else if(gameMode == '*')
            {
                iAnswer = iNumberOne * iNumberTwo;
            }
            else
            {
                iAnswer = iNumberOne / iNumberTwo; 
            } 
        }

       
    
    }
}
