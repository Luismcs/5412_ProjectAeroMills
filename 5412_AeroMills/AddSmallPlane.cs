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
    public partial class AddSmallPlane : Form
    {
        Empresa companySmallPlane = new Empresa();
        string dateUpdatedSmallPlane;

        public AddSmallPlane(Empresa company, string dateUpdated)
        {
            InitializeComponent();
            companySmallPlane = company;
            dateUpdatedSmallPlane = dateUpdated;
            timer1.Start();
            dateLabel.Text = dateUpdatedSmallPlane;
        }

        private bool VerifyEmptyCampsAvioneta() //verifies if there are empty fields
        {
            if (string.IsNullOrEmpty(Avioneta_model.Text) ||
                string.IsNullOrEmpty(Avioneta_capacity.Text) ||
                string.IsNullOrEmpty(Avioneta_autonomy.Text) ||
                string.IsNullOrEmpty(Avioneta_maintenanceDate.Text) ||
                string.IsNullOrEmpty(Avioneta_activity.Text) ||
                string.IsNullOrEmpty(Avioneta_engineQuantity.Text) ||
                string.IsNullOrEmpty(Avioneta_brand.Text) ||
                string.IsNullOrEmpty(Avioneta_manufacturingYear.Text) ||
                string.IsNullOrEmpty(Avioneta_minimumTakeoffArea.Text) ||
                string.IsNullOrEmpty(Avioneta_minimumLandingArea.Text) ||
                string.IsNullOrEmpty(Avioneta_freightValue.Text))
            {
                return false; //returns false if there are empty fields
            }
            else //returns true if there are no empty fields
            {
                return true;
            }
        }

        private void AddSmallPlaneButton_Click(object sender, EventArgs e)
        {
            if (!VerifyEmptyCampsAvioneta()) //verifies if there are empty fields
            {
                MessageBox.Show("There are empty fields.\nPlease fill all the required fields");
                return;
            }
            else if (companySmallPlane.ContainsLetters(Avioneta_capacity.Text)
                || companySmallPlane.ContainsLetters(Avioneta_engineQuantity.Text)
                || companySmallPlane.ContainsLetters(Avioneta_freightValue.Text))
            {
                MessageBox.Show("Make sure Capacity, Engine Quantity and Freight value only contain numbers");
            }
            else
            {
                Avioneta avioneta = new Avioneta();
                avioneta.Id = companySmallPlane.NumberOfPlanes();
                avioneta.Model = Avioneta_model.Text;
                avioneta.Capacity = Convert.ToInt32(Avioneta_capacity.Text);
                avioneta.Autonomy = Convert.ToInt32(Avioneta_autonomy.Text);
                avioneta.MaintenanceDate = Avioneta_maintenanceDate.Text;
                avioneta.Activity = Avioneta_activity.Text;
                avioneta.EngineQuantity = Convert.ToInt32(Avioneta_engineQuantity.Text);
                avioneta.Brand = Avioneta_brand.Text;
                avioneta.ManufacturingYear = Convert.ToInt32(Avioneta_manufacturingYear.Text);
                avioneta.MinimumTakeoffArea = Convert.ToDouble(Avioneta_minimumTakeoffArea.Text);
                avioneta.MinimumLandingArea = Convert.ToDouble(Avioneta_minimumLandingArea.Text);
                avioneta.FreightValue = Convert.ToDouble(Avioneta_freightValue.Text);
                companySmallPlane.AddAvioneta(avioneta);
                companySmallPlane.UpdateAvionetaFile();
                MessageBox.Show("Small Plane Added!");
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Avioneta_brand_TextChanged(object sender, EventArgs e)
        {

        }

        private void Avioneta_manufacturingYear_TextChanged(object sender, EventArgs e)
        {

        }

        private void Avioneta_maintenanceDate_TextChanged(object sender, EventArgs e)
        {

        }

        private void Avioneta_activity_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddSmallPlane_Load(object sender, EventArgs e)
        {

        }

        private void Avioneta_minimumTakeoffArea_TextChanged(object sender, EventArgs e)
        {

        }

        private void Avioneta_engineQuantity_TextChanged(object sender, EventArgs e)
        {

        }

        private void Avioneta_autonomy_TextChanged(object sender, EventArgs e)
        {

        }

        private void Avioneta_capacity_TextChanged(object sender, EventArgs e)
        {

        }

        private void Avioneta_model_TextChanged(object sender, EventArgs e)
        {

        }

        private void Avioneta_minimumLandingArea_TextChanged(object sender, EventArgs e)
        {

        }

        private void Avioneta_freightValue_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddSmallPlaneLabel1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timeLabel.Text = DateTime.Now.ToString("HH:mm:ss");
        }
    }
}
