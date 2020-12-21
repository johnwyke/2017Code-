using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Assignment4
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private GameRules game = new GameRules();
        private char[,] gameBoard = new char[3, 3];
        private Boolean gameStart = true;
        

        public MainWindow()
        {
            InitializeComponent();
  
        }

        /// <summary>
        /// Calculate and display ScoreBaord
        /// </summary>
        private void generateScoreBoard()
        {
            
            if (!game.getPlayerTurn)
            {
                txtGameStatus.Text = "Player One Wins!!!";
                game.calcPlayerWin();
                txtWinCount.Text = game.getScoreBoard();
            }
            else if(game.getPlayerTurn)
            {
                txtGameStatus.Text = "Player Two WIns!!";
                game.calcPlayerWin();
                txtWinCount.Text = game.getScoreBoard();
            }else if (game.CountToCat == 9)
            {
                txtGameStatus.Text = "Its a Tie";
                game.calcPlayerWin();
                txtWinCount.Text = game.getScoreBoard();
            }
        }

        /// <summary>
        /// Sets buttons content and Color back to normal. INitalize the 2d array 
        /// </summary>
        private void initForm()
        {
            btnBottomLeft.Content = "";
            btnBottomLeft.Background = Brushes.Green;
            btnBottommid.Content = "";
            btnBottommid.Background = Brushes.Green;
            btnBottomRight.Content = "";
            btnBottomRight.Background = Brushes.Green;
            btnCenterLeft.Content = "";
            btnCenterLeft.Background = Brushes.Green;
            btnCenterMid.Content = "";
            btnCenterMid.Background = Brushes.Green;
            btnCenterRight.Content = "";
            btnCenterRight.Background = Brushes.Green;
            btnTopLeft.Content = "";
            btnTopLeft.Background = Brushes.Green;
            btnTopMid.Content = "";
            btnTopMid.Background = Brushes.Green;
            btnTopRight.Content = "";
            btnTopRight.Background = Brushes.Green;
            game.CountToCat = 1;

            for (int i = 0; i < gameBoard.GetLength(0); i++)
            {
                for (int j = 0; j < gameBoard.GetLength(1); j++)
                {
                    gameBoard[i, j] = '\0';
                }
            }


        }
        /// <summary>
        /// Checks the winner the three diferrent ways. Then Colors respective buttons if found
        /// </summary>
        private void checkWinner()
        {
            int CheckValue;
                        if (game.checkRowWinner(gameBoard) != -1)
            {
                CheckValue = game.checkRowWinner(gameBoard); 
                if(CheckValue ==0)
                {
                    btnTopLeft.Background = Brushes.Gold;
                    btnTopMid.Background = Brushes.Gold;
                    btnTopRight.Background = Brushes.Gold;
                }
                else if (CheckValue == 1)
                {
                    btnCenterLeft.Background = Brushes.Gold;
                    btnCenterMid.Background = Brushes.Gold;
                    btnCenterRight.Background = Brushes.Gold;
                }
                else
                {
                    btnBottomLeft.Background = Brushes.Gold;
                    btnBottommid.Background = Brushes.Gold;
                    btnBottomRight.Background = Brushes.Gold;
                }
                generateScoreBoard();
                enableDisable(false);

            }
            else if (game.checkColWinner(gameBoard) != -1)
            {
                CheckValue = game.checkColWinner(gameBoard);
                if(CheckValue == 0)
                {
                    btnTopLeft.Background = Brushes.Gold;
                    btnCenterLeft.Background = Brushes.Gold;
                    btnBottomLeft.Background = Brushes.Gold; 
                }else if (CheckValue == 1)
                {
                    btnTopMid.Background = Brushes.Gold;
                    btnCenterMid.Background = Brushes.Gold;
                    btnBottommid.Background = Brushes.Gold;
                }
                else
                {
                    btnTopRight.Background = Brushes.Gold;
                    btnCenterRight.Background = Brushes.Gold;
                    btnBottomRight.Background = Brushes.Gold;
                }
                generateScoreBoard();
                enableDisable(false);

            }
            else if (game.checkDiagWinner(gameBoard) != -1)
            {
                CheckValue = game.checkDiagWinner(gameBoard);
                
                if (CheckValue == 0)
                {
                    btnTopLeft.Background = Brushes.Gold;
                    btnCenterMid.Background = Brushes.Gold;
                    btnBottomRight.Background = Brushes.Gold;
                }else
                {
                    btnTopRight.Background = Brushes.Gold;
                    btnCenterMid.Background = Brushes.Gold;
                    btnBottomLeft.Background = Brushes.Gold;
                }
                generateScoreBoard();
                enableDisable(false);
            }
            if (game.CountToCat == 9)
            {
                generateScoreBoard();
                enableDisable(false);

            }
            else
                game.CountToCat++;
        }

        /// <summary>
        /// Enable all buttons in grid or not. 
        /// </summary>
        /// <param name="Enable"></param>
        private void enableDisable(Boolean Enable)
        {
            
            btnTopLeft.IsEnabled = Enable;
            btnTopMid.IsEnabled = Enable;
            btnTopRight.IsEnabled = Enable;
            btnCenterLeft.IsEnabled = Enable;
            btnCenterMid.IsEnabled = Enable;
            btnCenterRight.IsEnabled = Enable;
            btnBottomLeft.IsEnabled = Enable;
            btnBottommid.IsEnabled = Enable;
            btnBottomRight.IsEnabled = Enable; 
          
        }
        /// <summary>
        /// Beings the game and enables all buttons.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnStart_Click(object sender, RoutedEventArgs e)
        {      
            if (!gameStart)
            {
                initForm();
            }
            gameStart = false;
            enableDisable(true);
            game.getPlayerTurn = true;
            txtGameStatus.Text = "Player 1's Turn";

        }

        #region "All Grid Button Clicks"
        private void btnTopLeft_Click(object sender, RoutedEventArgs e)
        {
            if (btnTopLeft.Content == null || btnTopLeft.Content.ToString() =="")
            {
                if (game.getPlayerTurn)
                    txtGameStatus.Text = "Player 2's Turn.";

                else
                    txtGameStatus.Text = "Player 1's Turn.";
                btnTopLeft.Content = game.fillGameBoard(gameBoard, 0, 0);
                

                checkWinner();
            }
            else
            {
                txtGameStatus.Text = "A player has already made that Play. Guess again.";
            }

        }
        private void btnTopMid_Click(object sender, RoutedEventArgs e)
        {
            if (btnTopMid.Content == null || btnTopMid.Content.ToString() == "")
            {
                if (game.getPlayerTurn)
                    txtGameStatus.Text = "Player 2's Turn.";

                else
                    txtGameStatus.Text = "Player 1's Turn.";
                btnTopMid.Content = game.fillGameBoard(gameBoard, 0, 1);
                
                checkWinner();
            }
            else
            {
                txtGameStatus.Text = "A player has already made that Play. Guess again.";
            }
        }

        private void btnTopRight_Click(object sender, RoutedEventArgs e)
        {
            if (btnTopRight.Content == null || btnTopRight.Content.ToString() == "")
            {
                if (game.getPlayerTurn)
                    txtGameStatus.Text = "Player 2's Turn.";

                else
                    txtGameStatus.Text = "Player 1's Turn.";
                btnTopRight.Content = game.fillGameBoard(gameBoard, 0, 2);
                
                checkWinner();
            }
            else
            {
                txtGameStatus.Text = "A player has already made that Play. Guess again.";
            }
        }

        private void btnCenterLeft_Click(object sender, RoutedEventArgs e)
        {
            if (btnCenterLeft.Content == null || btnCenterLeft.Content.ToString() == "")
            {
                if (game.getPlayerTurn)
                    txtGameStatus.Text = "Player 2's Turn.";

                else
                    txtGameStatus.Text = "Player 1's Turn.";
                btnCenterLeft.Content = game.fillGameBoard(gameBoard, 1, 0);
               
                checkWinner();
            }
            else
            {
                txtGameStatus.Text = "A player has already made that Play. Guess again.";
            }
        }

        private void btnCenterMid_Click(object sender, RoutedEventArgs e)
        {
            if (btnCenterMid.Content == null || btnCenterMid.Content.ToString() == "")
            {
                if (game.getPlayerTurn)
                    txtGameStatus.Text = "Player 2's Turn.";

                else
                    txtGameStatus.Text = "Player 1's Turn.";
                btnCenterMid.Content = game.fillGameBoard(gameBoard, 1, 1);
                checkWinner();
            }
            else
            {
                txtGameStatus.Text = "A player has already made that Play. Guess again.";
            }
        }

        private void btnCenterRight_Click(object sender, RoutedEventArgs e)
        {
            if (btnCenterRight.Content == null || btnCenterRight.Content.ToString() == "")
            {
                if (game.getPlayerTurn)
                    txtGameStatus.Text = "Player 2's Turn.";

                else
                    txtGameStatus.Text = "Player 1's Turn.";
                btnCenterRight.Content = game.fillGameBoard(gameBoard, 1, 2);
                checkWinner();
            }
            else
            {
                txtGameStatus.Text = "A player has already made that Play. Guess again.";
            }
        }

        private void btnBottomLeft_Click(object sender, RoutedEventArgs e)
        {
            if (btnBottomLeft.Content == null || btnBottomLeft.Content.ToString() == "")
            {
                if (game.getPlayerTurn)
                    txtGameStatus.Text = "Player 2's Turn.";

                else
                    txtGameStatus.Text = "Player 1's Turn.";
                btnBottomLeft.Content = game.fillGameBoard(gameBoard, 2, 0);
                checkWinner();
            }
            else
            {
                txtGameStatus.Text = "A player has already made that Play. Guess again.";
            }
        }

        private void btnBottommid_Click(object sender, RoutedEventArgs e)
        {
            if (btnBottommid.Content == null || btnBottommid.Content.ToString() == "")
            {
                if (game.getPlayerTurn)
                    txtGameStatus.Text = "Player 2's Turn.";

                else
                    txtGameStatus.Text = "Player 1's Turn.";
                btnBottommid.Content = game.fillGameBoard(gameBoard, 2, 1);
                checkWinner();
            }
            else
            {
                txtGameStatus.Text = "A player has already made that Play. Guess again.";
            }
        }

        private void btnBottomRight_Click(object sender, RoutedEventArgs e)
        {
            if (btnBottomRight.Content == null || btnBottomRight.Content.ToString() == "")
            {
                if (game.getPlayerTurn)
                    txtGameStatus.Text = "Player 2's Turn.";

                else
                    txtGameStatus.Text = "Player 1's Turn.";
                btnBottomRight.Content = game.fillGameBoard(gameBoard, 2, 2);
                checkWinner();
            }
            else
            {
                txtGameStatus.Text = "A player has already made that Play. Guess again.";
            }
        }
#endregion
    }
}
