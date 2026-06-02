
namespace drag_drop_app
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
            this.tb = new System.Windows.Forms.TextBox();
            this.lb = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // tb
            // 
            this.tb.Location = new System.Drawing.Point(12, 90);
            this.tb.Name = "tb";
            this.tb.Size = new System.Drawing.Size(202, 20);
            this.tb.TabIndex = 0;
            this.tb.MouseDown += new System.Windows.Forms.MouseEventHandler(this.tb_MouseDown);
            // 
            // lb
            // 
            this.lb.AllowDrop = true;
            this.lb.FormattingEnabled = true;
            this.lb.Location = new System.Drawing.Point(292, 24);
            this.lb.Name = "lb";
            this.lb.Size = new System.Drawing.Size(243, 212);
            this.lb.TabIndex = 1;
            this.lb.DragDrop += new System.Windows.Forms.DragEventHandler(this.lb_DragDrop);
            this.lb.DragEnter += new System.Windows.Forms.DragEventHandler(this.lb_DragEnter);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 288);
            this.Controls.Add(this.lb);
            this.Controls.Add(this.tb);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb;
        private System.Windows.Forms.ListBox lb;
    }
}

