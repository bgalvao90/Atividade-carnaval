int vetor = 5;
int pontos = 0;
Console.WriteLine("Digite o gabarito da loto:");
for (int i =0; i < vetor; i++)
{
    int r1 = int.Parse(Console.ReadLine());
    int r2 = int.Parse(Console.ReadLine());
    int r3 = int.Parse(Console.ReadLine());
    int r4 = int.Parse(Console.ReadLine());
    int r5 = int.Parse(Console.ReadLine());

    Console.WriteLine("Digite o 10 numeros referente a sua aposta:");
    for (int j = 0; i < 10; i++)
    {
        
        int a = int.Parse(Console.ReadLine());
        if (a == r1 || a == r2 || a == r3 || a == r4 || a == r5)
        {
            pontos += 1;
        }
    }
}
Console.WriteLine($"Voce fez {pontos} pontos");