namespace seminar8
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tbTitlu = new TextBox();
            lbCarti = new ListBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            cbTitulatura = new ComboBox();
            tbNume = new TextBox();
            tbAdresa = new TextBox();
            groupBox1 = new GroupBox();
            rbNu = new RadioButton();
            rbDa = new RadioButton();
            TbPlata = new TextBox();
            btnCumpara = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // tbTitlu
            // 
            tbTitlu.Location = new Point(29, 26);
            tbTitlu.Name = "tbTitlu";
            tbTitlu.ReadOnly = true;
            tbTitlu.Size = new Size(515, 35);
            tbTitlu.TabIndex = 0;
            // 
            // lbCarti
            // 
            lbCarti.FormattingEnabled = true;
            lbCarti.Location = new Point(31, 90);
            lbCarti.Name = "lbCarti";
            lbCarti.Size = new Size(515, 424);
            lbCarti.TabIndex = 1;
            lbCarti.SelectedIndexChanged += lbCarti_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(651, 44);
            label1.Name = "label1";
            label1.Size = new Size(200, 30);
            label1.TabIndex = 2;
            label1.Text = "Formular cumparare";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(642, 116);
            label2.Name = "label2";
            label2.Size = new Size(101, 30);
            label2.TabIndex = 3;
            label2.Text = "Titulatura";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(638, 181);
            label3.Name = "label3";
            label3.Size = new Size(179, 30);
            label3.TabIndex = 4;
            label3.Text = "Nume si prenume";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(638, 241);
            label4.Name = "label4";
            label4.Size = new Size(77, 30);
            label4.TabIndex = 5;
            label4.Text = "Adresa";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(642, 449);
            label5.Name = "label5";
            label5.Size = new Size(138, 30);
            label5.TabIndex = 6;
            label5.Text = "Total de plata";
            // 
            // cbTitulatura
            // 
            cbTitulatura.FormattingEnabled = true;
            cbTitulatura.Items.AddRange(new object[] { "Dl. ", "Dna." });
            cbTitulatura.Location = new Point(809, 124);
            cbTitulatura.Name = "cbTitulatura";
            cbTitulatura.Size = new Size(226, 38);
            cbTitulatura.TabIndex = 7;
            // 
            // tbNume
            // 
            tbNume.Location = new Point(858, 189);
            tbNume.Name = "tbNume";
            tbNume.Size = new Size(175, 35);
            tbNume.TabIndex = 8;
            // 
            // tbAdresa
            // 
            tbAdresa.Location = new Point(784, 252);
            tbAdresa.Name = "tbAdresa";
            tbAdresa.Size = new Size(229, 35);
            tbAdresa.TabIndex = 9;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rbNu);
            groupBox1.Controls.Add(rbDa);
            groupBox1.Location = new Point(748, 296);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(295, 150);
            groupBox1.TabIndex = 10;
            groupBox1.TabStop = false;
            groupBox1.Text = "Sunteti student?";
            // 
            // rbNu
            // 
            rbNu.AutoSize = true;
            rbNu.Location = new Point(17, 111);
            rbNu.Name = "rbNu";
            rbNu.Size = new Size(66, 34);
            rbNu.TabIndex = 1;
            rbNu.TabStop = true;
            rbNu.Text = "Nu";
            rbNu.UseVisualStyleBackColor = true;
            rbNu.CheckedChanged += rbNu_CheckedChanged;
            // 
            // rbDa
            // 
            rbDa.AutoSize = true;
            rbDa.Location = new Point(15, 41);
            rbDa.Name = "rbDa";
            rbDa.Size = new Size(64, 34);
            rbDa.TabIndex = 0;
            rbDa.TabStop = true;
            rbDa.Text = "Da";
            rbDa.UseVisualStyleBackColor = true;
            rbDa.CheckedChanged += rbDa_CheckedChanged;
            // 
            // TbPlata
            // 
            TbPlata.Location = new Point(837, 458);
            TbPlata.Name = "TbPlata";
            TbPlata.ReadOnly = true;
            TbPlata.Size = new Size(164, 35);
            TbPlata.TabIndex = 11;
            // 
            // btnCumpara
            // 
            btnCumpara.Location = new Point(698, 541);
            btnCumpara.Name = "btnCumpara";
            btnCumpara.Size = new Size(272, 46);
            btnCumpara.TabIndex = 12;
            btnCumpara.Text = "Cumpara";
            btnCumpara.UseVisualStyleBackColor = true;
            btnCumpara.Click += btnCumpara_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1135, 710);
            Controls.Add(btnCumpara);
            Controls.Add(TbPlata);
            Controls.Add(groupBox1);
            Controls.Add(tbAdresa);
            Controls.Add(tbNume);
            Controls.Add(cbTitulatura);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lbCarti);
            Controls.Add(tbTitlu);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbTitlu;
        private ListBox lbCarti;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private ComboBox cbTitulatura;
        private TextBox tbNume;
        private TextBox tbAdresa;
        private GroupBox groupBox1;
        private RadioButton rbNu;
        private RadioButton rbDa;
        private TextBox TbPlata;
        private Button btnCumpara;
    }
}
