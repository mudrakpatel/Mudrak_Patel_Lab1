//Mudrak Patel; 300878960; Programming 3 Lab 1

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mudrak_Patel_Lab1_Ex3
{
    public partial class FeedbackForm : Form
    {
        public FeedbackForm()
        {
            InitializeComponent();
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            if ((String.IsNullOrWhiteSpace(nameTextBox.Text)) ||
                (String.IsNullOrWhiteSpace(commentsTextBox.Text))||
                (String.IsNullOrWhiteSpace(emailTextBox.Text)))
            {
                MessageBox.Show("All fields are mandatory.","Validation error!");
            }
            else
            {
                string responseCaptured = "Name: " + nameTextBox.Text + Environment.NewLine +
                        "Comments: " + commentsTextBox.Text + Environment.NewLine +
                        "Emai address: " + emailTextBox.Text + Environment.NewLine +
                        "Things you liked: " + Environment.NewLine +
                        "           Site design: " + designCheckBox.CheckState.ToString() + Environment.NewLine +
                        "           Links: " + linksCheckBox.CheckState.ToString() + Environment.NewLine +
                        "           Ease of use: " + easeOfUseCheckBox.CheckState.ToString() + Environment.NewLine +
                        "           Images: " + imagesCheckBox.CheckState.ToString() + Environment.NewLine +
                        "           Source code: " + sourceCodeCheckBox.CheckState.ToString() + Environment.NewLine +
                        "How you got to our website?" + Environment.NewLine +
                        "           Search engine: " + searchEngineRadioButton.Checked.ToString() + Environment.NewLine +
                        "           Links from another site: " + linkFromAnotherSiteRadioButton.Checked.ToString() + Environment.NewLine +
                        "           Deitel.com website: " + deitelWebsiteRadioButton.Checked.ToString() + Environment.NewLine +
                        "           Reference from a book: " + bookReferenceRadioButton.Checked.ToString() + Environment.NewLine +
                        "           Other: " + otherOptionRadioButton.Checked.ToString() + Environment.NewLine;
                MessageBox.Show(responseCaptured, "Your response.");
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            //clear the textfields
            nameTextBox.Clear();
            commentsTextBox.Text = "Comments here...";
            emailTextBox.Clear();

            //uncheck the checkboxes
            designCheckBox.Checked = false;
            easeOfUseCheckBox.Checked = false;
            imagesCheckBox.Checked = false;
            linksCheckBox.Checked = false;
            sourceCodeCheckBox.Checked = false;

            //unselect the radio buttons
            bookReferenceRadioButton.Checked = false;
            otherOptionRadioButton.Checked = false;
            deitelWebsiteRadioButton.Checked = false;
            linkFromAnotherSiteRadioButton.Checked = false;
            searchEngineRadioButton.Checked = false;

            //combo box clearance
            rateOptionsComboBox.SelectedIndex = 0;
        }
    }
}
