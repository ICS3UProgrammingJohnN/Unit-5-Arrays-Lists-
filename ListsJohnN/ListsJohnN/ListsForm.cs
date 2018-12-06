using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListsJohnN
{
    public partial class frmLists : Form
    {
        public frmLists()
        {
            InitializeComponent();

        }

        List<int> myListOfIntegers = new List<int>();

        private void btnEnter_Click(object sender, EventArgs e)
        {
            
            // declare local variables
            int userMark = -1;

            // convert the value in the textbox to an integer
            try
            {
                userMark = int.Parse(txtMark.Text);
            }
            catch (Exception parseError)
            {
                Console.WriteLine("An error occurred: ' {0}'", parseError);
            }

            // check if the user entered a number between 0 - 100
            if ( (userMark >= 0) && (userMark <= 100) )
            {
                // add the mark to the listbox
                this.lstMarks.Items.Add(userMark);

                // add the mark to the list
                myListOfIntegers.Add(userMark);
            }
            // otherwise, display an error
            else
            {
                MessageBox.Show("Please enter a number between 0 and 100.", "Invalid Number");
            }

        }

        private void btnCalculateAverage_Click(object sender, EventArgs e)
        {
            
        }
    }
}
