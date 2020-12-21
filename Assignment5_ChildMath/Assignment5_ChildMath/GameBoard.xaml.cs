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
using System.Windows.Shapes;
using System.Windows.Threading;

namespace Assignment5_ChildMath
{
    /// <summary>
    /// Interaction logic for GameBoard.xaml
    /// </summary>
    public partial class GameBoard : Window
    {
        
        FinalScore wpfFinal;
        private GameRules GAME = new GameRules();
        DispatcherTimer Timer = new DispatcherTimer();
        private bool timerStart = true;
        private int lengthTime;
        private int playerGuess;
        private int QuestionCount=10;
        public GameBoard()
        {
            InitializeComponent();
           // wpfMainMenu = new MainWindow();
            wpfFinal = new FinalScore();
            Timer.Interval = new TimeSpan(0, 0, 1);
            Timer.Tick += Timer_Tick;
        }
        /// <summary>
        /// Counts and Displays  counter
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void Timer_Tick(object sender, EventArgs e)
        {  
            if (timerStart)
            {
                lengthTime = 0;
                timerStart = false;
            }
            else
                lengthTime += 1;
            //lblTimer.Content = DateTime.Now.Second;
            lblTimer.Content = lengthTime;
        }
        /// <summary>
        /// Calls methods to display numbers resets for next question
        /// </summary>
        private void nextQuestion()
        {
            if (QuestionCount > 0)
            {
                GAME.MathFunction();
                SetNumOne();
                SetNumTwo();
                txtGuess.Text = "";
                QuestionCount--;
            }
            else
            {
                btnStart.IsEnabled = false;
                this.Hide();
                wpfFinal.ShowDialog();

            }
        }
        /// <summary>
        /// Gets and displays Numer one
        /// </summary>
        private void SetNumOne() { lblNum1.Content = GameRules.iNumberOne; }
        /// <summary>
        /// Gets and displays number two
        /// </summary>
        private void SetNumTwo() { lblNum2.Content = GameRules.iNumberTwo; }
        /// <summary>
        /// Set and Sidplay GameMode
        /// </summary>
        private void SetSymb() { lblSym.Content = GameRules.gameMode; }
        /// <summary>
        /// Cycles the questions
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnStart_Click(object sender, RoutedEventArgs e)
        {
            int.TryParse(txtGuess.Text, out playerGuess);
            GAME.correctAnswer(playerGuess);
            nextQuestion();
        }
        /// <summary>
        /// Starts the Timer on the Window Load
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Timer.Start();
            SetSymb();
            nextQuestion();
        }

        private void txtGuess_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key <= Key.D0 || e.Key >= Key.D9)
            {
                e.Handled = true;
            }
        }

        private void btnMainMenu_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();

        }

    }
}
