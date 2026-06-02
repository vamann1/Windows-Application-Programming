
namespace App_use_ctrl
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pb = new System.Windows.Forms.PictureBox();
            this.cb = new Ctrl_culoare.Uc_culoare();
            this.cg = new Ctrl_culoare.Uc_culoare();
            this.cr = new Ctrl_culoare.Uc_culoare();
            ((System.ComponentModel.ISupportInitialize)(this.pb)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(59, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "ROSU:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(52, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "GREEN:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(62, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "BLUE:";
            // 
            // pb
            // 
            this.pb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pb.Location = new System.Drawing.Point(47, 223);
            this.pb.Name = "pb";
            this.pb.Size = new System.Drawing.Size(634, 73);
            this.pb.TabIndex = 6;
            this.pb.TabStop = false;
            // 
            // cb
            // 
            this.cb.Location = new System.Drawing.Point(153, 144);
            this.cb.Name = "cb";
            this.cb.Size = new System.Drawing.Size(430, 47);
            this.cb.TabIndex = 4;
            this.cb.Ev_Schimbare_culoare += new System.Action(this.cr_Ev_Schimbare_culoare);
            // 
            // cg
            // 
            this.cg.Location = new System.Drawing.Point(153, 91);
            this.cg.Name = "cg";
            this.cg.Size = new System.Drawing.Size(430, 47);
            this.cg.TabIndex = 2;
            this.cg.Ev_Schimbare_culoare += new System.Action(this.cr_Ev_Schimbare_culoare);
            // 
            // cr
            // 
            this.cr.Location = new System.Drawing.Point(153, 39);
            this.cr.Name = "cr";
            this.cr.Size = new System.Drawing.Size(430, 47);
            this.cr.TabIndex = 0;
            this.cr.Ev_Schimbare_culoare += new System.Action(this.cr_Ev_Schimbare_culoare);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 356);
            this.Controls.Add(this.pb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cg);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cr);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Ctrl_culoare.Uc_culoare cr;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Ctrl_culoare.Uc_culoare cg;
        private System.Windows.Forms.Label label3;
        private Ctrl_culoare.Uc_culoare cb;
        private System.Windows.Forms.PictureBox pb;
    }
}

