namespace ProjetoCleanyBeaches.Models
{
    public class ONG
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Img { get; set; }
        public string Instagram { get; set; }

        public string Facebook { get; set;}

        public string Email { get; set; }

        public string Telefone { get; set; }

        public string Color { get; set; }

        public Regiao regiao { get; set; }
    }
}
