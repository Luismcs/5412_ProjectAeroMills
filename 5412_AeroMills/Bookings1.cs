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
    public partial class Bookings1 : Form
    {
        public string date1, date2;
        DateTime datetime1, datetime2;
        Empresa companyB1 = new Empresa();
        public Bookings1(string dateS, string dateE, DateTime dt1, DateTime dt2,Empresa company, string dateUpdated)
        {
            InitializeComponent();
            companyB1= company;
            date1 = dateS;
            date2 = dateE;
            datetime1 = dt1;
            datetime2 = dt2;
            label3.Text = date1;
            label4.Text = date2;
            timer1.Start();
            dateLabel.Text = dateUpdated;
        }
        

        private void button2_Click(object sender, EventArgs e)
        {
            SpBooking();

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Bookings1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void timeLabel_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timeLabel.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Planes") //lists the planes list
            {
                companyB1.ListsPlanes(dataGridBooking2);
            }
            if (comboBox1.Text == "Comercials") //lists the comercials list
            {
                companyB1.ListsComercials(dataGridBooking2);
            }
            if (comboBox1.Text == "Cargos") //lists the cargos list
            {
                companyB1.ListsCargos(dataGridBooking2);
            }
            if (comboBox1.Text == "Jets") //lists the jets list
            {
                companyB1.ListsJets(dataGridBooking2);
            }
            if (comboBox1.Text == "SmallPlanes") //lists the small planes list
            {
                companyB1.ListsSmallPlanes(dataGridBooking2);
            }
        }

        private void SpBooking()
        {
            if (string.IsNullOrEmpty(textBox1.Text)) //verifies if the id field is empty
            {
                MessageBox.Show("Please fill the ID field");
                return;
            }
            
            else if (companyB1.ContainsLetters(textBox1.Text))
            {
                MessageBox.Show("Please input only numbers");
                return;
            }

            int id = 0;
            id = int.Parse(textBox1.Text);

            //Verifies Maintenance Avaiability

            if (companyB1.VerifyAvailability(id, date1, date2)) 
            {
                MessageBox.Show("There's a Maintenance booked for this plane in this date");
                return;
            }
            else if (companyB1.VerifyAvailabilityBooking(id, date1, date2))
            {

                MessageBox.Show("This plane is already booked in this date");
                return;

            } 
            else
            {
                string search = companyB1.SearchId(id, date1, date2, datetime1, datetime2); //Registers the Maintenance

                if (search == "Not Found") //Planes was not Found
                {
                    MessageBox.Show("Id not found");
                }
                else
                {
                    MessageBox.Show("Booking made with success");
                }
            }

        }
    }
}
