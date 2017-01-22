namespace Mudrak_Patel_Lab1_Ex3
{
    partial class Feedbackform
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
            this.headingLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.commentssLabel = new System.Windows.Forms.Label();
            this.commentsTextBox = new System.Windows.Forms.TextBox();
            this.emailLabel = new System.Windows.Forms.Label();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.likedThingsLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // headingLabel
            // 
            this.headingLabel.AutoSize = true;
            this.headingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.headingLabel.Location = new System.Drawing.Point(13, 13);
            this.headingLabel.Name = "headingLabel";
            this.headingLabel.Size = new System.Drawing.Size(211, 36);
            this.headingLabel.TabIndex = 0;
            this.headingLabel.Text = "Feedback form";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Please fill out this form to help us improve our site.";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(22, 84);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(41, 13);
            this.nameLabel.TabIndex = 2;
            this.nameLabel.Text = "Name: ";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(70, 84);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(246, 20);
            this.nameTextBox.TabIndex = 3;
            // 
            // commentssLabel
            // 
            this.commentssLabel.AutoSize = true;
            this.commentssLabel.Location = new System.Drawing.Point(25, 119);
            this.commentssLabel.Name = "commentssLabel";
            this.commentssLabel.Size = new System.Drawing.Size(62, 13);
            this.commentssLabel.TabIndex = 4;
            this.commentssLabel.Text = "Comments: ";
            // 
            // commentsTextBox
            // 
            this.commentsTextBox.Location = new System.Drawing.Point(28, 136);
            this.commentsTextBox.Multiline = true;
            this.commentsTextBox.Name = "commentsTextBox";
            this.commentsTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.commentsTextBox.Size = new System.Drawing.Size(288, 75);
            this.commentsTextBox.TabIndex = 5;
            this.commentsTextBox.Text = "Enter comments here.";
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Location = new System.Drawing.Point(27, 218);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(78, 13);
            this.emailLabel.TabIndex = 6;
            this.emailLabel.Text = "Email address: ";
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(113, 218);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(203, 20);
            this.emailTextBox.TabIndex = 7;
            // 
            // likedThingsLabel
            // 
            this.likedThingsLabel.AutoSize = true;
            this.likedThingsLabel.Location = new System.Drawing.Point(25, 241);
            this.likedThingsLabel.Name = "likedThingsLabel";
            this.likedThingsLabel.Size = new System.Drawing.Size(90, 13);
            this.likedThingsLabel.TabIndex = 8;
            this.likedThingsLabel.Text = "Things you liked: ";
            // 
            // Feedbackform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(727, 354);
            this.Controls.Add(this.likedThingsLabel);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.commentsTextBox);
            this.Controls.Add(this.commentssLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.headingLabel);
            this.Name = "Feedbackform";
            this.Text = "Feedback form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label headingLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label commentssLabel;
        private System.Windows.Forms.TextBox commentsTextBox;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.Label likedThingsLabel;
    }
}

