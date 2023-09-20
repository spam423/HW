/*Напишите программу, которая на вход принимает два 
числа и выдаёт, какое число большее, а какое меньшее.
a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3*/

int numberA, numberB;

Console.WriteLine("first number");
numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("second number");
numberB = Convert.ToInt32(Console.ReadLine());

if (numberA < numberB)
{
    Console.WriteLine("max");
    Console.WriteLine(numberB);
    Console.WriteLine("min");
    Console.WriteLine(numberA);
}

else
{
    Console.WriteLine("max");
    Console.WriteLine(numberA);
    Console.WriteLine("min");
    Console.WriteLine(numberB);
}

//Почему-то .gitignore не хочет "игнорировать" файлы в Task_2