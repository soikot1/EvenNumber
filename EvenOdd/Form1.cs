using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EvenOdd
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string[] days = { "Saturday", "Sunday", "Monday", "Tuesday", "Wednesday", "Thrusday", "Friday", };
        private void SaveButton_Click(object sender, EventArgs e)
        {
            for(int i=0;i<7;i++)
            {
                saveRichTextBox.Text = saveRichTextBox.Text + days[i] + "\n";
            }
        }

        private void OddButton_Click(object sender, EventArgs e)
        {
            for(int i=0;i<7;i++)
            {
                if(i%2!=1)
                {
                    oddRichTextBox.Text = oddRichTextBox.Text + days[i] + "\n";
                }
            }
        }

        private void CloneButton_Click(object sender, EventArgs e)
        {
            string []clone = new string[7];
            for(int i=0;i<7;i++)
            {
                clone[i] = days[i];
               cloneRichTextBox.Text = cloneRichTextBox.Text + clone[i] + "\n";
            }

        }

        private void EvenButton_Click(object sender, EventArgs e)
        {

            for (int i = 0; i < 7; i++)
            {
                if (i % 2 == 1)
                {
                    evenRichTextBox.Text = evenRichTextBox.Text + days[i] + "\n";
                }
            }
        }
    }
}
