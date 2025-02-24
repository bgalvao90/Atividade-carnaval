using System.ComponentModel.Design;
using System.Reflection.PortableExecutable;
Console.Write("Digite o seu sexo: ");
string sexo = Console.ReadLine().ToUpper();

do {
    



    if (sexo == "M" || sexo == "F") {

        

        if (sexo == "M")
        {
            Console.Write("Digite a sua altura: ");
            double altura = double.Parse(Console.ReadLine());
            double pesoIdeal = ((72.7 * altura) - 58);
            Console.WriteLine($"Seu peso ideal seria: {pesoIdeal.ToString("F2")}");
            return;
        }
        else
        {
            Console.Write("Digite a sua altura: ");
            double altura = double.Parse(Console.ReadLine());
            double pesoIdeal = ((62.1 * altura) - 44.7);
            Console.WriteLine($"Seu peso ideal seria: {pesoIdeal.ToString("F2")}");
            return;
        }

    }

    else
    {
        Console.WriteLine("Sigla invalida, Digite M para masculino ou F para Feminino ou S para Sair");
        Console.Write("Digite o seu sexo: ");
         sexo = Console.ReadLine().ToUpper();
    }
} while (sexo != "S");