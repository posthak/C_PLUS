

Console.Write("Введите число, чтобы проверить четное оно или нет: ");
int a = Convert.ToInt32(Console.ReadLine());
int reminder;
int res = Math.DivRem(a, 2, out reminder);

if (reminder == 0) 
{
    Console.Write("Число является четным");
}
else
{
    Console.Write("Число является нечетным");
}