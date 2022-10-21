//показать третью цифру или написать, что нет третьей цифры
Console.Clear(); 
int num = new Random().Next(-10000,10000);
int tempNum = Math.Abs(num);
if (tempNum < 100)
    Console.Write($"{num} -> третьей цифры нет");
else
{
    while (tempNum > 999)
    {
        tempNum/=10;
    }
    int thirdDigit = tempNum % 10;
    Console.Write($"{num} -> {thirdDigit}"); 
}
