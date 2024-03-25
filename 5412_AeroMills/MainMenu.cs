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
    public partial class MainMenu : Form
    {
        Empresa company = new Empresa();
        string accountPermission;
        string dateUpdated;

        public MainMenu(string permission)
        {
            InitializeComponent();
            company.ReadAllFiles();
            timer1.Start();
            dateLabel.Text = DateTime.Now.ToString("dd/MM/yyyy");
            dateUpdated = dateLabel.Text;
            accountPermission = permission;
            // Load Form2 into the panel
            FilterForm addnew = new FilterForm(company);
            OpenFormInPanel(addnew);
        }

        private void OpenFormInPanel(Form form)
        {
            // Clear existing controls from the panel
            MainPanel.Controls.Clear();

            // Set the form to be a child of the panel
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;

            // Add the form to the panel and display it
            MainPanel.Controls.Add(form);
            form.Show();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            if(accountPermission == "user")
            {
                InsertNewPlane.Visible = false;
                ChangeState.Visible = false;
                UpdateTime.Visible = false;
                calculateShipCost.Visible = false;
                UnderMaitenance.Visible = false;
                button1.Location = new Point(-3, 193);
                booking.Location = new Point(-2, 228);
                Filter.Location = new Point(-2, 264);
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MainPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void InsertNewPlane_Click(object sender, EventArgs e)
        {
            // Load Form2 into the panel
            AddNew addnew = new AddNew(company, dateUpdated);
            OpenFormInPanel(addnew);
        }

        private void calculateShipCost_Click(object sender, EventArgs e)
        {
            // Load Form2 into the panel
            CostOfFreight2Button addnew = new CostOfFreight2Button(company);
            OpenFormInPanel(addnew);
        }

        private void UpdateTime_Click(object sender, EventArgs e)
        {
            dateLabel.Text = company.AdvanceOneDay(dateLabel.Text);

            dateUpdated = dateLabel.Text;

            company.Verify(dateLabel.Text);
            company.VerifyAvailable(dateLabel.Text);
            company.VerifyManutencao(dateLabel.Text);
            company.VerifyAvailableFromManutencao(dateLabel.Text);

            string available, availablemain;
            available = company.ShowsAvailableFromF(); //available from freight
            availablemain = company.ShowsAvailableFromM(); //available from maintenance

            Not(available, availablemain);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timeLabel.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void showNotFreight(string number)  //shows the freight notification
        {
            notifyIcon1.Icon = new System.Drawing.Icon("plane-icon_34103.ico");
            notifyIcon1.Text = "Teste";
            notifyIcon1.Visible = true;
            notifyIcon1.BalloonTipTitle = "Available From Freight";
            notifyIcon1.BalloonTipText = number.ToString() + " is now Available";
            notifyIcon1.ShowBalloonTip(100);
        }

        private void showNotMain(string number)  //shows the maintenance notification
        {
            notifyIcon1.Icon = new System.Drawing.Icon("plane-icon_34103.ico");
            notifyIcon1.Text = "Teste";
            notifyIcon1.Visible = true;
            notifyIcon1.BalloonTipTitle = "Available From Maintenance";
            notifyIcon1.BalloonTipText = number.ToString() + " is now Available";
            notifyIcon1.ShowBalloonTip(100);
        }

        private void Not(string available, string availableFromForm)
        {
            //splits the available planes from fright in ";"

            string[] availableParts = available.Split(';');

            // For each new available plane from Booking shows the notification

            foreach (string part in availableParts)
            {
                // Verifies if it's empty
                if (!string.IsNullOrEmpty(part))
                {
                    showNotFreight(part);
                }
            }

            //splits the available planes from maintenance in ";"

            string[] availableFromFormParts = availableFromForm.Split(';');

            // For each new available plane from Maintenance shows the notification

            foreach (string part in availableFromFormParts)
            {
                // Verifies if it's empty
                if (!string.IsNullOrEmpty(part))
                {
                    showNotMain(part);
                }
            }

        }

        private void UnderMaitenance_Click(object sender, EventArgs e)
        {
            // Load Form2 into the panel
            Maintenancecs addnew = new Maintenancecs(company, dateUpdated);
            OpenFormInPanel(addnew);
        }

        private void ChangeState_Click(object sender, EventArgs e)
        {
            // Load Form2 into the panel
            ChangeGeralState addnew = new ChangeGeralState(company);
            OpenFormInPanel(addnew);
        }

        private void availableAirplanes_Click(object sender, EventArgs e)
        {
            // Load Form2 into the panel
            Availability addnew = new Availability(company, dateUpdated,accountPermission);
            OpenFormInPanel(addnew);
        }

        private void Filter_Click(object sender, EventArgs e)
        {
            // Load Form2 into the panel
            FilterForm addnew = new FilterForm(company);
            OpenFormInPanel(addnew);
        }

        private void booking_Click(object sender, EventArgs e)
        {
            // Load Form2 into the panel
            Bookings2 addnew = new Bookings2(company, dateUpdated);
            OpenFormInPanel(addnew);
        }

        private void dateLabel_Click(object sender, EventArgs e)
        {
            
        }

        private void timeLabel_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
           Login l1 = new Login();
            l1.Show();
            this.Hide();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ShippingCostDates sc = new ShippingCostDates(company, dateUpdated);
            OpenFormInPanel(sc);
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }
    }
}
