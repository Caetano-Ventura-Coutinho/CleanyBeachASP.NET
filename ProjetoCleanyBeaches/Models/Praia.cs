namespace ProjetoCleanyBeaches.Models
{
    public class Praia
    {
        public string Nome { get; set; }
        public int id { get; set; }
        public string img {  get; set; }

        public string condicao { get; set; }

        public string rota { get; set; }

        public string linkMaps { get; set; }

        public Municipio municipio { get; set; }

        
    }
}
