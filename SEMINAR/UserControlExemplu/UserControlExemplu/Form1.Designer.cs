namespace UserControlExemplu
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
            this.btnAfiseazaTara = new System.Windows.Forms.Button();
            this.userControlComboBox = new UserControlExemplu.UserControl1();
            this.SuspendLayout();
            // 
            // btnAfiseazaTara
            // 
            this.btnAfiseazaTara.Location = new System.Drawing.Point(224, 404);
            this.btnAfiseazaTara.Name = "btnAfiseazaTara";
            this.btnAfiseazaTara.Size = new System.Drawing.Size(283, 41);
            this.btnAfiseazaTara.TabIndex = 1;
            this.btnAfiseazaTara.Text = "Afiseaza tara selectata";
            this.btnAfiseazaTara.UseVisualStyleBackColor = true;
            this.btnAfiseazaTara.Click += new System.EventHandler(this.btnAfiseazaTara_Click);
            // 
            // userControlComboBox
            // 
            this.userControlComboBox.Location = new System.Drawing.Point(160, 70);
            this.userControlComboBox.Name = "userControlComboBox";
            this.userControlComboBox.Size = new System.Drawing.Size(380, 289);
            this.userControlComboBox.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAfiseazaTara);
            this.Controls.Add(this.userControlComboBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private UserControl1 userControlComboBox;
        private System.Windows.Forms.Button btnAfiseazaTara;
    }
}

