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