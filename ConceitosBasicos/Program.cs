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

       var calculadoraimc = new calculadoraimc();
        Console.WriteLine($"O seu IMC calculado foi:{calculadoraimc.Calcular(peso, altura)}");
        Console.WriteLine(calculadoraimc.statusIMC(calculadoraimc.Calcular(peso, altura)));

        saida = false;
    }
    catch (FormatException e)
    {
        Console.WriteLine("informe apenas numeros");
        Console.WriteLine(e.Message);
    }
}while (saida);