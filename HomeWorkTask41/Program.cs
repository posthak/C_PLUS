// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 4

Console.Clear();

Console.Write("Введите значения массива через пробел: ");
string values = Console.ReadLine();
int[] baseCollection = GetCollectionFromString(values);

Console.WriteLine($"{String.Join(", ", baseCollection)} -> {GetCountPositiveNumbers(baseCollection)}");

int[] GetCollectionFromString(string stringCollection)
{
    string[] numbers = stringCollection.Split(" ", StringSplitOptions.RemoveEmptyEntries);
    int[] result = new int[numbers.Length];

    for (int i = 0; i < numbers.Length; i++)
    {
        result[i] = int.Parse(numbers[i]);

    }
    return result;
}

int GetCountPositiveNumbers(int[] coll)
{
    int count = 0;
    for (int i = 0; i < coll.Length; i++)
    {
        if (coll[i] > 0) count++;
    }
    return count;
}