using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class RemovePlane : Form
    {
        Empresa companyRemove = new Empresa();
        string dateUpdate;
        public RemovePlane(Empresa company, string updatedDate)
        {
            companyRemove = company;
            dateUpdate = updatedDate;
            InitializeComponent();
        }

        private void AirplaneChangeButton_Click(object sender, EventArgs e)
        {
            int inputedId = int.Parse(textBox1.Text);

            if (companyRemove.removePlane(textBox1.Text))
            {
                MessageBox.Show("Plane Removed");
            }
            else
            {
                MessageBox.Show("Plane not found");
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
