Console.Write("Digite o valor do salário-hora (R$)..............: ");
double salarioHora = Convert.ToDouble(Console.ReadLine());
 
Console.Write("Digite o total de horas trabalhadas...............: ");
double horasTrabalhadas = Convert.ToDouble(Console.ReadLine());
 
Console.Write("Digite o número de horas extras....................: ");
double horasExtras = Convert.ToDouble(Console.ReadLine());
 
double salarioFinal = CalcularSalario(salarioHora, horasTrabalhadas, horasExtras);
 
Console.WriteLine();
Console.WriteLine($"Salário total a receber: R$ {salarioFinal:F2}");
 
double CalcularSalario(double valorHora, double horasNormais, double horasExtras)
{
    double salarioBase = valorHora * horasNormais;
    double valorHoraExtra = valorHora * 1.4;
    double salarioExtras = valorHoraExtra * horasExtras;
 
    return salarioBase + salarioExtras;
}