using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class CostOfFreight2Button : Form
    {
        List<string> ids = new List<string>();
        List<string> dailyvalues = new List<string>();
        List<string> initialDate = new List<string>();
        List<string> finalDate = new List<string>();

        Empresa companyC = new Empresa();

        public CostOfFreight2Button(Empresa company)
        {
            InitializeComponent();
            companyC= company;
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string filePath = @"freight.csv";

            // Clear lists before reading new data
            ids.Clear();
            dailyvalues.Clear();
            initialDate.Clear();
            finalDate.Clear();

            using (StreamReader file = new StreamReader(filePath))
            {
                string line;
                while ((line = file.ReadLine()) != null)
                {
                    string[] fields = line.Split(';');

                    if (!string.IsNullOrWhiteSpace(fields[0]))
                    {
                        ids.Add(fields[0]);
                        dailyvalues.Add(fields[1]);
                        initialDate.Add(fields[2]);
                        finalDate.Add(fields[3]);
                    }
                }
            }

            // Get the selected dates from DateTimePickers
            DateTime dt1 = dateTimePicker1.Value.Date;
            DateTime dt2 = dateTimePicker2.Value.Date;

            VerifyDates(dt1, dt2);

            string profit = companyC.profit(dt1, dt2);

            label3.Text = profit;
        }

        private void VerifyDates(DateTime dt1, DateTime dt2)
        {
            if (dt1 > dt2)
            {
                MessageBox.Show("Invalid date range");
                return;
            }
        }

        private void CostOfFreight2Button_Load(object sender, EventArgs e)
        {

        }
    }
}
