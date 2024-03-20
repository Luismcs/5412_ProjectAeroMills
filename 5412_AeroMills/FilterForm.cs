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
    public partial class FilterForm : Form
    {
        Empresa companyF = new Empresa();
        public FilterForm(Empresa company)
        {
            InitializeComponent();
            companyF=company;
        }

        private void button1_Click(object sender, EventArgs e) //changes the dataGrid depenting on the selected option
        {
            if (comboBox1.Text == "Maintenances") //lists the maintenances list
            {
                companyF.ListsMaintenance(dataGridView1);
            }
            if (comboBox1.Text == "Bookings") //lists the booking list
            {
                companyF.ListsBooking(dataGridView1);
            }
            if (comboBox1.Text == "Planes") //lists the planes list
            {
                companyF.ListsPlanes(dataGridView1);
            }
            if (comboBox1.Text == "Comercials") //lists the comercials list
            {
                companyF.ListsComercials(dataGridView1);
            }
            if (comboBox1.Text == "Cargos") //lists the cargos list
            {
                companyF.ListsCargos(dataGridView1);
            }
            if (comboBox1.Text == "Jets") //lists the jets list
            {
                companyF.ListsJets(dataGridView1);
            }
            if (comboBox1.Text == "Small Planes") //lists the small Planes list
            {
                companyF.ListsSmallPlanes(dataGridView1);
            }
        }

        private void FilterForm_Load(object sender, EventArgs e)
        {
            companyF.ListsPlanes(dataGridView1);
        }
    }
}
