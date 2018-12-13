/*
 * Created by: john Ngundeng
 * Created on: December 6, 2018
 * Created for: ICS3U Programming
 * Daily Assignment – Day #36 - Introduction to Arrays
 * This program calculates the average mark using lists
*/
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
        // creating global variable
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
            // declaring variables
            int average = 0;
            int sum = 0;
            int counter;

            // calculate the sum of all the values in the list
            for(counter = 0; counter < myListOfIntegers.Count(); counter++)
            {
                sum = sum + myListOfIntegers[counter];
            }

            // calculate the average
            average = sum / myListOfIntegers.Count();

            // display the average to the user
            this.lblAverage.Text = "The average is: " + average; 
        }
    }
}
