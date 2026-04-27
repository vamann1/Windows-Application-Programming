namespace Seminar7_2
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
            this.components = new System.ComponentModel.Container();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.tbDenumire = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbPret = new System.Windows.Forms.TextBox();
            this.tbCantitate = new System.Windows.Forms.TextBox();
            this.lvProduse = new System.Windows.Forms.ListView();
            this.Denumire = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Pret = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Cantitate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Valoare = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnAdaugaLinie = new System.Windows.Forms.Button();
            this.btnCalculeazaTotal = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.btnComanda = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.tbValoareTotala = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(24, 29);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(349, 34);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // tbDenumire
            // 
            this.tbDenumire.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDenumire.Location = new System.Drawing.Point(55, 143);
            this.tbDenumire.Name = "tbDenumire";
            this.tbDenumire.Size = new System.Drawing.Size(163, 39);
            this.tbDenumire.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(61, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 32);
            this.label2.TabIndex = 3;
            this.label2.Text = "Denumire";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(260, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 32);
            this.label3.TabIndex = 4;
            this.label3.Text = "Pret";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(352, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 32);
            this.label4.TabIndex = 5;
            this.label4.Text = "Cantitate";
            // 
            // tbPret
            // 
            this.tbPret.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPret.Location = new System.Drawing.Point(260, 143);
            this.tbPret.Name = "tbPret";
            this.tbPret.Size = new System.Drawing.Size(66, 39);
            this.tbPret.TabIndex = 6;
            // 
            // tbCantitate
            // 
            this.tbCantitate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCantitate.Location = new System.Drawing.Point(358, 143);
            this.tbCantitate.Name = "tbCantitate";
            this.tbCantitate.Size = new System.Drawing.Size(107, 39);
            this.tbCantitate.TabIndex = 7;
            // 
            // lvProduse
            // 
            this.lvProduse.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Denumire,
            this.Pret,
            this.Cantitate,
            this.Valoare});
            this.lvProduse.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvProduse.GridLines = true;
            this.lvProduse.HideSelection = false;
            this.lvProduse.Location = new System.Drawing.Point(561, 36);
            this.lvProduse.Name = "lvProduse";
            this.lvProduse.Size = new System.Drawing.Size(470, 317);
            this.lvProduse.TabIndex = 8;
            this.lvProduse.UseCompatibleStateImageBehavior = false;
            this.lvProduse.View = System.Windows.Forms.View.Details;
            // 
            // Denumire
            // 
            this.Denumire.Text = "Denumire";
            this.Denumire.Width = 123;
            // 
            // Pret
            // 
            this.Pret.Text = "Pret";
            this.Pret.Width = 80;
            // 
            // Cantitate
            // 
            this.Cantitate.Text = "Cantitate";
            this.Cantitate.Width = 129;
            // 
            // Valoare
            // 
            this.Valoare.Text = "Valoare";
            this.Valoare.Width = 138;
            // 
            // btnAdaugaLinie
            // 
            this.btnAdaugaLinie.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdaugaLinie.Location = new System.Drawing.Point(561, 379);
            this.btnAdaugaLinie.Name = "btnAdaugaLinie";
            this.btnAdaugaLinie.Size = new System.Drawing.Size(222, 44);
            this.btnAdaugaLinie.TabIndex = 9;
            this.btnAdaugaLinie.Text = "Adauga linie";
            this.btnAdaugaLinie.UseVisualStyleBackColor = true;
            this.btnAdaugaLinie.Click += new System.EventHandler(this.btnAdaugaLinie_Click);
            // 
            // btnCalculeazaTotal
            // 
            this.btnCalculeazaTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculeazaTotal.Location = new System.Drawing.Point(819, 379);
            this.btnCalculeazaTotal.Name = "btnCalculeazaTotal";
            this.btnCalculeazaTotal.Size = new System.Drawing.Size(170, 49);
            this.btnCalculeazaTotal.TabIndex = 10;
            this.btnCalculeazaTotal.Text = "Calculeaza total";
            this.btnCalculeazaTotal.UseVisualStyleBackColor = true;
            this.btnCalculeazaTotal.Click += new System.EventHandler(this.btnCalculeazaTotal_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(568, 464);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(315, 32);
            this.label5.TabIndex = 11;
            this.label5.Text = "Valoare totala comanda";
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(565, 527);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(208, 39);
            this.textBox3.TabIndex = 12;
            // 
            // btnComanda
            // 
            this.btnComanda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnComanda.Location = new System.Drawing.Point(833, 522);
            this.btnComanda.Name = "btnComanda";
            this.btnComanda.Size = new System.Drawing.Size(155, 43);
            this.btnComanda.TabIndex = 13;
            this.btnComanda.Text = "Comanda";
            this.btnComanda.UseVisualStyleBackColor = true;
            this.btnComanda.Click += new System.EventHandler(this.btnComanda_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(365, 202);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 32);
            this.label6.TabIndex = 14;
            this.label6.Text = "Valoare";
            // 
            // tbValoareTotala
            // 
            this.tbValoareTotala.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbValoareTotala.Location = new System.Drawing.Point(369, 273);
            this.tbValoareTotala.Name = "tbValoareTotala";
            this.tbValoareTotala.ReadOnly = true;
            this.tbValoareTotala.Size = new System.Drawing.Size(111, 39);
            this.tbValoareTotala.TabIndex = 15;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1128, 701);
            this.Controls.Add(this.tbValoareTotala);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnComanda);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnCalculeazaTotal);
            this.Controls.Add(this.btnAdaugaLinie);
            this.Controls.Add(this.lvProduse);
            this.Controls.Add(this.tbCantitate);
            this.Controls.Add(this.tbPret);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbDenumire);
            this.Controls.Add(this.dateTimePicker1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox tbDenumire;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbPret;
        private System.Windows.Forms.TextBox tbCantitate;
        private System.Windows.Forms.ListView lvProduse;
        private System.Windows.Forms.ColumnHeader Denumire;
        private System.Windows.Forms.ColumnHeader Pret;
        private System.Windows.Forms.ColumnHeader Cantitate;
        private System.Windows.Forms.ColumnHeader Valoare;
        private System.Windows.Forms.Button btnAdaugaLinie;
        private System.Windows.Forms.Button btnCalculeazaTotal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button btnComanda;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbValoareTotala;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}

