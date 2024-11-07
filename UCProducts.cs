using System;
using System.Data;
using System.Windows.Forms;
using MySqlConnector;

namespace ProduktverwaltungApp
{
    public partial class UCProducts : UserControl
    {
        private string dBConnectionString =
            "datasource=127.0.0.1;port=3306;username=root;password=;database=onlineshoptest";
        private MySqlConnection dBConnection = null;
        private MySqlCommand command = null;

        private DataSet dataset;
        private MySqlDataAdapter adapter;

        private Produkt produkt = new Produkt();
        
        public UCProducts()
        {
            InitializeComponent();
            DBConnect();
        }

        public void DBConnect()
        {
            try
            {
                dBConnection = new MySqlConnection(dBConnectionString);
                dBConnection.Open();

                ReadProducts();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                // dBConnection.Close();
            }
        }

        public void ReadProducts()
        {
            string sql = "CALL Read_All_Produkte();";
            
            try
            {
                command = new MySqlCommand(sql, dBConnection);
                adapter = new MySqlDataAdapter(command);
                dataset = new DataSet();
                adapter.Fill(dataset);

                DGVProducts.DataSource = dataset.Tables[0];
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public void CreateProduct(Produkt produkt)
        {
            string sql = "CALL Insert_Produkt(@artikelnummer, @produktname, @preis, @beschreibung, @anzahl);";

            try
            {
                command = new MySqlCommand(sql, dBConnection);
                command.Parameters.AddWithValue("@artikelnummer", produkt.Artikelnummer);
                command.Parameters.AddWithValue("@produktname", produkt.Produktname);
                command.Parameters.AddWithValue("@preis", produkt.Preis);
                command.Parameters.AddWithValue("@beschreibung", produkt.Beschreibung);
                command.Parameters.AddWithValue("@anzahl", produkt.Anzahl);

                command.ExecuteNonQuery();
                MessageBox.Show($"Das Produkt {produkt.Produktname} wurde erfolgreich angelegt.");
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        
        private void buttonShowProducts_Click(object sender, EventArgs e)
        {
            ReadProducts();
        }

        public void UpdateProduct(Produkt produkt)
        {
            string sql = "CALL Update_Produkt(@id, @artikelnummer, @produktname, @preis, @beschreibung, @anzahl);";
            
            try
            {
                command = new MySqlCommand(sql, dBConnection);
                command.Parameters.AddWithValue("@id", produkt.Id);
                command.Parameters.AddWithValue("@artikelnummer", produkt.Artikelnummer);
                command.Parameters.AddWithValue("@produktname", produkt.Produktname);
                command.Parameters.AddWithValue("@preis", produkt.Preis);
                command.Parameters.AddWithValue("@beschreibung", produkt.Beschreibung);
                command.Parameters.AddWithValue("@anzahl", produkt.Anzahl);

                command.ExecuteNonQuery();
                MessageBox.Show($"Das Produkt {produkt.Produktname} wurde erfolgreich geändert.");
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public void DeleteProduct(Produkt produkt)
        {
            string sql = "CALL Delete_Produkt(@id);";

            try
            {
                command = new MySqlCommand(sql, dBConnection);
                command.Parameters.AddWithValue("@id", produkt.Id);

                command.ExecuteNonQuery();
                MessageBox.Show($"Das Produkt {produkt.Produktname} wurde erfolgreich gelöscht.");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        private void DGVProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            produkt.Id = Convert.ToInt32(DGVProducts.CurrentRow.Cells["id"].Value);
            
            string artikelnummer = DGVProducts.CurrentRow.Cells["artikelnummer"].Value.ToString();
            textBoxArtikelnummer.Text = artikelnummer;
            string produktname = DGVProducts.CurrentRow.Cells["produktname"].Value.ToString();
            textBoxProduktname.Text = produktname;
            string preis = DGVProducts.CurrentRow.Cells["preis"].Value.ToString();
            textBoxPreis.Text = preis;
            string beschreibung = DGVProducts.CurrentRow.Cells["beschreibung"].Value.ToString();
            textBoxBeschreibung.Text = beschreibung;
            string anzahl = DGVProducts.CurrentRow.Cells["anzahl"].Value.ToString();
            textBoxAnzahl.Text = anzahl;
        }

        private void buttonCreateProduct_Click(object sender, EventArgs e)
        {
            produkt.Anzahl = Convert.ToInt32(textBoxArtikelnummer.Text);
            produkt.Artikelnummer = Convert.ToInt32(textBoxArtikelnummer.Text);
            produkt.Produktname = textBoxProduktname.Text;
            produkt.Preis = Convert.ToDecimal(textBoxPreis.Text);
            produkt.Beschreibung = textBoxBeschreibung.Text;
            produkt.Anzahl = Convert.ToInt32(textBoxAnzahl.Text);
            
            CreateProduct(produkt);
            ReadProducts();
        }
        
        private void buttonUpdateProduct_Click(object sender, EventArgs e)
        {
            produkt.Artikelnummer = Convert.ToInt32(textBoxArtikelnummer.Text);
            produkt.Produktname = textBoxProduktname.Text;
            produkt.Preis = Convert.ToDecimal(textBoxPreis.Text);
            produkt.Beschreibung = textBoxBeschreibung.Text;
            produkt.Anzahl = Convert.ToInt32(textBoxAnzahl.Text);
            
            UpdateProduct(produkt);
            ReadProducts();
        }

        private void buttonDeleteProduct_Click(object sender, EventArgs e)
        {
            produkt.Produktname = textBoxProduktname.Text;
            
            DeleteProduct(produkt);
            ReadProducts();
        }
    }
}