namespace Proiect_Vaman_Mircea_George
{
    partial class FormDetaliiVanzare
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.bindingSource1                   = new System.Windows.Forms.BindingSource(this.components);
            this.bindingNavigator1                = new System.Windows.Forms.BindingNavigator(false);
            this.bindingNavigatorMoveFirstItem    = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator        = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem     = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem        = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1       = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem     = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem     = new System.Windows.Forms.ToolStripButton();
            this.lblNumeProdus     = new System.Windows.Forms.Label();
            this.tbNumeProdus      = new System.Windows.Forms.TextBox();
            this.lblCantitate      = new System.Windows.Forms.Label();
            this.tbCantitate       = new System.Windows.Forms.TextBox();
            this.lblPretUnitar     = new System.Windows.Forms.Label();
            this.tbPretUnitar      = new System.Windows.Forms.TextBox();
            this.lblData           = new System.Windows.Forms.Label();
            this.tbData            = new System.Windows.Forms.TextBox();
            this.lblValoareTotala2 = new System.Windows.Forms.Label();
            this.tbValoareTotala2  = new System.Windows.Forms.TextBox();
            this.lblTVACalculat    = new System.Windows.Forms.Label();
            this.tbTVACalculat     = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            this.SuspendLayout();
            //
            // butoane navigator — text pur, vizibil la orice DPI
            //
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.bindingNavigatorMoveFirstItem.Name         = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.Text         = "|<";
            this.bindingNavigatorMoveFirstItem.ToolTipText  = "Prima inregistrare";

            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.bindingNavigatorMovePreviousItem.Name         = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.Text         = "<";
            this.bindingNavigatorMovePreviousItem.ToolTipText  = "Inregistrarea anterioara";

            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize       = false;
            this.bindingNavigatorPositionItem.Name           = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size           = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text           = "0";
            this.bindingNavigatorPositionItem.ToolTipText    = "Pozitia curenta";

