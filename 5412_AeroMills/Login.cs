using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Login : Form
    {
        Empresa company = new Empresa();
        public Login()
        {
            InitializeComponent();
            timer1.Start();
            dateLabel.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void AeroMils_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void LoginLoginButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text)) //verifies if the user field is empty
            {
                MessageBox.Show("Please fill the Username field");
                return;
            } 
            else if (string.IsNullOrEmpty(textBox2.Text)){ //verifies if the password field is empty
                MessageBox.Show("Please fill the Password field");
                return;
            }

            string username = textBox1.Text;
            string password = textBox2.Text;

            company.VerifySpace(username, password); //verifies if there are any spaces in the fields
            
            if (company.VerifiesLogin(username, password) == true) //verifies if the user exists
            {
                
                MainMenu f1 = new MainMenu();
                f1.Show();
                this.Hide();
                
            }         

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timeLabel.Text = DateTime.Now.ToString("HH:mm:ss");

        }

        private void dateLabel_Click(object sender, EventArgs e)
        {

        }

        private void timeLabel_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
        }
    }
}
