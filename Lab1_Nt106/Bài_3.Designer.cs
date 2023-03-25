namespace Lab1_Nt106
{
    partial class Bài_3
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
            this.ReadN = new System.Windows.Forms.Button();
            this.Del = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.ReadNum = new System.Windows.Forms.TextBox();
            this.Read = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ReadN
            // 
            this.ReadN.Location = new System.Drawing.Point(653, 71);
            this.ReadN.Name = "ReadN";
            this.ReadN.Size = new System.Drawing.Size(75, 23);
            this.ReadN.TabIndex = 0;
            this.ReadN.Text = "button1";
            this.ReadN.UseVisualStyleBackColor = true;
            this.ReadN.Click += new System.EventHandler(this.ReadN_Click);
            // 
            // Del
            // 
            this.Del.Location = new System.Drawing.Point(653, 145);
            this.Del.Name = "Del";
            this.Del.Size = new System.Drawing.Size(75, 23);
            this.Del.TabIndex = 1;
            this.Del.Text = "button2";
            this.Del.UseVisualStyleBackColor = true;
            this.Del.Click += new System.EventHandler(this.Del_Click);
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(653, 221);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(75, 23);
            this.Exit.TabIndex = 2;
            this.Exit.Text = "button3";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // ReadNum
            // 
            this.ReadNum.Location = new System.Drawing.Point(132, 106);
            this.ReadNum.Name = "ReadNum";
            this.ReadNum.Size = new System.Drawing.Size(100, 22);
            this.ReadNum.TabIndex = 3;
            // 
            // Read
            // 
            this.Read.Location = new System.Drawing.Point(135, 316);
            this.Read.Name = "Read";
            this.Read.ReadOnly = true;
            this.Read.Size = new System.Drawing.Size(100, 22);
            this.Read.TabIndex = 4;
            // 
            // Bài_3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Read);
            this.Controls.Add(this.ReadNum);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.Del);
            this.Controls.Add(this.ReadN);
            this.Name = "Bài_3";
            this.Text = "Bài_3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ReadN;
        private System.Windows.Forms.Button Del;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.TextBox ReadNum;
        private System.Windows.Forms.TextBox Read;
    }
}