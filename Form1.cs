using System;
using System.Windows.Forms;

namespace WindowsFormsApp19
{
    public partial class Form1 : Form
    {
        int count = default;
        bool check = default;
        public Form1()
        {
            InitializeComponent();
        }

        private void button9_MouseClick(object sender, MouseEventArgs e)
        {
            Button button = (Button)sender;
            if (check == true)
                button.Text = "X";
            else
                button.Text = "O";

            check = !check;
            count++;
            button.Enabled = false;
            CheckGame();
        }

        private void CheckGame()
        {
            if ((button1.Text == button2.Text && button2.Text == button3.Text) && (button1.Text == "X" || button1.Text == "O")) { MessageBox.Show($"Win {button1.Text}"); Environment.Exit(0); }
            else if ((button4.Text == button5.Text && button5.Text == button6.Text) && (button4.Text == "X" || button4.Text == "O")) { MessageBox.Show($"Win {button4.Text}"); Environment.Exit(0); }
            else if ((button7.Text == button8.Text && button8.Text == button9.Text) && (button9.Text == "X" || button9.Text == "O")) { MessageBox.Show($"Win {button9.Text}"); Environment.Exit(0); }
            else if ((button1.Text == button5.Text && button5.Text == button9.Text) && (button1.Text == "X" || button1.Text == "O")) { MessageBox.Show($"Win {button1.Text}"); Environment.Exit(0); }
            else if ((button3.Text == button5.Text && button5.Text == button7.Text) && (button3.Text == "X" || button3.Text == "O")) { MessageBox.Show($"Win {button3.Text}"); Environment.Exit(0); }
            else if ((button1.Text == button4.Text && button4.Text == button7.Text) && (button1.Text == "X" || button1.Text == "O")) { MessageBox.Show($"Win {button1.Text}"); Environment.Exit(0); }
            else if ((button1.Text == button4.Text && button4.Text == button7.Text) && (button1.Text == "X" || button1.Text == "O")) { MessageBox.Show($"Win {button1.Text}"); Environment.Exit(0); }
            else if ((button2.Text == button5.Text && button5.Text == button8.Text) && (button2.Text == "X" || button2.Text == "O")) { MessageBox.Show($"Win {button2.Text}"); Environment.Exit(0); }
            else if ((button3.Text == button6.Text && button6.Text == button9.Text) && (button3.Text == "X" || button3.Text == "O")) { MessageBox.Show($"Win {button3.Text}"); Environment.Exit(0); }
        }
    }
}
