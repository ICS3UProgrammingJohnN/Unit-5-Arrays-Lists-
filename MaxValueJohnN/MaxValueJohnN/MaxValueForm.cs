/*
 * Created by: John Ngundeng
 * Created on: December 3, 2018
 * Created for: ICS3U Programming
 * Daily Assignment – Day #37 - Find Max Value
 * This program finds the max value from 10 randomly generated numbers
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

namespace MaxValueJohnN
{
    public partial class frmMaxValue : Form
    {
        public frmMaxValue()
        {
            InitializeComponent();
        }

        private int GetMaxValue(int[]tmpArrayOfIntegers)
        {
            //declare variables
            int tmpMaxValue = -1;
            int counter;

            for (counter = 0; counter < tmpArrayOfIntegers.Length; counter++)
            {
                if (tmpArrayOfIntegers[counter]>tmpMaxValue)
                {
                    tmpMaxValue = tmpArrayOfIntegers[counter];
                }
            }
            
            // returing the the maxvalue
            return tmpMaxValue;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            // Declaring local constants and variables 
            const int MAX_ARRAY_SIZE = 10;
            const int MAX_RANDOM_NUMBER = 500;
            int[] arrayOfIntegers = new int[MAX_ARRAY_SIZE];
            int counter, maxValue, randomNumber;
            Random randomNumberGenerator = new Random();

            // clearing the list box
            this.lstValues.Items.Clear();

            for(counter= 0; counter < MAX_ARRAY_SIZE; counter++)
            {
                // generating a random number from 1 to the max random number
                randomNumber = randomNumberGenerator.Next(1, MAX_RANDOM_NUMBER+1);

                // 
                arrayOfIntegers[counter] = randomNumber;

                // adds a new random number into the box
                this.lstValues.Items.Add(randomNumber);

                // refresh the form to display new item inside 
                this.Refresh();
            }

            // get the max value in the array
            maxValue = GetMaxValue(arrayOfIntegers);
            
            // display the max value to the user 
            this.lblMaxValue.Text = "The max value is: " + maxValue;
            
        }
    }
}
