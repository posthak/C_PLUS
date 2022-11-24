// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

Console.Clear();
int row = 2;
int coll = 2;
int layer = 2;

int min = 10;
int max = 100;

int[,,] collection = new int[row, coll, layer];
int[,,] baseCollection = Get3DCollection(collection, min, max);

Print3DCollection(baseCollection);

int[,,] Get3DCollection(int[,,] coll, int mn, int mx)
{
    int[] uniqNumberColl = GeUniqNumberCollection(coll.GetLength(0) * coll.GetLength(1) * coll.GetLength(2));
    int count = 0;
    for (int i = 0; i < coll.GetLength(0); i++)
    {
        for (int j = 0; j < coll.GetLength(1); j++)
        {
            for (int k = 0; k < coll.GetLength(2); k++)
            {
                coll[i, j, k] = uniqNumberColl[count];
                count++;
            }
        }
    }
    return coll;
}

void Print3DCollection(int[,,] coll)
{
    for (int k = 0; k < coll.GetLength(2); k++)
    {
        for (int i = 0; i < coll.GetLength(0); i++)
        {
            for (int j = 0; j < coll.GetLength(1); j++)
            {
                Console.Write($"{coll[i, j, k]}({i},{j},{k}) ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}

int[] GeUniqNumberCollection(int num)
{
    int[] unColl = new int[num];
    for (int i = 0; i < unColl.GetLength(0); i++)
    {
        unColl[i] = new Random().Next(10, 100);
        if (i >= 1)
        {
            for (int j = 0; j < i; j++)
            {
                while (unColl[i] == unColl[j])
                {
                    unColl[i] = new Random().Next(10, 100);
                    j = 0;
                }
            }
        }
    }
    return unColl;
}

