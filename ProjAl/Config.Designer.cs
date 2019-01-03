namespace ProjAl
{
    partial class Config
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
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.txtServer = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.lblUsername = new MaterialSkin.Controls.MaterialLabel();
            this.lblPassword = new MaterialSkin.Controls.MaterialLabel();
            this.txtPass = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtUn = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtDb = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.chbwindowsAuth = new MaterialSkin.Controls.MaterialCheckBox();
            this.materialFlatButton1 = new MaterialSkin.Controls.MaterialFlatButton();
            this.Databazalbl = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.txtApi = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.BtnCheckApi = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnCheckDb = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnExit = new MaterialSkin.Controls.MaterialFlatButton();
            this.SuspendLayout();
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(337, 9);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(90, 19);
            this.materialLabel1.TabIndex = 0;
            this.materialLabel1.Text = "Konfigurime";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(90, 100);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(55, 19);
            this.materialLabel2.TabIndex = 1;
            this.materialLabel2.Text = "Serveri";
            // 
            // txtServer
            // 
            this.txtServer.Depth = 0;
            this.txtServer.Hint = "";
            this.txtServer.Location = new System.Drawing.Point(165, 100);
            this.txtServer.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtServer.Name = "txtServer";
            this.txtServer.PasswordChar = '\0';
            this.txtServer.SelectedText = "";
            this.txtServer.SelectionLength = 0;
            this.txtServer.SelectionStart = 0;
            this.txtServer.Size = new System.Drawing.Size(75, 23);
            this.txtServer.TabIndex = 2;
            this.txtServer.UseSystemPasswordChar = false;
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(90, 158);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(72, 19);
            this.materialLabel3.TabIndex = 3;
            this.materialLabel3.Text = "DataBaza";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Depth = 0;
            this.lblUsername.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblUsername.Location = new System.Drawing.Point(90, 235);
            this.lblUsername.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(77, 19);
            this.lblUsername.TabIndex = 4;
            this.lblUsername.Text = "Username";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Depth = 0;
            this.lblPassword.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblPassword.Location = new System.Drawing.Point(90, 286);
            this.lblPassword.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(75, 19);
            this.lblPassword.TabIndex = 5;
            this.lblPassword.Text = "Password";
            // 
            // txtPass
            // 
            this.txtPass.Depth = 0;
            this.txtPass.Hint = "";
            this.txtPass.Location = new System.Drawing.Point(173, 282);
            this.txtPass.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '\0';
            this.txtPass.SelectedText = "";
            this.txtPass.SelectionLength = 0;
            this.txtPass.SelectionStart = 0;
            this.txtPass.Size = new System.Drawing.Size(75, 23);
            this.txtPass.TabIndex = 6;
            this.txtPass.UseSystemPasswordChar = false;
            // 
            // txtUn
            // 
            this.txtUn.Depth = 0;
            this.txtUn.Hint = "";
            this.txtUn.Location = new System.Drawing.Point(173, 235);
            this.txtUn.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtUn.Name = "txtUn";
            this.txtUn.PasswordChar = '\0';
            this.txtUn.SelectedText = "";
            this.txtUn.SelectionLength = 0;
            this.txtUn.SelectionStart = 0;
            this.txtUn.Size = new System.Drawing.Size(75, 23);
            this.txtUn.TabIndex = 7;
            this.txtUn.UseSystemPasswordChar = false;
            // 
            // txtDb
            // 
            this.txtDb.Depth = 0;
            this.txtDb.Hint = "";
            this.txtDb.Location = new System.Drawing.Point(168, 154);
            this.txtDb.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtDb.Name = "txtDb";
            this.txtDb.PasswordChar = '\0';
            this.txtDb.SelectedText = "";
            this.txtDb.SelectionLength = 0;
            this.txtDb.SelectionStart = 0;
            this.txtDb.Size = new System.Drawing.Size(75, 23);
            this.txtDb.TabIndex = 8;
            this.txtDb.UseSystemPasswordChar = false;
            // 
            // chbwindowsAuth
            // 
            this.chbwindowsAuth.AutoSize = true;
            this.chbwindowsAuth.Depth = 0;
            this.chbwindowsAuth.Font = new System.Drawing.Font("Roboto", 10F);
            this.chbwindowsAuth.Location = new System.Drawing.Point(94, 193);
            this.chbwindowsAuth.Margin = new System.Windows.Forms.Padding(0);
            this.chbwindowsAuth.MouseLocation = new System.Drawing.Point(-1, -1);
            this.chbwindowsAuth.MouseState = MaterialSkin.MouseState.HOVER;
            this.chbwindowsAuth.Name = "chbwindowsAuth";
            this.chbwindowsAuth.Ripple = true;
            this.chbwindowsAuth.Size = new System.Drawing.Size(118, 30);
            this.chbwindowsAuth.TabIndex = 9;
            this.chbwindowsAuth.Text = "Windows Auth";
            this.chbwindowsAuth.UseVisualStyleBackColor = true;
            this.chbwindowsAuth.CheckedChanged += new System.EventHandler(this.chbwindowsAuth_CheckedChanged);
            // 
            // materialFlatButton1
            // 
            this.materialFlatButton1.AutoSize = true;
            this.materialFlatButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton1.Depth = 0;
            this.materialFlatButton1.Location = new System.Drawing.Point(258, 376);
            this.materialFlatButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton1.Name = "materialFlatButton1";
            this.materialFlatButton1.Primary = false;
            this.materialFlatButton1.Size = new System.Drawing.Size(153, 36);
            this.materialFlatButton1.TabIndex = 10;
            this.materialFlatButton1.Text = "Apliko Konfigurime";
            this.materialFlatButton1.UseVisualStyleBackColor = true;
            this.materialFlatButton1.Click += new System.EventHandler(this.materialFlatButton1_Click);
            // 
            // Databazalbl
            // 
            this.Databazalbl.AutoSize = true;
            this.Databazalbl.Depth = 0;
            this.Databazalbl.Font = new System.Drawing.Font("Roboto", 11F);
            this.Databazalbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Databazalbl.Location = new System.Drawing.Point(183, 65);
            this.Databazalbl.MouseState = MaterialSkin.MouseState.HOVER;
            this.Databazalbl.Name = "Databazalbl";
            this.Databazalbl.Size = new System.Drawing.Size(71, 19);
            this.Databazalbl.TabIndex = 11;
            this.Databazalbl.Text = "Databaza";
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel6.Location = new System.Drawing.Point(593, 70);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(31, 19);
            this.materialLabel6.TabIndex = 12;
            this.materialLabel6.Text = "Api";
            // 
            // txtApi
            // 
            this.txtApi.Depth = 0;
            this.txtApi.Hint = "";
            this.txtApi.Location = new System.Drawing.Point(597, 100);
            this.txtApi.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtApi.Name = "txtApi";
            this.txtApi.PasswordChar = '\0';
            this.txtApi.SelectedText = "";
            this.txtApi.SelectionLength = 0;
            this.txtApi.SelectionStart = 0;
            this.txtApi.Size = new System.Drawing.Size(304, 23);
            this.txtApi.TabIndex = 13;
            this.txtApi.UseSystemPasswordChar = false;
            // 
            // BtnCheckApi
            // 
            this.BtnCheckApi.AutoSize = true;
            this.BtnCheckApi.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnCheckApi.Depth = 0;
            this.BtnCheckApi.Location = new System.Drawing.Point(597, 154);
            this.BtnCheckApi.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.BtnCheckApi.MouseState = MaterialSkin.MouseState.HOVER;
            this.BtnCheckApi.Name = "BtnCheckApi";
            this.BtnCheckApi.Primary = false;
            this.BtnCheckApi.Size = new System.Drawing.Size(78, 36);
            this.BtnCheckApi.TabIndex = 14;
            this.BtnCheckApi.Text = "CheckApi";
            this.BtnCheckApi.UseVisualStyleBackColor = true;
            this.BtnCheckApi.Click += new System.EventHandler(this.BtnCheckApi_Click);
            // 
            // btnCheckDb
            // 
            this.btnCheckDb.AutoSize = true;
            this.btnCheckDb.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCheckDb.Depth = 0;
            this.btnCheckDb.Location = new System.Drawing.Point(94, 327);
            this.btnCheckDb.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnCheckDb.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCheckDb.Name = "btnCheckDb";
            this.btnCheckDb.Primary = false;
            this.btnCheckDb.Size = new System.Drawing.Size(74, 36);
            this.btnCheckDb.TabIndex = 15;
            this.btnCheckDb.Text = "CheckDb";
            this.btnCheckDb.UseVisualStyleBackColor = true;
            this.btnCheckDb.Click += new System.EventHandler(this.btnCheckDb_Click);
            // 
            // btnExit
            // 
            this.btnExit.AutoSize = true;
            this.btnExit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnExit.Depth = 0;
            this.btnExit.Location = new System.Drawing.Point(441, 376);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnExit.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnExit.Name = "btnExit";
            this.btnExit.Primary = false;
            this.btnExit.Size = new System.Drawing.Size(32, 36);
            this.btnExit.TabIndex = 16;
            this.btnExit.Text = "Dil";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Config
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(949, 553);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCheckDb);
            this.Controls.Add(this.BtnCheckApi);
            this.Controls.Add(this.txtApi);
            this.Controls.Add(this.materialLabel6);
            this.Controls.Add(this.Databazalbl);
            this.Controls.Add(this.materialFlatButton1);
            this.Controls.Add(this.chbwindowsAuth);
            this.Controls.Add(this.txtDb);
            this.Controls.Add(this.txtUn);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.txtServer);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel1);
            this.Name = "Config";
            this.Text = "Config";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtServer;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel lblUsername;
        private MaterialSkin.Controls.MaterialLabel lblPassword;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtPass;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtUn;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtDb;
        private MaterialSkin.Controls.MaterialCheckBox chbwindowsAuth;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton1;
        private MaterialSkin.Controls.MaterialLabel Databazalbl;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtApi;
        private MaterialSkin.Controls.MaterialFlatButton BtnCheckApi;
        private MaterialSkin.Controls.MaterialFlatButton btnCheckDb;
        private MaterialSkin.Controls.MaterialFlatButton btnExit;
    }
}