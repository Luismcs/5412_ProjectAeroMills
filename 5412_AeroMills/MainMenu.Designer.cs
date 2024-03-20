namespace WindowsFormsApp1
{
    partial class MainMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dateLabel = new System.Windows.Forms.Label();
            this.timeLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.MainPanel = new System.Windows.Forms.Panel();
            this.Filter = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ChangeState = new System.Windows.Forms.Button();
            this.UnderMaitenance = new System.Windows.Forms.Button();
            this.InsertNewPlane = new System.Windows.Forms.Button();
            this.booking = new System.Windows.Forms.Button();
            this.availableAirplanes = new System.Windows.Forms.Button();
            this.UpdateTime = new System.Windows.Forms.Button();
            this.calculateShipCost = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.button4 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(45)))), ((int)(((byte)(87)))));
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.Filter);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.ChangeState);
            this.panel1.Controls.Add(this.UnderMaitenance);
            this.panel1.Controls.Add(this.InsertNewPlane);
            this.panel1.Controls.Add(this.booking);
            this.panel1.Controls.Add(this.availableAirplanes);
            this.panel1.Controls.Add(this.UpdateTime);
            this.panel1.Controls.Add(this.calculateShipCost);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 32);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(196, 566);
            this.panel1.TabIndex = 10;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(103)))), ((int)(((byte)(54)))));
            this.button2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(45)))), ((int)(((byte)(87)))));
            this.button2.Location = new System.Drawing.Point(0, 533);
            this.button2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(196, 33);
            this.button2.TabIndex = 0;
            this.button2.Text = "Logout";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(45)))), ((int)(((byte)(87)))));
            this.panel2.Controls.Add(this.button4);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.dateLabel);
            this.panel2.Controls.Add(this.timeLabel);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(979, 32);
            this.panel2.TabIndex = 11;
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.dateLabel.Location = new System.Drawing.Point(717, 9);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(35, 13);
            this.dateLabel.TabIndex = 4;
            this.dateLabel.Text = "label4";
            this.dateLabel.Click += new System.EventHandler(this.dateLabel_Click);
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.timeLabel.Location = new System.Drawing.Point(655, 9);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(35, 13);
            this.timeLabel.TabIndex = 3;
            this.timeLabel.Text = "label3";
            this.timeLabel.Click += new System.EventHandler(this.timeLabel_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.label2.Location = new System.Drawing.Point(193, 5);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(229, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Beyond Boundaries, Above expectations";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.label1.Location = new System.Drawing.Point(9, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "AeroMils";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // MainPanel
            // 
            this.MainPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("MainPanel.BackgroundImage")));
            this.MainPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(196, 32);
            this.MainPanel.Margin = new System.Windows.Forms.Padding(2);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(783, 566);
            this.MainPanel.TabIndex = 12;
            this.MainPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.MainPanel_Paint);
            // 
            // Filter
            // 
            this.Filter.FlatAppearance.BorderSize = 0;
            this.Filter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Filter.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Filter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.Filter.Image = global::WindowsFormsApp1.Properties.Resources._30search;
            this.Filter.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Filter.Location = new System.Drawing.Point(-2, 428);
            this.Filter.Name = "Filter";
            this.Filter.Size = new System.Drawing.Size(196, 39);
            this.Filter.TabIndex = 8;
            this.Filter.Text = "Filter";
            this.Filter.UseVisualStyleBackColor = true;
            this.Filter.Click += new System.EventHandler(this.Filter_Click);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.button1.Image = global::WindowsFormsApp1.Properties.Resources.Euro;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(-2, 332);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(196, 30);
            this.button1.TabIndex = 10;
            this.button1.Text = "Freight Rate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources.wings_of_freedom_2021_logo_73F7E468C0_seeklogo_com;
            this.pictureBox1.Location = new System.Drawing.Point(53, 24);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(82, 89);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // ChangeState
            // 
            this.ChangeState.FlatAppearance.BorderSize = 0;
            this.ChangeState.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ChangeState.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChangeState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.ChangeState.Image = global::WindowsFormsApp1.Properties.Resources.change_status;
            this.ChangeState.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ChangeState.Location = new System.Drawing.Point(-2, 228);
            this.ChangeState.Name = "ChangeState";
            this.ChangeState.Size = new System.Drawing.Size(196, 33);
            this.ChangeState.TabIndex = 2;
            this.ChangeState.Text = "Change Status";
            this.ChangeState.UseVisualStyleBackColor = true;
            this.ChangeState.Click += new System.EventHandler(this.ChangeState_Click);
            // 
            // UnderMaitenance
            // 
            this.UnderMaitenance.FlatAppearance.BorderSize = 0;
            this.UnderMaitenance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UnderMaitenance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UnderMaitenance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.UnderMaitenance.Image = global::WindowsFormsApp1.Properties.Resources.maintenance;
            this.UnderMaitenance.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.UnderMaitenance.Location = new System.Drawing.Point(-2, 298);
            this.UnderMaitenance.Name = "UnderMaitenance";
            this.UnderMaitenance.Size = new System.Drawing.Size(196, 30);
            this.UnderMaitenance.TabIndex = 3;
            this.UnderMaitenance.Text = "Maintenance";
            this.UnderMaitenance.UseVisualStyleBackColor = true;
            this.UnderMaitenance.Click += new System.EventHandler(this.UnderMaitenance_Click);
            // 
            // InsertNewPlane
            // 
            this.InsertNewPlane.FlatAppearance.BorderSize = 0;
            this.InsertNewPlane.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.InsertNewPlane.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InsertNewPlane.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.InsertNewPlane.Image = global::WindowsFormsApp1.Properties.Resources.Plussss;
            this.InsertNewPlane.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.InsertNewPlane.Location = new System.Drawing.Point(-3, 193);
            this.InsertNewPlane.Name = "InsertNewPlane";
            this.InsertNewPlane.Size = new System.Drawing.Size(196, 31);
            this.InsertNewPlane.TabIndex = 1;
            this.InsertNewPlane.Text = "Insert New Plane";
            this.InsertNewPlane.UseVisualStyleBackColor = true;
            this.InsertNewPlane.Click += new System.EventHandler(this.InsertNewPlane_Click);
            // 
            // booking
            // 
            this.booking.FlatAppearance.BorderSize = 0;
            this.booking.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.booking.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.booking.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.booking.Image = global::WindowsFormsApp1.Properties.Resources.calendar_booking;
            this.booking.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.booking.Location = new System.Drawing.Point(-1, 362);
            this.booking.Name = "booking";
            this.booking.Size = new System.Drawing.Size(196, 33);
            this.booking.TabIndex = 4;
            this.booking.Text = "Booking";
            this.booking.UseVisualStyleBackColor = true;
            this.booking.Click += new System.EventHandler(this.booking_Click);
            // 
            // availableAirplanes
            // 
            this.availableAirplanes.FlatAppearance.BorderSize = 0;
            this.availableAirplanes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.availableAirplanes.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.availableAirplanes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.availableAirplanes.Image = global::WindowsFormsApp1.Properties.Resources.status;
            this.availableAirplanes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.availableAirplanes.Location = new System.Drawing.Point(-1, 154);
            this.availableAirplanes.Name = "availableAirplanes";
            this.availableAirplanes.Size = new System.Drawing.Size(196, 33);
            this.availableAirplanes.TabIndex = 6;
            this.availableAirplanes.Text = "Available Airplanes";
            this.availableAirplanes.UseVisualStyleBackColor = true;
            this.availableAirplanes.Click += new System.EventHandler(this.availableAirplanes_Click);
            // 
            // UpdateTime
            // 
            this.UpdateTime.FlatAppearance.BorderSize = 0;
            this.UpdateTime.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UpdateTime.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.UpdateTime.Image = global::WindowsFormsApp1.Properties.Resources.time;
            this.UpdateTime.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.UpdateTime.Location = new System.Drawing.Point(-2, 264);
            this.UpdateTime.Name = "UpdateTime";
            this.UpdateTime.Size = new System.Drawing.Size(196, 30);
            this.UpdateTime.TabIndex = 7;
            this.UpdateTime.Text = "Update Time";
            this.UpdateTime.UseVisualStyleBackColor = true;
            this.UpdateTime.Click += new System.EventHandler(this.UpdateTime_Click);
            // 
            // calculateShipCost
            // 
            this.calculateShipCost.FlatAppearance.BorderSize = 0;
            this.calculateShipCost.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.calculateShipCost.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculateShipCost.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.calculateShipCost.Image = ((System.Drawing.Image)(resources.GetObject("calculateShipCost.Image")));
            this.calculateShipCost.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.calculateShipCost.Location = new System.Drawing.Point(-2, 391);
            this.calculateShipCost.Name = "calculateShipCost";
            this.calculateShipCost.Size = new System.Drawing.Size(196, 44);
            this.calculateShipCost.TabIndex = 5;
            this.calculateShipCost.Text = "Profit";
            this.calculateShipCost.UseVisualStyleBackColor = true;
            this.calculateShipCost.Click += new System.EventHandler(this.calculateShipCost_Click);
            // 
            // button3
            // 
            this.button3.BackgroundImage = global::WindowsFormsApp1.Properties.Resources._204538__1_;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button3.Dock = System.Windows.Forms.DockStyle.Right;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(873, 0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(62, 32);
            this.button3.TabIndex = 16;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox2.Image = global::WindowsFormsApp1.Properties.Resources.Close;
            this.pictureBox2.Location = new System.Drawing.Point(935, 0);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(44, 32);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // button4
            // 
            this.button4.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.windowIcon;
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button4.Dock = System.Windows.Forms.DockStyle.Right;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Location = new System.Drawing.Point(811, 0);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(62, 32);
            this.button4.TabIndex = 17;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(979, 598);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainMenu";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "s";
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button InsertNewPlane;
        private System.Windows.Forms.Button ChangeState;
        private System.Windows.Forms.Button UnderMaitenance;
        private System.Windows.Forms.Button booking;
        private System.Windows.Forms.Button calculateShipCost;
        private System.Windows.Forms.Button availableAirplanes;
        private System.Windows.Forms.Button UpdateTime;
        private System.Windows.Forms.Button Filter;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}