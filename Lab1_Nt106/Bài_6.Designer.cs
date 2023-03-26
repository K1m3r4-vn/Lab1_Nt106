namespace Lab1_Nt106
{
    partial class Bài_6
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
            this.Print = new System.Windows.Forms.Button();
            this.Date_time = new System.Windows.Forms.TextBox();
            this.Date_Zoo = new System.Windows.Forms.TextBox();
            this.Del = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Print
            // 
            this.Print.Location = new System.Drawing.Point(145, 161);
            this.Print.Name = "Print";
            this.Print.Size = new System.Drawing.Size(75, 23);
            this.Print.TabIndex = 0;
            this.Print.Text = "Xuất ra";
            this.Print.UseVisualStyleBackColor = true;
            this.Print.Click += new System.EventHandler(this.Print_Click);
            // 
            // Date_time
            // 
            this.Date_time.Location = new System.Drawing.Point(145, 97);
            this.Date_time.Name = "Date_time";
            this.Date_time.Size = new System.Drawing.Size(187, 22);
            this.Date_time.TabIndex = 1;
            this.Date_time.TextChanged += new System.EventHandler(this.Date_time_TextChanged);
            // 
            // Date_Zoo
            // 
            this.Date_Zoo.Location = new System.Drawing.Point(136, 246);
            this.Date_Zoo.Multiline = true;
            this.Date_Zoo.Name = "Date_Zoo";
            this.Date_Zoo.ReadOnly = true;
            this.Date_Zoo.Size = new System.Drawing.Size(463, 137);
            this.Date_Zoo.TabIndex = 2;
            // 
            // Del
            // 
            this.Del.Location = new System.Drawing.Point(342, 161);
            this.Del.Name = "Del";
            this.Del.Size = new System.Drawing.Size(76, 23);
            this.Del.TabIndex = 3;
            this.Del.Text = "Xóa";
            this.Del.UseVisualStyleBackColor = true;
            this.Del.Click += new System.EventHandler(this.Del_Click);
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(524, 161);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(75, 23);
            this.Exit.TabIndex = 4;
            this.Exit.Text = "Thoát";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Bài_6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.Del);
            this.Controls.Add(this.Date_Zoo);
            this.Controls.Add(this.Date_time);
            this.Controls.Add(this.Print);
            this.Name = "Bài_6";
            this.Text = "Bài_6";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Print;
        private System.Windows.Forms.TextBox Date_time;
        private System.Windows.Forms.TextBox Date_Zoo;
        private System.Windows.Forms.Button Del;
        private System.Windows.Forms.Button Exit;
    }
}