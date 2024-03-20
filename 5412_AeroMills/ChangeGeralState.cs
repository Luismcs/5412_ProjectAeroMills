using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1
{
    public partial class ChangeGeralState : Form
    {
        Empresa companyState = new Empresa();

        public ChangeGeralState(Empresa company)
        {
            InitializeComponent();
            companyState = company;
        }

        private void AirplaneChangeButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text)) //verifies if the id field is empty
            {
                MessageBox.Show("Please fill the ID field");
                return;
            }
            if (!VerifyEmptyFields(textBox1.Text, comboBox1.Text))
            {
                MessageBox.Show("Make sure all the fields are filled, with the correct format."); //verifies if there are empty fields
            }
            if (companyState.ContainsLetters(textBox1.Text))
            {
                MessageBox.Show("Please in input only numbers."); //verifies if there are empty fields
            }
            else
            {
                companyState.ChangeState(int.Parse(textBox1.Text), comboBox1.Text);
            }
        }

        private bool VerifyEmptyFields(string id, string state) //verifies empty fields
        {
            if (string.IsNullOrEmpty(id) || string.IsNullOrEmpty(state)) //verifies if there are empty fields
            {
                return false;
            }
            else //else returns true
            {
                return true;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
