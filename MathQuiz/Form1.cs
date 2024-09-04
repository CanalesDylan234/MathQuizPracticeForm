using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MathQuiz
{
    public partial class Form1 : Form
    {
        // Create a random object called randomizer 
        // generates random numbers 
        Random randomizer = new Random();

        // int to store the numbers for addition problems
        int add1;
        int add2;

        // int to store the numbers for subtraction problems
        int min1;
        int min2;

        // int to store the numbers for multiplication problems
        int mul1;
        int mul2;

        // int to store the numbers for division problems
        int div1;
        int div2;

        // time int variable 
        int timeLeft;

        // Original TimeLabel Color 
        private Color originalTimeLabelColor;

        public Form1()
        {
            InitializeComponent();
            // Store the original background color of the timeLabel
            originalTimeLabelColor = timeLabel.BackColor;
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        // Starts the quiz with numbers and timer
        public void StartTheQuiz()
        {
            // Reset the background color of the timeLabel to the original color 
            timeLabel.BackColor = originalTimeLabelColor;
            // Fill in the addition problem, generate random numbers and store the values 
            add1 = randomizer.Next(51);
            add2 = randomizer.Next(51);

            // Convert the random generated numbers into strings that can be displayed in label controls
            plusLeftLabel.Text = add1.ToString();
            plusRightLabel.Text = add2.ToString();

            // ensures that the sum box is initialized to 0 before adding any values to it 
            Sum.Value = 0;

            // Fill in the subtraction problem.
            min1 = randomizer.Next(1, 101);
            min2 = randomizer.Next(1, min1);
            minusLeftLabel.Text = min1.ToString();
            minusRightLabel.Text = min2.ToString();
            difference.Value = 0;

            // Fill in the multiplication problem.
            mul1 = randomizer.Next(2, 11);
            mul2 = randomizer.Next(2, 11);
            timesLeftLabel.Text = mul1.ToString();
            timesRightLabel.Text = mul2.ToString();
            product.Value = 0;

            // Fill in the division problem.
            div2 = randomizer.Next(2, 11);
            int tempQuotient = randomizer.Next(2, 11);
            div1 = div2 * tempQuotient;
            divLeftLabel.Text = div1.ToString();
            divRightLabel.Text = div2.ToString();
            quotient.Value = 0;

            // Start the timer
            timeLeft = 30;
            timeLabel.Text = "30 seconds";
            timer1.Start();
        }

        // Check the answers given by the user (true if the answer is correct, false if wrong
        private bool CheckTheAnswer()
        {
            if ((add1 + add2 == Sum.Value)
                && (min1 - min2 == difference.Value)
                && (mul1 * mul2 == product.Value)
                && (div1 / div2 == quotient.Value))
            {
                return true;

            }
            else
            {
                return false;
            }
        }

        private void CheckAnswer()
        {
            if (CheckTheAnswer())
            {
                answer_Correct(this, EventArgs.Empty);
            }
        }

        // Click Events 
        private void label1_Click(object sender, EventArgs e)
        {

        }
        //
        private void startButton_Click(object sender, EventArgs e)
        {
            StartTheQuiz();
            startButton.Enabled = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (CheckTheAnswer())
            {
                // If CheckTheAnswer() returns true, then the user got the right answer (Stop the timer and show the message box)
                timer1.Stop();
                MessageBox.Show("You got all the answers correct! Amazing Job!");
                startButton.Enabled = true;
            }
            else if (timeLeft > 0)
            {
                // If the CheckTheAnswer() returns false, keep counting down and decrease each time by 1 second and display the new time left 
                timeLeft = timeLeft - 1;
                timeLabel.Text = timeLeft + " seconds";
                UpdateTimeColor();
            }
            else
            {
                // If the user ran out of time, stop the timer and show a message box wit the answers to each problem
                timer1.Stop();
                timeLabel.Text = "Time's up!";
                MessageBox.Show("Youi didn't finish in time.", "Let's do beter!!");
                Sum.Value = add1 + add2;
                difference.Value = min1 - min2;
                product.Value = mul1 * mul2;
                quotient.Value = div1 / div2;
                startButton.Enabled = true;
            }
        }

        // Change Timer Label Color 
        private void UpdateTimeColor()
        {
            if (timeLeft <= 30 && timeLeft >= 20)
            {
                timeLabel.BackColor = Color.Green;
            }
            else if (timeLeft <= 19 && timeLeft >= 11)
            {
                timeLabel.BackColor = Color.Orange;
            }
            else
            {
                timeLabel.BackColor = Color.Red;
            }
        }
        private void answer_Enter(object sender, EventArgs e)
        {
            // Selects the whole answer in the NumericUpDown control 
            // This parameter refers to the object whose event is firing, which is known as the sender. In this case, the sender object is the NumericUpDown control.
            // first line inside the method casts, or converts, the sender from a generic object to a NumericUpDown control.
            NumericUpDown answerBox = sender as NumericUpDown;

            if (answerBox != null) 
            { 
                int lengthOfAnswer = answerBox.Value.ToString().Length;
                answerBox.Select(0, lengthOfAnswer);
            }
        }

        private void timeLabel_Click(object sender, EventArgs e)
        {
           
        }

        private void answer_Correct(object sender, EventArgs e)
        {
            // Create a SoundPLayer instance
            SoundPlayer player = new SoundPlayer("C:/Users/dcanales/Downloads/mixkit-correct-answer-tone-2870.wav");

            // Play the sound
            player.Play();
        }
    }
}