            this.bindingNavigatorCountItem.Name        = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Text        = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total inregistrari";

            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.bindingNavigatorMoveNextItem.Name         = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.Text         = ">";
            this.bindingNavigatorMoveNextItem.ToolTipText  = "Urmatoarea inregistrare";

            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.bindingNavigatorMoveLastItem.Name         = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.Text         = ">|";
            this.bindingNavigatorMoveLastItem.ToolTipText  = "Ultima inregistrare";
            //
            // bindingNavigator1
            //
            this.bindingNavigator1.AddNewItem       = null;
            this.bindingNavigator1.BindingSource    = this.bindingSource1;
            this.bindingNavigator1.CountItem        = this.bindingNavigatorCountItem;
            this.bindingNavigator1.DeleteItem       = null;
            this.bindingNavigator1.Dock             = System.Windows.Forms.DockStyle.Top;
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
                this.bindingNavigatorMoveFirstItem,
                this.bindingNavigatorMovePreviousItem,
                this.bindingNavigatorSeparator,
                this.bindingNavigatorPositionItem,
                this.bindingNavigatorCountItem,
                this.bindingNavigatorSeparator1,
                this.bindingNavigatorMoveNextItem,
                this.bindingNavigatorMoveLastItem
            });
            this.bindingNavigator1.Location         = new System.Drawing.Point(0, 0);
            this.bindingNavigator1.MoveFirstItem    = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator1.MoveLastItem     = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator1.MoveNextItem     = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator1.Name             = "bindingNavigator1";
            this.bindingNavigator1.PositionItem     = this.bindingNavigatorPositionItem;
            this.bindingNavigator1.Size             = new System.Drawing.Size(500, 25);
            this.bindingNavigator1.TabIndex         = 0;
            this.bindingNavigator1.Text             = "bindingNavigator1";
            //
            // lblNumeProdus
            //
            this.lblNumeProdus.AutoSize = true;
            this.lblNumeProdus.Location = new System.Drawing.Point(30, 60);
            this.lblNumeProdus.Name     = "lblNumeProdus";
            this.lblNumeProdus.Size     = new System.Drawing.Size(79, 13);
            this.lblNumeProdus.TabIndex = 1;
            this.lblNumeProdus.Text     = "Nume produs:";
            //
            // tbNumeProdus
            //
            this.tbNumeProdus.Location = new System.Drawing.Point(150, 57);
            this.tbNumeProdus.Name     = "tbNumeProdus";
            this.tbNumeProdus.Size     = new System.Drawing.Size(300, 20);
            this.tbNumeProdus.TabIndex = 2;
            //
            // lblCantitate
            //
            this.lblCantitate.AutoSize = true;
            this.lblCantitate.Location = new System.Drawing.Point(30, 100);
            this.lblCantitate.Name     = "lblCantitate";
            this.lblCantitate.Size     = new System.Drawing.Size(57, 13);
            this.lblCantitate.TabIndex = 3;
            this.lblCantitate.Text     = "Cantitate:";
            //
            // tbCantitate
            //
            this.tbCantitate.Location = new System.Drawing.Point(150, 97);
            this.tbCantitate.Name     = "tbCantitate";
            this.tbCantitate.Size     = new System.Drawing.Size(300, 20);
            this.tbCantitate.TabIndex = 4;
            //
            // lblPretUnitar
            //
            this.lblPretUnitar.AutoSize = true;
            this.lblPretUnitar.Location = new System.Drawing.Point(30, 140);
            this.lblPretUnitar.Name     = "lblPretUnitar";
            this.lblPretUnitar.Size     = new System.Drawing.Size(62, 13);
            this.lblPretUnitar.TabIndex = 5;
            this.lblPretUnitar.Text     = "Pret unitar:";
            //
            // tbPretUnitar
            //
            this.tbPretUnitar.Location = new System.Drawing.Point(150, 137);
            this.tbPretUnitar.Name     = "tbPretUnitar";
            this.tbPretUnitar.Size     = new System.Drawing.Size(300, 20);
            this.tbPretUnitar.TabIndex = 6;
            //
            // lblData
            //
            this.lblData.AutoSize = true;
            this.lblData.Location = new System.Drawing.Point(30, 180);
            this.lblData.Name     = "lblData";
            this.lblData.Size     = new System.Drawing.Size(34, 13);
            this.lblData.TabIndex = 7;
            this.lblData.Text     = "Data:";
            //
            // tbData
            //
            this.tbData.Location = new System.Drawing.Point(150, 177);
            this.tbData.Name     = "tbData";
            this.tbData.Size     = new System.Drawing.Size(300, 20);
            this.tbData.TabIndex = 8;
            //
            // lblValoareTotala2
            //
            this.lblValoareTotala2.AutoSize = true;
            this.lblValoareTotala2.Location = new System.Drawing.Point(30, 220);
            this.lblValoareTotala2.Name     = "lblValoareTotala2";
            this.lblValoareTotala2.TabIndex = 9;
            this.lblValoareTotala2.Text     = "Valoare totala (cu TVA):";
            //
            // tbValoareTotala2
            //
            this.tbValoareTotala2.Location = new System.Drawing.Point(200, 217);
            this.tbValoareTotala2.Name     = "tbValoareTotala2";
            this.tbValoareTotala2.ReadOnly = true;
            this.tbValoareTotala2.Size     = new System.Drawing.Size(250, 20);
            this.tbValoareTotala2.TabIndex = 10;
            //
            // lblTVACalculat
            //
            this.lblTVACalculat.AutoSize = true;
            this.lblTVACalculat.Location = new System.Drawing.Point(30, 260);
            this.lblTVACalculat.Name     = "lblTVACalculat";
            this.lblTVACalculat.TabIndex = 11;
            this.lblTVACalculat.Text     = "TVA (19%):";
            //
            // tbTVACalculat
            //
            this.tbTVACalculat.Location = new System.Drawing.Point(200, 257);
            this.tbTVACalculat.Name     = "tbTVACalculat";
            this.tbTVACalculat.ReadOnly = true;
            this.tbTVACalculat.Size     = new System.Drawing.Size(250, 20);
            this.tbTVACalculat.TabIndex = 12;
            //
            // Form2
            //
            this.Controls.Add(this.lblNumeProdus);
            this.Controls.Add(this.tbNumeProdus);
            this.Controls.Add(this.lblCantitate);
            this.Controls.Add(this.tbCantitate);
            this.Controls.Add(this.lblPretUnitar);
            this.Controls.Add(this.tbPretUnitar);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.tbData);
            this.Controls.Add(this.lblValoareTotala2);
            this.Controls.Add(this.tbValoareTotala2);
            this.Controls.Add(this.lblTVACalculat);
            this.Controls.Add(this.tbTVACalculat);
            this.Controls.Add(this.bindingNavigator1);
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode       = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize          = new System.Drawing.Size(500, 300);
            this.Name          = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text          = "Detalii vanzari (binding)";
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.BindingSource              bindingSource1;
        private System.Windows.Forms.BindingNavigator           bindingNavigator1;
        private System.Windows.Forms.ToolStripButton            bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton            bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator         bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox           bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripLabel             bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripSeparator         bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton            bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton            bindingNavigatorMoveLastItem;
        private System.Windows.Forms.Label   lblNumeProdus;
        private System.Windows.Forms.TextBox tbNumeProdus;
        private System.Windows.Forms.Label   lblCantitate;
        private System.Windows.Forms.TextBox tbCantitate;
        private System.Windows.Forms.Label   lblPretUnitar;
        private System.Windows.Forms.TextBox tbPretUnitar;
        private System.Windows.Forms.Label   lblData;
        private System.Windows.Forms.TextBox tbData;
        private System.Windows.Forms.Label   lblValoareTotala2;
        private System.Windows.Forms.TextBox tbValoareTotala2;
        private System.Windows.Forms.Label   lblTVACalculat;
        private System.Windows.Forms.TextBox tbTVACalculat;
    }
}
