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
                if (txtBoxInput.Text.Equals("") || txtBoxInput.Text == String.Empty)
                {
                    MessageBox.Show("Please enter a valid integer.\nAnd donot keep the input empty.", "Warning");
                }
                numberToBeAdded = Convert.ToInt32(txtBoxInput.Text);
                lstBoxGrades.Items.Add(numberToBeAdded);
            }
            catch(Exception exception)
            {
                MessageBox.Show("The input must be an integer.\n"+exception.Message,"Wrong input!");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lstBoxGrades.Items.Clear();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            lstBoxGrades.Items.Remove(lstBoxGrades.SelectedItem);
        }
    }
}
