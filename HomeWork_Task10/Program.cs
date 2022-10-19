Console.Clear(); 
Console.Write("Введите трехзначное число: ");
int s = Convert.ToInt32(Console.ReadLine());

Console.Write($"{s} -> {s/10%10}");