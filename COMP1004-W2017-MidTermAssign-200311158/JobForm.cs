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
    public partial class JobForm : Form
    {
        //PRIVATE VARIABLES++++++++++++++++
        private int _Health;
        private string _job;

        //Constructors++++++++++++++++++++++
        public JobForm()
        {
            InitializeComponent();
        }

        //PUBLIC PROPERTIES++++++++++++++++++

        public JobForm PreviousForm { get; set; }
        public int _STR { get; private set; }
        public int _DEX { get; private set; }
        public int _INT { get; private set; }
        public int _END { get; private set; }
        public int _PER { get; private set; }
        public int _CHA { get; private set; }

        public string _character { get; private set; }

        //PRIVATE METHODS+++++++++++++++++++++

        /// <summary>
        /// this method changes the characters stats based of which job the user chose
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void _jobRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (SoldierRadioButton.Checked)
            {
                this._Health = 30 + _END;
                _job = "Soldier";
            }
            else if (RogueRadioButton.Checked)
            {
                this._Health = 28 + _DEX;
                _job = "Rogue";
            }
            else if (MagickerRadioButton.Checked)
            {
                this._Health = 15 + _INT;
                _job = "Magicker";
            }
            else if (CultistRadioButton.Checked)
            {
               this._Health = 24 + _CHA;
                _job = "Cultist";
            }
        }

        /// <summary>
        /// this method moves to the next form when the next button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NextButton_Click(object sender, EventArgs e)
        {
            // Instantiate the next form
            FinalForm finalForm = new FinalForm();

            // pass a reference from the current form to the next form
            finalForm.PreviousForm = this;

            finalForm.Show();
            this.Hide();
        }
    }
}
