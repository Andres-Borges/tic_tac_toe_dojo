namespace TicTacToeDojo
{
    partial class Form2
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
            labelSelect = new Label();
            btnSakura = new Button();
            btnBlaze = new Button();
            btnAurora = new Button();
            btnJade = new Button();
            SuspendLayout();
            // 
            // labelSelect
            // 
            labelSelect.AutoSize = true;
            labelSelect.BackColor = Color.Transparent;
            labelSelect.Font = new Font("Segoe Print", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelSelect.Location = new Point(294, 30);
            labelSelect.Name = "labelSelect";
            labelSelect.Size = new Size(250, 37);
            labelSelect.TabIndex = 0;
            labelSelect.Text = "Select your Champion";
            // 
            // btnSakura
            // 
            btnSakura.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnSakura.BackColor = Color.Transparent;
            btnSakura.BackgroundImage = Properties.Resources.scroll;
            btnSakura.BackgroundImageLayout = ImageLayout.Stretch;
            btnSakura.Cursor = Cursors.Hand;
            btnSakura.FlatAppearance.BorderSize = 0;
            btnSakura.FlatStyle = FlatStyle.Flat;
            btnSakura.Font = new Font("Segoe Print", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSakura.Location = new Point(44, 370);
            btnSakura.Name = "btnSakura";
            btnSakura.Size = new Size(147, 39);
            btnSakura.TabIndex = 4;
            btnSakura.Text = "Sakura";
            btnSakura.UseVisualStyleBackColor = false;
            btnSakura.Click += selectBtns_Click;
            btnSakura.MouseEnter += selectBtns_MouseEnter;
            btnSakura.MouseLeave += selectBtns_MouseLeave;
            // 
            // btnBlaze
            // 
            btnBlaze.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnBlaze.BackColor = Color.Transparent;
            btnBlaze.BackgroundImage = Properties.Resources.scroll;
            btnBlaze.BackgroundImageLayout = ImageLayout.Stretch;
            btnBlaze.Cursor = Cursors.Hand;
            btnBlaze.FlatAppearance.BorderSize = 0;
            btnBlaze.FlatStyle = FlatStyle.Flat;
            btnBlaze.Font = new Font("Segoe Print", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBlaze.Location = new Point(244, 370);
            btnBlaze.Name = "btnBlaze";
            btnBlaze.Size = new Size(147, 39);
            btnBlaze.TabIndex = 5;
            btnBlaze.Text = "Blaze";
            btnBlaze.UseVisualStyleBackColor = false;
            btnBlaze.Click += selectBtns_Click;
            btnBlaze.MouseEnter += selectBtns_MouseEnter;
            btnBlaze.MouseLeave += selectBtns_MouseLeave;
            // 
            // btnAurora
            // 
            btnAurora.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnAurora.BackColor = Color.Transparent;
            btnAurora.BackgroundImage = Properties.Resources.scroll;
            btnAurora.BackgroundImageLayout = ImageLayout.Stretch;
            btnAurora.Cursor = Cursors.Hand;
            btnAurora.FlatAppearance.BorderSize = 0;
            btnAurora.FlatStyle = FlatStyle.Flat;
            btnAurora.Font = new Font("Segoe Print", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAurora.Location = new Point(446, 370);
            btnAurora.Name = "btnAurora";
            btnAurora.Size = new Size(147, 39);
            btnAurora.TabIndex = 6;
            btnAurora.Text = "Aurora";
            btnAurora.UseVisualStyleBackColor = false;
            btnAurora.Click += selectBtns_Click;
            btnAurora.MouseEnter += selectBtns_MouseEnter;
            btnAurora.MouseLeave += selectBtns_MouseLeave;
            // 
            // btnJade
            // 
            btnJade.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnJade.BackColor = Color.Transparent;
            btnJade.BackgroundImage = Properties.Resources.scroll;
            btnJade.BackgroundImageLayout = ImageLayout.Stretch;
            btnJade.Cursor = Cursors.Hand;
            btnJade.FlatAppearance.BorderSize = 0;
            btnJade.FlatStyle = FlatStyle.Flat;
            btnJade.Font = new Font("Segoe Print", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnJade.Location = new Point(648, 370);
            btnJade.Name = "btnJade";
            btnJade.Size = new Size(147, 39);
            btnJade.TabIndex = 7;
            btnJade.Text = "Jade";
            btnJade.UseVisualStyleBackColor = false;
            btnJade.Click += selectBtns_Click;
            btnJade.MouseEnter += selectBtns_MouseEnter;
            btnJade.MouseLeave += selectBtns_MouseLeave;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Select_Champion_Screen;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(838, 441);
            Controls.Add(btnJade);
            Controls.Add(btnAurora);
            Controls.Add(btnBlaze);
            Controls.Add(btnSakura);
            Controls.Add(labelSelect);
            Name = "Form2";
            Text = "Tic-Tac-Toe Dojo (Select Champion)";
            FormClosing += Form2_FormClosing;
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelSelect;
        private Button btnSakura;
        private Button btnBlaze;
        private Button btnAurora;
        private Button btnJade;
    }
}