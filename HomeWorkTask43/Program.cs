// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.Clear();
double k1 = 5, k2 = 9, b1 = 2, b2 = 4;
FindCrossedLinesPoint(k1, k2, b1, b2);

void FindCrossedLinesPoint(double pk1, double pk2, double pb1, double pb2)
{
    double x, y;
    if ((pk1 == pk2) && (pb1 == pb2))
        Console.WriteLine("Прямые совпадают");
    else if (pk1 == pk2)
        Console.WriteLine("Прямые параллельны");
    else
    {
        x = (pb2 - pb1) / (pk1 - pk2);
        y = (pk1 * x) + pb1;
        Console.WriteLine($"b1 = {pb1},k1 = {pk1}, b2 = {pb2}, k2 = {pk2} -> ({x}; {y})");
    }
}

