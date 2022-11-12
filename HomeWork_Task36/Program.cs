// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

Console.Clear();

int ArrayLength = new Random().Next(4, 10);
int[] Collection = new int[ArrayLength];
int ArrayMin = -10;
int ArrayMax = 100;

int[] col = fillArray(Collection, ArrayMax, ArrayMin, ArrayLength);
Console.WriteLine($"[{String.Join(", ", col)}] -> {SumOdd(col, ArrayLength)}");

int[] fillArray(int[] Collection, int max, int min, int len)
{
    for (int count = 0; count < len; count++)
    {
        Collection[count] = new Random().Next(min, max);
    }
    return Collection;
}

int SumOdd(int[] Collection, int len)
{
    int sum = 0;
    for (int count = 0; count < len; count++)
    {
        if (count % 2 != 0) sum += Collection[count];
    }
    return sum;
}