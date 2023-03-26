/*Author: Jared Gratz
 *Date: 17/08/2022
 *Purpose: Provide functionality to the Windows Form application.
 */
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Hangman
{
    public partial class frmForm1 : Form
    {
        //initialization
        private SortedList scores = new SortedList();
        private ArrayList words = new ArrayList()
        {
            "silly","artist","turn","suspicious", "computer", "ate","sit","at","no","zero","sleeping","program"
        };
        private ArrayList wrongGuesses = new ArrayList();
        private ArrayList rightGuesses = new ArrayList();
        private int guesses = 0;
        private bool gameActiveFlag = false;
        private Random rand;
        private string guessWord = null;
        private string refGuessWord = null;
        private Regex checker;
        public string displayWord = null;

        //Method to handle Key presses, also the main processes of the game
        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            //The key press event from the form
            if (gameActiveFlag)//checks if game is actually active first before accepting input
            {
                string key = ("" + e.KeyChar).ToLower();//stores the input into a string and normalised to lower case
                if (checker.IsMatch(key))//regex checker to only accept letters
                {
                    guesses += 1;//increment score
                    lblDisplayGuessCount.Text = guesses.ToString();
                    //Implement a max of 10 guesses within the if statement one by the wrong guess process and one by correct process
                    if (guessWord.Contains(key))
                    {
                        //correct guess process
                        if (!rightGuesses.Contains(key))
                        {
                            rightGuesses.Add(key);
                        }
                        guessWord = guessWord.Replace(key, "*");
                        string temp = "";
                        for (int i = 0; i < guessWord.Length; i++)
                        {
                            if (guessWord[i] == '*')
                            {
                                temp = temp + refGuessWord[i];
                            }
                            else
                            {
                                temp = temp + "*";

                            }
                        }
                        displayWord = temp.ToLower();
                        txtDisplayWord.Text = displayWord;
                        if (!displayWord.Contains('*') && guesses <= 10)
                        {
                            //win process
                            gameActiveFlag = false;//no more input will be accepted
                            lblFinished.Visible = true;
                            string scoreText = "Won: " + guessWord.Length + " letters, " + guesses + " guesses";
                            scores.Add(DateTime.Now, scoreText);
                            lstScores.Items.Clear();
                            for (int i = 0; i < scores.Count; i++)
                            {
                                lstScores.Items.Add(scores.GetByIndex(i) + ": " + scores.GetKey(i));
                            }
                        }
                        else if(guesses == 10)
                        {
                            //lose process
                            gameActiveFlag = false;//no more input will be accepted
                            lblFinished.Visible = true;
                            string scoreText = "Lost: " + guessWord.Length + " letters, " + guesses + " guesses";
                            scores.Add(DateTime.Now, scoreText);
                            lstScores.Items.Clear();
                            for (int i = 0; i < scores.Count; i++)
                            {
                                lstScores.Items.Add(scores.GetByIndex(i) + ": " + scores.GetKey(i));
                            }
                        }
                    }
                    else
                    {
                        //wrong guess process
                        if (!wrongGuesses.Contains(key) & !refGuessWord.Contains(key))
                        {
                            wrongGuesses.Add(key);
                            lstGuessLetters.Items.Add(key);
                        }
                        if (guesses == 10)
                        {
                            //lose process
                            gameActiveFlag = false;//no more input will be accepted
                            lblFinished.Visible = true;
                            string scoreText = "Lost: " + guessWord.Length + " letters, " + guesses + " guesses";
                            scores.Add(DateTime.Now, scoreText);
                            lstScores.Items.Clear();
                            for (int i = 0; i < scores.Count; i++)
                            {
                                lstScores.Items.Add(scores.GetByIndex(i) + ": " + scores.GetKey(i));
                            }
                        }
                    }         
                }
            }
        }
        public frmForm1()
        {
            InitializeComponent();
            //Initialize the Random and Regex object
            rand = new Random();
            checker = new Regex("[a-z]");
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            //To close the game
            Application.Exit();
        }

        private void btnNewWord_Click(object sender, EventArgs e)
        {
            //Start with a new word and clears display
            gameActiveFlag = true;
            lblFinished.Visible = false;
            guesses = 0;
            guessWord = (string) words[rand.Next(0, words.Count)];
            refGuessWord = guessWord;
            displayWord = "";
            for(int i = 0; i < guessWord.Length; i++)
            {
                displayWord += "*";
            }
            wrongGuesses.Clear();
            rightGuesses.Clear();
            lstGuessLetters.Items.Clear();
            lblDisplayGuessCount.Text = guesses.ToString();
            txtDisplayWord.Text = displayWord;
        }
    }
}
