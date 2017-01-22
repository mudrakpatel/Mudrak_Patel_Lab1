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
                case true:
                    computerProgrammerAnalystComboBox.Show();
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
                MessageBox.Show(exception.Message, "Exception occured!");
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
            if (String.IsNullOrEmpty(nameTextBox.Text))
            {
                MessageBox.Show("Please enter a name","Validation warning!");
            }
        }


        private void phoneNumberTextBox_MouseLeave(object sender, EventArgs e)
        {
            if (phoneNumberTextBox.TextLength > 13) {
                MessageBox.Show("Phone number must be less than 13 characters","Validation warning!");
            } else if (String.IsNullOrEmpty(phoneNumberTextBox.Text))
            {
                MessageBox.Show("Please fill in your phone number","Validation warning!");
            }
            else {
                try {
                    Convert.ToInt32(phoneNumberTextBox.Text);
                }
                catch (Exception exception)
                {
                    MessageBox.Show("Please enter a valid phone number.\n"+exception.Message,"Validation warning!");
                }
            }
        }

        private void displayButton_Click(object sender, EventArgs e)
        {
            if ((computerProgrammerAnalystRadioButton.Checked) || (computerProgrammerRadioButton.Checked))
            {
                if ((String.IsNullOrEmpty(addressTextBox.Text)) ||
                    (String.IsNullOrEmpty(cityTextBox.Text)) ||
                   (String.IsNullOrEmpty(postalCodeTextBox.Text)) ||
                    (String.IsNullOrEmpty(provinceTextBox.Text)))
                {
                    MessageBox.Show("Check whether you have filled all the inputs","Input errors!");
                }
                else
                {
                    if (computerProgrammerAnalystRadioButton.Checked)
                    {
                        displayTextBox.Text = "Name: "+nameTextBox.Text + "<---->"
                                              +"Address: "+addressTextBox.Text+"<---->"
                                              +"City: "+cityTextBox.Text+ "<---->"
                                              + "Postal code: "+postalCodeTextBox.Text+ "<---->"
                                              + "Province: "+provinceTextBox.Text+ "<---->"
                                              + "Phone: "+phoneNumberTextBox.Text+ "<---->"
                                              + "Courses: "+">>>"
                                              +computerProgrammerAnalystComboBox.Text;
                    }
                    else if(computerProgrammerRadioButton.Checked)
                    {
                        displayTextBox.Text = "Name: " + nameTextBox.Text + "<---->"
                                              + "Address: " + addressTextBox.Text + "<---->"
                                              + "City: " + cityTextBox.Text + "<---->"
                                              + "Postal code: " + postalCodeTextBox.Text + "<---->"
                                              + "Province: " + provinceTextBox.Text + "<---->"
                                              + "Phone: " + phoneNumberTextBox.Text + "<---->"
                                              + "Courses: " + ">>>"
                                              + computerProgrammerComboBox.Text;
                    }
                }
            } else
            {
                MessageBox.Show("Please select a program to register.","Validation error!");
            }
        }
    }
}
