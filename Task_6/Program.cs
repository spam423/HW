/* Напишите программу, которая на вход принимает число и выдаёт, 
является ли число чётным (делится ли оно на два без остатка).
4 -> да
-3 -> нет
7 -> нет*/

int number;
int sum;

Console.WriteLine("Enter number");
number = Convert.ToInt32(Console.ReadLine());

sum = number % 2;

if (sum == 0)
{
    Console.WriteLine("yes");
}
else
{
    Console.WriteLine("no");
}
