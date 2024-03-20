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
    public partial class Bookings2 : Form
    {
        private string date1, date2;

        Empresa companyB2 = new Empresa();
        string dateUpdatedB2;

        public Bookings2(Empresa company, string dateUpdated)
        {
            InitializeComponent();
            dateUpdatedB2 = dateUpdated;
            companyB2 = company;
        }

        private void AvailableAircraftsLabel_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            date1 = dateTimePicker1.Value.ToString("yyyy-MM-dd"); //gets the start date
            date2 = dateTimePicker2.Value.ToString("yyyy-MM-dd"); //gets the end date

            DateTime dt1 = dateTimePicker1.Value.Date;
            DateTime dt2 = dateTimePicker2.Value.Date;

            if(companyB2.VerifiesDates(dt1, dt2)) //verifies if the start date is smaller than the end date
            {
                MessageBox.Show("The start date must be smaller than the end date");
            }
            else  //if the dates are correct it opens the next form
            {
                //Opens the next Form
                Bookings1 f8 = new Bookings1(date1, date2, dt1, dt2, companyB2, dateUpdatedB2);
                f8.Show();
                this.Hide();
            }

            
        }
    }
}
