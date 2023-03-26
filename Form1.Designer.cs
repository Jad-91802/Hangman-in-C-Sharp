
namespace Hangman
{
    partial class frmForm1
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
            this.pnlScores = new System.Windows.Forms.Panel();
            this.lblScore = new System.Windows.Forms.Label();
            this.lstScores = new System.Windows.Forms.ListBox();
            this.btnNewWord = new System.Windows.Forms.Button();
            this.btnQuit = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlMainDisplay = new System.Windows.Forms.Panel();
            this.lblFinished = new System.Windows.Forms.Label();
            this.lblDisplayGuessCount = new System.Windows.Forms.Label();
            this.lstGuessLetters = new System.Windows.Forms.ListBox();
            this.txtDisplayWord = new System.Windows.Forms.TextBox();
            this.lblGuessWordTitle = new System.Windows.Forms.Label();
            this.pnlScores.SuspendLayout();
            this.pnlMainDisplay.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlScores
            // 
            this.pnlScores.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlScores.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnlScores.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlScores.Controls.Add(this.lblScore);
            this.pnlScores.Controls.Add(this.lstScores);
            this.pnlScores.Location = new System.Drawing.Point(488, 12);
            this.pnlScores.Name = "pnlScores";
            this.pnlScores.Size = new System.Drawing.Size(304, 360);
            this.pnlScores.TabIndex = 0;
            // 
            // lblScore
            // 
            this.lblScore.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblScore.AutoSize = true;
            this.lblScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.Location = new System.Drawing.Point(3, 6);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(52, 17);
            this.lblScore.TabIndex = 1;
            this.lblScore.Text = "Scores";
            // 
            // lstScores
            // 
            this.lstScores.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstScores.FormattingEnabled = true;
            this.lstScores.Items.AddRange(new object[] {
            " "});
            this.lstScores.Location = new System.Drawing.Point(3, 33);
            this.lstScores.Name = "lstScores";
            this.lstScores.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.lstScores.Size = new System.Drawing.Size(294, 316);
            this.lstScores.TabIndex = 0;
            // 
            // btnNewWord
            // 
            this.btnNewWord.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnNewWord.Location = new System.Drawing.Point(12, 330);
            this.btnNewWord.Name = "btnNewWord";
            this.btnNewWord.Size = new System.Drawing.Size(126, 42);
            this.btnNewWord.TabIndex = 1;
            this.btnNewWord.Text = "New Word";
            this.btnNewWord.UseVisualStyleBackColor = true;
            this.btnNewWord.Click += new System.EventHandler(this.btnNewWord_Click);
            // 
            // btnQuit
            // 
            this.btnQuit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnQuit.Location = new System.Drawing.Point(356, 330);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(126, 42);
            this.btnQuit.TabIndex = 2;
            this.btnQuit.Text = "Quit";
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(9, 12);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(192, 25);
            this.lblTitle.TabIndex = 3;
            this.lblTitle.Text = "Let\'s Play Hangman!";
            // 
            // pnlMainDisplay
            // 
            this.pnlMainDisplay.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlMainDisplay.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pnlMainDisplay.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlMainDisplay.Controls.Add(this.lblFinished);
            this.pnlMainDisplay.Controls.Add(this.lblDisplayGuessCount);
            this.pnlMainDisplay.Controls.Add(this.lstGuessLetters);
            this.pnlMainDisplay.Controls.Add(this.txtDisplayWord);
            this.pnlMainDisplay.Controls.Add(this.lblGuessWordTitle);
            this.pnlMainDisplay.Location = new System.Drawing.Point(12, 47);
            this.pnlMainDisplay.Name = "pnlMainDisplay";
            this.pnlMainDisplay.Size = new System.Drawing.Size(470, 277);
            this.pnlMainDisplay.TabIndex = 4;
            // 
            // lblFinished
            // 
            this.lblFinished.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFinished.AutoSize = true;
            this.lblFinished.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFinished.Location = new System.Drawing.Point(249, 59);
            this.lblFinished.Name = "lblFinished";
            this.lblFinished.Size = new System.Drawing.Size(104, 25);
            this.lblFinished.TabIndex = 4;
            this.lblFinished.Text = "Finished!!!";
            this.lblFinished.Visible = false;
            // 
            // lblDisplayGuessCount
            // 
            this.lblDisplayGuessCount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblDisplayGuessCount.AutoSize = true;
            this.lblDisplayGuessCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisplayGuessCount.Location = new System.Drawing.Point(23, 91);
            this.lblDisplayGuessCount.Name = "lblDisplayGuessCount";
            this.lblDisplayGuessCount.Size = new System.Drawing.Size(0, 63);
            this.lblDisplayGuessCount.TabIndex = 3;
            // 
            // lstGuessLetters
            // 
            this.lstGuessLetters.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstGuessLetters.ColumnWidth = 15;
            this.lstGuessLetters.FormattingEnabled = true;
            this.lstGuessLetters.Items.AddRange(new object[] {
            " "});
            this.lstGuessLetters.Location = new System.Drawing.Point(379, 91);
            this.lstGuessLetters.Margin = new System.Windows.Forms.Padding(5);
            this.lstGuessLetters.MultiColumn = true;
            this.lstGuessLetters.Name = "lstGuessLetters";
            this.lstGuessLetters.Size = new System.Drawing.Size(58, 134);
            this.lstGuessLetters.TabIndex = 2;
            // 
            // txtDisplayWord
            // 
            this.txtDisplayWord.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDisplayWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDisplayWord.Location = new System.Drawing.Point(121, 29);
            this.txtDisplayWord.Name = "txtDisplayWord";
            this.txtDisplayWord.ReadOnly = true;
            this.txtDisplayWord.Size = new System.Drawing.Size(232, 27);
            this.txtDisplayWord.TabIndex = 1;
            this.txtDisplayWord.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDisplayWord.WordWrap = false;
            // 
            // lblGuessWordTitle
            // 
            this.lblGuessWordTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblGuessWordTitle.AutoSize = true;
            this.lblGuessWordTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGuessWordTitle.Location = new System.Drawing.Point(118, 10);
            this.lblGuessWordTitle.Name = "lblGuessWordTitle";
            this.lblGuessWordTitle.Size = new System.Drawing.Size(109, 16);
            this.lblGuessWordTitle.TabIndex = 0;
            this.lblGuessWordTitle.Text = "Guess the word...";
            this.lblGuessWordTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(804, 384);
            this.Controls.Add(this.pnlMainDisplay);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.btnNewWord);
            this.Controls.Add(this.pnlScores);
            this.KeyPreview = true;
            this.Name = "frmForm1";
            this.Text = "Hangman";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            this.pnlScores.ResumeLayout(false);
            this.pnlScores.PerformLayout();
            this.pnlMainDisplay.ResumeLayout(false);
            this.pnlMainDisplay.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlScores;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.ListBox lstScores;
        private System.Windows.Forms.Button btnNewWord;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlMainDisplay;
        private System.Windows.Forms.TextBox txtDisplayWord;
        private System.Windows.Forms.Label lblGuessWordTitle;
        private System.Windows.Forms.ListBox lstGuessLetters;
        private System.Windows.Forms.Label lblDisplayGuessCount;
        private System.Windows.Forms.Label lblFinished;
    }
}

