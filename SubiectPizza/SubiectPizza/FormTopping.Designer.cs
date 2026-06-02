namespace SubiectPizza
{
    partial class FormTopping
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.Denumire = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Pret = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Cantitate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Cod = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnSalveazaToppinguri = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.CheckBoxes = true;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Denumire,
            this.Pret,
            this.Cantitate,
            this.Cod});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(36, 41);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(435, 334);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // Denumire
            // 
            this.Denumire.Text = "Denumire";
            this.Denumire.Width = 117;
            // 
            // Pret
            // 
            this.Pret.Text = "Pret";
            this.Pret.Width = 52;
            // 
            // Cantitate
            // 
            this.Cantitate.Text = "Cantitate";
            this.Cantitate.Width = 91;
            // 
            // Cod
            // 
            this.Cod.Text = "Cod";
            this.Cod.Width = 197;
            // 
            // btnSalveazaToppinguri
            // 
            this.btnSalveazaToppinguri.Location = new System.Drawing.Point(93, 434);
            this.btnSalveazaToppinguri.Name = "btnSalveazaToppinguri";
            this.btnSalveazaToppinguri.Size = new System.Drawing.Size(236, 43);
            this.btnSalveazaToppinguri.TabIndex = 1;
            this.btnSalveazaToppinguri.Text = "Salveaza toppinguri";
            this.btnSalveazaToppinguri.UseVisualStyleBackColor = true;
            this.btnSalveazaToppinguri.Click += new System.EventHandler(this.btnSalveazaToppinguri_Click);
            // 
            // FormTopping
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 651);
            this.Controls.Add(this.btnSalveazaToppinguri);
            this.Controls.Add(this.listView1);
            this.Name = "FormTopping";
            this.Text = "FormTopping";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader Denumire;
        private System.Windows.Forms.ColumnHeader Pret;
        private System.Windows.Forms.ColumnHeader Cantitate;
        private System.Windows.Forms.ColumnHeader Cod;
        private System.Windows.Forms.Button btnSalveazaToppinguri;
    }
}