
Console.Write("Введите число а: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число b: ");
int b = Convert.ToInt32(Console.ReadLine());

int max = b;
int min = a;

if (a > max) 
{
    max = a;
    min = b;
}
Console.Write("Максимальное значение: ");
Console.WriteLine(max);
Console.Write("Минимальное значение: ");
Console.WriteLine(min);

