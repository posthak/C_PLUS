Console.Clear(); 
Console.Write("Введите день недели цифрой: ");
int s = Convert.ToInt32(Console.ReadLine());

if(s == 6 || s == 7) Console.Write($"{s} -> да");  
else
{
    Console.WriteLine($"{s} -> нет");  
}