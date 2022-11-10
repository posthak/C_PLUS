// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
Console.Clear();

Console.Write("Введите число A: ");
int NumberA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число B: ");
int PowerB = Convert.ToInt32(Console.ReadLine());

getPower(NumberA, PowerB);


void getPower(int NumberA, int PowerB)
{
    int count = 1;
    int PowNumber = 1;
    if (PowerB > 0)
    {
        for (count = 1; count <= PowerB; count++)
        {
            PowNumber *= NumberA;
        }
        Console.Write($"{NumberA}, {PowerB} -> {PowNumber} ");
    }
    else
    {
        Console.Write($"Please enter number A greater than ({PowerB})!");
    }
}