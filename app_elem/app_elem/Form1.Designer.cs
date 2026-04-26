
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
            this.button1 = new System.Windows.Forms.Button();
            this.el = new System.Windows.Forms.TextBox();
            this.pel = new System.Windows.Forms.TextBox();
            this.lb = new System.Windows.Forms.ListBox();
            this.err = new System.Windows.Forms.ErrorProvider(this.components);
            this.lv = new System.Windows.Forms.ListView();
            this.Numarul = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Patratul = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.err)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(51, 122);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(345, 34);
            this.button1.TabIndex = 1;
            this.button1.Text = "Apasa pe EL!";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // el
            // 
            this.el.Location = new System.Drawing.Point(63, 35);
            this.el.Name = "el";
            this.el.Size = new System.Drawing.Size(320, 31);
            this.el.TabIndex = 0;
            this.el.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.el.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.el_KeyPress);
            this.el.Validating += new System.ComponentModel.CancelEventHandler(this.el_Validating);
            // 
            // pel
            // 
            this.pel.Location = new System.Drawing.Point(63, 207);
            this.pel.Name = "pel";
            this.pel.ReadOnly = true;
            this.pel.Size = new System.Drawing.Size(320, 31);
            this.pel.TabIndex = 2;
            this.pel.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lb
            // 
            this.lb.FormattingEnabled = true;
            this.lb.ItemHeight = 23;
            this.lb.Location = new System.Drawing.Point(51, 287);
            this.lb.Name = "lb";
            this.lb.Size = new System.Drawing.Size(344, 165);
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
            this.Numarul,
            this.Patratul});
            this.lv.HideSelection = false;
            this.lv.Location = new System.Drawing.Point(31, 505);
            this.lv.Name = "lv";
            this.lv.Size = new System.Drawing.Size(491, 165);
            this.lv.TabIndex = 4;
            this.lv.UseCompatibleStateImageBehavior = false;
            this.lv.View = System.Windows.Forms.View.Details;
            // 
            // Numarul
            // 
            this.Numarul.Text = "Numarul";
            this.Numarul.Width = 169;
            // 
            // Patratul
            // 
            this.Patratul.Text = "Patratul";
            this.Patratul.Width = 150;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton3);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Location = new System.Drawing.Point(569, 505);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(148, 165);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Vizualizare";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(18, 31);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(90, 27);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Tag = "D";
            this.radioButton1.Text = "Tabel";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(18, 64);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(79, 27);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.Tag = "L";
            this.radioButton2.Text = "List";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(18, 97);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(90, 27);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.Tag = "T";
            this.radioButton3.Text = "Titlu";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(875, 750);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lv);
            this.Controls.Add(this.lb);
            this.Controls.Add(this.pel);
            this.Controls.Add(this.el);
            this.Controls.Add(this.button1);
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

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox el;
        private System.Windows.Forms.TextBox pel;
        private System.Windows.Forms.ListBox lb;
        private System.Windows.Forms.ErrorProvider err;
        private System.Windows.Forms.ListView lv;
        private System.Windows.Forms.ColumnHeader Numarul;
        private System.Windows.Forms.ColumnHeader Patratul;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
    }
}

