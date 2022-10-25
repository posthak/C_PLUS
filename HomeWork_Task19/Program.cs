// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
Console.Clear(); 

Console.Write("Введите 5-ти значную цифру: ");
int num = Convert.ToInt32(Console.ReadLine());
CheckPalindrome(num);

void CheckPalindrome(int num) {
int leftTwoDigits = num / 1000;
int rightTwoDigits = num % 100;

rightTwoDigits = rightTwoDigits % 10 * 10 + rightTwoDigits / 10;

if (leftTwoDigits == rightTwoDigits) Console.WriteLine($"{num} -> да");
else
{
    Console.WriteLine($"{num} -> нет");
}
}

