namespace ProjAl
{
    partial class loading
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(loading));
            this.loadgif = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.loadgif)).BeginInit();
            this.SuspendLayout();
            // 
            // loadgif
            // 
            this.loadgif.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.loadgif.Image = ((System.Drawing.Image)(resources.GetObject("loadgif.Image")));
            this.loadgif.InitialImage = ((System.Drawing.Image)(resources.GetObject("loadgif.InitialImage")));
            this.loadgif.Location = new System.Drawing.Point(28, 33);
            this.loadgif.Name = "loadgif";
            this.loadgif.Size = new System.Drawing.Size(188, 185);
            this.loadgif.TabIndex = 0;
            this.loadgif.TabStop = false;
            // 
            // loading
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(241, 261);
            this.Controls.Add(this.loadgif);
            this.Name = "loading";
            this.Text = "loading";
            ((System.ComponentModel.ISupportInitialize)(this.loadgif)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox loadgif;
    }
}