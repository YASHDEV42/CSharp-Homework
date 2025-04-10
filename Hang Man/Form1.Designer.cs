namespace HangMan
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
            GuessPanel = new Panel();
            btnGuess = new Button();
            tbGuess = new TextBox();
            lblWordDisplay = new Label();
            panel1 = new Panel();
            GuessPanel.SuspendLayout();
            SuspendLayout();
            // 
            // GuessPanel
            // 
            GuessPanel.BackColor = Color.FromArgb(255, 192, 128);
            GuessPanel.Controls.Add(btnGuess);
            GuessPanel.Controls.Add(tbGuess);
            GuessPanel.Controls.Add(lblWordDisplay);
            GuessPanel.Dock = DockStyle.Bottom;
            GuessPanel.Location = new Point(0, 391);
            GuessPanel.Name = "GuessPanel";
            GuessPanel.Size = new Size(584, 170);
            GuessPanel.TabIndex = 1;
            // 
            // btnGuess
            // 
            btnGuess.BackColor = Color.FromArgb(255, 128, 0);
            btnGuess.FlatAppearance.BorderColor = Color.White;
            btnGuess.FlatAppearance.BorderSize = 0;
            btnGuess.FlatStyle = FlatStyle.Flat;
            btnGuess.Location = new Point(329, 94);
            btnGuess.Name = "btnGuess";
            btnGuess.Size = new Size(74, 37);
            btnGuess.TabIndex = 2;
            btnGuess.Text = "Guess";
            btnGuess.UseVisualStyleBackColor = false;
            btnGuess.Click += tbGame_Click;
            // 
            // tbGuess
            // 
            tbGuess.BackColor = Color.PeachPuff;
            tbGuess.BorderStyle = BorderStyle.None;
            tbGuess.Font = new Font("MS Reference Sans Serif", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tbGuess.Location = new Point(157, 94);
            tbGuess.Multiline = true;
            tbGuess.Name = "tbGuess";
            tbGuess.Size = new Size(165, 37);
            tbGuess.TabIndex = 1;
            tbGuess.TextAlign = HorizontalAlignment.Center;
            // 
            // lblWordDisplay
            // 
            lblWordDisplay.BackColor = Color.PeachPuff;
            lblWordDisplay.BorderStyle = BorderStyle.Fixed3D;
            lblWordDisplay.Font = new Font("Segoe UI", 14.25F);
            lblWordDisplay.Location = new Point(157, 15);
            lblWordDisplay.Name = "lblWordDisplay";
            lblWordDisplay.Size = new Size(246, 59);
            lblWordDisplay.TabIndex = 0;
            lblWordDisplay.TextAlign = ContentAlignment.MiddleCenter;
            lblWordDisplay.Click += label1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 192, 128);
            panel1.BackgroundImage = Properties.Resources.hangman_0;
            panel1.BackgroundImageLayout = ImageLayout.Zoom;
            panel1.Location = new Point(26, 35);
            panel1.Name = "panel1";
            panel1.Size = new Size(508, 311);
            panel1.TabIndex = 2;
            panel1.Paint += panel1_Paint;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 192, 128);
            ClientSize = new Size(584, 561);
            Controls.Add(panel1);
            Controls.Add(GuessPanel);
            MaximumSize = new Size(600, 600);
            MinimumSize = new Size(600, 600);
            Name = "Form1";
            Text = "HangMan";
            Load += Form1_Load;
            GuessPanel.ResumeLayout(false);
            GuessPanel.PerformLayout();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel GuessPanel;
        private System.Windows.Forms.Label lblWordDisplay;
        private System.Windows.Forms.TextBox tbGuess;
        private System.Windows.Forms.Button btnGuess;
        private Panel panel1;
    }
}
