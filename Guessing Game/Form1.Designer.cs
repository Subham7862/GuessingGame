namespace Guessing_Game
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblHint1 = new System.Windows.Forms.Label();
            this.lblHint2 = new System.Windows.Forms.Label();
            this.lblHint3 = new System.Windows.Forms.Label();
            this.lblInst = new System.Windows.Forms.Label();
            this.lblInst3 = new System.Windows.Forms.Label();
            this.lblInst2 = new System.Windows.Forms.Label();
            this.lblInst1 = new System.Windows.Forms.Label();
            this.btnCheck = new System.Windows.Forms.Button();
            this.lblHints = new System.Windows.Forms.Label();
            this.lblGuess1 = new System.Windows.Forms.Label();
            this.txtGuess1 = new System.Windows.Forms.TextBox();
            this.txtGuess3 = new System.Windows.Forms.TextBox();
            this.lblGuess3 = new System.Windows.Forms.Label();
            this.txtGuess2 = new System.Windows.Forms.TextBox();
            this.lblGuess2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblHint1
            // 
            this.lblHint1.AutoSize = true;
            this.lblHint1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblHint1.Location = new System.Drawing.Point(50, 249);
            this.lblHint1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHint1.Name = "lblHint1";
            this.lblHint1.Size = new System.Drawing.Size(342, 21);
            this.lblHint1.TabIndex = 0;
            this.lblHint1.Text = "Hint 1: It was used by warriors in battlefields";
            // 
            // lblHint2
            // 
            this.lblHint2.AutoSize = true;
            this.lblHint2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblHint2.Location = new System.Drawing.Point(50, 283);
            this.lblHint2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHint2.Name = "lblHint2";
            this.lblHint2.Size = new System.Drawing.Size(196, 21);
            this.lblHint2.TabIndex = 1;
            this.lblHint2.Text = "Hint 2: It is made of steel";
            // 
            // lblHint3
            // 
            this.lblHint3.AutoSize = true;
            this.lblHint3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblHint3.Location = new System.Drawing.Point(50, 318);
            this.lblHint3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHint3.Name = "lblHint3";
            this.lblHint3.Size = new System.Drawing.Size(261, 21);
            this.lblHint3.TabIndex = 2;
            this.lblHint3.Text = "Hint 3: It is a sharp melee weapon";
            // 
            // lblInst
            // 
            this.lblInst.AutoSize = true;
            this.lblInst.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lblInst.Location = new System.Drawing.Point(50, 42);
            this.lblInst.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInst.Name = "lblInst";
            this.lblInst.Size = new System.Drawing.Size(148, 21);
            this.lblInst.TabIndex = 3;
            this.lblInst.Text = "Some instructions:";
            // 
            // lblInst3
            // 
            this.lblInst3.AutoSize = true;
            this.lblInst3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lblInst3.Location = new System.Drawing.Point(50, 147);
            this.lblInst3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInst3.Name = "lblInst3";
            this.lblInst3.Size = new System.Drawing.Size(356, 21);
            this.lblInst3.TabIndex = 4;
            this.lblInst3.Text = "3. All characters are to be entered in lowercase";
            // 
            // lblInst2
            // 
            this.lblInst2.AutoSize = true;
            this.lblInst2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lblInst2.Location = new System.Drawing.Point(50, 112);
            this.lblInst2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInst2.Name = "lblInst2";
            this.lblInst2.Size = new System.Drawing.Size(391, 21);
            this.lblInst2.TabIndex = 5;
            this.lblInst2.Text = "2. Only a specific single word is the correct answer";
            // 
            // lblInst1
            // 
            this.lblInst1.AutoSize = true;
            this.lblInst1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lblInst1.Location = new System.Drawing.Point(50, 77);
            this.lblInst1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInst1.Name = "lblInst1";
            this.lblInst1.Size = new System.Drawing.Size(349, 21);
            this.lblInst1.TabIndex = 6;
            this.lblInst1.Text = "1. 3 guesses have been provided to the player";
            // 
            // btnCheck
            // 
            this.btnCheck.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnCheck.Location = new System.Drawing.Point(179, 523);
            this.btnCheck.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(107, 32);
            this.btnCheck.TabIndex = 7;
            this.btnCheck.Text = "Check";
            this.btnCheck.UseVisualStyleBackColor = false;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // lblHints
            // 
            this.lblHints.AutoSize = true;
            this.lblHints.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblHints.Location = new System.Drawing.Point(50, 214);
            this.lblHints.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHints.Name = "lblHints";
            this.lblHints.Size = new System.Drawing.Size(49, 21);
            this.lblHints.TabIndex = 8;
            this.lblHints.Text = "Hints";
            // 
            // lblGuess1
            // 
            this.lblGuess1.AutoSize = true;
            this.lblGuess1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblGuess1.Location = new System.Drawing.Point(50, 403);
            this.lblGuess1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGuess1.Name = "lblGuess1";
            this.lblGuess1.Size = new System.Drawing.Size(222, 21);
            this.lblGuess1.TabIndex = 9;
            this.lblGuess1.Text = "Please enter your first guess:";
            // 
            // txtGuess1
            // 
            this.txtGuess1.Location = new System.Drawing.Point(335, 400);
            this.txtGuess1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtGuess1.Name = "txtGuess1";
            this.txtGuess1.Size = new System.Drawing.Size(141, 29);
            this.txtGuess1.TabIndex = 10;
            // 
            // txtGuess3
            // 
            this.txtGuess3.Location = new System.Drawing.Point(335, 474);
            this.txtGuess3.Margin = new System.Windows.Forms.Padding(4);
            this.txtGuess3.Name = "txtGuess3";
            this.txtGuess3.Size = new System.Drawing.Size(141, 29);
            this.txtGuess3.TabIndex = 12;
            // 
            // lblGuess3
            // 
            this.lblGuess3.AutoSize = true;
            this.lblGuess3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblGuess3.Location = new System.Drawing.Point(50, 477);
            this.lblGuess3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGuess3.Name = "lblGuess3";
            this.lblGuess3.Size = new System.Drawing.Size(218, 21);
            this.lblGuess3.TabIndex = 11;
            this.lblGuess3.Text = "Please enter your last guess:";
            // 
            // txtGuess2
            // 
            this.txtGuess2.Location = new System.Drawing.Point(335, 437);
            this.txtGuess2.Margin = new System.Windows.Forms.Padding(4);
            this.txtGuess2.Name = "txtGuess2";
            this.txtGuess2.Size = new System.Drawing.Size(141, 29);
            this.txtGuess2.TabIndex = 14;
            // 
            // lblGuess2
            // 
            this.lblGuess2.AutoSize = true;
            this.lblGuess2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblGuess2.Location = new System.Drawing.Point(50, 440);
            this.lblGuess2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGuess2.Name = "lblGuess2";
            this.lblGuess2.Size = new System.Drawing.Size(247, 21);
            this.lblGuess2.TabIndex = 13;
            this.lblGuess2.Text = "Please enter your second guess:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(546, 568);
            this.Controls.Add(this.txtGuess2);
            this.Controls.Add(this.lblGuess2);
            this.Controls.Add(this.txtGuess3);
            this.Controls.Add(this.lblGuess3);
            this.Controls.Add(this.txtGuess1);
            this.Controls.Add(this.lblGuess1);
            this.Controls.Add(this.lblHints);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.lblInst1);
            this.Controls.Add(this.lblInst2);
            this.Controls.Add(this.lblInst3);
            this.Controls.Add(this.lblInst);
            this.Controls.Add(this.lblHint3);
            this.Controls.Add(this.lblHint2);
            this.Controls.Add(this.lblHint1);
            this.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Guessing Game";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHint1;
        private System.Windows.Forms.Label lblHint2;
        private System.Windows.Forms.Label lblHint3;
        private System.Windows.Forms.Label lblInst;
        private System.Windows.Forms.Label lblInst3;
        private System.Windows.Forms.Label lblInst2;
        private System.Windows.Forms.Label lblInst1;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.Label lblHints;
        private System.Windows.Forms.Label lblGuess1;
        private System.Windows.Forms.TextBox txtGuess1;
        private System.Windows.Forms.TextBox txtGuess3;
        private System.Windows.Forms.Label lblGuess3;
        private System.Windows.Forms.TextBox txtGuess2;
        private System.Windows.Forms.Label lblGuess2;
    }
}

