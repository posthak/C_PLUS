
Console.Write("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());
int count = 2;
String s = "";

while (count <= N)
{
    if (count > 2) s = s + ",";
    s = s + Convert.ToString(count);
    count+=2;
}
Console.Write(N);
Console.Write(" -> ");
Console.WriteLine(s);

