namespace COMP1004_W2017_MidTermAssign_200311158
{
    partial class FinalForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fontToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitButton = new System.Windows.Forms.Button();
            this.CharacterFontDialog = new System.Windows.Forms.FontDialog();
            this.CharacterPictureBox = new System.Windows.Forms.PictureBox();
            this.CharacterInfoGroupBox = new System.Windows.Forms.GroupBox();
            this.TitleTextBox = new System.Windows.Forms.TextBox();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.WeightTextBox = new System.Windows.Forms.TextBox();
            this.HeightTextBox = new System.Windows.Forms.TextBox();
            this.AgeTextBox = new System.Windows.Forms.TextBox();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.WeightLabel = new System.Windows.Forms.Label();
            this.HeightLabel = new System.Windows.Forms.Label();
            this.AgeLabel = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.InfoGroupBox = new System.Windows.Forms.GroupBox();
            this.HealthTextBox = new System.Windows.Forms.TextBox();
            this.RaceTextBox = new System.Windows.Forms.TextBox();
            this.JobTextBox = new System.Windows.Forms.TextBox();
            this.HealthLabel = new System.Windows.Forms.Label();
            this.RaceLabel = new System.Windows.Forms.Label();
            this.JobLabel = new System.Windows.Forms.Label();
            this.AbilitiesGroupBox = new System.Windows.Forms.GroupBox();
            this.PERLabel = new System.Windows.Forms.Label();
            this.CHALabel = new System.Windows.Forms.Label();
            this.ENDLabel = new System.Windows.Forms.Label();
            this.INTLabel = new System.Windows.Forms.Label();
            this.DEXLabel = new System.Windows.Forms.Label();
            this.STRLabel = new System.Windows.Forms.Label();
            this.STRTextBox = new System.Windows.Forms.TextBox();
            this.DEXTextBox = new System.Windows.Forms.TextBox();
            this.ENDTextBox = new System.Windows.Forms.TextBox();
            this.INTTextBox = new System.Windows.Forms.TextBox();
            this.PERTextBox = new System.Windows.Forms.TextBox();
            this.CHATextBox = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CharacterPictureBox)).BeginInit();
            this.CharacterInfoGroupBox.SuspendLayout();
            this.InfoGroupBox.SuspendLayout();
            this.AbilitiesGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(641, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.printToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F)));
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // printToolStripMenuItem
            // 
            this.printToolStripMenuItem.Name = "printToolStripMenuItem";
            this.printToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.printToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.printToolStripMenuItem.Text = "&Print";
            this.printToolStripMenuItem.Click += new System.EventHandler(this.printToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this._exit_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fontToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "&Edit";
            // 
            // fontToolStripMenuItem
            // 
            this.fontToolStripMenuItem.Name = "fontToolStripMenuItem";
            this.fontToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.fontToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.fontToolStripMenuItem.Text = "&Font";
            this.fontToolStripMenuItem.Click += new System.EventHandler(this.fontToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.H)));
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.aboutToolStripMenuItem.Text = "&About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(554, 436);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(75, 23);
            this.ExitButton.TabIndex = 1;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this._exit_Click);
            // 
            // CharacterFontDialog
            // 
            this.CharacterFontDialog.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.CharacterFontDialog.MaxSize = 18;
            this.CharacterFontDialog.MinSize = 10;
            // 
            // CharacterPictureBox
            // 
            this.CharacterPictureBox.Location = new System.Drawing.Point(12, 27);
            this.CharacterPictureBox.Name = "CharacterPictureBox";
            this.CharacterPictureBox.Size = new System.Drawing.Size(290, 262);
            this.CharacterPictureBox.TabIndex = 2;
            this.CharacterPictureBox.TabStop = false;
            // 
            // CharacterInfoGroupBox
            // 
            this.CharacterInfoGroupBox.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.CharacterInfoGroupBox.Controls.Add(this.TitleTextBox);
            this.CharacterInfoGroupBox.Controls.Add(this.TitleLabel);
            this.CharacterInfoGroupBox.Controls.Add(this.WeightTextBox);
            this.CharacterInfoGroupBox.Controls.Add(this.HeightTextBox);
            this.CharacterInfoGroupBox.Controls.Add(this.AgeTextBox);
            this.CharacterInfoGroupBox.Controls.Add(this.NameTextBox);
            this.CharacterInfoGroupBox.Controls.Add(this.WeightLabel);
            this.CharacterInfoGroupBox.Controls.Add(this.HeightLabel);
            this.CharacterInfoGroupBox.Controls.Add(this.AgeLabel);
            this.CharacterInfoGroupBox.Controls.Add(this.NameLabel);
            this.CharacterInfoGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CharacterInfoGroupBox.Location = new System.Drawing.Point(12, 302);
            this.CharacterInfoGroupBox.Name = "CharacterInfoGroupBox";
            this.CharacterInfoGroupBox.Size = new System.Drawing.Size(382, 157);
            this.CharacterInfoGroupBox.TabIndex = 3;
            this.CharacterInfoGroupBox.TabStop = false;
            this.CharacterInfoGroupBox.Text = "Character Information";
            // 
            // TitleTextBox
            // 
            this.TitleTextBox.Location = new System.Drawing.Point(94, 35);
            this.TitleTextBox.Name = "TitleTextBox";
            this.TitleTextBox.Size = new System.Drawing.Size(273, 20);
            this.TitleTextBox.TabIndex = 9;
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Location = new System.Drawing.Point(9, 38);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(79, 13);
            this.TitleLabel.TabIndex = 8;
            this.TitleLabel.Text = "Character Title:";
            // 
            // WeightTextBox
            // 
            this.WeightTextBox.Location = new System.Drawing.Point(268, 120);
            this.WeightTextBox.Name = "WeightTextBox";
            this.WeightTextBox.Size = new System.Drawing.Size(100, 20);
            this.WeightTextBox.TabIndex = 7;
            // 
            // HeightTextBox
            // 
            this.HeightTextBox.Location = new System.Drawing.Point(268, 77);
            this.HeightTextBox.Name = "HeightTextBox";
            this.HeightTextBox.Size = new System.Drawing.Size(100, 20);
            this.HeightTextBox.TabIndex = 6;
            // 
            // AgeTextBox
            // 
            this.AgeTextBox.Location = new System.Drawing.Point(57, 120);
            this.AgeTextBox.Name = "AgeTextBox";
            this.AgeTextBox.Size = new System.Drawing.Size(100, 20);
            this.AgeTextBox.TabIndex = 5;
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(57, 77);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(100, 20);
            this.NameTextBox.TabIndex = 4;
            // 
            // WeightLabel
            // 
            this.WeightLabel.AutoSize = true;
            this.WeightLabel.Location = new System.Drawing.Point(220, 120);
            this.WeightLabel.Name = "WeightLabel";
            this.WeightLabel.Size = new System.Drawing.Size(44, 13);
            this.WeightLabel.TabIndex = 3;
            this.WeightLabel.Text = "Weight:";
            // 
            // HeightLabel
            // 
            this.HeightLabel.AutoSize = true;
            this.HeightLabel.Location = new System.Drawing.Point(220, 77);
            this.HeightLabel.Name = "HeightLabel";
            this.HeightLabel.Size = new System.Drawing.Size(41, 13);
            this.HeightLabel.TabIndex = 2;
            this.HeightLabel.Text = "Height:";
            // 
            // AgeLabel
            // 
            this.AgeLabel.AutoSize = true;
            this.AgeLabel.Location = new System.Drawing.Point(21, 120);
            this.AgeLabel.Name = "AgeLabel";
            this.AgeLabel.Size = new System.Drawing.Size(29, 13);
            this.AgeLabel.TabIndex = 1;
            this.AgeLabel.Text = "Age:";
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(12, 77);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(38, 13);
            this.NameLabel.TabIndex = 0;
            this.NameLabel.Text = "Name:";
            // 
            // InfoGroupBox
            // 
            this.InfoGroupBox.Controls.Add(this.HealthTextBox);
            this.InfoGroupBox.Controls.Add(this.RaceTextBox);
            this.InfoGroupBox.Controls.Add(this.JobTextBox);
            this.InfoGroupBox.Controls.Add(this.HealthLabel);
            this.InfoGroupBox.Controls.Add(this.RaceLabel);
            this.InfoGroupBox.Controls.Add(this.JobLabel);
            this.InfoGroupBox.Location = new System.Drawing.Point(429, 302);
            this.InfoGroupBox.Name = "InfoGroupBox";
            this.InfoGroupBox.Size = new System.Drawing.Size(200, 100);
            this.InfoGroupBox.TabIndex = 4;
            this.InfoGroupBox.TabStop = false;
            // 
            // HealthTextBox
            // 
            this.HealthTextBox.Location = new System.Drawing.Point(86, 71);
            this.HealthTextBox.Name = "HealthTextBox";
            this.HealthTextBox.ReadOnly = true;
            this.HealthTextBox.Size = new System.Drawing.Size(100, 20);
            this.HealthTextBox.TabIndex = 5;
            // 
            // RaceTextBox
            // 
            this.RaceTextBox.Location = new System.Drawing.Point(86, 45);
            this.RaceTextBox.Name = "RaceTextBox";
            this.RaceTextBox.ReadOnly = true;
            this.RaceTextBox.Size = new System.Drawing.Size(100, 20);
            this.RaceTextBox.TabIndex = 4;
            // 
            // JobTextBox
            // 
            this.JobTextBox.Location = new System.Drawing.Point(86, 19);
            this.JobTextBox.Name = "JobTextBox";
            this.JobTextBox.ReadOnly = true;
            this.JobTextBox.Size = new System.Drawing.Size(100, 20);
            this.JobTextBox.TabIndex = 3;
            // 
            // HealthLabel
            // 
            this.HealthLabel.AutoSize = true;
            this.HealthLabel.Location = new System.Drawing.Point(7, 74);
            this.HealthLabel.Name = "HealthLabel";
            this.HealthLabel.Size = new System.Drawing.Size(73, 13);
            this.HealthLabel.TabIndex = 2;
            this.HealthLabel.Text = "Health Points:";
            // 
            // RaceLabel
            // 
            this.RaceLabel.AutoSize = true;
            this.RaceLabel.Location = new System.Drawing.Point(44, 48);
            this.RaceLabel.Name = "RaceLabel";
            this.RaceLabel.Size = new System.Drawing.Size(36, 13);
            this.RaceLabel.TabIndex = 1;
            this.RaceLabel.Text = "Race:";
            // 
            // JobLabel
            // 
            this.JobLabel.AutoSize = true;
            this.JobLabel.Location = new System.Drawing.Point(53, 22);
            this.JobLabel.Name = "JobLabel";
            this.JobLabel.Size = new System.Drawing.Size(27, 13);
            this.JobLabel.TabIndex = 0;
            this.JobLabel.Text = "Job:";
            // 
            // AbilitiesGroupBox
            // 
            this.AbilitiesGroupBox.Controls.Add(this.CHATextBox);
            this.AbilitiesGroupBox.Controls.Add(this.PERTextBox);
            this.AbilitiesGroupBox.Controls.Add(this.INTTextBox);
            this.AbilitiesGroupBox.Controls.Add(this.ENDTextBox);
            this.AbilitiesGroupBox.Controls.Add(this.DEXTextBox);
            this.AbilitiesGroupBox.Controls.Add(this.STRTextBox);
            this.AbilitiesGroupBox.Controls.Add(this.PERLabel);
            this.AbilitiesGroupBox.Controls.Add(this.CHALabel);
            this.AbilitiesGroupBox.Controls.Add(this.ENDLabel);
            this.AbilitiesGroupBox.Controls.Add(this.INTLabel);
            this.AbilitiesGroupBox.Controls.Add(this.DEXLabel);
            this.AbilitiesGroupBox.Controls.Add(this.STRLabel);
            this.AbilitiesGroupBox.Location = new System.Drawing.Point(429, 27);
            this.AbilitiesGroupBox.Name = "AbilitiesGroupBox";
            this.AbilitiesGroupBox.Size = new System.Drawing.Size(200, 262);
            this.AbilitiesGroupBox.TabIndex = 5;
            this.AbilitiesGroupBox.TabStop = false;
            this.AbilitiesGroupBox.Text = "Abilities";
            // 
            // PERLabel
            // 
            this.PERLabel.AutoSize = true;
            this.PERLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PERLabel.Location = new System.Drawing.Point(6, 174);
            this.PERLabel.Name = "PERLabel";
            this.PERLabel.Size = new System.Drawing.Size(51, 24);
            this.PERLabel.TabIndex = 5;
            this.PERLabel.Text = "PER";
            // 
            // CHALabel
            // 
            this.CHALabel.AutoSize = true;
            this.CHALabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CHALabel.Location = new System.Drawing.Point(6, 211);
            this.CHALabel.Name = "CHALabel";
            this.CHALabel.Size = new System.Drawing.Size(53, 24);
            this.CHALabel.TabIndex = 4;
            this.CHALabel.Text = "CHA";
            // 
            // ENDLabel
            // 
            this.ENDLabel.AutoSize = true;
            this.ENDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ENDLabel.Location = new System.Drawing.Point(6, 100);
            this.ENDLabel.Name = "ENDLabel";
            this.ENDLabel.Size = new System.Drawing.Size(53, 24);
            this.ENDLabel.TabIndex = 3;
            this.ENDLabel.Text = "END";
            // 
            // INTLabel
            // 
            this.INTLabel.AutoSize = true;
            this.INTLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.INTLabel.Location = new System.Drawing.Point(10, 137);
            this.INTLabel.Name = "INTLabel";
            this.INTLabel.Size = new System.Drawing.Size(43, 24);
            this.INTLabel.TabIndex = 2;
            this.INTLabel.Text = "INT";
            // 
            // DEXLabel
            // 
            this.DEXLabel.AutoSize = true;
            this.DEXLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DEXLabel.Location = new System.Drawing.Point(6, 63);
            this.DEXLabel.Name = "DEXLabel";
            this.DEXLabel.Size = new System.Drawing.Size(53, 24);
            this.DEXLabel.TabIndex = 1;
            this.DEXLabel.Text = "DEX";
            // 
            // STRLabel
            // 
            this.STRLabel.AutoSize = true;
            this.STRLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.STRLabel.Location = new System.Drawing.Point(6, 26);
            this.STRLabel.Name = "STRLabel";
            this.STRLabel.Size = new System.Drawing.Size(50, 24);
            this.STRLabel.TabIndex = 0;
            this.STRLabel.Text = "STR";
            // 
            // STRTextBox
            // 
            this.STRTextBox.Location = new System.Drawing.Point(90, 29);
            this.STRTextBox.Name = "STRTextBox";
            this.STRTextBox.ReadOnly = true;
            this.STRTextBox.Size = new System.Drawing.Size(100, 20);
            this.STRTextBox.TabIndex = 6;
            // 
            // DEXTextBox
            // 
            this.DEXTextBox.Location = new System.Drawing.Point(90, 68);
            this.DEXTextBox.Name = "DEXTextBox";
            this.DEXTextBox.ReadOnly = true;
            this.DEXTextBox.Size = new System.Drawing.Size(100, 20);
            this.DEXTextBox.TabIndex = 7;
            // 
            // ENDTextBox
            // 
            this.ENDTextBox.Location = new System.Drawing.Point(90, 104);
            this.ENDTextBox.Name = "ENDTextBox";
            this.ENDTextBox.ReadOnly = true;
            this.ENDTextBox.Size = new System.Drawing.Size(100, 20);
            this.ENDTextBox.TabIndex = 8;
            // 
            // INTTextBox
            // 
            this.INTTextBox.Location = new System.Drawing.Point(90, 141);
            this.INTTextBox.Name = "INTTextBox";
            this.INTTextBox.ReadOnly = true;
            this.INTTextBox.Size = new System.Drawing.Size(100, 20);
            this.INTTextBox.TabIndex = 9;
            // 
            // PERTextBox
            // 
            this.PERTextBox.Location = new System.Drawing.Point(90, 179);
            this.PERTextBox.Name = "PERTextBox";
            this.PERTextBox.ReadOnly = true;
            this.PERTextBox.Size = new System.Drawing.Size(100, 20);
            this.PERTextBox.TabIndex = 10;
            // 
            // CHATextBox
            // 
            this.CHATextBox.Location = new System.Drawing.Point(90, 216);
            this.CHATextBox.Name = "CHATextBox";
            this.CHATextBox.ReadOnly = true;
            this.CHATextBox.Size = new System.Drawing.Size(100, 20);
            this.CHATextBox.TabIndex = 11;
            // 
            // FinalForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(641, 469);
            this.Controls.Add(this.AbilitiesGroupBox);
            this.Controls.Add(this.InfoGroupBox);
            this.Controls.Add(this.CharacterInfoGroupBox);
            this.Controls.Add(this.CharacterPictureBox);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FinalForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Your Character Selections";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CharacterPictureBox)).EndInit();
            this.CharacterInfoGroupBox.ResumeLayout(false);
            this.CharacterInfoGroupBox.PerformLayout();
            this.InfoGroupBox.ResumeLayout(false);
            this.InfoGroupBox.PerformLayout();
            this.AbilitiesGroupBox.ResumeLayout(false);
            this.AbilitiesGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fontToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.FontDialog CharacterFontDialog;
        private System.Windows.Forms.PictureBox CharacterPictureBox;
        private System.Windows.Forms.GroupBox CharacterInfoGroupBox;
        private System.Windows.Forms.Label WeightLabel;
        private System.Windows.Forms.Label HeightLabel;
        private System.Windows.Forms.Label AgeLabel;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.TextBox AgeTextBox;
        private System.Windows.Forms.TextBox HeightTextBox;
        private System.Windows.Forms.TextBox WeightTextBox;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.TextBox TitleTextBox;
        private System.Windows.Forms.GroupBox InfoGroupBox;
        private System.Windows.Forms.Label JobLabel;
        private System.Windows.Forms.Label RaceLabel;
        private System.Windows.Forms.Label HealthLabel;
        private System.Windows.Forms.TextBox HealthTextBox;
        private System.Windows.Forms.TextBox RaceTextBox;
        private System.Windows.Forms.TextBox JobTextBox;
        private System.Windows.Forms.GroupBox AbilitiesGroupBox;
        private System.Windows.Forms.Label STRLabel;
        private System.Windows.Forms.Label DEXLabel;
        private System.Windows.Forms.Label ENDLabel;
        private System.Windows.Forms.Label INTLabel;
        private System.Windows.Forms.Label CHALabel;
        private System.Windows.Forms.Label PERLabel;
        private System.Windows.Forms.TextBox STRTextBox;
        private System.Windows.Forms.TextBox ENDTextBox;
        private System.Windows.Forms.TextBox DEXTextBox;
        private System.Windows.Forms.TextBox INTTextBox;
        private System.Windows.Forms.TextBox PERTextBox;
        private System.Windows.Forms.TextBox CHATextBox;
    }
}