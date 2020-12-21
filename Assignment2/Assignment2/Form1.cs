using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;


namespace Assignment2
{
    public partial class Form1 : Form
    {
        private int iplayerChoie1;
        private int iplayerChoie2;
        private int iplayerChoie3;
        private int iplayerChoie4;
        private int iplayerChoie5;
        private int iplayerChoie6;

        private int iCompChoie1;
        private int iCompChoie2;
        private int iCompChoie3;
        private int iCompChoie4;
        private int iCompChoie5;
        private int iCompChoie6;

        private Double dPercent1;
        private Double dPercent2;
        private Double dPercent3;
        private Double dPercent4;
        private Double dPercent5;
        private Double dPercent6;

        public Form1()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Roll the dice and display Image
        /// </summary>
        /// <returns></returns>
        private int rollDice()
        {
            int iDice = 0;
            Random rnd = new Random();
            for (int i = 0; i < 5; i++)
            {
                iDice = rnd.Next(1, 7);
                pbDice.Image = Image.FromFile("die" + iDice.ToString() + ".gif");
                pbDice.Refresh();
                Thread.Sleep(300);
            }

            return iDice;
        }

        /// <summary>
        /// This Method resets to text fields in the form. It real initializes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnReset_Click(object sender, EventArgs e)
        {
            lblTimesPlayed.Text = "......";
            lblWon.Text = "......";
            lblLost.Text = "......";
            txtFeqDisplay.Text = "";
            txtGuess.Text = "";
            iplayerChoie1=0;
            iplayerChoie2=0;
            iplayerChoie3=0;
            iplayerChoie4=0;
            iplayerChoie5=0;
            iplayerChoie6 = 0;

            iCompChoie1=0;
            iCompChoie2=0;
            iCompChoie3=0;
            iCompChoie4=0;
            iCompChoie5=0;
            iCompChoie6 = 0;

            dPercent1=0.0;
            dPercent2=0.0;
            dPercent3=0.0;
            dPercent4=0.0;
            dPercent5=0.0;
            dPercent6 = 0.0;

        }
        /// <summary>
        /// Verifies User entry and Calls Dice roll. Calls methods to update fields
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bnRoll_Click(object sender, EventArgs e)
        {
            int iguess;
            int iDice;
            int iTotal;

            lblInvalid.Text = "";
            if (Int32.TryParse(txtGuess.Text, out iguess))
            {
                if (iguess > 6)
                {
                    lblInvalid.Text = "Please enter a valid number (1-6)";
                }
            }
            else
            {
                lblInvalid.Text = "Please enter a valid number (1-6)";
            }
            iDice = rollDice();

            checkWinner(iguess, iDice);            

            Int32.TryParse(lblTimesPlayed.Text, out iTotal);
            iTotal += 1;
            lblTimesPlayed.Text = iTotal.ToString();

            buildfreqtext(iguess, iDice, iTotal);
        }
        /// <summary>
        /// Take is two integers compares and to choose a winner, loser, and calculate amount of times played.Updates win or lost field 
        /// </summary>
        /// <param name="iPlayerGuess"></param>
        /// <param name="iDiceRoll"></param>
        private void checkWinner(int iPlayerGuess, int iDiceRoll)
        {
            int itext;
            if (iPlayerGuess == iDiceRoll)
            {
                Int32.TryParse(lblWon.Text, out itext);
                ++itext;
                lblWon.Text = itext.ToString();
            }
            else
            {
                Int32.TryParse(lblLost.Text, out itext);
                ++itext;
                lblLost.Text = itext.ToString();
            }
        }

/// <summary>
/// Build the way that txtFreqDisplay is rendered. Also call update methods
/// </summary>
/// <param name="iguess"></param>
/// <param name="idice"></param>
        private void buildfreqtext(int iguess, int idice, int itotal)
        {
            updateplayercounter(iguess);
            updatecompcounter(idice);
            calculatePercent(itotal, idice);

            txtFeqDisplay.Text = "FACE\tFREQUENCY\tPERCENT\tNUMBER OF TIMES GUESSED";
            txtFeqDisplay.Text = txtFeqDisplay.Text + "\n1\t\t" + iCompChoie1.ToString() + "\t" + dPercent1.ToString() + "%\t\t\t" + iplayerChoie1.ToString();
            txtFeqDisplay.Text = txtFeqDisplay.Text + "\n2\t\t" + iCompChoie2.ToString() + "\t" + dPercent2.ToString() + "%\t\t\t" + iplayerChoie2.ToString();
            txtFeqDisplay.Text = txtFeqDisplay.Text + "\n3\t\t" + iCompChoie3.ToString() + "\t" + dPercent3.ToString() + "%\t\t\t" + iplayerChoie3.ToString();
            txtFeqDisplay.Text = txtFeqDisplay.Text + "\n4\t\t" + iCompChoie4.ToString() + "\t" + dPercent4.ToString() + "%\t\t\t" + iplayerChoie4.ToString();
            txtFeqDisplay.Text = txtFeqDisplay.Text + "\n5\t\t" + iCompChoie5.ToString() + "\t" + dPercent5.ToString() + "%\t\t\t" + iplayerChoie5.ToString();
            txtFeqDisplay.Text = txtFeqDisplay.Text + "\n6\t\t" + iCompChoie6.ToString() + "\t" + dPercent6.ToString() + "%\t\t\t" + iplayerChoie6.ToString();

        }
      /// <summary>
      /// Caclulate the respective percentages based on the dice face. 
      /// </summary>
      /// <param name="itotal"></param>
      /// <param name="idice"></param>
        private void calculatePercent(int itotal, int idice)
        {
            
                    dPercent1 = ((double)iCompChoie1 / (double)itotal) * 100;
                                 
                    dPercent2 = ((double)iCompChoie2 / (double)itotal) *100;
                                 
                    dPercent3 = ((double)iCompChoie3 / (double)itotal) *100;
                                 
                    dPercent4 = ((double)iCompChoie4 / (double)itotal) * 100;
                                 
                    dPercent5 = ((double)iCompChoie5 / (double)itotal)*100;
                               
                    dPercent6 = ((double)iCompChoie6 / (double)itotal)*100;
            dPercent1 = Math.Round(dPercent1,2);
            dPercent2 = Math.Round(dPercent2,2);
            dPercent3 = Math.Round(dPercent3,2);
            dPercent4 = Math.Round(dPercent4,2);
            dPercent5 = Math.Round(dPercent5,2);
            dPercent6 = Math.Round(dPercent6,2);

        }

        /// <summary>
        /// Choose with Playre Choice to update 
        /// </summary>
        /// <param name="iguess"></param>
        private void updateplayercounter(int iguess)
        {
            switch (iguess)
            {
                case 1:
                    iplayerChoie1++;
                    break;
                case 2:
                    iplayerChoie2++;
                    break;
                case 3:
                    iplayerChoie3++;
                    break;
                case 4:
                    iplayerChoie4++;
                    break;
                case 5:
                    iplayerChoie5++;
                    break;
                case 6:
                    iplayerChoie6++;
                    break;

                default:
                    break;
            }

        }

        /// <summary>
        /// Choose with Computer Choice to update 
        /// </summary>
        /// <param name="iroll"></param>
        private void updatecompcounter(int iroll)
        {
            switch (iroll)
            {
                case 1:
                    iCompChoie1++;
                    break;
                case 2:
                    iCompChoie2++;
                    break;
                case 3:
                    iCompChoie3++;
                    break;
                case 4:
                    iCompChoie4++;
                    break;
                case 5:
                    iCompChoie5++;
                    break;
                case 6:
                    iCompChoie6++;
                    break;

                default:
                    break;
            }


        }
    }
}
