namespace TicTacToeDojo
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pbLogo = new PictureBox();
            btnStart = new Button();
            lblStudio = new Label();
            btnTutorial = new Button();
            buttonContacts = new Button();
            labelPresents = new Label();
            btnBack = new Button();
            ((System.ComponentModel.ISupportInitialize)pbLogo).BeginInit();
            SuspendLayout();
            // 
            // pbLogo
            // 
            pbLogo.BackColor = Color.Transparent;
            pbLogo.Image = Properties.Resources.Logo;
            pbLogo.Location = new Point(317, 130);
            pbLogo.Name = "pbLogo";
            pbLogo.Size = new Size(204, 180);
            pbLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            pbLogo.TabIndex = 0;
            pbLogo.TabStop = false;
            // 
            // btnStart
            // 
            btnStart.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnStart.BackColor = Color.Transparent;
            btnStart.BackgroundImage = Properties.Resources.scroll;
            btnStart.BackgroundImageLayout = ImageLayout.Stretch;
            btnStart.Cursor = Cursors.Hand;
            btnStart.FlatAppearance.BorderSize = 0;
            btnStart.FlatStyle = FlatStyle.Flat;
            btnStart.Font = new Font("Segoe Print", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnStart.Location = new Point(193, 306);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(147, 39);
            btnStart.TabIndex = 1;
            btnStart.Text = "Start Game";
            btnStart.UseVisualStyleBackColor = false;
            btnStart.Click += btnStart_Click;
            btnStart.MouseEnter += menuBtns_MouseEnter;
            btnStart.MouseLeave += menuBtns_MouseLeave;
            // 
            // lblStudio
            // 
            lblStudio.AutoSize = true;
            lblStudio.BackColor = Color.Transparent;
            lblStudio.Font = new Font("Segoe Print", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStudio.ForeColor = Color.Red;
            lblStudio.Location = new Point(331, 141);
            lblStudio.Name = "lblStudio";
            lblStudio.Size = new Size(121, 21);
            lblStudio.TabIndex = 2;
            lblStudio.Text = "Sleepy Owl Games";
            // 
            // btnTutorial
            // 
            btnTutorial.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnTutorial.BackColor = Color.Transparent;
            btnTutorial.BackgroundImage = Properties.Resources.scroll;
            btnTutorial.BackgroundImageLayout = ImageLayout.Stretch;
            btnTutorial.Cursor = Cursors.Hand;
            btnTutorial.FlatAppearance.BorderSize = 0;
            btnTutorial.FlatStyle = FlatStyle.Flat;
            btnTutorial.Font = new Font("Segoe Print", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTutorial.Location = new Point(346, 306);
            btnTutorial.Name = "btnTutorial";
            btnTutorial.Size = new Size(147, 39);
            btnTutorial.TabIndex = 3;
            btnTutorial.Text = "Tutorial";
            btnTutorial.UseVisualStyleBackColor = false;
            btnTutorial.Click += btnTutorial_Click;
            btnTutorial.MouseEnter += menuBtns_MouseEnter;
            btnTutorial.MouseLeave += menuBtns_MouseLeave;
            // 
            // buttonContacts
            // 
            buttonContacts.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            buttonContacts.BackColor = Color.Transparent;
            buttonContacts.BackgroundImage = Properties.Resources.scroll;
            buttonContacts.BackgroundImageLayout = ImageLayout.Stretch;
            buttonContacts.Cursor = Cursors.Hand;
            buttonContacts.FlatAppearance.BorderSize = 0;
            buttonContacts.FlatStyle = FlatStyle.Flat;
            buttonContacts.Font = new Font("Segoe Print", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonContacts.Location = new Point(499, 306);
            buttonContacts.Name = "buttonContacts";
            buttonContacts.Size = new Size(147, 39);
            buttonContacts.TabIndex = 4;
            buttonContacts.Text = "Contacts";
            buttonContacts.UseVisualStyleBackColor = false;
            buttonContacts.Click += buttonContacts_Click;
            buttonContacts.MouseEnter += menuBtns_MouseEnter;
            buttonContacts.MouseLeave += menuBtns_MouseLeave;
            // 
            // labelPresents
            // 
            labelPresents.AutoSize = true;
            labelPresents.BackColor = Color.Transparent;
            labelPresents.Font = new Font("Segoe Print", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelPresents.Location = new Point(447, 141);
            labelPresents.Name = "labelPresents";
            labelPresents.Size = new Size(60, 21);
            labelPresents.TabIndex = 5;
            labelPresents.Text = "presents";
            // 
            // btnBack
            // 
            btnBack.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnBack.BackColor = Color.Transparent;
            btnBack.BackgroundImage = Properties.Resources.scroll;
            btnBack.BackgroundImageLayout = ImageLayout.Stretch;
            btnBack.Cursor = Cursors.Hand;
            btnBack.Enabled = false;
            btnBack.FlatAppearance.BorderSize = 0;
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.Font = new Font("Segoe Print", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBack.Location = new Point(12, 390);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(147, 39);
            btnBack.TabIndex = 6;
            btnBack.Text = "Back To Menu";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Visible = false;
            btnBack.Click += btnBack_Click;
            btnBack.MouseEnter += menuBtns_MouseEnter;
            btnBack.MouseLeave += menuBtns_MouseLeave;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Background_Image;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(838, 441);
            Controls.Add(btnBack);
            Controls.Add(labelPresents);
            Controls.Add(buttonContacts);
            Controls.Add(btnTutorial);
            Controls.Add(lblStudio);
            Controls.Add(btnStart);
            Controls.Add(pbLogo);
            Name = "Form1";
            Text = "Tic-Tac-Toe Dojo (Menu)";
            FormClosing += Form1_FormClosing;
            ((System.ComponentModel.ISupportInitialize)pbLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pbLogo;
        private Button btnStart;
        private Label lblStudio;
        private Button btnTutorial;
        private Button buttonContacts;
        private Label labelPresents;
        private Button btnBack;
    }
}
