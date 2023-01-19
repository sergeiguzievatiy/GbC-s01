// See https://aka.ms/new-console-template for more information
Console.Write("Введите первое число > ");
int firstNumber = Convert.ToInt32(Console.ReadLine()); 
Console.Write("Введите второе число > ");
int secondNumber = Convert.ToInt32(Console.ReadLine());
if (firstNumber * firstNumber == secondNumber)
{
Console.WriteLine($"Первое число {firstNumber} является квадратом второго числа {secondNumber}");
}
else
{
  Console.WriteLine($"Первое число {firstNumber} не является квадратом второго числа {secondNumber}");
}
// ghjvth
  