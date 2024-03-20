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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1
{
    public partial class CostOfFreight1 : Form
    {
        Empresa companyCalculo = new Empresa();
        int days;
        string dateUpdatedC;
        public CostOfFreight1(int daysNumber,Empresa company, string dateUpdated)
        {
            InitializeComponent();
            companyCalculo = company;
            dateUpdatedC = dateUpdated;
            days = daysNumber;
            timer1.Start();
            dateLabel.Text = dateUpdated;
        }

        private void button1_Click(object sender, EventArgs e) //changes the dataGrid depenting on the selected option
        {
            if (comboBox1.Text == "Cargos") //lists the cargos list
            {
                companyCalculo.ListsCargos(dataGridView1);
            } 
            if (comboBox1.Text == "Jets") //lists the jets list
            {
                companyCalculo.ListsJets(dataGridView1);
            }
            if (comboBox1.Text == "SmallPlanes") //lists the small Planes list
            {
                companyCalculo.ListsSmallPlanes(dataGridView1);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(textBox1.Text)) //verifies if the id field is empty
            {
                MessageBox.Show("Please fill the ID field");
                return;
            }
            else if (companyCalculo.ContainsLetters(textBox1.Text))
            {
                MessageBox.Show("Please input only numbers");
                return;
            }
            else
            {
                int id = int.Parse(textBox1.Text);

                string text = companyCalculo.PlaneType(id);

                label2.Text = text;

                if (companyCalculo.PlaneType(id) == "Not Found") //verifies if the plane exists
                {
                    MessageBox.Show("Plane not found");
                }
                else
                {
                    if (companyCalculo.PlaneType(id) == "Cargo") //shows the price
                    {
                        label2.Text = "Cargo Found\nPrice for " + days + " days: " + companyCalculo.Search(id, days);
                    }

                    else if (companyCalculo.PlaneType(id) == "Jet") //shows the price
                    {
                        label2.Text = "Jet Found\nPrice for " + days + " days: " + companyCalculo.Search(id, days);
                    }

                    else if (companyCalculo.PlaneType(id) == "Small Plane") //shows the price
                    {
                        label2.Text = "Small Plane Found\nPrice for " + days + " days: " + companyCalculo.Search(id, days);
                    }

                }
            }

            
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
    }
}
