/*
 * Created by: John Ngundeng
 * Created on: December 4, 2018
 * Created for: ICS3U Programming
 * Daily Assignment – Day #37 - Find Min Value
 * This program generates 10 random numbers and finds the minium value.
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

namespace MinValueJohnN
{
    public partial class frmMinValue : Form
    {
        public frmMinValue()
        {
            InitializeComponent();
        }

        private int GetMinValue(int[] tmpArrayOfIntegers)
        {
            // Declare local variables
            int tmpMinValue = 501;
            int counter;

            for (counter = 0; counter < tmpArrayOfIntegers.Length;counter++)
            {
                if(tmpMinValue > tmpArrayOfIntegers[counter])
                {
                    tmpMinValue = tmpArrayOfIntegers[counter];
                }
            }

            // returns the min value
            return tmpMinValue;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            // Declaring local constants and variables 
            const int MAX_ARRAY_SIZE = 10;
            const int MAX_RANDOM_NUMBER = 501;
            int[] arrayOfIntegers = new int[MAX_ARRAY_SIZE];
            int counter, minValue, randomNumber;
            Random randomNumberGenerator = new Random();

            // clearing the list box
            this.lstValues.Items.Clear();

            for (counter = 0; counter < MAX_ARRAY_SIZE; counter++)
            {
                // generating a random number from 1 to the max random number
                randomNumber = randomNumberGenerator.Next(1, MAX_RANDOM_NUMBER);

                // assigning a random number in each index
                arrayOfIntegers[counter] = randomNumber;

                // adds a new random number into the box
                this.lstValues.Items.Add(randomNumber);

                // refresh the form to display new item inside 
                this.Refresh();
            }

            // get the max value in the array
            minValue = GetMinValue(arrayOfIntegers);

            // display the max value to the user 
            this.lblMinValue.Text = "The min value is: " + minValue;
        }
    }
}