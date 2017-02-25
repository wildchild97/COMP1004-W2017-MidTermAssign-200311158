using COMP1004_W2017_MidTermAssgnment_StudentID;
using COMP1004_W2017_MidTermAssign_200311158;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//App name: Character Generator
//Caitlin Foster and Tom Tsiliopoulos       Student	ID: 200311158
//App Creation Date: February 21, 2017

namespace COMP1004_W2017_MidTermAssign_200311158
{
    public partial class RaceForm : Form
    {
        //PRIVATE VARIABLES++++++++++++++++
        private string _character;

        //Constructors++++++++++++++++++++++
        public RaceForm()
        {
            InitializeComponent();
            CharacterPictureBox.Load("M_Human1.png");
            RacialBonusTextBox.Text = "All Stats increased by 5 points";
        }

        //PUBLIC PROPERTIES++++++++++++++++++
        public AbilityForm PreviousForm { get; set; }

        public int _STR { get; private set; }
        public int _DEX { get; private set; }
        public int _INT { get; private set; }
        public int _END { get; private set; }
        public int _PER { get; private set; }
        public int _CHA { get; private set; }

        //PRIVATE METHODS+++++++++++++++++++++

        /// <summary>
        /// this method changes the character picture when a diffrent race is selected
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void _raceRadioButton_CheckedChanged(object sender, EventArgs e)
        { 
            
            if (HumanRadioButton.Checked)
            {
                CharacterPictureBox.Load("M_Human1.png");
                RacialBonusTextBox.Text = "All Stats increased by 5 points";
            }
            else if(DwarfRadioButton.Checked)
            {
                CharacterPictureBox.Load("M_Dwarf1.png");
                RacialBonusTextBox.Text = "STR and PER increased by	20 points, CHA decreased by	20 points";
            }
            else if(ElfRadioButton.Checked)
            {
                CharacterPictureBox.Load("M_Elf1.png");
                RacialBonusTextBox.Text = "DEX and PER increased by 15 points";
            }
            else if(HalflingRadioButton.Checked)
            {
                CharacterPictureBox.Load("M_Halfling2.png");
                RacialBonusTextBox.Text = "DEX and INT incteased by 20 points, STR decreased by 10 points";
            }

        }

        /// <summary>
        /// this method changes the characters stats based off which character race they chose then moves to the next page when the next button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void _nextButton_Click(object sender, EventArgs e)
        {
            if (HumanRadioButton.Checked)
            {
                _STR += 5;
                _DEX += 5;
                _END += 5;
                _INT += 5;
                _PER += 5;
                _CHA += 5;

                _character = "Human";
            }
            else if (DwarfRadioButton.Checked)
            {
                _STR += 20;
                _PER += 20;
                _CHA -= 20;

                _character = "Dwarf";
            }
            else if (ElfRadioButton.Checked)
            {
                _DEX += 15;
                _PER += 15;

                _character = "Elf";
            }
            else if (HalflingRadioButton.Checked)
            {
                _DEX += 20;
                _INT += 20;
                _STR -= 10;

                _character = "Halfling";
            }

            // Instantiate the next form
            JobForm jobForm = new JobForm();

            // pass a reference from the current form to the next form
            jobForm.PreviousForm = this;

            jobForm.Show();
            this.Hide();
        }
    }
    
}
