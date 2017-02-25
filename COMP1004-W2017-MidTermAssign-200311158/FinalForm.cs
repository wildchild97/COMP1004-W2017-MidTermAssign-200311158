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
    public partial class FinalForm : Form
    {
        //Constructors++++++++++++++++++++++
        public FinalForm()
        {
            InitializeComponent();

            //show all details from previus forms 
            _characterPicture();
            RaceTextBox.Text = _character;
            JobTextBox.Text = _job;
            HealthTextBox.Text = _Health.ToString();

            STRTextBox.Text = _STR.ToString();
            DEXTextBox.Text = _DEX.ToString();
            INTTextBox.Text = _INT.ToString();
            ENDTextBox.Text = _END.ToString();
            PERTextBox.Text = _PER.ToString();
            CHATextBox.Text = _CHA.ToString();

        }

        //PUBLIC PROPERTIES++++++++++++++++++

        public string _character { get; private set; }
        public string _job { get; private set; }
        public int _Health { get; private set; }
        public int _STR { get; private set; }
        public int _DEX { get; private set; }
        public int _INT { get; private set; }
        public int _END { get; private set; }
        public int _PER { get; private set; }
        public int _CHA { get; private set; }

        //PRIVATE METHODS+++++++++++++++++++++

            /// <summary>
            /// this method sees what the user chose as a character and sets the right picture for that character
            /// </summary>
        private void _characterPicture ()
        {
            if (_character.Equals("Human"))
            {
                CharacterPictureBox.Load("M_Human1.png");
            }
            else if(_character.Equals("Dwarf"))
            {
                CharacterPictureBox.Load("M_Dwarf1.png");
            }
            else if (_character.Equals("Elf"))
            {
                CharacterPictureBox.Load("M_Elf1.png");
            }
            else if (_character.Equals("Halfling"))
            {
                CharacterPictureBox.Load("M_Halfling2.png");
            }
        }

        /// <summary>
        /// this method exits the program when exit button or exit tool clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void _exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// this method gives details about the program when selected
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Step 1. Create a new Form
            AboutForm aboutForm = new AboutForm();

            // Step 2. show the About Form with ShowDialog (a modal method to display the form)
            aboutForm.ShowDialog();
        }

        /// <summary>
        /// this method allows the user to change the text fonts 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CharacterFontDialog.ShowDialog();
        }

        /// <summary>
        /// this method prints a preview of the final form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Now Printing your Character");
        }

    }
}
