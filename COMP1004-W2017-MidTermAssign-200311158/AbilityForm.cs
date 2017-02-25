using COMP1004_W2017_MidTermAssign_200311158;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//App name: Character Generator
//Caitlin Foster and Tom Tsiliopoulos       Student	ID: 200311158
//App Creation Date: February 21, 2017

namespace COMP1004_W2017_MidTermAssgnment_StudentID
{
    public partial class AbilityForm : Form
    {
        public Form PreviousForm;
        // Random Number object
        Random random = new Random();

        //PRIVATE VARIABLES++++++++++++++++
        private int _STR;
        private int _DEX;
        private int _END;
        private int _INT;
        private int _PER;
        private int _CHA;

        //Constructors++++++++++++++++++++++
        public AbilityForm()
        {
            InitializeComponent();
        }

        //PRIVATE METHODS+++++++++++++++++++++

        /// <summary>
        /// This method simulates the rolling of three 10-sided dice
        /// </summary>
        /// <returns>
        /// This method returns a number between 3 and 30 (The result of rolling 3d10)
        /// </returns>
        private int Roll3D10()
        {
            int result = 0;
            for (int dice = 0; dice < 3; dice++)
            {
                result += random.Next(1, 11);
            }
            return result;
        }

        /// <summary>
        /// this method assigns the character's abilities random stats and display's them
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RollButton_Click(object sender, EventArgs e)
        {
            this._STR = Roll3D10();
            this._DEX = Roll3D10();
            this._END = Roll3D10();
            this._INT = Roll3D10();
            this._PER = Roll3D10();
            this._CHA = Roll3D10();

            STRTextBox.Text = _STR.ToString();
            DEXTextBox.Text = _DEX.ToString();
            ENDTextBox.Text = _END.ToString();
            INTTextBox.Text = _INT.ToString();
            PERTextBox.Text = _PER.ToString();
            CHATextBox.Text = _CHA.ToString();    
        }

        /// <summary>
        /// this method goes to the next page when next button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NextButton_Click(object sender, EventArgs e)
        {
            // Instantiate the next form
            RaceForm raceForm = new RaceForm();

            // pass a reference from the current form to the next form
            raceForm.PreviousForm = this;
            
            raceForm.Show();
            this.Hide();
        }
    }
}

