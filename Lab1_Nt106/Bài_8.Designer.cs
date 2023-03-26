namespace Lab1_Nt106
{
    partial class Bài_8
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
            this.String_In = new System.Windows.Forms.TextBox();
            this.String_Out = new System.Windows.Forms.TextBox();
            this.Print = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // String_In
            // 
            this.String_In.Location = new System.Drawing.Point(81, 99);
            this.String_In.Name = "String_In";
            this.String_In.Size = new System.Drawing.Size(498, 22);
            this.String_In.TabIndex = 0;
            // 
            // String_Out
            // 
            this.String_Out.Location = new System.Drawing.Point(81, 200);
            this.String_Out.Multiline = true;
            this.String_Out.Name = "String_Out";
            this.String_Out.ReadOnly = true;
            this.String_Out.Size = new System.Drawing.Size(506, 155);
            this.String_Out.TabIndex = 1;
            this.String_Out.TextChanged += new System.EventHandler(this.String_Out_TextChanged);
            // 
            // Print
            // 
            this.Print.Location = new System.Drawing.Point(81, 151);
            this.Print.Name = "Print";
            this.Print.Size = new System.Drawing.Size(75, 23);
            this.Print.TabIndex = 2;
            this.Print.Text = "button1";
            this.Print.UseVisualStyleBackColor = true;
            this.Print.Click += new System.EventHandler(this.Print_Click);
            // 
            // Bài_8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Print);
            this.Controls.Add(this.String_Out);
            this.Controls.Add(this.String_In);
            this.Name = "Bài_8";
            this.Text = "Bài_8";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox String_In;
        private System.Windows.Forms.TextBox String_Out;
        private System.Windows.Forms.Button Print;
    }
}