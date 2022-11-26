// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30
Console.Clear();

Console.Write("Введите M: ");
int m = int.Parse(Console.ReadLine());
Console.Write("Введите N: ");
int n = int.Parse(Console.ReadLine());

Console.Write($"M = {m}; N = {n} -> ");
Console.WriteLine(PrintNumbers(m, n));

int PrintNumbers(int start, int end)
{
    if (start > end) return 0;
    return start + PrintNumbers(start + 1, end);
}