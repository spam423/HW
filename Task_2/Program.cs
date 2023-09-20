/*Напишите программу, которая на вход принимает два 
числа и выдаёт, какое число большее, а какое меньшее.
a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3*/

int numberA, numberB;

Console.WriteLine("Введите первое число");
numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
numberB = Convert.ToInt32(Console.ReadLine());

if (numberA < numberB)
{
    Console.WriteLine(numberB);
}

else
{
    Console.WriteLine(numberA);
}