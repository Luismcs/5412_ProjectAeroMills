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
    public partial class ShippingCostDates : Form
    {
        Empresa EmpresaS = new Empresa();
        string dateUpdatedS;
        public ShippingCostDates(Empresa company, string dateUpdated)
        {
            InitializeComponent();
            EmpresaS = company;
            dateUpdatedS = dateUpdated;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime dt1 = dateTimePicker1.Value.Date;
            DateTime dt2 = dateTimePicker2.Value.Date;

            if (EmpresaS.VerifiesDates(dt1, dt2))
            {
                MessageBox.Show("The initial date must be earlier than the final date");
                return;
            }

            string dias = ((dt1 - dt2).TotalDays).ToString();
            int daysNumber = int.Parse(dias);
            daysNumber = Math.Abs(daysNumber);  //calculates the number of days between the start and end date

            CostOfFreight1 form10 = new CostOfFreight1(daysNumber , EmpresaS, dateUpdatedS);
            this.Hide();
            form10.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
