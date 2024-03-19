namespace CP1.Net.Models
{
    public class Pessoa
    {
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Nacionalidade { get; set; }
        internal string CPF { get; set; }
    }
}
