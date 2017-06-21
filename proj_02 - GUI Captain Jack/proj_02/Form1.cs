// File Prologue
// Author: Daniel Avery
// Assignment: Project 02
// Instructor: Dana Doggett
// Class: CS 1400 Section: 602
// Date Written: 02/04/2017
// Description: A calculator for splitting gold among a group
// ----------------------------

// I declare that the following source code was written by me, or provided
// by the instructor for this project. I understand that copying 
// source code from any other source constitutes cheating, and that I will
// receive a zero grade on this project if I am found in violation of
// this policy.

using System;
using System.Windows.Forms;

namespace proj_02
{
    public partial class Main : Form
    {
        public Main()
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
            MessageBox.Show("Daniel Avery\nCS 1400\nSection 602\nProject #2");
        }

        /// <summary>
        /// The BtnSplitGold_Click Method
        /// Purpose: Split the coins using the given user inputs, then display the amounts
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnSplitGold_Click(object sender, EventArgs e)
        {
            // Declare constants, which will all be doubles and will require parsing (12% for Jack, and 8% for the first mate)
            const double JACK_PERCENTAGE = 0.12;
            const double MATE_PERCENTAGE = 0.08;
            const int LEADERSHIP = 2;
            const int GOLD_PER_CREW = 3;

            // Get user inputs from 2 textboxes - all variables will be ints!!
            int numOfPirates = int.Parse(TxtNumOfPirates.Text);
            int numOfCoinsLeft = int.Parse(TxtNumOfCoins.Text);

            // Calculate the amount of gold coins given to the crew to go ashore and subtract
            int crewMinusLeadership = numOfPirates - LEADERSHIP;
            int goldToCrew = crewMinusLeadership * GOLD_PER_CREW;
            numOfCoinsLeft = numOfCoinsLeft - goldToCrew;

            // Calculate Jack's share - 12%; Round down if uneven
            int shareForJack = (int)(numOfCoinsLeft * JACK_PERCENTAGE);
            numOfCoinsLeft = numOfCoinsLeft - shareForJack;

            // Calculate the first mate's share - 8% of what's left; Round down if uneven
            int shareForMate = (int)(numOfCoinsLeft * MATE_PERCENTAGE);
            numOfCoinsLeft = numOfCoinsLeft - shareForMate;

            // Calculate the even shares for all crew members from what's left; Round down if uneven
            int shareForCrew = (int)(numOfCoinsLeft / numOfPirates);

            // Get the remainder, if any; this is for the Pirate's Benevolent Association
            int amountForFund = (int)(numOfCoinsLeft % numOfPirates);

            // Output each variable amount to the interface
            TxtJackShare.Text = $"{shareForJack}";
            TxtMateShare.Text = $"{shareForMate}";
            TxtCrewShare.Text = $"{shareForCrew}";
            TxtFund.Text = $"{amountForFund}";

            /*
              * With 20 pirates and 1000 pieces of gold:
              * Captain Jack	113 gold coins (151 if you count the 38 everyone in the crew gets)
              * First Mate	66 gold coins (104 if you count the 38 coins everyone in the crew gets)
              * The Crew	38 gold coins each (don't count the 3 coins each took into town)
              * The PBA	7 gold coins 
              */

        }

    } // end class Main : form
} // end namespace proj_02
                          