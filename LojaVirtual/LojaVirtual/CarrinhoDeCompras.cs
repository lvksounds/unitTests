namespace LojaVirtual
{
    public class CarrinhoDeCompras
    {
        public List<Produto> produtos = new List<Produto>();
        public void Adiciona (Produto produto)
        {
            produtos.Add(produto);
        }
    }
}