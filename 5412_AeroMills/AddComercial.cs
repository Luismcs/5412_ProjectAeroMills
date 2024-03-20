using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class AddComercial : Form
    {
        Empresa companyComercial = new Empresa();
        string dateUpdatedAdd;
        public AddComercial(Empresa company, string dateUpdated)
        {
            InitializeComponent();
            companyComercial=company;
            dateUpdatedAdd=dateUpdated;
            timer1.Start();
            dateLabel.Text = dateUpdatedAdd;
        }

        private void AddComercialButton_Click(object sender, EventArgs e)
        {
            if (!VerifyEmptyCampsComercial()) //verifies if there are empty fields
            {
                MessageBox.Show("There are empty fields.\nPlease fill all the required fields");
                return;
            }
            else if (companyComercial.ContainsLetters(Comercial_capacity.ToString())
                || companyComercial.ContainsLetters(Comercial_dailyFlightsNumber.ToString())
                || companyComercial.ContainsLetters(Comercial_engineQuantity.ToString()))
            {
                MessageBox.Show("Make sure Capacity, Daily Flights Number and Engine Quantity only contain numbers");
            }
            else
            {

                AeronaveComercial aeronaveComercial = new AeronaveComercial();
                aeronaveComercial.Id = companyComercial.NumberOfPlanes();
                aeronaveComercial.Model = Comercial_model.Text;
                aeronaveComercial.Capacity = Convert.ToInt32(Comercial_capacity.Text);
                aeronaveComercial.Autonomy = Convert.ToInt32(Comercial_autonomy.Text);
                aeronaveComercial.MaintenanceDate = Comercial_maintenanceDate.Text;
                aeronaveComercial.Activity = Comercial_activity.Text;
                aeronaveComercial.EngineQuantity = Convert.ToInt32(Comercial_engineQuantity.Text);
                aeronaveComercial.Brand = Comercial_brand.Text;
                aeronaveComercial.ManufacturingYear = Convert.ToInt32(Comercial_manufacturingYear.Text);
                aeronaveComercial.DailyFlightsNumber = Convert.ToInt32(Comercial_dailyFlightsNumber.Text);
                aeronaveComercial.Airline = Comercial_airline.Text;
                companyComercial.AddAeronaveComercial(aeronaveComercial);
                companyComercial.UpdateAeronaveComercialFile();
                MessageBox.Show("Comercial Plane Added!");

            }
        }

        private bool VerifyEmptyCampsComercial() //verifies if there are empty fields
        {
            if (string.IsNullOrEmpty(Comercial_model.Text) ||
                string.IsNullOrEmpty(Comercial_capacity.Text) ||
                string.IsNullOrEmpty(Comercial_autonomy.Text) ||
                string.IsNullOrEmpty(Comercial_maintenanceDate.Text) ||
                string.IsNullOrEmpty(Comercial_activity.Text) ||
                string.IsNullOrEmpty(Comercial_engineQuantity.Text) ||
                string.IsNullOrEmpty(Comercial_brand.Text) ||
                string.IsNullOrEmpty(Comercial_manufacturingYear.Text) ||
                string.IsNullOrEmpty(Comercial_dailyFlightsNumber.Text) ||
                string.IsNullOrEmpty(Comercial_airline.Text))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void AddComercial_Load(object sender, EventArgs e)
        {

        }

        private void Comercial_model_TextChanged(object sender, EventArgs e)
        {

        }

        private void Comercial_engineQuantity_TextChanged(object sender, EventArgs e)
        {

        }

        private void Comercial_maintenanceDate_TextChanged(object sender, EventArgs e)
        {

        }

        private void Comercial_capacity_TextChanged(object sender, EventArgs e)
        {

        }

        private void Comercial_autonomy_TextChanged(object sender, EventArgs e)
        {

        }

        private void Comercial_activity_TextChanged(object sender, EventArgs e)
        {

        }

        private void Comercial_brand_TextChanged(object sender, EventArgs e)
        {

        }

        private void Comercial_manufacturingYear_TextChanged(object sender, EventArgs e)
        {

        }

        private void Comercial_dailyFlightsNumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void Comercial_airline_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddSmallPlaneLabel1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timeLabel.Text = DateTime.Now.ToString("HH:mm:ss");
        }
    }
}
