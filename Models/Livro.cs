namespace CP1.Net.Models
{
    public class Livro
    {
        public string Titulo { get; set; }
        public Autor Autor { get; set; }
        public decimal Preco { get; set; }
        public int QuantidadeDisponivel { get; set; }

        public override string ToString()
        {
            return $"Título: {Titulo}, Autor: {Autor.Nome}, Preço: {Preco:C}";
        }

        private string isbn;
        public string ISBN
        {
            get { return isbn; }
            set
            {
                if (value != null && value.Length == 13)
                {
                    isbn = value;
                }
                else
                {
                    throw new ArgumentException("ISBN deve ter 13 caracteres.");
                }
            }
        }
        protected virtual decimal CalcularDesconto(decimal preco)
        {
            decimal desconto = preco * 0.1m;
            decimal precoComDesconto = preco - desconto;
            return precoComDesconto;
        }
    }
}

        
