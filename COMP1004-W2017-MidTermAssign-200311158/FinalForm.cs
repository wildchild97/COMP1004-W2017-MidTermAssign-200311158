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
    public partial class FinalForm : Form
    {
        public FinalForm()
        {
            InitializeComponent();
            _characterPicture();
        }

        public string _character { get; private set; }

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

        private void _exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Step 1. Create a new Form
            AboutForm aboutForm = new AboutForm();

            // Step 2. show the About Form with ShowDialog (a modal method to display the form)
            aboutForm.ShowDialog();
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CharacterFontDialog.ShowDialog();
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Now Printing your Character");
        }
    }
}
