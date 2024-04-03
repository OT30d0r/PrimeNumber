using System;
using System.Drawing;
using System.Windows.Forms;

namespace PrimeNumber
{
    public partial class PrimeNumberForm : Form
    {
        public PrimeNumberForm()
        {
            InitializeComponent();
        }

        private void PrimeNumberTextBox_TextChanged(object sender, EventArgs e)
        {
            // Resetăm culoarea de fundal la implicit
            this.BackColor = SystemColors.Control;
        }

        private void CheckButton_Click(object sender, EventArgs e)
        {
            int result = 0;
            bool isNumber = Int32.TryParse(PrimeNumberTextBox.Text, out result);
            if (isNumber)
            {
                if (result > 1)
                {
                    bool isPrime = true;
                    for (int i = 2; i <= result / 2; i++)
                    {
                        if (result % i == 0)
                        {
                            isPrime = false;
                            break;
                        }
                    }
                    if (isPrime)
                    {
                        TrueOrFalseLabel.Text = "true";
                        this.BackColor = Color.Green;
                    }
                    else
                    {
                        TrueOrFalseLabel.Text = "false";
                        this.BackColor = Color.Red;
                    }
                }

            }
            else
            {
                TrueOrFalseLabel.Text = "false";
                this.BackColor = Color.Yellow;
                MessageBox.Show("Nu s-a introdus un număr întreg.");
            }
        }
    }
}