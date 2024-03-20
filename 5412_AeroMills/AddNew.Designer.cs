namespace WindowsFormsApp1
{
    partial class AddNew
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddNew));
            this.AddNewPanel = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.SmallPlane = new System.Windows.Forms.Button();
            this.Comercial = new System.Windows.Forms.Button();
            this.Cargo = new System.Windows.Forms.Button();
            this.Airplane = new System.Windows.Forms.Button();
            this.Jets = new System.Windows.Forms.Button();
            this.AddNewPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // AddNewPanel
            // 
            this.AddNewPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("AddNewPanel.BackgroundImage")));
            this.AddNewPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.AddNewPanel.Controls.Add(this.panel2);
            this.AddNewPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AddNewPanel.Location = new System.Drawing.Point(0, 0);
            this.AddNewPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AddNewPanel.Name = "AddNewPanel";
            this.AddNewPanel.Size = new System.Drawing.Size(1044, 697);
            this.AddNewPanel.TabIndex = 5;
            this.AddNewPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.panel2.Controls.Add(this.SmallPlane);
            this.panel2.Controls.Add(this.Comercial);
            this.panel2.Controls.Add(this.Cargo);
            this.panel2.Controls.Add(this.Airplane);
            this.panel2.Controls.Add(this.Jets);
            this.panel2.Location = new System.Drawing.Point(361, 166);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(318, 351);
            this.panel2.TabIndex = 0;
            // 
            // SmallPlane
            // 
            this.SmallPlane.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(103)))), ((int)(((byte)(54)))));
            this.SmallPlane.FlatAppearance.BorderSize = 0;
            this.SmallPlane.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(45)))), ((int)(((byte)(87)))));
            this.SmallPlane.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SmallPlane.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SmallPlane.ForeColor = System.Drawing.Color.White;
            this.SmallPlane.Location = new System.Drawing.Point(47, 282);
            this.SmallPlane.Margin = new System.Windows.Forms.Padding(4);
            this.SmallPlane.Name = "SmallPlane";
            this.SmallPlane.Size = new System.Drawing.Size(227, 39);
            this.SmallPlane.TabIndex = 3;
            this.SmallPlane.Text = "Small Plane";
            this.SmallPlane.UseVisualStyleBackColor = false;
            this.SmallPlane.Click += new System.EventHandler(this.SmallPlane_Click);
            // 
            // Comercial
            // 
            this.Comercial.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(103)))), ((int)(((byte)(54)))));
            this.Comercial.FlatAppearance.BorderSize = 0;
            this.Comercial.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(45)))), ((int)(((byte)(87)))));
            this.Comercial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Comercial.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Comercial.ForeColor = System.Drawing.Color.White;
            this.Comercial.Location = new System.Drawing.Point(47, 88);
            this.Comercial.Margin = new System.Windows.Forms.Padding(4);
            this.Comercial.Name = "Comercial";
            this.Comercial.Size = new System.Drawing.Size(227, 33);
            this.Comercial.TabIndex = 4;
            this.Comercial.Text = "Comercial";
            this.Comercial.UseVisualStyleBackColor = false;
            this.Comercial.Click += new System.EventHandler(this.Comercial_Click);
            // 
            // Cargo
            // 
            this.Cargo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(103)))), ((int)(((byte)(54)))));
            this.Cargo.FlatAppearance.BorderSize = 0;
            this.Cargo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(45)))), ((int)(((byte)(87)))));
            this.Cargo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cargo.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cargo.ForeColor = System.Drawing.Color.White;
            this.Cargo.Location = new System.Drawing.Point(47, 214);
            this.Cargo.Margin = new System.Windows.Forms.Padding(4);
            this.Cargo.Name = "Cargo";
            this.Cargo.Size = new System.Drawing.Size(227, 38);
            this.Cargo.TabIndex = 2;
            this.Cargo.Text = "Cargo";
            this.Cargo.UseVisualStyleBackColor = false;
            this.Cargo.Click += new System.EventHandler(this.Cargo_Click);
            // 
            // Airplane
            // 
            this.Airplane.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(103)))), ((int)(((byte)(54)))));
            this.Airplane.FlatAppearance.BorderSize = 0;
            this.Airplane.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(45)))), ((int)(((byte)(87)))));
            this.Airplane.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Airplane.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Airplane.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.Airplane.Location = new System.Drawing.Point(47, 28);
            this.Airplane.Margin = new System.Windows.Forms.Padding(4);
            this.Airplane.Name = "Airplane";
            this.Airplane.Size = new System.Drawing.Size(227, 34);
            this.Airplane.TabIndex = 0;
            this.Airplane.Text = "Airplane";
            this.Airplane.UseVisualStyleBackColor = false;
            this.Airplane.Click += new System.EventHandler(this.Airplane_Click_1);
            // 
            // Jets
            // 
            this.Jets.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(103)))), ((int)(((byte)(54)))));
            this.Jets.FlatAppearance.BorderSize = 0;
            this.Jets.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(45)))), ((int)(((byte)(87)))));
            this.Jets.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Jets.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Jets.ForeColor = System.Drawing.Color.White;
            this.Jets.Location = new System.Drawing.Point(47, 152);
            this.Jets.Margin = new System.Windows.Forms.Padding(4);
            this.Jets.Name = "Jets";
            this.Jets.Size = new System.Drawing.Size(227, 36);
            this.Jets.TabIndex = 1;
            this.Jets.Text = "Jet";
            this.Jets.UseVisualStyleBackColor = false;
            this.Jets.Click += new System.EventHandler(this.Jets_Click);
            // 
            // AddNew
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1044, 697);
            this.Controls.Add(this.AddNewPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AddNew";
            this.Text = "AddNewPlane";
            this.AddNewPanel.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Airplane;
        private System.Windows.Forms.Button Jets;
        private System.Windows.Forms.Button Cargo;
        private System.Windows.Forms.Button SmallPlane;
        private System.Windows.Forms.Button Comercial;
        private System.Windows.Forms.Panel AddNewPanel;
        private System.Windows.Forms.Panel panel2;
    }
}