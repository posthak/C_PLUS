// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
// Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

Console.Clear();

Console.Write("Введите N: ");
int n = int.Parse(Console.ReadLine());

Console.Write($"N = {n} -> ");
Console.Write("\"");

PrintNumbers(1, n);

Console.Write("\"");
void PrintNumbers(int start, int end)
{
    Console.Write($"{end}");
    if (start == end) return;
    Console.Write(", ");
    PrintNumbers(start, end - 1);
}