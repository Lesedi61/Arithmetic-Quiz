using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quiz_Drill
{
    public partial class Form1 : Form
    {
        Random rnd = new Random();
        string [] Maths = { "Add", "Subtract", "Multiple", "Division" };
        int total,quesNum=0;
        int score=0;
        public Form1()
        {
            InitializeComponent();
            lblStatus.Text = null;
            lblComplete.Text = null;
            lblPercent.Text = null;
            lblScore.Text = null;
            lblRestart.Visible = false;
            SetupApplication();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void CheckAnswer(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(lblAnswer.Text, "[^0-9-]")) // Input Validation
            {
                MessageBox.Show("Please Enter Numbers Only");
                lblAnswer.Text = lblAnswer.Text.Remove(lblAnswer.Text.Length - 1); // Erase Invalid Value

            }
        }

        private void CheckBtnSubmit(object sender, EventArgs e)
        {
            
            if (lblAnswer.TextLength == 0) // Check if textfield is empty
            {
                MessageBox.Show("Please Enter Your Answer");
            }
            else
            {
                int userAnswer = Convert.ToInt32(lblAnswer.Text);
                if (userAnswer == total) // Check if user entered correct answer
                {
                    lblStatus.Text = "Correct";
                    lblStatus.ForeColor = Color.Green;
                    score += 1;
                    SetupApplication();
                }
                else
                {
                    lblStatus.Text = "Incorrect, Correct Answer Is "+total.ToString(); // Display correct answer
                    lblStatus.ForeColor = Color.Red;
                    SetupApplication();
                }
            }
            if (quesNum > 10)
            {
              
                lblScore.Text = "Score : "+score.ToString() + "/10"; // Display score
                lblComplete.Text = "You Have Completed Your Quiz Successfully";
                lblSubmit.Enabled = false; // Disable submit button after completng quiz
                lblRestart.Visible = true; // Show Restart button after completion

            }
            
        }

        private void lblRestart_Click(object sender, EventArgs e)
        {
            // Restart application
            quesNum = 0;
            score = 0;
            lblSubmit.Enabled = true;
            lblRestart.Visible = false;
            lblStatus.Text = null;
            lblComplete.Text = null;
            lblPercent.Text = null;
            lblScore.Text = null;
            lblRestart.Visible = false;

            SetupApplication();
        }

        private void SetupApplication()
        {
            int numA=0;
            int numB=0;

            lblAnswer.Text = null; // Erase previous answer

            switch (Maths[rnd.Next(0, Maths.Length)])
            {
                case "Add":
                    numA = rnd.Next(0, 50); // Generate random values
                    numB = rnd.Next(0, 50);
                    total = numA + numB;
                    logiOper.Text = "+";
                    logiOper.ForeColor = Color.DarkGreen;
                    break;
                case "Subtract":
                    numA = rnd.Next(0, 50);
                    numB = rnd.Next(0, 50);
                    total = numA - numB;
                    logiOper.Text = "-";
                    logiOper.ForeColor = Color.Maroon;
                    break;
                case "Multiple":
                    numA = rnd.Next(0, 12);
                    numB = rnd.Next(0, 12);
                    total = numA * numB;
                    logiOper.Text = "x";
                    logiOper.ForeColor = Color.Purple;
                    break;
                case "Division":
                    numA = rnd.Next(0, 13);
                    numB = rnd.Next(0, 13);
                    total = numA / numB;
                    logiOper.Text = "/";
                    logiOper.ForeColor = Color.Blue;
                    break;
            }
            lblNumA.Text = numA.ToString();
            lblNumB.Text = numB.ToString();
            quesNum += 1;
            lblQuesNum.Text = quesNum.ToString()+".";
             
        }
    }
}
