// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным.
Console.Write("Введите число: ");
double a = double.Parse(Console.ReadLine());
if (a % 2 == 0)
{
    Console.Write("Число ");
    Console.Write(a);
    Console.Write(" является чётным");
}
else
{
    Console.Write("Число ");
    Console.Write(a);
    Console.Write(" не является чётным");
}