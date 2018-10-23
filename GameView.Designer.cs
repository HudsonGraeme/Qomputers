namespace ICS3U1_Culminating
{
    partial class GameView
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
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.questionText = new System.Windows.Forms.Label();
            this.MainLabel = new System.Windows.Forms.Label();
            this.AnswerOne = new CButton();
            this.AnswerTwo = new CButton();
            this.AnswerThree = new CButton();
            this.AnswerFour = new CButton();
            this.PointsLabel = new System.Windows.Forms.Label();
            this.NextButton = new CButton();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Goldenrod;
            this.button2.Location = new System.Drawing.Point(674, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(34, 27);
            this.button2.TabIndex = 3;
            this.button2.Text = "—";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Minimize);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(754, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(34, 27);
            this.button1.TabIndex = 4;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Close);
            // 
            // button3
            // 
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.button3.Location = new System.Drawing.Point(714, 11);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(34, 27);
            this.button3.TabIndex = 5;
            this.button3.Text = "☐";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Expand);
            // 
            // questionText
            // 
            this.questionText.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.questionText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.questionText.ForeColor = System.Drawing.Color.White;
            this.questionText.Location = new System.Drawing.Point(184, 118);
            this.questionText.Name = "questionText";
            this.questionText.Size = new System.Drawing.Size(434, 94);
            this.questionText.TabIndex = 6;
            this.questionText.Text = "What is your favourite color?";
            this.questionText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainLabel
            // 
            this.MainLabel.Font = new System.Drawing.Font("Arial", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.MainLabel.Location = new System.Drawing.Point(292, 12);
            this.MainLabel.Name = "MainLabel";
            this.MainLabel.Size = new System.Drawing.Size(218, 48);
            this.MainLabel.TabIndex = 7;
            this.MainLabel.Text = "Qomputers";
            this.MainLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AnswerOne
            // 
            this.AnswerOne.FlatAppearance.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.AnswerOne.FlatAppearance.BorderSize = 2;
            this.AnswerOne.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.AnswerOne.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AnswerOne.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AnswerOne.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.AnswerOne.isCorrect = false;
            this.AnswerOne.Location = new System.Drawing.Point(150, 215);
            this.AnswerOne.Name = "AnswerOne";
            this.AnswerOne.Size = new System.Drawing.Size(500, 35);
            this.AnswerOne.TabIndex = 8;
            this.AnswerOne.Text = "AnswerOne";
            this.AnswerOne.UseVisualStyleBackColor = true;
            this.AnswerOne.Click += new System.EventHandler(this.AnswerOne_Click);
            // 
            // AnswerTwo
            // 
            this.AnswerTwo.FlatAppearance.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.AnswerTwo.FlatAppearance.BorderSize = 2;
            this.AnswerTwo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.AnswerTwo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AnswerTwo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AnswerTwo.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.AnswerTwo.isCorrect = false;
            this.AnswerTwo.Location = new System.Drawing.Point(150, 256);
            this.AnswerTwo.Name = "AnswerTwo";
            this.AnswerTwo.Size = new System.Drawing.Size(500, 35);
            this.AnswerTwo.TabIndex = 9;
            this.AnswerTwo.Text = "AnswerTwo";
            this.AnswerTwo.UseVisualStyleBackColor = true;
            this.AnswerTwo.Click += new System.EventHandler(this.AnswerTwo_Click);
            // 
            // AnswerThree
            // 
            this.AnswerThree.FlatAppearance.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.AnswerThree.FlatAppearance.BorderSize = 2;
            this.AnswerThree.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.AnswerThree.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AnswerThree.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AnswerThree.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.AnswerThree.isCorrect = false;
            this.AnswerThree.Location = new System.Drawing.Point(150, 297);
            this.AnswerThree.Name = "AnswerThree";
            this.AnswerThree.Size = new System.Drawing.Size(500, 35);
            this.AnswerThree.TabIndex = 10;
            this.AnswerThree.Text = "AnswerThree";
            this.AnswerThree.UseVisualStyleBackColor = true;
            this.AnswerThree.Click += new System.EventHandler(this.AnswerThree_Click);
            // 
            // AnswerFour
            // 
            this.AnswerFour.FlatAppearance.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.AnswerFour.FlatAppearance.BorderSize = 2;
            this.AnswerFour.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.AnswerFour.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AnswerFour.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AnswerFour.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.AnswerFour.isCorrect = false;
            this.AnswerFour.Location = new System.Drawing.Point(150, 338);
            this.AnswerFour.Name = "AnswerFour";
            this.AnswerFour.Size = new System.Drawing.Size(500, 35);
            this.AnswerFour.TabIndex = 11;
            this.AnswerFour.Text = "AnswerFour";
            this.AnswerFour.UseVisualStyleBackColor = true;
            this.AnswerFour.Click += new System.EventHandler(this.AnswerFour_Click);
            // 
            // PointsLabel
            // 
            this.PointsLabel.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PointsLabel.ForeColor = System.Drawing.Color.Goldenrod;
            this.PointsLabel.Location = new System.Drawing.Point(12, 12);
            this.PointsLabel.Name = "PointsLabel";
            this.PointsLabel.Size = new System.Drawing.Size(218, 48);
            this.PointsLabel.TabIndex = 12;
            this.PointsLabel.Text = "Points";
            this.PointsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NextButton
            // 
            this.NextButton.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.NextButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.NextButton.FlatAppearance.BorderSize = 2;
            this.NextButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.NextButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NextButton.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NextButton.ForeColor = System.Drawing.Color.White;
            this.NextButton.isCorrect = false;
            this.NextButton.Location = new System.Drawing.Point(150, 403);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(500, 35);
            this.NextButton.TabIndex = 13;
            this.NextButton.Text = "Next";
            this.NextButton.UseVisualStyleBackColor = false;
            this.NextButton.Visible = false;
            this.NextButton.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // GameView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.NextButton);
            this.Controls.Add(this.PointsLabel);
            this.Controls.Add(this.AnswerFour);
            this.Controls.Add(this.AnswerThree);
            this.Controls.Add(this.AnswerTwo);
            this.Controls.Add(this.AnswerOne);
            this.Controls.Add(this.MainLabel);
            this.Controls.Add(this.questionText);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GameView";
            this.Text = "GameView";
            this.Load += new System.EventHandler(this.GameView_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label questionText;
        private System.Windows.Forms.Label MainLabel;
        private CButton AnswerOne;
        private CButton AnswerTwo;
        private CButton AnswerThree;
        private CButton AnswerFour;
        private System.Windows.Forms.Label PointsLabel;
        private CButton NextButton;
    }
}