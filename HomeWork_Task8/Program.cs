
Console.Write("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());
int count = 2;
String s = "";

while (count <= N)
{
    int reminder;
    int res = Math.DivRem(count, 2, out reminder);
    if (count > 2) s = s + ",";
    if (reminder == 0) 
    {
        s = s + Convert.ToString(count);
    }
    count = count + 2;
}
Console.Write(N);
Console.Write(" -> ");
Console.WriteLine(s);

