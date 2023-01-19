// Задача 1: Напишите программу, которая на вход принимает два числа 
//и выдаёт, какое число большее, а какое меньшее.
System.Console.WriteLine("Введите первое число> ");
int firstNumer = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите второе число> ");
int secondNumber = Convert.ToInt32(Console.ReadLine());
 
if(firstNumer > secondNumber)
{
  System.Console.WriteLine(firstNumer + " Большее, а " + secondNumber + " Меньшее"  );
}
else
{
  System.Console.WriteLine(secondNumber + " Большее, а " + firstNumer + " Меньшее");
}