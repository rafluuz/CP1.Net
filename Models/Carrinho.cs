namespace CP1.Net.Models
{
    public class Carrinho
    {
        public List<Livro> Livros { get; } = new List<Livro>();

        public void AdicionarLivro(Livro livro)
        {
            Livros.Add(livro);
        }

        public void LimparCarrinho()
        {
            Livros.Clear();
        }

        public decimal CalcularTotal()
        {
            decimal total = 0;
            foreach (var livro in Livros)
            {
                total += livro.Preco;
            }
            return total;
        }
    }
}

