// crie um programa para calcular o imc de uma pessoa
//imc  = peso / altura * altura
using ConceitosBasicos;

bool saida = true;
do
{
    try
    {

        Console.WriteLine("informe a altura:");

        float altura = float.Parse(Console.ReadLine());

        Console.WriteLine("informe o peso:");

        float peso = float.Parse(Console.ReadLine());

        calculadoraimc calculadoraimc = new calculadoraimc();

        calculadoraimc.Calcular(peso, altura);

        string resposta = calculadoraimc.Calcular(peso, altura);
        Console.WriteLine(resposta);

        saida = false;
       /* if (imc < 18.5)
        {
            Console.WriteLine("Peso abaixo do normal.");
        }
        else if (imc >= 18.5 && imc < 25)
        {
            Console.WriteLine("Peso normal.");
        }
        else if (imc >=25 && imc < 29.9)
        {
            Console.WriteLine("Levemente acima do peso");
        }    
        else
        {
            Console.WriteLine("Sobrepeso.");
        }*/

    }
    catch (FormatException e)
    {
        Console.WriteLine("informe apenas numeros");
        Console.WriteLine(e.Message);
    }
}while (saida);