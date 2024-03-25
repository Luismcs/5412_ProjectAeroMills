using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1
{
    public partial class Availability : Form
    {
        Empresa companyA = new Empresa();
        string dateUpdated;
        string accountPermission;
        public Availability(Empresa company, string updatedDate,string permission)
        {
            InitializeComponent();
            dateUpdated = updatedDate;
            companyA=company;
            accountPermission = permission;

        }

        private void button1_Click(object sender, EventArgs e) //lists the list in the dataGrid depending on the option selected
        {
            if (AvailabilityMenu.Text == "Planes") //lists the planes list
            {
                companyA.ListsAvailablePlanes(dataGridView1);
            } 
            if (AvailabilityMenu.Text == "Comercials") //lists the comercials list
            {
                companyA.ListsAvailableComercials(dataGridView1);
            }
            if (AvailabilityMenu.Text == "Cargos") //lists the cargos list
            {
                companyA.ListsAvailableCargos(dataGridView1);
            }
            if (AvailabilityMenu.Text == "Jets") //lists the Jets list
            {
                companyA.ListsAvailableJets(dataGridView1);
            }
            if (AvailabilityMenu.Text == "SmallPlanes") //lists the Small planes list
            {
                companyA.ListsAvailableSmallPlanes(dataGridView1);
            }
        }

        private void Availability_Load(object sender, EventArgs e)
        {
            companyA.ListsAvailablePlanes(dataGridView1);

            if (accountPermission == "user")
            {
                button2.Visible = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void AvailabilityMenu_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void AvailableAircraftsLabel_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            RemovePlane removePlaneForm = new RemovePlane(companyA, dateUpdated);
            removePlaneForm.Show();
            this.Hide();
        }
    }
}
