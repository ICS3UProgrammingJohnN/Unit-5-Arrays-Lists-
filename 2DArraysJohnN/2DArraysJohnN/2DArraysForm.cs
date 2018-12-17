using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2DArraysJohnN
{
    public partial class frm2DArrays : Form
    {
        public frm2DArrays()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            // declare local and global variables 
            int width, length, aRandomNumber, total = 0, average;
            Random randomNumberGenerator = new Random();
            string aPieceOfText = null;


            // get the desierd width and length from the user
            width = Convert.ToInt16(this.numWidth.Value);
            length = Convert.ToInt16(this.numLength.Value);

            // declare the array with the desired width and length
            int[,] a2DArray = new int[width, length];

            
            // loop through each element in the length
            for (int widthCounter = 0; widthCounter < width; widthCounter++)
            {
                for (int lengthCounter = 0; lengthCounter < length; lengthCounter++)
                {
                    // get a random number between 0 and 9
                    aRandomNumber = randomNumberGenerator.Next(0, 9 + 1);

                    total = total + aRandomNumber;

                    // insert the random number into the array and the current width and length
                    a2DArray[widthCounter, lengthCounter] = aRandomNumber;

                    // add the random number to the string of array numbers
                    aPieceOfText = aPieceOfText + " " + aRandomNumber;
                }
                // add a line break to th end of the line to show a new row in the string 
                aPieceOfText = aPieceOfText + "\r" + "\n";
            }

            // insert the string into the textbox
            this.txtValues.Text = aPieceOfText;

            average = total / a2DArray.Length;


        }
    }
}
