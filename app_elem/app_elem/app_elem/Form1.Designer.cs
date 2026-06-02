
namespace app_elem
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnSetValoare = new System.Windows.Forms.Button();
            this.txtValoare = new System.Windows.Forms.TextBox();
            this.txtPatrat = new System.Windows.Forms.TextBox();
            this.lb = new System.Windows.Forms.ListBox();
            this.err = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.err)).BeginInit();
            this.SuspendLayout();
            //
            // btnSetValoare
            //
            this.btnSetValoare.Location = new System.Drawing.Point(51, 122);
            this.btnSetValoare.Name = "btnSetValoare";
            this.btnSetValoare.Size = new System.Drawing.Size(273, 56);
            this.btnSetValoare.TabIndex = 1;
            this.btnSetValoare.Text = "Apasa pe EL!";
            this.btnSetValoare.UseVisualStyleBackColor = true;
            this.btnSetValoare.Click += new System.EventHandler(this.btnSetValoare_Click);
            //
            // txtValoare
            //
            this.txtValoare.Location = new System.Drawing.Point(63, 35);
            this.txtValoare.Name = "txtValoare";
            this.txtValoare.Size = new System.Drawing.Size(248, 35);
            this.txtValoare.TabIndex = 0;
            this.txtValoare.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtValoare.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValoare_KeyPress);
            //
            // txtPatrat
            //
            this.txtPatrat.Location = new System.Drawing.Point(63, 207);
            this.txtPatrat.Name = "txtPatrat";
            this.txtPatrat.ReadOnly = true;
            this.txtPatrat.Size = new System.Drawing.Size(248, 35);
            this.txtPatrat.TabIndex = 2;
            this.txtPatrat.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            //
            // lb
            //
            this.lb.FormattingEnabled = true;
            this.lb.ItemHeight = 27;
            this.lb.Location = new System.Drawing.Point(51, 287);
            this.lb.Name = "lb";
            this.lb.Size = new System.Drawing.Size(272, 166);
            this.lb.TabIndex = 3;
            this.lb.SelectedIndexChanged += new System.EventHandler(this.lb_SelectedIndexChanged);
            //
            // err
            //
            this.err.ContainerControl = this;
            //
            // Form1
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 519);
            this.Controls.Add(this.lb);
            this.Controls.Add(this.txtPatrat);
            this.Controls.Add(this.txtValoare);
            this.Controls.Add(this.btnSetValoare);
            this.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.Text = "App_WinF";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.err)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSetValoare;
        private System.Windows.Forms.TextBox txtValoare;
        private System.Windows.Forms.TextBox txtPatrat;
        private System.Windows.Forms.ListBox lb;
        private System.Windows.Forms.ErrorProvider err;
    }
}
