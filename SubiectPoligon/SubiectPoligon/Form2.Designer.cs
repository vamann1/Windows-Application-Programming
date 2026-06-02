namespace SubiectPoligon
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
            System.Windows.Forms.Label label1;
            this.tbEticheta = new System.Windows.Forms.TextBox();
            this.btnDeseneaza = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(12, 65);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(435, 25);
            label1.TabIndex = 1;
            label1.Text = "Introduce eticheta figurii pe care vrei sa o afisezi: ";
            // 
            // tbEticheta
            // 
            this.tbEticheta.Location = new System.Drawing.Point(46, 93);
            this.tbEticheta.Name = "tbEticheta";
            this.tbEticheta.Size = new System.Drawing.Size(218, 29);
            this.tbEticheta.TabIndex = 0;
            // 
            // btnDeseneaza
            // 
            this.btnDeseneaza.Location = new System.Drawing.Point(37, 146);
            this.btnDeseneaza.Name = "btnDeseneaza";
            this.btnDeseneaza.Size = new System.Drawing.Size(153, 48);
            this.btnDeseneaza.TabIndex = 2;
            this.btnDeseneaza.Text = "Deseneaza";
            this.btnDeseneaza.UseVisualStyleBackColor = true;
            this.btnDeseneaza.Click += new System.EventHandler(this.btnDeseneaza_Click_1);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1026, 725);
            this.Controls.Add(this.btnDeseneaza);
            this.Controls.Add(label1);
            this.Controls.Add(this.tbEticheta);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form2_Paint_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbEticheta;
        private System.Windows.Forms.Button btnDeseneaza;
    }
}