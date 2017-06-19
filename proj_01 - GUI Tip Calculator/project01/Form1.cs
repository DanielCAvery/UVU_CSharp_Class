// File Prologue
// Author: Daniel Avery
// Assignment: Project 01
// Instructor: Dana Doggett
// Class: CS 1400 Section: 602
// Date Written: 01/28/2017
// Description: A simple tip calculator
// ----------------------------

// I declare that the following source code was written by me, or provided
// by the instructor for this project. I understand that copying 
// source code from any other source constitutes cheating, and that I will
// receive a zero grade on this project if I am found in violation of
// this policy.


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project01
{
    public partial class project01 : Form
    {
        public project01()
        {
            InitializeComponent();
        }

        /// <summary>
        /// exitToolStripMenuItem1_Click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// aboutToolStripMenuItem_Click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Daniel Avery\nCS 1400\nSection 602\nProject #1");
        }

        /// <summary>
        /// The TxtMeal_Leave Method
        /// Purpose: Calculate possible tips based on the meal cost entered
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TxtMeal_Leave(object sender, EventArgs e)
        {
            // Get the meal cost
            double mealCost = double.Parse(TxtMeal.Text);

            // Create the tip and percentage variables
            double tipAmount = 0.0;
            double tipPercent = 0.0;

            //Calculate tip for poor service (10%) and output
            tipPercent = 0.1;
            tipAmount = mealCost * tipPercent;
            string outputPoor = $"{tipAmount:C}";
            TxtPoor.Text = outputPoor;

            //Calculate tip for average service (15%) and output
            tipPercent = 0.15;
            tipAmount = mealCost * tipPercent;
            string outputAvg = $"{tipAmount:C}";
            TxtAverage.Text = outputAvg;

            //Calculate tip for excellent service (20%) and output
            tipPercent = 0.2;
            tipAmount = mealCost * tipPercent;
            string outputExcellent = $"{tipAmount:C}";
            TxtExcellent.Text = outputExcellent;

        }// end TxtMeal_Leave

    } // end project01 : Form
} // end project01