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
    public partial class AddCargo : Form
    {
        Empresa companyCargo = new Empresa();
        string dateUpdatedCargo;

        public AddCargo(Empresa company, string dateUpdated)
        {
            InitializeComponent();
            dateUpdatedCargo = dateUpdated;
            companyCargo=company;
            timer1.Start();
            dateLabel.Text = dateUpdatedCargo;

        }
        private bool VerifyEmptyCampsMercadorias() //verifies if there are empty fields returns false
        {
            if (string.IsNullOrEmpty(Mercadorias_model.Text) || 
                string.IsNullOrEmpty(Mercadorias_capacity.Text) || 
                string.IsNullOrEmpty(Mercadorias_autonomy.Text) || 
                string.IsNullOrEmpty(Mercadorias_maintenanceDate.Text) || 
                string.IsNullOrEmpty(Mercadorias_activity.Text) || 
                string.IsNullOrEmpty(Mercadorias_engineQuantity.Text) || 
                string.IsNullOrEmpty(Mercadorias_brand.Text) || 
                string.IsNullOrEmpty(Mercadorias_manufacturingYear.Text) || 
                string.IsNullOrEmpty(Mercadorias_cargoCapacity.Text) || 
                string.IsNullOrEmpty(Mercadorias_freightValue.Text))
            {
                return false;
            }
            else //if there are no empty fields, returns true
            {
                return true;
            }
        }
        private void AddCargoButton_Click(object sender, EventArgs e)
        {
            if (!VerifyEmptyCampsMercadorias()) //verifies if there are empty fields
            {
                MessageBox.Show("There are empty fields.\nPlease fill all the required fields");
                return;
            }
            else if (companyCargo.ContainsLetters(Mercadorias_capacity.Text)
                || companyCargo.ContainsLetters(Mercadorias_engineQuantity.Text)
                || companyCargo.ContainsLetters(Mercadorias_freightValue.Text))
            {
                MessageBox.Show("Make sure Capacity, Engine Quantity and Freight Value only contain numbers");
            }
            else
            {
                AeronaveMercadorias aeronaveMercadorias = new AeronaveMercadorias();
                aeronaveMercadorias.Id = companyCargo.NumberOfPlanes();
                aeronaveMercadorias.Model = Mercadorias_model.Text;
                aeronaveMercadorias.Capacity = Convert.ToInt32(Mercadorias_capacity.Text);
                aeronaveMercadorias.Autonomy = Convert.ToInt32(Mercadorias_autonomy.Text);
                aeronaveMercadorias.MaintenanceDate = Mercadorias_maintenanceDate.Text;
                aeronaveMercadorias.Activity = Mercadorias_activity.Text;
                aeronaveMercadorias.EngineQuantity = Convert.ToInt32(Mercadorias_engineQuantity.Text);
                aeronaveMercadorias.Brand = Mercadorias_brand.Text;
                aeronaveMercadorias.ManufacturingYear = Convert.ToInt32(Mercadorias_manufacturingYear.Text);
                aeronaveMercadorias.CargoCapacity = Convert.ToInt32(Mercadorias_cargoCapacity.Text);
                aeronaveMercadorias.FreightValue = Convert.ToDouble(Mercadorias_freightValue.Text);

                companyCargo.AddAeronaveMercadorias(aeronaveMercadorias);
                companyCargo.UpdateAeronaveMercadoriasFile();
                MessageBox.Show("Cargo Plane Added!");
            }
        }

        private void Mercadorias_model_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddSmallPlaneLabel1_Click(object sender, EventArgs e)
        {

        }

        private void Mercadorias_capacity_TextChanged(object sender, EventArgs e)
        {

        }

        private void Mercadorias_autonomy_TextChanged(object sender, EventArgs e)
        {

        }

        private void Mercadorias_engineQuantity_TextChanged(object sender, EventArgs e)
        {

        }

        private void Mercadorias_maintenanceDate_TextChanged(object sender, EventArgs e)
        {

        }

        private void Mercadorias_activity_TextChanged(object sender, EventArgs e)
        {

        }

        private void Mercadorias_cargoCapacity_TextChanged(object sender, EventArgs e)
        {

        }

        private void Mercadorias_manufacturingYear_TextChanged(object sender, EventArgs e)
        {

        }

        private void Mercadorias_brand_TextChanged(object sender, EventArgs e)
        {

        }

        private void Mercadorias_freightValue_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
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
    }
}
