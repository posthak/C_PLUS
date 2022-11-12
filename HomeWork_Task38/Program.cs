// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

Console.Clear();

int ArrayLength = 5;
double[] Collection = { 3.2, 7.8, 22.33, 2.65, 78.1 };

Console.WriteLine($"[{String.Join(", ", Collection)}] -> {FindDiffMinMax(Collection, ArrayLength)}");

double FindDiffMinMax(double[] Collection, int len)
{
    double min = Collection[0];
    double max = Collection[0];
    for (int count = 0; count < len; count++)
    {
        if (min > Collection[count]) min = Collection[count];
        if (max < Collection[count]) max = Collection[count];
    }
    return Math.Round(max - min, 2);
}