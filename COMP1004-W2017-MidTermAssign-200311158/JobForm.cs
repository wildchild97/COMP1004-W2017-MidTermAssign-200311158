using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP1004_W2017_MidTermAssign_200311158
{
    public partial class JobForm : Form
    {
        private int _Health;

        public JobForm()
        {
            InitializeComponent();
        }

        // public properties

        public JobForm PreviousForm { get; set; }
        public int _STR { get; private set; }
        public int _DEX { get; private set; }
        public int _INT { get; private set; }
        public int _END { get; private set; }
        public int _PER { get; private set; }
        public int _CHA { get; private set; }

        public string _character { get; private set; }

        private void _jobRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (SoldierRadioButton.Checked)
            {
                this._Health = 30 + _END;
            }
            else if (RogueRadioButton.Checked)
            {
                this._Health = 28 + _DEX;
            }
            else if (MagickerRadioButton.Checked)
            {
                this._Health = 15 + _INT;
            }
            else if (CultistRadioButton.Checked)
            {
               this._Health = 24 + _CHA;
            }
        }

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
