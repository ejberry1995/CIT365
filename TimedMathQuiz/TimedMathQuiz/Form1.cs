using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Color Pallet: https://coolors.co/0a1b6a-011627-fdfffc-8fbfe0-d64045

namespace TimedMathQuiz
{
    public partial class mathQuizForm : Form
    {
        // Create an object to generate random numbers
        Random randomizer = new Random();

        // Declare variable for tracking time
        int timeLeft;

        // Declare variables for addition problem
        int addend1;
        int addend2;

        // Declare variables for subtraction problem
        int minuend;
        int subtrahend;

        // Declare variables for multiplication problem
        int multiplicand;
        int multiplier;

        // Declare variables for division problem
        int dividend;
        int divisor;

        public mathQuizForm()
        {
            InitializeComponent();
            todayLabel.Text = DateTime.Now.ToString("dd MMMM yyyy");
        }

        // Starts the quiz by generating random numbers,
        // inserting them into the math problems and
        // starting the timer
        public void StartTheQuiz() 
        {
            // generate random numbers for addition
            addend1 = randomizer.Next(51);
            addend2 = randomizer.Next(51);

            // insert the numbers into the addition problem
            addendLeftLabel.Text  = addend1.ToString();
            addendRightLabel.Text = addend2.ToString();

            // generate random numbers for subtraction
            minuend = randomizer.Next(1, 101);
            subtrahend = randomizer.Next(1, minuend);

            // insert the numbers into the subtraction problem
            minuendLabel.Text = minuend.ToString();
            subtrahendLabel.Text = subtrahend.ToString();

            // generate random numbers for multiplication
            multiplicand = randomizer.Next(2, 11);
            multiplier = randomizer.Next(2, 11);

            // insert the numbers into the multiplication problem
            multiplicandLabel.Text = multiplicand.ToString();
            multiplierLabel.Text = multiplier.ToString();

            // generate random numbers for multiplication
            divisor = randomizer.Next(2, 11);
            int tempQuotient = randomizer.Next(2, 11);
            dividend = divisor * tempQuotient;

            // insert the numbers into the multiplication problem
            dividendLabel.Text = dividend.ToString();
            divisorLabel.Text = divisor.ToString();

            // start the timer
            timeLeft = 30;
            timeLabel.Text = "30 seconds";
            quizTimer.Start();

        }

        //check if the the user's answers are correct
        private bool CheckTheAnswer()
        {
            if ((addend1 + addend2 == sumUpDown.Value)
                && (minuend - subtrahend == differenceUpDown.Value)
                && (multiplicand * multiplier == productUpDown.Value)
                && (dividend / divisor == quotientUpDown.Value))
                return true;
            else
                return false;
        }

        //defines what happens when the start button is clicked
        private void startButton_Click(object sender, EventArgs e)
        {
            StartTheQuiz();

            startButton.Visible = false;
            startButton.Enabled = false;

        }

        private void quizTimer_Tick(object sender, EventArgs e)
        {
            if (CheckTheAnswer())
            {
                quizTimer.Stop();

                //show a messagebox
                MessageBox.Show("You got all the answers right!",
                                    "Congragulations");
                startButton.Enabled = true;
            }
            else if (timeLeft > 0)
            {
                // update the time display
                timeLeft--;
                timeLabel.Text = timeLeft + " Seconds";
                if (timeLeft < 6)
                    timeLabel.ForeColor = Color.FromArgb(214,64,69);
            }
            else
            {
                quizTimer.Stop();

                // update the display and show a message box
                timeLabel.Text = "0 Seconds";
                MessageBox.Show("You didn't finish in time.", "Sorry!");

                // display the correct answers
                sumUpDown.Value = addend1 + addend2;
                differenceUpDown.Value = minuend - subtrahend;
                productUpDown.Value = multiplicand * multiplier;
                quotientUpDown.Value = dividend / divisor;

                reset_quiz();
                
            }
        }

        private void reset_quiz()
        {
            //reset the start button
            startButton.Visible = true;
            startButton.Enabled = true;

            timeLabel.ForeColor = Color.FromArgb(1, 22, 39);
            timeLabel.Text = "30 Seconds";

            // ensure answer values are all zero
            sumUpDown.Value = 0;
            differenceUpDown.Value = 0;
            productUpDown.Value = 0;
            quotientUpDown.Value = 0;
        }

        private void answer_Enter(object sender, EventArgs e)
        {
            //Select the whole anser in the NumericUpDown control
            NumericUpDown answerBox = sender as NumericUpDown;

            if (answerBox != null)
            {
                int lengthOfAnswer = answerBox.Value.ToString().Length;
                answerBox.Select(0, lengthOfAnswer);
            }
        }

    }
}
