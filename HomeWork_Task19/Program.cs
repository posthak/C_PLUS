Console.Clear(); 

Console.Write("Введите 5-ти значную цифру: ");
int num = Convert.ToInt32(Console.ReadLine());
int leftTwoDigits = num / 1000;
int rightTwoDigits = num % 100;

rightTwoDigits = rightTwoDigits % 10 * 10 + rightTwoDigits / 10;

if (leftTwoDigits == rightTwoDigits) Console.WriteLine($"{num} -> да");
else
{
    Console.WriteLine($"{num} -> нет");
}
