/*Напишите программу, которая принимает на вход 
три числа и выдаёт максимальное из этих чисел.
2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22*/

int numberA, numberB, numberC;

Console.WriteLine("first number");
numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("second number");
numberB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("third number");
numberC = Convert.ToInt32(Console.ReadLine());

int max = numberA;

if (numberA > max) max = numberA;
if (numberB > max) max = numberB;
if (numberC > max) max = numberC;

Console.Write("max = ");
Console.WriteLine(max);