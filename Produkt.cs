namespace ProduktverwaltungApp
{
    public class Produkt
    {
        // Attribute
        private int id;
        private int artikelnummer;
        private string produktname;
        private decimal preis;
        private string beschreibung;
        private int anzahl;

        public Produkt()
        {
        }

        public Produkt(int id, int artikelnummer, string produktname, decimal preis, string beschreibung, int anzahl)
        {
            this.id = id;
            this.artikelnummer = artikelnummer;
            this.produktname = produktname;
            this.preis = preis;
            this.beschreibung = beschreibung;
            this.anzahl = anzahl;
        }
        
        public Produkt(int artikelnummer, string produktname, decimal preis, string beschreibung, int anzahl)
        {
            this.artikelnummer = artikelnummer;
            this.produktname = produktname;
            this.preis = preis;
            this.beschreibung = beschreibung;
            this.anzahl = anzahl;
        }

        public Produkt(int id, int artikelnummer, string produktname)
        {
            this.id = id;
            this.artikelnummer = artikelnummer;
            this.produktname = produktname;
        }

        // Getter / Setter
        public int Id
        {
            get => id;
            set => id = value;
        }

        public int Artikelnummer
        {
            get => artikelnummer;
            set => artikelnummer = value;
        }

        public string Produktname
        {
            get => produktname;
            set => produktname = value;
        }

        public decimal Preis
        {
            get => preis;
            set => preis = value;
        }

        public string Beschreibung
        {
            get => beschreibung;
            set => beschreibung = value;
        }

        public int Anzahl
        {
            get => anzahl;
            set => anzahl = value;
        }
    }
}