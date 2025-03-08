int [] juizes = new int[7];
double maior = 0;
double menor = 10;
List<double> notalista = new List<double>();
for (int i = 0; i < 6; i++)
{
    Console.WriteLine("Digite uma nota de 1 a 10:");
    double nota = double.Parse(Console.ReadLine());
    notalista.Add(nota);

    if (nota > maior)
    {
        maior = nota;
    }
    if (nota < menor)
    {
        menor = nota;
    }
   
    
}
notalista.Remove(maior);
notalista.Remove(menor);
double soma = notalista.Sum();
Console.WriteLine($"A soma das notas e {soma}");