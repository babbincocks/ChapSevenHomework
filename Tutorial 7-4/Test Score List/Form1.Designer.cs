﻿namespace Test_Score_List
{
    partial class frmTestScoreList
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
            this.lbTestScores = new System.Windows.Forms.ListBox();
            this.btnGetScores = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblAverage = new System.Windows.Forms.Label();
            this.lblAboveAverage = new System.Windows.Forms.Label();
            this.lblBelowAverage = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbTestScores
            // 
            this.lbTestScores.FormattingEnabled = true;
            this.lbTestScores.Location = new System.Drawing.Point(16, 25);
            this.lbTestScores.Name = "lbTestScores";
            this.lbTestScores.Size = new System.Drawing.Size(220, 173);
            this.lbTestScores.TabIndex = 0;
            // 
            // btnGetScores
            // 
            this.btnGetScores.Location = new System.Drawing.Point(215, 227);
            this.btnGetScores.Name = "btnGetScores";
            this.btnGetScores.Size = new System.Drawing.Size(91, 27);
            this.btnGetScores.TabIndex = 1;
            this.btnGetScores.Text = "Get Scores";
            this.btnGetScores.UseVisualStyleBackColor = true;
            this.btnGetScores.Click += new System.EventHandler(this.btnGetScores_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(312, 227);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(91, 27);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // lblAverage
            // 
            this.lblAverage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblAverage.Location = new System.Drawing.Point(447, 25);
            this.lblAverage.Name = "lblAverage";
            this.lblAverage.Size = new System.Drawing.Size(112, 30);
            this.lblAverage.TabIndex = 3;
            // 
            // lblAboveAverage
            // 
            this.lblAboveAverage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblAboveAverage.Location = new System.Drawing.Point(447, 81);
            this.lblAboveAverage.Name = "lblAboveAverage";
            this.lblAboveAverage.Size = new System.Drawing.Size(112, 30);
            this.lblAboveAverage.TabIndex = 4;
            // 
            // lblBelowAverage
            // 
            this.lblBelowAverage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblBelowAverage.Location = new System.Drawing.Point(447, 141);
            this.lblBelowAverage.Name = "lblBelowAverage";
            this.lblBelowAverage.Size = new System.Drawing.Size(112, 30);
            this.lblBelowAverage.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(358, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Average Score:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(269, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Number of Scores Above Average:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(269, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(170, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Number of Scores Below Average:";
            // 
            // frmTestScoreList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 273);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblBelowAverage);
            this.Controls.Add(this.lblAboveAverage);
            this.Controls.Add(this.lblAverage);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnGetScores);
            this.Controls.Add(this.lbTestScores);
            this.Name = "frmTestScoreList";
            this.Text = "Test Score List";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbTestScores;
        private System.Windows.Forms.Button btnGetScores;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblAverage;
        private System.Windows.Forms.Label lblAboveAverage;
        private System.Windows.Forms.Label lblBelowAverage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}
