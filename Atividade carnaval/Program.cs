Console.Write("Digite a venda média mensal: ");
double mediaMensal = double.Parse(Console.ReadLine());

Console.Write("Digite o preço atual: ");
double precoAtual = double.Parse(Console.ReadLine());



if ((mediaMensal < 500) && (precoAtual < 30)) {
    double acrescimo = 0.10;
    precoAtual = ((precoAtual * acrescimo) + precoAtual);
    Console.WriteLine($"O preço atual é: {precoAtual}");
}
else
{
    double reducao = 0.20;
    precoAtual = (precoAtual - (precoAtual * reducao));
    Console.WriteLine($"O preço atual é: {precoAtual}");
}