using ConceitosBasicos;

namespace TesteConceitosBasicos
{
    [TestClass]
    public class calculadoraIMCTeste
    {
        [TestMethod]
        public void calcularteste()
        {
            //cenario 
            float peso = 70f;
            float altura = 1.7f;
            calculadoraimc calculadora = new calculadoraimc();

            //a��o

            float imc = calculadora.Calcular(peso, altura); 

            //verifica��o
        }
    }
}