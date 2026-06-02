namespace Ctrl_culoare
{
    partial class Uc_culoare
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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.trbc = new System.Windows.Forms.TrackBar();
            this.tbc = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.trbc)).BeginInit();
            this.SuspendLayout();
            // 
            // trbc
            // 
            this.trbc.Location = new System.Drawing.Point(0, -1);
            this.trbc.Maximum = 255;
            this.trbc.Name = "trbc";
            this.trbc.Size = new System.Drawing.Size(333, 45);
            this.trbc.TabIndex = 0;
            this.trbc.Scroll += new System.EventHandler(this.trbc_Scroll);
            // 
            // tbc
            // 
            this.tbc.Location = new System.Drawing.Point(358, 10);
            this.tbc.Name = "tbc";
            this.tbc.ReadOnly = true;
            this.tbc.Size = new System.Drawing.Size(55, 20);
            this.tbc.TabIndex = 1;
            this.tbc.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Uc_culoare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tbc);
            this.Controls.Add(this.trbc);
            this.Name = "Uc_culoare";
            this.Size = new System.Drawing.Size(425, 47);
            this.Load += new System.EventHandler(this.Uc_culoare_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trbc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar trbc;
        private System.Windows.Forms.TextBox tbc;
    }
}
