namespace Lab1_Nt106
{
    partial class Bài_4
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
            this.Bike_Type = new System.Windows.Forms.ComboBox();
            this.Fuel_Type = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Fuel_Cal = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Bike_Type
            // 
            this.Bike_Type.FormattingEnabled = true;
            this.Bike_Type.Location = new System.Drawing.Point(180, 82);
            this.Bike_Type.Name = "Bike_Type";
            this.Bike_Type.Size = new System.Drawing.Size(258, 24);
            this.Bike_Type.TabIndex = 0;
            this.Bike_Type.SelectedIndexChanged += new System.EventHandler(this.Bike_Type_SelectedIndexChanged);
            // 
            // Fuel_Type
            // 
            this.Fuel_Type.FormattingEnabled = true;
            this.Fuel_Type.Location = new System.Drawing.Point(180, 156);
            this.Fuel_Type.Name = "Fuel_Type";
            this.Fuel_Type.Size = new System.Drawing.Size(258, 24);
            this.Fuel_Type.TabIndex = 1;
            this.Fuel_Type.SelectedIndexChanged += new System.EventHandler(this.Fuel_Type_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(213, 229);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Fuel_Cal
            // 
            this.Fuel_Cal.Location = new System.Drawing.Point(171, 312);
            this.Fuel_Cal.Multiline = true;
            this.Fuel_Cal.Name = "Fuel_Cal";
            this.Fuel_Cal.ReadOnly = true;
            this.Fuel_Cal.Size = new System.Drawing.Size(341, 107);
            this.Fuel_Cal.TabIndex = 3;
            this.Fuel_Cal.TextChanged += new System.EventHandler(this.Fuel_Cal_TextChanged);
            // 
            // Bài_4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Fuel_Cal);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Fuel_Type);
            this.Controls.Add(this.Bike_Type);
            this.Name = "Bài_4";
            this.Text = "Bài_4";
            this.Load += new System.EventHandler(this.Bài_4_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox Bike_Type;
        private System.Windows.Forms.ComboBox Fuel_Type;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox Fuel_Cal;
    }
}