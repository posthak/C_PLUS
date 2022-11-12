// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2
Console.Clear();

int ArrayLength = new Random().Next(4, 10);
int[] Collection = new int[ArrayLength];
int ArrayMin = 99;
int ArrayMax = 1000;

int[] col = fillArray(Collection, ArrayMax, ArrayMin, ArrayLength);
Console.WriteLine($"[{String.Join(", ", col)}] -> {QuantityEven(col, ArrayLength)}");

int[] fillArray(int[] Collection, int max, int min, int len)
{
    for (int count = 0; count < len; count++)
    {
        Collection[count] = new Random().Next(min, max);
    }
    return Collection;
}

int QuantityEven(int[] Collection, int len)
{
    int quant = 0;
    for (int count = 0; count < len; count++)
    {
        if (Collection[count] % 2 == 0) quant++;
    }
    return quant;
}