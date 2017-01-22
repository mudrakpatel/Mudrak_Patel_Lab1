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

namespace Mudrak_Patel_Lab1_Ex1
{
    public partial class Ex1 : Form
    {
        public Ex1()
        {
            InitializeComponent();
        }

        private void btnInput_Click(object sender, EventArgs e)
        {
            int numberToBeAdded;
            try
            {
                if ((txtBoxInput.Text.Equals("") || txtBoxInput.Text == String.Empty))
                {
                    MessageBox.Show("Please enter a valid integer.\nAnd donot keep the input empty.", "Warning");
                }
                numberToBeAdded = Convert.ToInt32(txtBoxInput.Text);
                if (numberToBeAdded > 100 || numberToBeAdded < 0)
                {
                    MessageBox.Show("Please enter a value in between 0 and 100(both inclusive).","Invalid input!");
                }
                else {
                    lstBoxGrades.Items.Add(numberToBeAdded);
                }
            }
            catch(Exception exception)
            {
                MessageBox.Show("The input must be an integer.\n"+exception.Message,"Wrong input!");
            }
            txtBoxInput.Clear();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lstBoxGrades.Items.Clear();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            try
            {
                    lstBoxGrades.Items.Remove(lstBoxGrades.SelectedItem);
            }
            catch (Exception exception)
            {
                MessageBox.Show("Multiple selected items will be removed in sequence.",
                    "Invalid operation");
            }
        }

        private void btnSum_Click(object sender, EventArgs e)
        {
            var sumOfElements = 0;
            foreach (var listItem in lstBoxGrades.Items)
            {
                try
                {
                    sumOfElements += Convert.ToInt32(listItem);
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message,"Int conversion exception");
                }
            }
            MessageBox.Show(Convert.ToString(sumOfElements),"Sum of grades");
        }

        private void btnAverage_Click(object sender, EventArgs e)
        {
            var sumOfElements = 0;
            var numberOfElements = lstBoxGrades.Items.Count;
            foreach (var listItem in lstBoxGrades.Items)
            {
                try
                {
                    sumOfElements += Convert.ToInt32(listItem);
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message, "Int conversion exception");
                }
            }
            var average = sumOfElements / numberOfElements;
            MessageBox.Show(Convert.ToString(average), "Average of grades");
        }
    }
}
