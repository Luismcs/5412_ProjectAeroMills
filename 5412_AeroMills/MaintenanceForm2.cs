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
    public partial class MaintenanceForm2 : Form
    {
        public string date1, date2;
        DateTime datetime1, datetime2;
        Empresa company = new Empresa();
        string dateUpdatedM;
        public MaintenanceForm2(string dateS, string dateE, DateTime dt1, DateTime dt2,Empresa companyM, string dateUpdated)
        {
            InitializeComponent();
            company = companyM;
            dateUpdatedM = dateUpdated;
            date1 = dateS;
            date2 = dateE;
            datetime1 = dt1;
            datetime2 = dt2;
            MessageBox.Show(date1);
            timer1.Start();
            dateLabel.Text = dateUpdatedM;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Planes")
            {
                company.ListsPlanes(dataGridView1);
            }
            if (comboBox1.Text == "Comercials")
            {
                company.ListsComercials(dataGridView1);
            }
            if (comboBox1.Text == "Cargos")
            {
                company.ListsCargos(dataGridView1);
            }
            if (comboBox1.Text == "Jets")
            {
                company.ListsJets(dataGridView1);
            }
            if (comboBox1.Text == "SmallPlanes")
            {
                company.ListsSmallPlanes(dataGridView1);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SpBookingManutencao();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timeLabel.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            SpBookingManutencao();
        }

        private void SpBookingManutencao()
        {
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("Please fill the ID field");
                return;
            }
            else if (company.ContainsLetters(textBox1.Text))
            {
                MessageBox.Show("Please input only numbers");
                return;
            }

            int id = 0;
            id = int.Parse(textBox1.Text);


            if (company.VerifyAvailabilityMaintenance(id, date1, date2))
            {
                MessageBox.Show("This plane alredy has a maintenance for this date");
                return;
            }
            else
            {
                string search = company.SearchIdManutencao(id, date1, date2, datetime1, datetime2);

                if (search == "Not Found")
                {
                    MessageBox.Show("Id not found");
                }
                else
                {
                    MessageBox.Show("Maintenance apointed with success");
                }

            }  

        }
        
    }
}
