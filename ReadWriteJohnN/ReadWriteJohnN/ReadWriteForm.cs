using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReadWriteJohnN
{
    public partial class frmReadWrite : Form
    {
        public frmReadWrite()
        {
            InitializeComponent();
            lblOutput.Hide();
        }

        private bool StringsAreEqual(string string1, string string2)
        {
            // declaring variable
            bool isEqual;
            // Camparing the lengths of the strings
            if (string1.Length == string2.Length)
            {
                //changing the characters to lower cased letters to compare
                if (string1.ToLower() == string2.ToLower())
                {
                    isEqual = true;
                }
                else
                {
                    isEqual = false;
                }
            }
            else
            {
                isEqual = false;
            }
            // returning value
            return isEqual;
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            //
            string[] lines = System.IO.File.ReadAllLines(@"input.txt");

            // 
            char[] charSeparators = new char[] { ' ', '\t' };

            // 
            string output = "";

            // 
            foreach (string line in lines)
            {
                //
                string[] words = line.Split(charSeparators, StringSplitOptions.RemoveEmptyEntries);

                if (StringsAreEqual(words[0], words[1]) == true)
                {
                    //
                    output = output + "True\r\n";
                }
                else
                {
                    output = output + "False\r\n";
                }
            }

            //
            System.IO.File.WriteAllText(@"output.txt", output);

            // 
            this.lblOutput.Show();
        }
    }
}
