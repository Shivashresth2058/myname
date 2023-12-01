using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Math_game_real
{
    public partial class Form1 : Form
    {
        int numA;
        int numB;
        int total;

        Random rnd = new Random();
        string[] Maths = { "Add", "Subtract", "Multiply" };

        string SecretAnswer;
        string UserChoice;


        public Form1()
        {
            InitializeComponent();
            SetUpGame();
        }
        private void SetUpGame()
        {
            numA = rnd.Next(10, 20);
            numB = rnd.Next(0, 9);
            
            SecretAnswer = Maths[rnd.Next(0, Maths.Length)];

            switch(SecretAnswer) 
            {
                case "Add":
                    total = numA + numB;
                    break;

                case "Subtract":
                    total = numA - numB;
                    break;

                case "Multiply":
                    total = numA * numB;
                    break;

            }

            lblNumA.Text = numA.ToString();
            lblNumB.Text = numB.ToString();
            lblTotal.Text = total.ToString();
            lblSymbol.Text = "?";
        }
         
        private void CheckAnswer()
        {
          if(UserChoice == SecretAnswer)
            {
                MessageBox.Show("correct, Now try again");
                SetUpGame();
            }

            else
            {
                MessageBox.Show("Incorrect, Try Again");
                lblSymbol.Text = "?";
            }

        }
        private void KeyIsUp(object sender, KeyEventArgs e)
        {
         if (e.KeyCode == Keys.Q)
            {
                UserChoice = "Add";
                lblSymbol.Text = "+";
                CheckAnswer();
            }
            if (e.KeyCode == Keys.W)
            {
                UserChoice = "Subtract";
                lblSymbol.Text = "-";
                CheckAnswer();
            }
            if (e.KeyCode == Keys.E)
            {
                UserChoice = "Multiply";
                lblSymbol.Text = "x";
                CheckAnswer();
            }
        }
    }
}
