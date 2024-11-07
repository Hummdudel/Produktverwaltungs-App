using System.ComponentModel;

namespace ProduktverwaltungApp
{
    partial class UCProducts
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.DGVProducts = new System.Windows.Forms.DataGridView();
            this.buttonShowProducts = new System.Windows.Forms.Button();
            this.buttonCreateProduct = new System.Windows.Forms.Button();
            this.textBoxArtikelnummer = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxProduktname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxPreis = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxBeschreibung = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxAnzahl = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonUpdateProduct = new System.Windows.Forms.Button();
            this.buttonDeleteProduct = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGVProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(0, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Produkte und so";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DGVProducts
            // 
            this.DGVProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVProducts.Location = new System.Drawing.Point(0, 59);
            this.DGVProducts.Name = "DGVProducts";
            this.DGVProducts.Size = new System.Drawing.Size(700, 222);
            this.DGVProducts.TabIndex = 1;
            this.DGVProducts.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVProducts_CellContentClick);
            // 
            // buttonShowProducts
            // 
            this.buttonShowProducts.BackgroundImage = global::ProduktverwaltungApp.Properties.Resources.icons8_database_backup_96;
            this.buttonShowProducts.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonShowProducts.Location = new System.Drawing.Point(151, 5);
            this.buttonShowProducts.Name = "buttonShowProducts";
            this.buttonShowProducts.Size = new System.Drawing.Size(51, 50);
            this.buttonShowProducts.TabIndex = 2;
            this.buttonShowProducts.UseVisualStyleBackColor = true;
            this.buttonShowProducts.Click += new System.EventHandler(this.buttonShowProducts_Click);
            // 
            // buttonCreateProduct
            // 
            this.buttonCreateProduct.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonCreateProduct.Location = new System.Drawing.Point(3, 362);
            this.buttonCreateProduct.Name = "buttonCreateProduct";
            this.buttonCreateProduct.Size = new System.Drawing.Size(63, 50);
            this.buttonCreateProduct.TabIndex = 3;
            this.buttonCreateProduct.Text = "Neues Produkt";
            this.buttonCreateProduct.UseVisualStyleBackColor = true;
            this.buttonCreateProduct.Click += new System.EventHandler(this.buttonCreateProduct_Click);
            // 
            // textBoxArtikelnummer
            // 
            this.textBoxArtikelnummer.Location = new System.Drawing.Point(0, 320);
            this.textBoxArtikelnummer.Name = "textBoxArtikelnummer";
            this.textBoxArtikelnummer.Size = new System.Drawing.Size(68, 20);
            this.textBoxArtikelnummer.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(0, 298);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 19);
            this.label2.TabIndex = 5;
            this.label2.Text = "Artikelnummer";
            // 
            // textBoxProduktname
            // 
            this.textBoxProduktname.Location = new System.Drawing.Point(74, 320);
            this.textBoxProduktname.Name = "textBoxProduktname";
            this.textBoxProduktname.Size = new System.Drawing.Size(145, 20);
            this.textBoxProduktname.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(74, 298);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 19);
            this.label3.TabIndex = 7;
            this.label3.Text = "Produktname";
            // 
            // textBoxPreis
            // 
            this.textBoxPreis.Location = new System.Drawing.Point(225, 320);
            this.textBoxPreis.Name = "textBoxPreis";
            this.textBoxPreis.Size = new System.Drawing.Size(63, 20);
            this.textBoxPreis.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(225, 298);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 19);
            this.label4.TabIndex = 9;
            this.label4.Text = "Preis";
            // 
            // textBoxBeschreibung
            // 
            this.textBoxBeschreibung.Location = new System.Drawing.Point(294, 320);
            this.textBoxBeschreibung.Name = "textBoxBeschreibung";
            this.textBoxBeschreibung.Size = new System.Drawing.Size(348, 20);
            this.textBoxBeschreibung.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(294, 298);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 19);
            this.label5.TabIndex = 11;
            this.label5.Text = "Beschreibung";
            // 
            // textBoxAnzahl
            // 
            this.textBoxAnzahl.Location = new System.Drawing.Point(648, 320);
            this.textBoxAnzahl.Name = "textBoxAnzahl";
            this.textBoxAnzahl.Size = new System.Drawing.Size(52, 20);
            this.textBoxAnzahl.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(648, 298);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 19);
            this.label6.TabIndex = 13;
            this.label6.Text = "Anzahl";
            // 
            // buttonUpdateProduct
            // 
            this.buttonUpdateProduct.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonUpdateProduct.Location = new System.Drawing.Point(91, 362);
            this.buttonUpdateProduct.Name = "buttonUpdateProduct";
            this.buttonUpdateProduct.Size = new System.Drawing.Size(63, 50);
            this.buttonUpdateProduct.TabIndex = 15;
            this.buttonUpdateProduct.Text = "Produkt ändern";
            this.buttonUpdateProduct.UseVisualStyleBackColor = true;
            this.buttonUpdateProduct.Click += new System.EventHandler(this.buttonUpdateProduct_Click);
            // 
            // buttonDeleteProduct
            // 
            this.buttonDeleteProduct.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonDeleteProduct.Location = new System.Drawing.Point(183, 362);
            this.buttonDeleteProduct.Name = "buttonDeleteProduct";
            this.buttonDeleteProduct.Size = new System.Drawing.Size(63, 50);
            this.buttonDeleteProduct.TabIndex = 16;
            this.buttonDeleteProduct.Text = "Produkt löschen";
            this.buttonDeleteProduct.UseVisualStyleBackColor = true;
            this.buttonDeleteProduct.Click += new System.EventHandler(this.buttonDeleteProduct_Click);
            // 
            // UCProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.buttonDeleteProduct);
            this.Controls.Add(this.buttonUpdateProduct);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxAnzahl);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxBeschreibung);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxPreis);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxProduktname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxArtikelnummer);
            this.Controls.Add(this.buttonCreateProduct);
            this.Controls.Add(this.buttonShowProducts);
            this.Controls.Add(this.DGVProducts);
            this.Controls.Add(this.label1);
            this.Name = "UCProducts";
            this.Size = new System.Drawing.Size(700, 430);
            ((System.ComponentModel.ISupportInitialize)(this.DGVProducts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.TextBox textBoxArtikelnummer;
        private System.Windows.Forms.TextBox textBoxProduktname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxPreis;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxBeschreibung;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonCreateProduct;
        private System.Windows.Forms.Button buttonUpdateProduct;

        private System.Windows.Forms.Label label2;

        private System.Windows.Forms.TextBox textBoxAnzahl;

        private System.Windows.Forms.Button buttonDeleteProduct;

        private System.Windows.Forms.Button buttonShowProducts;

        private System.Windows.Forms.DataGridView DGVProducts;

        private System.Windows.Forms.Label label1;

        #endregion
    }
}