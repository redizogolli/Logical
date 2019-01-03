namespace ProjAl
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
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.txtusername = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtpassword = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btnexit = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnlogin = new MaterialSkin.Controls.MaterialFlatButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnConfig = new MaterialSkin.Controls.MaterialFlatButton();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(3, 13);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(77, 19);
            this.materialLabel1.TabIndex = 6;
            this.materialLabel1.Text = "Username";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(5, 57);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(75, 19);
            this.materialLabel2.TabIndex = 7;
            this.materialLabel2.Text = "Password";
            // 
            // txtusername
            // 
            this.txtusername.Depth = 0;
            this.txtusername.Hint = "";
            this.txtusername.Location = new System.Drawing.Point(95, 13);
            this.txtusername.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtusername.Name = "txtusername";
            this.txtusername.PasswordChar = '\0';
            this.txtusername.SelectedText = "";
            this.txtusername.SelectionLength = 0;
            this.txtusername.SelectionStart = 0;
            this.txtusername.Size = new System.Drawing.Size(138, 23);
            this.txtusername.TabIndex = 8;
            this.txtusername.UseSystemPasswordChar = false;
            // 
            // txtpassword
            // 
            this.txtpassword.Depth = 0;
            this.txtpassword.Hint = "";
            this.txtpassword.Location = new System.Drawing.Point(95, 53);
            this.txtpassword.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.PasswordChar = '*';
            this.txtpassword.SelectedText = "";
            this.txtpassword.SelectionLength = 0;
            this.txtpassword.SelectionStart = 0;
            this.txtpassword.Size = new System.Drawing.Size(138, 23);
            this.txtpassword.TabIndex = 9;
            this.txtpassword.UseSystemPasswordChar = true;
            // 
            // btnexit
            // 
            this.btnexit.AutoSize = true;
            this.btnexit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnexit.Depth = 0;
            this.btnexit.Location = new System.Drawing.Point(139, 85);
            this.btnexit.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnexit.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnexit.Name = "btnexit";
            this.btnexit.Primary = false;
            this.btnexit.Size = new System.Drawing.Size(41, 36);
            this.btnexit.TabIndex = 10;
            this.btnexit.Text = "Exit";
            this.btnexit.UseVisualStyleBackColor = true;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click_1);
            // 
            // btnlogin
            // 
            this.btnlogin.AutoSize = true;
            this.btnlogin.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnlogin.Depth = 0;
            this.btnlogin.Location = new System.Drawing.Point(67, 86);
            this.btnlogin.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnlogin.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.Primary = false;
            this.btnlogin.Size = new System.Drawing.Size(52, 36);
            this.btnlogin.TabIndex = 11;
            this.btnlogin.Text = "Login";
            this.btnlogin.UseVisualStyleBackColor = true;
            this.btnlogin.Click += new System.EventHandler(this.btnlogin_Click_1);
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.Controls.Add(this.btnConfig);
            this.panel1.Controls.Add(this.materialLabel1);
            this.panel1.Controls.Add(this.btnexit);
            this.panel1.Controls.Add(this.btnlogin);
            this.panel1.Controls.Add(this.materialLabel2);
            this.panel1.Controls.Add(this.txtusername);
            this.panel1.Controls.Add(this.txtpassword);
            this.panel1.Location = new System.Drawing.Point(165, 111);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(387, 127);
            this.panel1.TabIndex = 12;
            // 
            // btnConfig
            // 
            this.btnConfig.AutoSize = true;
            this.btnConfig.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnConfig.Depth = 0;
            this.btnConfig.Location = new System.Drawing.Point(253, 40);
            this.btnConfig.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnConfig.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnConfig.Name = "btnConfig";
            this.btnConfig.Primary = false;
            this.btnConfig.Size = new System.Drawing.Size(102, 36);
            this.btnConfig.TabIndex = 12;
            this.btnConfig.Text = "Konfigurime";
            this.btnConfig.UseVisualStyleBackColor = true;
            this.btnConfig.Click += new System.EventHandler(this.btnConfig_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 400);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtusername;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtpassword;
        private MaterialSkin.Controls.MaterialFlatButton btnexit;
        private MaterialSkin.Controls.MaterialFlatButton btnlogin;
        private System.Windows.Forms.Panel panel1;
        private MaterialSkin.Controls.MaterialFlatButton btnConfig;
    }
}

