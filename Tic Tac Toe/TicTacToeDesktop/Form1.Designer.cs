namespace TicTacToeDesktop
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
            btn7 = new Button();
            btn8 = new Button();
            btn9 = new Button();
            btn4 = new Button();
            btn5 = new Button();
            btn6 = new Button();
            btn1 = new Button();
            btn2 = new Button();
            btn3 = new Button();
            lblStatus = new Label();
            Reset = new Button();
            SuspendLayout();
            // 
            // btn7
            // 
            btn7.Location = new Point(236, 317);
            btn7.Name = "btn7";
            btn7.Size = new Size(100, 100);
            btn7.TabIndex = 0;
            btn7.UseVisualStyleBackColor = true;
            btn7.Click += BoardButton_Click;
            // 
            // btn8
            // 
            btn8.Location = new Point(342, 317);
            btn8.Name = "btn8";
            btn8.Size = new Size(100, 100);
            btn8.TabIndex = 1;
            btn8.UseVisualStyleBackColor = true;
            btn8.Click += BoardButton_Click;
            // 
            // btn9
            // 
            btn9.Location = new Point(448, 317);
            btn9.Name = "btn9";
            btn9.Size = new Size(100, 100);
            btn9.TabIndex = 2;
            btn9.UseVisualStyleBackColor = true;
            btn9.Click += BoardButton_Click;
            // 
            // btn4
            // 
            btn4.Location = new Point(236, 211);
            btn4.Name = "btn4";
            btn4.Size = new Size(100, 100);
            btn4.TabIndex = 3;
            btn4.UseVisualStyleBackColor = true;
            btn4.Click += BoardButton_Click;
            // 
            // btn5
            // 
            btn5.Location = new Point(342, 211);
            btn5.Name = "btn5";
            btn5.Size = new Size(100, 100);
            btn5.TabIndex = 4;
            btn5.UseVisualStyleBackColor = true;
            btn5.Click += BoardButton_Click;
            // 
            // btn6
            // 
            btn6.Location = new Point(448, 211);
            btn6.Name = "btn6";
            btn6.Size = new Size(100, 100);
            btn6.TabIndex = 5;
            btn6.UseVisualStyleBackColor = true;
            btn6.Click += BoardButton_Click;
            // 
            // btn1
            // 
            btn1.Location = new Point(236, 105);
            btn1.Name = "btn1";
            btn1.Size = new Size(100, 100);
            btn1.TabIndex = 6;
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += btn1_Click;
            // 
            // btn2
            // 
            btn2.Location = new Point(342, 105);
            btn2.Name = "btn2";
            btn2.Size = new Size(100, 100);
            btn2.TabIndex = 7;
            btn2.UseVisualStyleBackColor = true;
            btn2.Click += BoardButton_Click;
            // 
            // btn3
            // 
            btn3.Location = new Point(448, 105);
            btn3.Name = "btn3";
            btn3.Size = new Size(100, 100);
            btn3.TabIndex = 8;
            btn3.UseVisualStyleBackColor = true;
            btn3.Click += BoardButton_Click;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("Lucida Sans Unicode", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStatus.Location = new Point(249, 32);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(299, 45);
            lblStatus.TabIndex = 9;
            lblStatus.Text = "Player X's Turn";
            lblStatus.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Reset
            // 
            Reset.BackColor = Color.DarkSlateGray;
            Reset.Font = new Font("Lucida Bright", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Reset.ForeColor = Color.White;
            Reset.Location = new Point(572, 377);
            Reset.Name = "Reset";
            Reset.Size = new Size(110, 40);
            Reset.TabIndex = 10;
            Reset.Text = "Reset";
            Reset.UseVisualStyleBackColor = false;
            Reset.Click += btnReset_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Bisque;
            ClientSize = new Size(800, 450);
            Controls.Add(Reset);
            Controls.Add(lblStatus);
            Controls.Add(btn3);
            Controls.Add(btn2);
            Controls.Add(btn1);
            Controls.Add(btn6);
            Controls.Add(btn5);
            Controls.Add(btn4);
            Controls.Add(btn9);
            Controls.Add(btn8);
            Controls.Add(btn7);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn7;
        private Button btn8;
        private Button btn9;
        private Button btn4;
        private Button btn5;
        private Button btn6;
        private Button btn1;
        private Button btn2;
        private Button btn3;
        private Label lblStatus;
        private Button Reset;
    }
}
