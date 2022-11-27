
// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

Console.Clear();

int n = 3;
int m = 2;
Console.Write(Akkerman(n, m));

int Akkerman(int n, int m)
{
    if (n == 0) return m + 1;
    if (n != 0 && m == 0) return Akkerman(n - 1, 1);
    if (n > 0 && m > 0) return Akkerman(n - 1, Akkerman(n, m - 1));
    return Akkerman(n, m);

    //Код без рекурсии
    // if (m == 0) return n + 1;
    // else if (m == 1) return n + 2;
    // else if (m == 2) return 2 * n + 3;
    // else return Math.Pow(2, n + 3) - 3;
}