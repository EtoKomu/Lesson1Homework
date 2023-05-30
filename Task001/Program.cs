Console.Write("Введите первое число: ");
int a = int.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
int b = int.Parse(Console.ReadLine());
int max = a;
if (b > a)
{
    max = b;
}
Console.Write("Наибольшее из введенных чисел: ");
Console.WriteLine(max);