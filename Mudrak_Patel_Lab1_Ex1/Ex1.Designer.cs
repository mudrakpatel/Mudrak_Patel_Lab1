﻿namespace Mudrak_Patel_Lab1_Ex1
{
    partial class Ex1
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
            this.lstBoxGrades = new System.Windows.Forms.ListBox();
            this.lblGrades = new System.Windows.Forms.Label();
            this.btnInput = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnSum = new System.Windows.Forms.Button();
            this.btnAverage = new System.Windows.Forms.Button();
            this.txtBoxInput = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lstBoxGrades
            // 
            this.lstBoxGrades.FormattingEnabled = true;
            this.lstBoxGrades.Location = new System.Drawing.Point(13, 67);
            this.lstBoxGrades.Name = "lstBoxGrades";
            this.lstBoxGrades.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lstBoxGrades.Size = new System.Drawing.Size(120, 186);
            this.lstBoxGrades.TabIndex = 0;
            // 
            // lblGrades
            // 
            this.lblGrades.AutoSize = true;
            this.lblGrades.Location = new System.Drawing.Point(12, 41);
            this.lblGrades.Name = "lblGrades";
            this.lblGrades.Size = new System.Drawing.Size(47, 13);
            this.lblGrades.TabIndex = 1;
            this.lblGrades.Text = "Grades: ";
            // 
            // btnInput
            // 
            this.btnInput.Location = new System.Drawing.Point(154, 69);
            this.btnInput.Name = "btnInput";
            this.btnInput.Size = new System.Drawing.Size(75, 23);
            this.btnInput.TabIndex = 2;
            this.btnInput.Text = "Input";
            this.btnInput.UseVisualStyleBackColor = true;
            this.btnInput.Click += new System.EventHandler(this.btnInput_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(154, 99);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(154, 129);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(75, 23);
            this.btnRemove.TabIndex = 4;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnSum
            // 
            this.btnSum.Location = new System.Drawing.Point(154, 159);
            this.btnSum.Name = "btnSum";
            this.btnSum.Size = new System.Drawing.Size(75, 23);
            this.btnSum.TabIndex = 5;
            this.btnSum.Text = "Sum";
            this.btnSum.UseVisualStyleBackColor = true;
            this.btnSum.Click += new System.EventHandler(this.btnSum_Click);
            // 
            // btnAverage
            // 
            this.btnAverage.Location = new System.Drawing.Point(154, 189);
            this.btnAverage.Name = "btnAverage";
            this.btnAverage.Size = new System.Drawing.Size(75, 23);
            this.btnAverage.TabIndex = 6;
            this.btnAverage.Text = "Average";
            this.btnAverage.UseVisualStyleBackColor = true;
            this.btnAverage.Click += new System.EventHandler(this.btnAverage_Click);
            // 
            // txtBoxInput
            // 
            this.txtBoxInput.Location = new System.Drawing.Point(140, 41);
            this.txtBoxInput.Name = "txtBoxInput";
            this.txtBoxInput.Size = new System.Drawing.Size(100, 20);
            this.txtBoxInput.TabIndex = 7;
            // 
            // Ex1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(252, 325);
            this.Controls.Add(this.txtBoxInput);
            this.Controls.Add(this.btnAverage);
            this.Controls.Add(this.btnSum);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnInput);
            this.Controls.Add(this.lblGrades);
            this.Controls.Add(this.lstBoxGrades);
            this.Name = "Ex1";
            this.Text = "Grade Book Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstBoxGrades;
        private System.Windows.Forms.Label lblGrades;
        private System.Windows.Forms.Button btnInput;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnSum;
        private System.Windows.Forms.Button btnAverage;
        private System.Windows.Forms.TextBox txtBoxInput;
    }
}

