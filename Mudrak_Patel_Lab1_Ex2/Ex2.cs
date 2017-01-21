using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Mudrak_Patel_Lab1_Ex2
{
    public partial class Ex2 : Form
    {
        public Ex2()
        {
            InitializeComponent();
        }

        private void computerProgrammerAnalystRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            switch (computerProgrammerAnalystRadioButton.Checked)
            {
                case true: computerProgrammerAnalystComboBox.Show();
                           computerProgrammerAnalystListBox.Show();
                           computerProgrammerComboBox.Hide();
                           computerProgrammerListBox.Hide();
                    break;
            }
        }

        private void computerProgrammerRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            switch (computerProgrammerRadioButton.Checked)
            {
                case true:
                    computerProgrammerComboBox.Show();
                    computerProgrammerListBox.Show();
                    computerProgrammerAnalystComboBox.Hide();
                    computerProgrammerAnalystListBox.Hide();
                    break;
            }
        }

        private void computerProgrammerComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (computerProgrammerListBox.Items.Contains(computerProgrammerComboBox.SelectedItem))
                {
                    MessageBox.Show("One course can be added only one time.", "Selection error!");
                }
                else
                {
                    computerProgrammerListBox.Items.Add(computerProgrammerComboBox.SelectedItem);
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message,"Exception occured!");
            }
        }

        private void computerProgrammerAnalystComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (computerProgrammerAnalystListBox.Items.Contains(computerProgrammerAnalystComboBox.SelectedItem))
                {
                    MessageBox.Show("One course can be added only one time.", "Selection error!");
                }
                else
                {
                    computerProgrammerAnalystListBox.Items.Add(computerProgrammerAnalystComboBox.SelectedItem);
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Exception occured!");
            }
        }

        private void nameTextBox_Leave(object sender, EventArgs e)
        {
            validateTextBox(nameTextBox, new Regex(@"^((\(\d{3}\) ?)|(\d{3}-))?\d{3}-\d{4}$"), "Please enter a valid phone number with country code.\nDonot leave this textbox empty or null.");
        }

        private void validateTextBox(TextBox textBoxToValidate, Regex validationExpression, string errorMessageToShow)
        {
            if (!(validationExpression.IsMatch(textBoxToValidate.Text)) || 
                (String.IsNullOrWhiteSpace(textBoxToValidate.Text)))
            {
                MessageBox.Show(errorMessageToShow,"Validation error!");
            }
        }
    }
}
