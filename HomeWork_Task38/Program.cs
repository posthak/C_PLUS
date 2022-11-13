// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

Console.Clear();

int arrayLength = 5;
double[] collection = { 3.2, 7.8, 22.33, 2.65, 78.1 };

Console.WriteLine($"[{String.Join(", ", collection)}] -> {FindDiffMinMax(collection, arrayLength)}");

double FindDiffMinMax(double[] collection, int len)
{
    double min = collection[0];
    double max = collection[0];
    for (int count = 0; count < len; count++)
    {
        if (min > collection[count]) min = collection[count];
        else if (max < collection[count]) max = collection[count];
    }
    return Math.Round(max - min, 2);
}