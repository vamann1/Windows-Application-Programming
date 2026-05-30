namespace Proiect_Vaman_Mircea_George
{
    partial class UCSelectorProds
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        private void InitializeComponent()
        {
            this.lblProdus = new System.Windows.Forms.Label();
            this.cbProdus  = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            //
            // lblProdus
            //
            this.lblProdus.AutoSize = true;
            this.lblProdus.Location = new System.Drawing.Point(6, 6);
            this.lblProdus.Name     = "lblProdus";
            this.lblProdus.Size     = new System.Drawing.Size(150, 25);
            this.lblProdus.TabIndex = 0;
            this.lblProdus.Text     = "Selecteaza produs:";
            //
            // cbProdus
            //
            this.cbProdus.DropDownStyle      = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbProdus.FormattingEnabled  = true;
            this.cbProdus.Location           = new System.Drawing.Point(6, 38);
            this.cbProdus.Name               = "cbProdus";
            this.cbProdus.Size               = new System.Drawing.Size(400, 33);
            this.cbProdus.TabIndex           = 1;
            //
            // UCSelectorProds
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode       = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblProdus);
            this.Controls.Add(this.cbProdus);
            this.Name = "UCSelectorProds";
            this.Size = new System.Drawing.Size(420, 82);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label   lblProdus;
        private System.Windows.Forms.ComboBox cbProdus;
    }
}
