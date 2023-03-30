using FS11_ProjetoTestes;

namespace TesteMsTest
{
    [TestClass]
    public class TesteCalculadoraIMC
    {
        [TestMethod]
        public void TestMethod1()
        {
            //3A

            //Arrange - Prepara��o
            double pNum = 2;
            double sNum = 1;
            double rNum = 3;

            //Act - A��o
            var resultado = CalculadoraIMC.Somar(pNum, sNum);


            //Assert - Verifica��es
            Assert.AreEqual(resultado, rNum);
        }

        [DataTestMethod]
        [DataRow(2, 1, 3)]
        [DataRow(2, 2, 4)]
        [DataRow(2, 5, 7)]

        public void TesteSomarDoisNumeros(double pNum, double sNum, double rNum)
        {
            //Act - A��o
            var resultado = CalculadoraIMC.Somar(pNum, sNum);


            //Assert - Verifica��es
            Assert.AreEqual(resultado, rNum);
        }
    }
}