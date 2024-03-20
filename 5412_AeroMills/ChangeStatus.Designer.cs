namespace WindowsFormsApp1
{
    partial class ChangeStatus
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
            this.Comercial = new System.Windows.Forms.Button();
            this.SmallPlane = new System.Windows.Forms.Button();
            this.Cargo = new System.Windows.Forms.Button();
            this.Jets = new System.Windows.Forms.Button();
            this.Airplane = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Comercial
            // 
            this.Comercial.Location = new System.Drawing.Point(583, 182);
            this.Comercial.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Comercial.Name = "Comercial";
            this.Comercial.Size = new System.Drawing.Size(100, 28);
            this.Comercial.TabIndex = 9;
            this.Comercial.Text = " ";
            this.Comercial.UseVisualStyleBackColor = true;
            this.Comercial.Click += new System.EventHandler(this.Comercial_Click);
            // 
            // SmallPlane
            // 
            this.SmallPlane.Location = new System.Drawing.Point(583, 249);
            this.SmallPlane.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SmallPlane.Name = "SmallPlane";
            this.SmallPlane.Size = new System.Drawing.Size(100, 28);
            this.SmallPlane.TabIndex = 8;
            this.SmallPlane.Text = "SmallPlane";
            this.SmallPlane.UseVisualStyleBackColor = true;
            // 
            // Cargo
            // 
            this.Cargo.Location = new System.Drawing.Point(257, 330);
            this.Cargo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Cargo.Name = "Cargo";
            this.Cargo.Size = new System.Drawing.Size(100, 28);
            this.Cargo.TabIndex = 7;
            this.Cargo.Text = "Cargo";
            this.Cargo.UseVisualStyleBackColor = true;
            // 
            // Jets
            // 
            this.Jets.Location = new System.Drawing.Point(257, 249);
            this.Jets.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Jets.Name = "Jets";
            this.Jets.Size = new System.Drawing.Size(100, 28);
            this.Jets.TabIndex = 6;
            this.Jets.Text = "Jets";
            this.Jets.UseVisualStyleBackColor = true;
            // 
            // Airplane
            // 
            this.Airplane.Location = new System.Drawing.Point(257, 148);
            this.Airplane.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Airplane.Name = "Airplane";
            this.Airplane.Size = new System.Drawing.Size(100, 28);
            this.Airplane.TabIndex = 5;
            this.Airplane.Text = "Airplane";
            this.Airplane.UseVisualStyleBackColor = true;
            // 
            // ChangeStatus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.Comercial);
            this.Controls.Add(this.SmallPlane);
            this.Controls.Add(this.Cargo);
            this.Controls.Add(this.Jets);
            this.Controls.Add(this.Airplane);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ChangeStatus";
            this.Text = "ChangeStatus";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Comercial;
        private System.Windows.Forms.Button SmallPlane;
        private System.Windows.Forms.Button Cargo;
        private System.Windows.Forms.Button Jets;
        private System.Windows.Forms.Button Airplane;
    }
}