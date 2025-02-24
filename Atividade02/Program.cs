using System.Reflection.PortableExecutable;

Console.Write("Digite o seu sexo: ");
string sexo  = Console.ReadLine().ToUpper();


Console.Write("Digite a sua altura");
double altura = double.Parse(Console.ReadLine());

if (sexo == "M")
{
    double pesoIdeal = ((72.7 * altura) - 58);
    Console.WriteLine($"Seu peso ideal seria:{pesoIdeal}");
    if (sexo == "F")
    {
        pesoIdeal = ((62.1 * altura) - 44.7);
        Console.WriteLine($"Seu peso ideal seria:{pesoIdeal}");
    }
    
}
else
{
    Console.WriteLine("Sigla invalida, Digite M para masculino ou F para Feminino");
}