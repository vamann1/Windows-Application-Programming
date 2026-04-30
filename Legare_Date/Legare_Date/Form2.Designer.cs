namespace Legare_Date
{
    partial class Form2
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
            this.btnAdauga = new System.Windows.Forms.Button();
            this.btnAnulare = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbMarca
            // 
            this.tbMarca.Location = new System.Drawing.Point(180, 139);
            this.tbMarca.Name = "tbMarca";
            this.tbMarca.Size = new System.Drawing.Size(245, 29);
            this.tbMarca.TabIndex = 0;
            // 
            // tbNume
            // 
            this.tbNume.Location = new System.Drawing.Point(186, 212);
            this.tbNume.Name = "tbNume";
            this.tbNume.Size = new System.Drawing.Size(238, 29);
            this.tbNume.TabIndex = 1;
            // 
            // btnAdauga
            // 
            this.btnAdauga.Location = new System.Drawing.Point(51, 327);
            this.btnAdauga.Name = "btnAdauga";
            this.btnAdauga.Size = new System.Drawing.Size(213, 61);
            this.btnAdauga.TabIndex = 2;
            this.btnAdauga.Text = "Adauga";
            this.btnAdauga.UseVisualStyleBackColor = true;
            this.btnAdauga.Click += new System.EventHandler(this.btnAdauga_Click);
            // 
            // btnAnulare
            // 
            this.btnAnulare.Location = new System.Drawing.Point(459, 327);
            this.btnAnulare.Name = "btnAnulare";
            this.btnAnulare.Size = new System.Drawing.Size(185, 74);
            this.btnAnulare.TabIndex = 3;
            this.btnAnulare.Text = "Anulare";
            this.btnAnulare.UseVisualStyleBackColor = true;
            this.btnAnulare.Click += new System.EventHandler(this.btnAnulare_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAnulare);
            this.Controls.Add(this.btnAdauga);
            this.Controls.Add(this.tbNume);
            this.Controls.Add(this.tbMarca);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbMarca;
        private System.Windows.Forms.TextBox tbNume;
        private System.Windows.Forms.Button btnAdauga;
        private System.Windows.Forms.Button btnAnulare;
    }
}