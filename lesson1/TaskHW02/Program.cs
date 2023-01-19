// Задача 2: Напишите программу, которая принимает на вход три числа 
//и выдаёт максимальное из этих чисел.
System.Console.WriteLine(" Введите первое число > ");
int firstNumber = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine(" Введите второе число > ");
int secondNumber = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine(" Введите третье число > ");
int thirdNumber = Convert.ToInt32(Console.ReadLine());
if(firstNumber > secondNumber && firstNumber > thirdNumber)
{
  System.Console.WriteLine(" Максимальное число = " + firstNumber);
}
else if(secondNumber > firstNumber && secondNumber > thirdNumber)
{
  System.Console.WriteLine(" Максимальное число = " + secondNumber);
}
else 
{
  System.Console.WriteLine(" Максимальное число = " + thirdNumber);
}