namespace Legare_Date
{
    partial class Modificare
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
            this.tbMarca = new System.Windows.Forms.TextBox();
            this.tbNume = new System.Windows.Forms.TextBox();
            this.btnTerminare = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbMarca
            // 
            this.tbMarca.Location = new System.Drawing.Point(18, 41);
            this.tbMarca.Name = "tbMarca";
            this.tbMarca.Size = new System.Drawing.Size(210, 29);
            this.tbMarca.TabIndex = 0;
            // 
            // tbNume
            // 
            this.tbNume.Location = new System.Drawing.Point(19, 111);
            this.tbNume.Name = "tbNume";
            this.tbNume.Size = new System.Drawing.Size(235, 29);
            this.tbNume.TabIndex = 1;
            // 
            // btnTerminare
            // 
            this.btnTerminare.Location = new System.Drawing.Point(45, 216);
            this.btnTerminare.Name = "btnTerminare";
            this.btnTerminare.Size = new System.Drawing.Size(208, 80);
            this.btnTerminare.TabIndex = 2;
            this.btnTerminare.Text = "Terminare";
            this.btnTerminare.UseVisualStyleBackColor = true;
            this.btnTerminare.Click += new System.EventHandler(this.btnTerminare_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(341, 175);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 55);
            this.button1.TabIndex = 3;
            this.button1.Text = "<<";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(543, 190);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(95, 56);
            this.button2.TabIndex = 4;
            this.button2.Text = ">>";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Modificare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnTerminare);
            this.Controls.Add(this.tbNume);
            this.Controls.Add(this.tbMarca);
            this.Name = "Modificare";
            this.Text = "Modificare";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Modificare_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbMarca;
        private System.Windows.Forms.TextBox tbNume;
        private System.Windows.Forms.Button btnTerminare;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}