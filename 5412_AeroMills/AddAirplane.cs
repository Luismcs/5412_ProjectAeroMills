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
    public partial class AddAirplanePanel : Form
    {
        Empresa companyPlane = new Empresa();
        string dateUpdatedAdd;
        public AddAirplanePanel(Empresa company, string dateUpdated)
        {
            InitializeComponent();
            companyPlane= company;
            timer1.Start();
            dateUpdatedAdd= dateUpdated;
            dateLabel.Text = dateUpdated;
        }

        private void OpenFormInPanel(Form form)
        {
            // Clear existing controls from the panel
            AddAirplanePanelTrue.Controls.Clear();

            // Set the form to be a child of the panel
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;

            // Add the form to the panel and display it
            AddAirplanePanelTrue.Controls.Add(form);
            form.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
    
        }

        private void AddAirplane_Load(object sender, EventArgs e)
        {

        }

     
        private void AddAirplaneReturnButton_Click(object sender, EventArgs e)
        {
            //open AddNew form in the same panel and close this form
            AddNew addnew = new AddNew(companyPlane, dateUpdatedAdd);
            this.Hide();
            OpenFormInPanel(addnew);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!VerifyEmptyCampsAviao()) //verifies if there are empty fields
            {
                MessageBox.Show("There are empty fields.\nPlease fill all the required fields");
                return;
            }
            else if (companyPlane.ContainsLetters(Aviao_capacity.ToString())
                ||companyPlane.ContainsLetters(Aviao_engineQuantity.ToString()))
            {
                MessageBox.Show("Make sure Capacity and Engine Quantity only contain numbers");
            }
            else
            {

                Aviao aviao = new Aviao();
                aviao.Id = companyPlane.NumberOfPlanes();
                aviao.Model = Aviao_model.Text;
                aviao.Capacity = Convert.ToInt32(Aviao_capacity.Text);
                aviao.Autonomy = Convert.ToInt32(Aviao_autonomy.Text);
                aviao.MaintenanceDate = Aviao_maintenanceDate.Text;
                aviao.Activity = Aviao_activity.Text;
                aviao.EngineQuantity = Convert.ToInt32(Aviao_engineQuantity.Text);
                aviao.Brand = Aviao_brand.Text;
                aviao.ManufacturingYear = Convert.ToInt32(Aviao_manufacturingYear.Text);
                companyPlane.AddAviao(aviao);
                companyPlane.UpdateAviaoFile();
                MessageBox.Show("Plane Added!");

            }
        }

        private bool VerifyEmptyCampsAviao() //verifies if there are empty fields
        {
            if (string.IsNullOrEmpty(Aviao_model.Text) || 
                string.IsNullOrEmpty(Aviao_capacity.Text) || 
                string.IsNullOrEmpty(Aviao_autonomy.Text) || 
                string.IsNullOrEmpty(Aviao_maintenanceDate.Text) || 
                string.IsNullOrEmpty(Aviao_activity.Text) || 
                string.IsNullOrEmpty(Aviao_engineQuantity.Text) || 
                string.IsNullOrEmpty(Aviao_brand.Text) || 
                string.IsNullOrEmpty(Aviao_manufacturingYear.Text))
            {
                return false; //if there are empty fields, returns false
            }
            else
            {
                return true; //if there are no empty fields, returns true
            }

        }

        private void Aviao_model_TextChanged(object sender, EventArgs e)
        {

        }

        private void Aviao_capacity_TextChanged(object sender, EventArgs e)
        {

        }

        private void Aviao_autonomy_TextChanged(object sender, EventArgs e)
        {

        }

        private void Aviao_maintenanceDate_TextChanged(object sender, EventArgs e)
        {

        }

        private void Aviao_manufacturingYear_TextChanged(object sender, EventArgs e)
        {

        }

        private void Aviao_brand_TextChanged(object sender, EventArgs e)
        {

        }

        private void Aviao_engineQuantity_TextChanged(object sender, EventArgs e)
        {

        }

        private void Aviao_activity_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddAirplaneButton_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void timeLabel_Click(object sender, EventArgs e)
        {
        }

        private void dateLabel_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timeLabel.Text = DateTime.Now.ToString("HH:mm:ss");
        }
    }
}
