namespace SubiectPoligon
{
    partial class FormAdaugare
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblPuncte = new System.Windows.Forms.Label();
            this.tbPuncte = new System.Windows.Forms.TextBox();
            this.lblCuloare = new System.Windows.Forms.Label();
            this.tbCuloare = new System.Windows.Forms.TextBox();
            this.lblLinie = new System.Windows.Forms.Label();
            this.tbLinie = new System.Windows.Forms.TextBox();
            this.lblEticheta = new System.Windows.Forms.Label();
            this.tbEticheta = new System.Windows.Forms.TextBox();
            this.btnAdauga = new System.Windows.Forms.Button();
            this.btnAnuleaza = new System.Windows.Forms.Button();
            this.err1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.err1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPuncte
            // 
            this.lblPuncte.AutoSize = true;
            this.lblPuncte.Location = new System.Drawing.Point(12, 20);
            this.lblPuncte.Name = "lblPuncte";
            this.lblPuncte.Size = new System.Drawing.Size(217, 25);
            this.lblPuncte.TabIndex = 0;
            this.lblPuncte.Text = "Puncte (x1,y1,x2,y2,...):";
            // 
            // tbPuncte
            // 
            this.tbPuncte.Location = new System.Drawing.Point(200, 17);
            this.tbPuncte.Name = "tbPuncte";
            this.tbPuncte.Size = new System.Drawing.Size(250, 29);
            this.tbPuncte.TabIndex = 1;
            this.tbPuncte.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbPuncte_KeyPress);
            // 
            // lblCuloare
            // 
            this.lblCuloare.AutoSize = true;
            this.lblCuloare.Location = new System.Drawing.Point(12, 55);
            this.lblCuloare.Name = "lblCuloare";
            this.lblCuloare.Size = new System.Drawing.Size(87, 25);
            this.lblCuloare.TabIndex = 2;
            this.lblCuloare.Text = "Culoare:";
            // 
            // tbCuloare
            // 
            this.tbCuloare.Location = new System.Drawing.Point(200, 52);
            this.tbCuloare.Name = "tbCuloare";
            this.tbCuloare.Size = new System.Drawing.Size(250, 29);
            this.tbCuloare.TabIndex = 3;
            // 
            // lblLinie
            // 
            this.lblLinie.AutoSize = true;
            this.lblLinie.Location = new System.Drawing.Point(12, 90);
            this.lblLinie.Name = "lblLinie";
            this.lblLinie.Size = new System.Drawing.Size(130, 25);
            this.lblLinie.TabIndex = 4;
            this.lblLinie.Text = "Grosime linie:";
            // 
            // tbLinie
            // 
            this.tbLinie.Location = new System.Drawing.Point(200, 87);
            this.tbLinie.Name = "tbLinie";
            this.tbLinie.Size = new System.Drawing.Size(250, 29);
            this.tbLinie.TabIndex = 5;
            // 
            // lblEticheta
            // 
            this.lblEticheta.AutoSize = true;
            this.lblEticheta.Location = new System.Drawing.Point(12, 125);
            this.lblEticheta.Name = "lblEticheta";
            this.lblEticheta.Size = new System.Drawing.Size(88, 25);
            this.lblEticheta.TabIndex = 6;
            this.lblEticheta.Text = "Eticheta:";
            // 
            // tbEticheta
            // 
            this.tbEticheta.Location = new System.Drawing.Point(200, 122);
            this.tbEticheta.Name = "tbEticheta";
            this.tbEticheta.Size = new System.Drawing.Size(250, 29);
            this.tbEticheta.TabIndex = 7;
            // 
            // btnAdauga
            // 
            this.btnAdauga.Location = new System.Drawing.Point(200, 165);
            this.btnAdauga.Name = "btnAdauga";
            this.btnAdauga.Size = new System.Drawing.Size(100, 30);
            this.btnAdauga.TabIndex = 8;
            this.btnAdauga.Text = "Adaugă";
            this.btnAdauga.Click += new System.EventHandler(this.btnAdauga_Click);
            // 
            // btnAnuleaza
            // 
            this.btnAnuleaza.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnAnuleaza.Location = new System.Drawing.Point(320, 165);
            this.btnAnuleaza.Name = "btnAnuleaza";
            this.btnAnuleaza.Size = new System.Drawing.Size(100, 30);
            this.btnAnuleaza.TabIndex = 9;
            this.btnAnuleaza.Text = "Anulează";
            // 
            // err1
            // 
            this.err1.ContainerControl = this;
            // 
            // FormAdaugare
            // 
            this.CancelButton = this.btnAnuleaza;
            this.ClientSize = new System.Drawing.Size(490, 220);
            this.Controls.Add(this.lblPuncte);
            this.Controls.Add(this.tbPuncte);
            this.Controls.Add(this.lblCuloare);
            this.Controls.Add(this.tbCuloare);
            this.Controls.Add(this.lblLinie);
            this.Controls.Add(this.tbLinie);
            this.Controls.Add(this.lblEticheta);
            this.Controls.Add(this.tbEticheta);
            this.Controls.Add(this.btnAdauga);
            this.Controls.Add(this.btnAnuleaza);
            this.Name = "FormAdaugare";
            this.Text = "Adaugare Poligon";
            ((System.ComponentModel.ISupportInitialize)(this.err1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPuncte;
        private System.Windows.Forms.TextBox tbPuncte;
        private System.Windows.Forms.Label lblCuloare;
        private System.Windows.Forms.TextBox tbCuloare;
        private System.Windows.Forms.Label lblLinie;
        private System.Windows.Forms.TextBox tbLinie;
        private System.Windows.Forms.Label lblEticheta;
        private System.Windows.Forms.TextBox tbEticheta;
        private System.Windows.Forms.Button btnAdauga;
        private System.Windows.Forms.Button btnAnuleaza;
        private System.Windows.Forms.ErrorProvider err1;
    }
}
