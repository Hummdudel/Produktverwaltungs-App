using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;

namespace ProduktverwaltungApp
{
    public partial class MainForm : MaterialForm
    {
        // Singleton
        public static MainForm instance;
        
        private readonly MaterialSkinManager materialSkinManager;
        
        public MainForm()
        {
            InitializeComponent();

            instance = this;
            
            /*materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.EnforceBackcolorOnAllComponents = true;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Indigo500,
                Primary.Indigo700,
                Primary.Indigo100, 
                Accent.Pink200, 
                TextShade.WHITE);*/
        }

        public Panel PanelContainer
        {
            get { return panelContainer; }
            set { panelContainer = value; }
        }

        private void buttonHome_Click(object sender, EventArgs e)
        {
            panelContainer.Controls.Clear();
            UCHome ucHome = new UCHome();
            ucHome.Dock = DockStyle.Fill;
            panelContainer.Controls.Add(ucHome);
        }

        private void buttonAbout_Click(object sender, EventArgs e)
        {
            panelContainer.Controls.Clear();
            UCAbout ucAbout = new UCAbout();
            ucAbout.Dock = DockStyle.Fill;
            panelContainer.Controls.Add(ucAbout);
        }

        private void buttonProducts_Click(object sender, EventArgs e)
        {
            panelContainer.Controls.Clear();
            UCProducts ucProducts = new UCProducts();
            ucProducts.Dock = DockStyle.Fill;
            panelContainer.Controls.Add(ucProducts);
        }
    }
}