using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace typing_tutor
{

    public partial class Form1 : Form
    {

        string[] words = { "PC", "Laptop", "Server", "Computer", "Motherboard", "CPU", "RAM", "Port", "Mainframe", "Modem", "USB", "Coding", "Hacked", "Firewall", "Debug", "Web", "Virtual", "Reboot", "Bits", "Cookie" };

        Random rnd = new Random(); //Initialize random number generator

        int Correct = 0;
        int Incorrect = 0;
        // Keeps track of words array
        public static int numWords = 20;
        
        public Form1()
        {
            InitializeComponent();
            lblword.Text = words[rnd.Next(0, words.Length)];
        }

        /* The following block of code will be executed if the new game button is pressed
         * The counts are going to be initialised
         * The below code will also call the rendom class again to keep words random
         */


        private void txtEnty_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (Char.IsControl(e.KeyChar) && e.KeyChar == 13) // When enter is presed the following code will execute.
            {


                if (inputbox.Text == lblword.Text)
                {
                    Correct++;  // Correct count is incremented
                    lblword.Text = words[rnd.Next(0, words.Length)];
                    wordsTyped.Items.Add(inputbox.Text); //The text will be added to the Listbox 
                    inputbox.Text = null; //Return the textbox empty for the user to type in the next word


                }
                else
                {
                    Incorrect++; // Incorrect count is incremented
                    lblword.Text = words[rnd.Next(0, words.Length)];
                    inputbox.Text = null;


                }

                lblcorrect.Text = "Correct: " + Correct;
                lblincorrect.Text = "Incorrect:" + Incorrect;

            }
        }
        // The folllowing block of code will executed if the exit button is pressed
        private void btnexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        


        int timeleft = 30;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (timeleft > 0)
            {
                timeleft = timeleft - 1;
                lbltime.Text = timeleft + " seconds";


            }
            else
            {
                
                lblmessage.Text = "Your time is up!!!";
                inputbox.Enabled = false;
             
            }
        }
       

        private void btnrestart_Click(object sender, EventArgs e)
        {
            Form1 F1 = new Form1();
            F1.Show();
            this.Hide();
            inputbox.Enabled = true;
        }

        private void wordsTyped_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
