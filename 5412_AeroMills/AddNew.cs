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
    public partial class AddNew : Form
    {
        Empresa companyM = new Empresa();
        string dateUpdatedM;
        public AddNew(Empresa company, string dateUpdated)
        {
            InitializeComponent();
            companyM=company;
            dateUpdatedM = dateUpdated;
        }

        private void OpenFormInPanel(Form form)
        {
            // Clear existing controls from the panel
            AddNewPanel.Controls.Clear();

            // Set the form to be a child of the panel
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;

            // Add the form to the panel and display it
            AddNewPanel.Controls.Add(form);
            form.Show();
        }

        private void Airplane_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Airplane_Click_1(object sender, EventArgs e) //opens add airplane form
        {
            // Load Form into the panel
            AddAirplanePanel form3 = new AddAirplanePanel(companyM, dateUpdatedM);
            form3.Show();
        }

        private void Comercial_Click(object sender, EventArgs e)  //opens add comercial form
        {
            AddComercial form3 = new AddComercial(companyM, dateUpdatedM);
            form3.Show();
        }

        private void Jets_Click(object sender, EventArgs e)  //opens add jet form
        {
            AddJetButton form3 = new AddJetButton(companyM, dateUpdatedM);
            form3.Show();
        }

        private void Cargo_Click(object sender, EventArgs e)  //opens add cargo form
        {
            AddCargo form3 = new AddCargo(companyM, dateUpdatedM);
            form3.Show();
        }

        private void SmallPlane_Click(object sender, EventArgs e)  //opens add small Plane form
        {
            AddSmallPlane form3 = new AddSmallPlane(companyM, dateUpdatedM);
            form3.Show();
        }
    }
}
