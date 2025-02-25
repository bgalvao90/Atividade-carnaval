Console.Write("Digite o número de horas trabalhadas no mês: ");
double horasTrabalhadasMes = double.Parse(Console.ReadLine());

Console.Write("Digite o seu salário por hora: ");
double salarioHora = double.Parse(Console.ReadLine());



if (horasTrabalhadasMes > 160) {

    double salarioMes = (salarioHora * 160);
    double horasExtra = (horasTrabalhadasMes - 160);
    double valorHorasExtra = (horasExtra * 0.5);
    double salarioTotal = (salarioMes + valorHorasExtra);
    Console.WriteLine($"O salario total é: {salarioTotal}");


}



