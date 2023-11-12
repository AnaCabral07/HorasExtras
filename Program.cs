// Console.WriteLine("Hello, World!");

Console.WriteLine("--- Horas Extras ---\n");

Console.WriteLine($"Salário por hora {15:C}, {300} horas, sendo {0,2} horas extra, salário = {Salario(15, 300, 0):C}");
Console.WriteLine($"Salário por hora {20:C}, {350} horas, sendo {20} horas extras, salário = {Salario(20, 350, 20):C}");
Console.WriteLine($"Salário por hora {25:C}, {400} horas, sendo {0,2} horas-extra, salário = {Salario(25, 400, 0):C}");
Console.WriteLine($"Salário por hora {30:C}, {450} horas, sendo {20} horas extras, salário = {Salario(30, 450, 20):C}");

double Salario(double salarioHora, double horasTotais, double horasExtras)
{
    return (salarioHora * (horasTotais - horasExtras)) + (salarioHora * horasExtras * 1.4);
}


