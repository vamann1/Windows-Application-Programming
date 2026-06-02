
namespace app_elem
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
            this.btnSetValoare = new System.Windows.Forms.Button();
            this.txtValoare = new System.Windows.Forms.TextBox();
            this.txtPatrat = new System.Windows.Forms.TextBox();
            this.lb = new System.Windows.Forms.ListBox();
            this.err = new System.Windows.Forms.ErrorProvider(this.components);
            this.lv = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.err)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSetValoare
            // 
            this.btnSetValoare.Location = new System.Drawing.Point(50, 86);
            this.btnSetValoare.Name = "btnSetValoare";
            this.btnSetValoare.Size = new System.Drawing.Size(273, 27);
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
            this.txtValoare.Validating += new System.ComponentModel.CancelEventHandler(this.txtValoare_Validating);
            // 
            // txtPatrat
            // 
            this.txtPatrat.Location = new System.Drawing.Point(63, 139);
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
            this.lb.Location = new System.Drawing.Point(27, 181);
            this.lb.Name = "lb";
            this.lb.Size = new System.Drawing.Size(365, 85);
            this.lb.TabIndex = 3;
            this.lb.SelectedIndexChanged += new System.EventHandler(this.lb_SelectedIndexChanged);
            // 
            // err
            // 
            this.err.ContainerControl = this;
            // 
            // lv
            // 
            this.lv.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.lv.HideSelection = false;
            this.lv.Location = new System.Drawing.Point(27, 345);
            this.lv.Name = "lv";
            this.lv.Size = new System.Drawing.Size(284, 153);
            this.lv.TabIndex = 4;
            this.lv.UseCompatibleStateImageBehavior = false;
            this.lv.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Numarul";
            this.columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Patratul";
            this.columnHeader2.Width = 150;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton3);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(326, 345);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(98, 153);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Vizualizare";
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(6, 118);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(95, 28);
            this.radioButton3.TabIndex = 7;
            this.radioButton3.Tag = "T";
            this.radioButton3.Text = "Titlu";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(6, 75);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(83, 28);
            this.radioButton2.TabIndex = 6;
            this.radioButton2.Tag = "L";
            this.radioButton2.Text = "List";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(6, 37);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(95, 28);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Tag = "D";
            this.radioButton1.Text = "Tabel";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 519);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lv);
            this.Controls.Add(this.lb);
            this.Controls.Add(this.txtPatrat);
            this.Controls.Add(this.txtValoare);
            this.Controls.Add(this.btnSetValoare);
            this.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.Text = "App_WinF";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.err)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSetValoare;
        private System.Windows.Forms.TextBox txtValoare;
        private System.Windows.Forms.TextBox txtPatrat;
        private System.Windows.Forms.ListBox lb;
        private System.Windows.Forms.ErrorProvider err;
        private System.Windows.Forms.ListView lv;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
    }
}

