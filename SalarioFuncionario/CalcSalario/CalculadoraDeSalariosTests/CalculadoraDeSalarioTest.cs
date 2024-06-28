using FuncionarioData;
namespace CalculadoraDeSalariosTests
{
    [TestFixture]
    public class CalculadoraDeSalarioTest
    {
        [Test]
        public void DeveCalcularSalarioParaDesenvolvedoresComSalarioAbaixoDoLimite()
        {
            CalculadoraDeSalario calculadora = new CalculadoraDeSalario();
            Funcionario dev = new Funcionario("Lucas", 1500.0, Cargo.DESENVOLVEDOR);

            double salario = calculadora.CalculaSalario(dev);

            Assert.AreEqual(1500.0 * 0.9, salario, 0.00001);
        }

        [Test]
        public void DeveCalcularSalarioParaDesenvolvedoresComSalarioAcimaDoLimite()
        {
            CalculadoraDeSalario calculadora = new CalculadoraDeSalario();
            Funcionario dev = new Funcionario("Lucas", 4000.0, Cargo.DESENVOLVEDOR);

            double salario = calculadora.CalculaSalario(dev);

            Assert.AreEqual(4000.0 * 0.8, salario, 0.00001);
        }

    }
}