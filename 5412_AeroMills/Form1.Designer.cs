namespace WindowsFormsApp1
{
    partial class Form1
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
            this.Form1_btn1 = new System.Windows.Forms.Button();
            this.Form1_btn2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Form1_btn1
            // 
            this.Form1_btn1.Location = new System.Drawing.Point(116, 295);
            this.Form1_btn1.Name = "Form1_btn1";
            this.Form1_btn1.Size = new System.Drawing.Size(119, 39);
            this.Form1_btn1.TabIndex = 0;
            this.Form1_btn1.Text = "Insert New Plane";
            this.Form1_btn1.UseVisualStyleBackColor = true;
            // 
            // Form1_btn2
            // 
            this.Form1_btn2.Location = new System.Drawing.Point(500, 295);
            this.Form1_btn2.Name = "Form1_btn2";
            this.Form1_btn2.Size = new System.Drawing.Size(119, 39);
            this.Form1_btn2.TabIndex = 1;
            this.Form1_btn2.Text = "Change Plane State";
            this.Form1_btn2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Form1_btn2);
            this.Controls.Add(this.Form1_btn1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Form1_btn1;
        private System.Windows.Forms.Button Form1_btn2;
    }
}

