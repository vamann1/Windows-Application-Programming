namespace SubiectPizza
{
    partial class FormComanda
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
            this.tbNume = new System.Windows.Forms.TextBox();
            this.tbDurata = new System.Windows.Forms.TextBox();
            this.cbBlat = new System.Windows.Forms.ComboBox();
            this.tbTopping = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAdaugaComanda = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbNume
            // 
            this.tbNume.Location = new System.Drawing.Point(96, 70);
            this.tbNume.Name = "tbNume";
            this.tbNume.Size = new System.Drawing.Size(266, 29);
            this.tbNume.TabIndex = 0;
            this.tbNume.Validating += new System.ComponentModel.CancelEventHandler(this.tbNume_Validating);
            // 
            // tbDurata
            // 
            this.tbDurata.Location = new System.Drawing.Point(96, 209);
            this.tbDurata.Name = "tbDurata";
            this.tbDurata.Size = new System.Drawing.Size(272, 29);
            this.tbDurata.TabIndex = 1;
            // 
            // cbBlat
            // 
            this.cbBlat.FormattingEnabled = true;
            this.cbBlat.Items.AddRange(new object[] {
            "Subtire",
            "Normal",
            "Pufos",
            "Cheese"});
            this.cbBlat.Location = new System.Drawing.Point(96, 135);
            this.cbBlat.Name = "cbBlat";
            this.cbBlat.Size = new System.Drawing.Size(266, 32);
            this.cbBlat.TabIndex = 2;
            // 
            // tbTopping
            // 
            this.tbTopping.Location = new System.Drawing.Point(96, 293);
            this.tbTopping.Multiline = true;
            this.tbTopping.Name = "tbTopping";
            this.tbTopping.Size = new System.Drawing.Size(263, 127);
            this.tbTopping.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(96, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nume";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(96, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Blat";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(96, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Durata realizare";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(96, 265);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(554, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "Topping-uri(fiecare pe cate o linie, fiecare camp separat prin \',\')";
            // 
            // btnAdaugaComanda
            // 
            this.btnAdaugaComanda.Location = new System.Drawing.Point(96, 458);
            this.btnAdaugaComanda.Name = "btnAdaugaComanda";
            this.btnAdaugaComanda.Size = new System.Drawing.Size(254, 41);
            this.btnAdaugaComanda.TabIndex = 9;
            this.btnAdaugaComanda.Text = "Adauga comanda";
            this.btnAdaugaComanda.UseVisualStyleBackColor = true;
            this.btnAdaugaComanda.Click += new System.EventHandler(this.btnAdaugaComanda_Click);
            // 
            // FormComanda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 898);
            this.Controls.Add(this.btnAdaugaComanda);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbTopping);
            this.Controls.Add(this.cbBlat);
            this.Controls.Add(this.tbDurata);
            this.Controls.Add(this.tbNume);
            this.Name = "FormComanda";
            this.Text = "FormComanda";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbNume;
        private System.Windows.Forms.TextBox tbDurata;
        private System.Windows.Forms.ComboBox cbBlat;
        private System.Windows.Forms.TextBox tbTopping;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAdaugaComanda;
    }
}