// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2
Console.Clear();

int arrayLength = new Random().Next(4, 10);
int[] collection = new int[arrayLength];
int arrayMin = 99;
int arrayMax = 1000;

int[] col = fillArray(collection, arrayMax, arrayMin, arrayLength);
Console.WriteLine($"[{String.Join(", ", col)}] -> {QuantityEven(col, arrayLength)}");

int[] fillArray(int[] collection, int max, int min, int len)
{
    for (int count = 0; count < len; count++)
    {
        collection[count] = new Random().Next(min, max);
    }
    return collection;
}

int QuantityEven(int[] collection, int len)
{
    int quant = 0;
    for (int count = 0; count < len; count++)
    {
        if (collection[count] % 2 == 0) quant++;
    }
    return quant;
}