namespace LojaVirtual.Tests
{
    [TestFixture]
    public class TestaMaiorEMenor
    {
       [Test]
        public void OrdemDecrescente()
        {
            CarrinhoDeCompras carrinho = new CarrinhoDeCompras();
            carrinho.Adiciona(new Produto("Geladeira", 450.0));
            carrinho.Adiciona(new Produto("Liquidificador", 250.00));
            carrinho.Adiciona(new Produto("Jogo de Pratos", 70.0));

            MaiorEMenor algoritmo = new MaiorEMenor();
            algoritmo.Encontra(carrinho);

            Assert.AreEqual("Jogo de Pratos", algoritmo.Menor.Nome);
            Assert.AreEqual("Geladeira", algoritmo.Maior.Nome);

        }
    }
}