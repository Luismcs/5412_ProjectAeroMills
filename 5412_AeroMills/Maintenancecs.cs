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
    public partial class Maintenancecs : Form
    {
        Empresa EmpresaManutencao = new Empresa();
        string dateUpdatedM;
        public Maintenancecs(Empresa company,string dateUpdated)
        {
            InitializeComponent();
            EmpresaManutencao= company;
            dateUpdatedM = dateUpdated;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)  //Changes the plane list depending on the selected option
        {
            if (comboBox1.Text == "Planes")  //lists the planes list
            {
                EmpresaManutencao.ListsMaintenancePlanes(dataGridView1);
            }
            if (comboBox1.Text == "Comercials")  //lists the comercials list
            {
                EmpresaManutencao.ListsMaintenanceComercials(dataGridView1);
            }
            if (comboBox1.Text == "Cargos")  //lists the cargos list
            {
                EmpresaManutencao.ListsMaintenanceCargos(dataGridView1);
            }
            if (comboBox1.Text == "Jets")  //lists the jets list
            {
                EmpresaManutencao.ListsMaintenanceJets(dataGridView1);
            }
            if (comboBox1.Text == "SmallPlanes")  //lists the small plane list
            {
                EmpresaManutencao.ListsMaintenanceSmallPlanes(dataGridView1);
            }
        }

        private void Maintenancecs_Load(object sender, EventArgs e)
        {
            EmpresaManutencao.ListsMaintenancePlanes(dataGridView1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MaintenanceForm1 f1 = new MaintenanceForm1(EmpresaManutencao,dateUpdatedM);
            f1.Show();
            this.Hide();

        }
    }
}
