namespace ProjAl
{
    partial class Form2
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
            this.menu = new MaterialSkin.Controls.MaterialContextMenuStrip();
            this.syncItemsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.syncCustomers = new System.Windows.Forms.ToolStripMenuItem();
            this.syncPrices = new System.Windows.Forms.ToolStripMenuItem();
            this.materialFlatButton1 = new MaterialSkin.Controls.MaterialFlatButton();
            this.grid = new System.Windows.Forms.DataGridView();
            this.lblGridHead = new MaterialSkin.Controls.MaterialLabel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.txtemri = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btnsearch = new MaterialSkin.Controls.MaterialFlatButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.materialRaisedButton1 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.BackColor = System.Drawing.Color.DimGray;
            this.menu.Depth = 0;
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.syncItemsToolStripMenuItem,
            this.syncCustomers,
            this.syncPrices});
            this.menu.MouseState = MaterialSkin.MouseState.HOVER;
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(160, 70);
            this.menu.Text = "Menu";
            // 
            // syncItemsToolStripMenuItem
            // 
            this.syncItemsToolStripMenuItem.Name = "syncItemsToolStripMenuItem";
            this.syncItemsToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.syncItemsToolStripMenuItem.Text = "Sync Items";
            this.syncItemsToolStripMenuItem.Click += new System.EventHandler(this.syncItemsToolStripMenuItem_Click);
            // 
            // syncCustomers
            // 
            this.syncCustomers.Name = "syncCustomers";
            this.syncCustomers.Size = new System.Drawing.Size(159, 22);
            this.syncCustomers.Text = "Sync Customers";
            this.syncCustomers.Click += new System.EventHandler(this.syncCustomers_Click);
            // 
            // syncPrices
            // 
            this.syncPrices.Name = "syncPrices";
            this.syncPrices.Size = new System.Drawing.Size(159, 22);
            this.syncPrices.Text = "Sync Prices";
            this.syncPrices.Click += new System.EventHandler(this.syncPrices_Click);
            // 
            // materialFlatButton1
            // 
            this.materialFlatButton1.AutoSize = true;
            this.materialFlatButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton1.ContextMenuStrip = this.menu;
            this.materialFlatButton1.Depth = 0;
            this.materialFlatButton1.Location = new System.Drawing.Point(347, 0);
            this.materialFlatButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton1.Name = "materialFlatButton1";
            this.materialFlatButton1.Primary = false;
            this.materialFlatButton1.Size = new System.Drawing.Size(106, 36);
            this.materialFlatButton1.TabIndex = 1;
            this.materialFlatButton1.Text = "Sinkronizime";
            this.materialFlatButton1.UseVisualStyleBackColor = true;
            // 
            // grid
            // 
            this.grid.AllowUserToAddRows = false;
            this.grid.AllowUserToDeleteRows = false;
            this.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid.Location = new System.Drawing.Point(3, 169);
            this.grid.Name = "grid";
            this.grid.Size = new System.Drawing.Size(1482, 382);
            this.grid.TabIndex = 2;
            // 
            // lblGridHead
            // 
            this.lblGridHead.AutoSize = true;
            this.lblGridHead.Depth = 0;
            this.lblGridHead.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblGridHead.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblGridHead.Location = new System.Drawing.Point(613, 0);
            this.lblGridHead.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblGridHead.Name = "lblGridHead";
            this.lblGridHead.Size = new System.Drawing.Size(209, 19);
            this.lblGridHead.TabIndex = 3;
            this.lblGridHead.Text = "Sinkronizo te dhenat fillimisht";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(701, 59);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 4;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(585, 58);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(56, 19);
            this.materialLabel1.TabIndex = 5;
            this.materialLabel1.Text = "Kolona";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(585, 102);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(44, 19);
            this.materialLabel2.TabIndex = 6;
            this.materialLabel2.Text = "Vlera";
            // 
            // txtemri
            // 
            this.txtemri.Depth = 0;
            this.txtemri.Hint = "";
            this.txtemri.Location = new System.Drawing.Point(701, 98);
            this.txtemri.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtemri.Name = "txtemri";
            this.txtemri.PasswordChar = '\0';
            this.txtemri.SelectedText = "";
            this.txtemri.SelectionLength = 0;
            this.txtemri.SelectionStart = 0;
            this.txtemri.Size = new System.Drawing.Size(121, 23);
            this.txtemri.TabIndex = 7;
            this.txtemri.UseSystemPasswordChar = false;
            // 
            // btnsearch
            // 
            this.btnsearch.AutoSize = true;
            this.btnsearch.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnsearch.Depth = 0;
            this.btnsearch.Location = new System.Drawing.Point(893, 85);
            this.btnsearch.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnsearch.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Primary = false;
            this.btnsearch.Size = new System.Drawing.Size(55, 36);
            this.btnsearch.TabIndex = 8;
            this.btnsearch.Text = "Kerko";
            this.btnsearch.UseVisualStyleBackColor = true;
            this.btnsearch.Click += new System.EventHandler(this.btnsearch_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1488, 554);
            this.panel1.TabIndex = 9;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.grid, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1488, 554);
            this.tableLayoutPanel1.TabIndex = 9;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.materialRaisedButton1);
            this.panel2.Controls.Add(this.materialFlatButton1);
            this.panel2.Controls.Add(this.lblGridHead);
            this.panel2.Controls.Add(this.btnsearch);
            this.panel2.Controls.Add(this.materialLabel1);
            this.panel2.Controls.Add(this.txtemri);
            this.panel2.Controls.Add(this.comboBox1);
            this.panel2.Controls.Add(this.materialLabel2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1482, 160);
            this.panel2.TabIndex = 10;
            // 
            // materialRaisedButton1
            // 
            this.materialRaisedButton1.Depth = 0;
            this.materialRaisedButton1.Location = new System.Drawing.Point(893, 43);
            this.materialRaisedButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton1.Name = "materialRaisedButton1";
            this.materialRaisedButton1.Primary = true;
            this.materialRaisedButton1.Size = new System.Drawing.Size(51, 37);
            this.materialRaisedButton1.TabIndex = 9;
            this.materialRaisedButton1.Text = "Log";
            this.materialRaisedButton1.UseVisualStyleBackColor = true;
            this.materialRaisedButton1.Click += new System.EventHandler(this.materialRaisedButton1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1488, 554);
            this.Controls.Add(this.panel1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.menu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialContextMenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem syncItemsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem syncCustomers;
        private System.Windows.Forms.ToolStripMenuItem syncPrices;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton1;
        private System.Windows.Forms.DataGridView grid;
        private MaterialSkin.Controls.MaterialLabel lblGridHead;
        private System.Windows.Forms.ComboBox comboBox1;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtemri;
        private MaterialSkin.Controls.MaterialFlatButton btnsearch;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel2;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton1;
    }
}