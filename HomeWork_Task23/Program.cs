// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел 
Console.Clear(); 

Console.Write("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());
calculatePow(N);

void calculatePow(int N) {
int count = 1;
Console.Write($"{N} -> ");
while (count <= N)
{
    double numPower = Math.Pow(count,3);
    Console.Write($"{numPower} ");
    count+=1;
}
}