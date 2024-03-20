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
    public partial class MaintenanceForm1 : Form
    {
        private string date1, date2;
        Empresa companyM = new Empresa();
        string dateUpdatedM;


        public MaintenanceForm1(Empresa company,string dateUpdated)
        {
            InitializeComponent();
            companyM = company;
            dateUpdatedM = dateUpdated;
            timer1.Start();
            dateLabel.Text = dateUpdated;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timeLabel.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void AvailableAircraftsLabel_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            date1 = dateTimePicker1.Value.ToString("yyyy-MM-dd");
            date2 = dateTimePicker2.Value.ToString("yyyy-MM-dd");

            DateTime dt1 = dateTimePicker1.Value.Date;
            DateTime dt2 = dateTimePicker2.Value.Date;

            if (companyM.VerifiesDates(dateTimePicker1.Value.Date, dateTimePicker2.Value.Date))
            {
                MessageBox.Show("The start date must be smaller than the end date");
                return;
            }
            else
            {
                MaintenanceForm2 form13 = new MaintenanceForm2(date1, date2, dt1, dt2, companyM,dateUpdatedM);
                this.Hide();
                form13.Show();
            }

            
        }
    }
}
