// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
Console.Write("Введите число: ");
int a = int.Parse(Console.ReadLine());
int index = 2;
if (a >= 2)
{
    Console.Write(index);
    index += 2;
}
while (index <= a)
{
    Console.Write(", ");
    Console.Write(index);
    index += 2;
}