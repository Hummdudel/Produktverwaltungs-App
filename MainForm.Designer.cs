



namespace ProduktverwaltungApp
{
    partial class MainForm
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
            this.panelContainer = new System.Windows.Forms.Panel();
            this.buttonHome = new System.Windows.Forms.Button();
            this.buttonAbout = new System.Windows.Forms.Button();
            this.buttonProducts = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panelContainer
            // 
            this.panelContainer.Location = new System.Drawing.Point(95, 105);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(700, 430);
            this.panelContainer.TabIndex = 0;
            // 
            // buttonHome
            // 
            this.buttonHome.BackgroundImage = global::ProduktverwaltungApp.Properties.Resources.home;
            this.buttonHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonHome.Location = new System.Drawing.Point(6, 105);
            this.buttonHome.Name = "buttonHome";
            this.buttonHome.Size = new System.Drawing.Size(83, 68);
            this.buttonHome.TabIndex = 1;
            this.buttonHome.UseVisualStyleBackColor = true;
            this.buttonHome.Click += new System.EventHandler(this.buttonHome_Click);
            // 
            // buttonAbout
            // 
            this.buttonAbout.BackgroundImage = global::ProduktverwaltungApp.Properties.Resources.info;
            this.buttonAbout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonAbout.Location = new System.Drawing.Point(6, 467);
            this.buttonAbout.Name = "buttonAbout";
            this.buttonAbout.Size = new System.Drawing.Size(83, 68);
            this.buttonAbout.TabIndex = 2;
            this.buttonAbout.UseVisualStyleBackColor = true;
            this.buttonAbout.Click += new System.EventHandler(this.buttonAbout_Click);
            // 
            // buttonProducts
            // 
            this.buttonProducts.BackgroundImage = global::ProduktverwaltungApp.Properties.Resources.products;
            this.buttonProducts.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonProducts.Location = new System.Drawing.Point(6, 179);
            this.buttonProducts.Name = "buttonProducts";
            this.buttonProducts.Size = new System.Drawing.Size(83, 68);
            this.buttonProducts.TabIndex = 3;
            this.buttonProducts.UseVisualStyleBackColor = true;
            this.buttonProducts.Click += new System.EventHandler(this.buttonProducts_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 541);
            this.Controls.Add(this.buttonProducts);
            this.Controls.Add(this.buttonAbout);
            this.Controls.Add(this.buttonHome);
            this.Controls.Add(this.panelContainer);
            this.Name = "MainForm";
            this.Text = "Produktverwaltung";
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button buttonProducts;

        private System.Windows.Forms.Button buttonAbout;

        private System.Windows.Forms.Button buttonHome;

        private System.Windows.Forms.Panel panelContainer;

        #endregion
    }
}