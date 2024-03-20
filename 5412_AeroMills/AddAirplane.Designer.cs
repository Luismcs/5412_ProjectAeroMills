namespace WindowsFormsApp1
{
    partial class AddAirplanePanel
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.AddSmallPlaneLabel1 = new System.Windows.Forms.Label();
            this.Aviao_model = new System.Windows.Forms.TextBox();
            this.Aviao_capacity = new System.Windows.Forms.TextBox();
            this.Aviao_activity = new System.Windows.Forms.TextBox();
            this.Aviao_engineQuantity = new System.Windows.Forms.TextBox();
            this.Aviao_autonomy = new System.Windows.Forms.TextBox();
            this.Aviao_manufacturingYear = new System.Windows.Forms.TextBox();
            this.Aviao_brand = new System.Windows.Forms.TextBox();
            this.Aviao_maintenanceDate = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.AddAirplanePanelTrue = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dateLabel = new System.Windows.Forms.Label();
            this.timeLabel = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.AddAirplanePanelTrue.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(45)))), ((int)(((byte)(87)))));
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 698);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1307, 42);
            this.panel1.TabIndex = 24;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.button1.Dock = System.Windows.Forms.DockStyle.Right;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(45)))), ((int)(((byte)(87)))));
            this.button1.FlatAppearance.BorderSize = 2;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(103)))), ((int)(((byte)(54)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(45)))), ((int)(((byte)(87)))));
            this.button1.Location = new System.Drawing.Point(1163, 0);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(144, 42);
            this.button1.TabIndex = 24;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AddSmallPlaneLabel1
            // 
            this.AddSmallPlaneLabel1.AutoSize = true;
            this.AddSmallPlaneLabel1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddSmallPlaneLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(45)))), ((int)(((byte)(87)))));
            this.AddSmallPlaneLabel1.Location = new System.Drawing.Point(528, 132);
            this.AddSmallPlaneLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.AddSmallPlaneLabel1.Name = "AddSmallPlaneLabel1";
            this.AddSmallPlaneLabel1.Size = new System.Drawing.Size(295, 38);
            this.AddSmallPlaneLabel1.TabIndex = 4;
            this.AddSmallPlaneLabel1.Text = "Airplane Information";
            // 
            // Aviao_model
            // 
            this.Aviao_model.Location = new System.Drawing.Point(229, 164);
            this.Aviao_model.Margin = new System.Windows.Forms.Padding(4);
            this.Aviao_model.Name = "Aviao_model";
            this.Aviao_model.Size = new System.Drawing.Size(159, 22);
            this.Aviao_model.TabIndex = 6;
            this.Aviao_model.TextChanged += new System.EventHandler(this.Aviao_model_TextChanged);
            // 
            // Aviao_capacity
            // 
            this.Aviao_capacity.Location = new System.Drawing.Point(229, 223);
            this.Aviao_capacity.Margin = new System.Windows.Forms.Padding(4);
            this.Aviao_capacity.Name = "Aviao_capacity";
            this.Aviao_capacity.Size = new System.Drawing.Size(159, 22);
            this.Aviao_capacity.TabIndex = 7;
            this.Aviao_capacity.TextChanged += new System.EventHandler(this.Aviao_capacity_TextChanged);
            // 
            // Aviao_activity
            // 
            this.Aviao_activity.Location = new System.Drawing.Point(701, 160);
            this.Aviao_activity.Margin = new System.Windows.Forms.Padding(4);
            this.Aviao_activity.Name = "Aviao_activity";
            this.Aviao_activity.Size = new System.Drawing.Size(159, 22);
            this.Aviao_activity.TabIndex = 9;
            this.Aviao_activity.TextChanged += new System.EventHandler(this.Aviao_activity_TextChanged);
            // 
            // Aviao_engineQuantity
            // 
            this.Aviao_engineQuantity.Location = new System.Drawing.Point(701, 219);
            this.Aviao_engineQuantity.Margin = new System.Windows.Forms.Padding(4);
            this.Aviao_engineQuantity.Name = "Aviao_engineQuantity";
            this.Aviao_engineQuantity.Size = new System.Drawing.Size(159, 22);
            this.Aviao_engineQuantity.TabIndex = 10;
            this.Aviao_engineQuantity.TextChanged += new System.EventHandler(this.Aviao_engineQuantity_TextChanged);
            // 
            // Aviao_autonomy
            // 
            this.Aviao_autonomy.Location = new System.Drawing.Point(229, 284);
            this.Aviao_autonomy.Margin = new System.Windows.Forms.Padding(4);
            this.Aviao_autonomy.Name = "Aviao_autonomy";
            this.Aviao_autonomy.Size = new System.Drawing.Size(159, 22);
            this.Aviao_autonomy.TabIndex = 11;
            this.Aviao_autonomy.TextChanged += new System.EventHandler(this.Aviao_autonomy_TextChanged);
            // 
            // Aviao_manufacturingYear
            // 
            this.Aviao_manufacturingYear.Location = new System.Drawing.Point(701, 342);
            this.Aviao_manufacturingYear.Margin = new System.Windows.Forms.Padding(4);
            this.Aviao_manufacturingYear.Name = "Aviao_manufacturingYear";
            this.Aviao_manufacturingYear.Size = new System.Drawing.Size(159, 22);
            this.Aviao_manufacturingYear.TabIndex = 12;
            this.Aviao_manufacturingYear.TextChanged += new System.EventHandler(this.Aviao_manufacturingYear_TextChanged);
            // 
            // Aviao_brand
            // 
            this.Aviao_brand.Location = new System.Drawing.Point(701, 280);
            this.Aviao_brand.Margin = new System.Windows.Forms.Padding(4);
            this.Aviao_brand.Name = "Aviao_brand";
            this.Aviao_brand.Size = new System.Drawing.Size(159, 22);
            this.Aviao_brand.TabIndex = 13;
            this.Aviao_brand.TextChanged += new System.EventHandler(this.Aviao_brand_TextChanged);
            // 
            // Aviao_maintenanceDate
            // 
            this.Aviao_maintenanceDate.Location = new System.Drawing.Point(229, 342);
            this.Aviao_maintenanceDate.Margin = new System.Windows.Forms.Padding(4);
            this.Aviao_maintenanceDate.Name = "Aviao_maintenanceDate";
            this.Aviao_maintenanceDate.Size = new System.Drawing.Size(159, 22);
            this.Aviao_maintenanceDate.TabIndex = 14;
            this.Aviao_maintenanceDate.TextChanged += new System.EventHandler(this.Aviao_maintenanceDate_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(45)))), ((int)(((byte)(87)))));
            this.label2.Location = new System.Drawing.Point(168, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 20);
            this.label2.TabIndex = 16;
            this.label2.Text = "Model";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(45)))), ((int)(((byte)(87)))));
            this.label3.Location = new System.Drawing.Point(156, 224);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 20);
            this.label3.TabIndex = 17;
            this.label3.Text = "Capacity";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(45)))), ((int)(((byte)(87)))));
            this.label4.Location = new System.Drawing.Point(141, 287);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 20);
            this.label4.TabIndex = 18;
            this.label4.Text = "Autonomy";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(45)))), ((int)(((byte)(87)))));
            this.label5.Location = new System.Drawing.Point(89, 346);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 20);
            this.label5.TabIndex = 19;
            this.label5.Text = "Maintenance Date";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(45)))), ((int)(((byte)(87)))));
            this.label6.Location = new System.Drawing.Point(631, 161);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 20);
            this.label6.TabIndex = 20;
            this.label6.Text = "Activity";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(45)))), ((int)(((byte)(87)))));
            this.label7.Location = new System.Drawing.Point(572, 220);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(119, 20);
            this.label7.TabIndex = 21;
            this.label7.Text = "Engine Quantity";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(45)))), ((int)(((byte)(87)))));
            this.label8.Location = new System.Drawing.Point(640, 283);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 20);
            this.label8.TabIndex = 22;
            this.label8.Text = "Brand";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(45)))), ((int)(((byte)(87)))));
            this.label9.Location = new System.Drawing.Point(545, 344);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(145, 20);
            this.label9.TabIndex = 23;
            this.label9.Text = "Manufacturing Year";
            // 
            // AddAirplanePanelTrue
            // 
            this.AddAirplanePanelTrue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.AddAirplanePanelTrue.Controls.Add(this.AddSmallPlaneLabel1);
            this.AddAirplanePanelTrue.Controls.Add(this.panel3);
            this.AddAirplanePanelTrue.Controls.Add(this.panel2);
            this.AddAirplanePanelTrue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AddAirplanePanelTrue.Location = new System.Drawing.Point(0, 0);
            this.AddAirplanePanelTrue.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AddAirplanePanelTrue.Name = "AddAirplanePanelTrue";
            this.AddAirplanePanelTrue.Size = new System.Drawing.Size(1307, 740);
            this.AddAirplanePanelTrue.TabIndex = 25;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.Aviao_maintenanceDate);
            this.panel3.Controls.Add(this.Aviao_brand);
            this.panel3.Controls.Add(this.Aviao_manufacturingYear);
            this.panel3.Controls.Add(this.Aviao_autonomy);
            this.panel3.Controls.Add(this.Aviao_engineQuantity);
            this.panel3.Controls.Add(this.Aviao_activity);
            this.panel3.Controls.Add(this.Aviao_capacity);
            this.panel3.Controls.Add(this.Aviao_model);
            this.panel3.Location = new System.Drawing.Point(190, 152);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(964, 440);
            this.panel3.TabIndex = 25;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(45)))), ((int)(((byte)(87)))));
            this.panel2.Controls.Add(this.dateLabel);
            this.panel2.Controls.Add(this.timeLabel);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1307, 34);
            this.panel2.TabIndex = 24;
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.dateLabel.Location = new System.Drawing.Point(1073, 10);
            this.dateLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(44, 16);
            this.dateLabel.TabIndex = 26;
            this.dateLabel.Text = "label4";
            this.dateLabel.Click += new System.EventHandler(this.dateLabel_Click);
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.timeLabel.Location = new System.Drawing.Point(908, 10);
            this.timeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(44, 16);
            this.timeLabel.TabIndex = 26;
            this.timeLabel.Text = "label3";
            this.timeLabel.Click += new System.EventHandler(this.timeLabel_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.label10.Location = new System.Drawing.Point(15, 5);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(81, 23);
            this.label10.TabIndex = 26;
            this.label10.Text = "AeroMils";
            // 
            // button2
            // 
            this.button2.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.Close;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button2.Dock = System.Windows.Forms.DockStyle.Right;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(1270, 0);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(37, 34);
            this.button2.TabIndex = 25;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // AddAirplanePanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1307, 740);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.AddAirplanePanelTrue);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AddAirplanePanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NewAirplane";
            this.Load += new System.EventHandler(this.AddAirplane_Load);
            this.panel1.ResumeLayout(false);
            this.AddAirplanePanelTrue.ResumeLayout(false);
            this.AddAirplanePanelTrue.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label AddSmallPlaneLabel1;
        private System.Windows.Forms.TextBox Aviao_model;
        private System.Windows.Forms.TextBox Aviao_capacity;
        private System.Windows.Forms.TextBox Aviao_activity;
        private System.Windows.Forms.TextBox Aviao_engineQuantity;
        private System.Windows.Forms.TextBox Aviao_autonomy;
        private System.Windows.Forms.TextBox Aviao_manufacturingYear;
        private System.Windows.Forms.TextBox Aviao_brand;
        private System.Windows.Forms.TextBox Aviao_maintenanceDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel AddAirplanePanelTrue;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.Timer timer1;
    }
}