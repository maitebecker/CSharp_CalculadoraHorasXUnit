using Desafio;

string data = DateTime.Now.ToString("dd/MM/yyyy");
Calculadora calc = new Calculadora(data);

Console.WriteLine(calc.Somar("20:00", "08:00"));
Console.WriteLine(calc.Subtrair("12:00", "08:00"));
Console.WriteLine(calc.Multiplicacao("20:00", 3));
Console.WriteLine(calc.Divisao("20:00", 3));
calc.Historico().ForEach(x => Console.WriteLine($"{x} "));