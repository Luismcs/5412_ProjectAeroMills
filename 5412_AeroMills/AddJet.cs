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
    public partial class AddJetButton : Form
    {
        Empresa companyJets = new Empresa();
        string dateUpdatedJets;
        public AddJetButton(Empresa company, string dateUpdated)
        {
            InitializeComponent();
            companyJets=company;
            dateUpdatedJets = dateUpdated;
            timer1.Start();
            dateLabel.Text = dateUpdatedJets;
        }

        private bool VerifyEmptyCampsParticular() //verifies if there are empty fields
        {
            if (string.IsNullOrEmpty(Particular_model.Text) ||
                string.IsNullOrEmpty(Particular_capacity.Text) ||
                string.IsNullOrEmpty(Particular_autonomy.Text) ||
                string.IsNullOrEmpty(Particular_maintenanceDate.Text) ||
                string.IsNullOrEmpty(Particular_activity.Text) ||
                string.IsNullOrEmpty(Particular_engineQuantity.Text) ||
                string.IsNullOrEmpty(Particular_brand.Text) ||
                string.IsNullOrEmpty(Particular_manufacturingYear.Text) ||
                string.IsNullOrEmpty(Particular_ownersNumber.Text) ||
                string.IsNullOrEmpty(Particular_freightValue.Text))
            {
                return false; //returns false if there are empty fields
            }
            else //returns true if there are no empty fields
            {
                return true;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (!VerifyEmptyCampsParticular()) //verifies if there are empty fields
            {
                MessageBox.Show("There are empty fields.\nPlease fill all the required fields");
                return;
            }
            else if (companyJets.ContainsLetters(Particular_capacity.Text)
                || companyJets.ContainsLetters(Particular_engineQuantity.Text)
                || companyJets.ContainsLetters(Particular_ownersNumber.Text)
                || companyJets.ContainsLetters(Particular_freightValue.Text))
            {
                MessageBox.Show("Make sure Capacity, Engine Quantity, Owners Number and Freight value only contain numbers");
            }
            else
            {
                AeronaveParticular aeronaveParticular = new AeronaveParticular();
                aeronaveParticular.Id = companyJets.NumberOfPlanes();
                aeronaveParticular.Model = Particular_model.Text;
                aeronaveParticular.Capacity = Convert.ToInt32(Particular_capacity.Text);
                aeronaveParticular.Autonomy = Convert.ToInt32(Particular_autonomy.Text);
                aeronaveParticular.MaintenanceDate = Particular_maintenanceDate.Text;
                aeronaveParticular.Activity = Particular_activity.Text;
                aeronaveParticular.EngineQuantity = Convert.ToInt32(Particular_engineQuantity.Text);
                aeronaveParticular.Brand = Particular_brand.Text;
                aeronaveParticular.ManufacturingYear = Convert.ToInt32(Particular_manufacturingYear.Text);
                aeronaveParticular.OwnersNumber = Convert.ToInt32(Particular_ownersNumber.Text);
                aeronaveParticular.FreightValue = Convert.ToDouble(Particular_freightValue.Text);

                companyJets.AddAeronaveParticular(aeronaveParticular);
                companyJets.UpdateAeronaveParticularFile();
                MessageBox.Show("Jet Plane Added!");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Particular_brand_TextChanged(object sender, EventArgs e)
        {

        }

        private void Particular_model_TextChanged(object sender, EventArgs e)
        {

        }

        private void Particular_capacity_TextChanged(object sender, EventArgs e)
        {

        }

        private void Particular_autonomy_TextChanged(object sender, EventArgs e)
        {

        }

        private void Particular_ownersNumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void Particular_manufacturingYear_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Particular_maintenanceDate_TextChanged(object sender, EventArgs e)
        {

        }

        private void Particular_activity_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timeLabel.Text = DateTime.Now.ToString("HH:mm:ss");
        }
    }
}
