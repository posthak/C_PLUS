
Console.Write("Введите число а: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число b: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число c: ");
int c = Convert.ToInt32(Console.ReadLine());

int max = b;

if (a > max) max = a;
if (c > max) max = c;

Console.Write("Максимальное значение: ");
Console.WriteLine(max);

