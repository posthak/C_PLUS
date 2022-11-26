// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4. 
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07
Console.Clear();
int r = 8;
int c = 8;
int[,] collection = new int[r, c];

Console.WriteLine("");
CreateSpiralCollection(collection, 0, 0, false, 1, true);
PrintCollection(collection);

void CreateSpiralCollection(int[,] col, int row, int column, Boolean st, int number, Boolean firstCycle)
{   //direction == right
    int j;
    if (!firstCycle) j = column++;
    else
    {
        j = column;
    }
    while (j < col.GetLength(1) && col[row, column] == 0)
    {
        col[row, column] = number;
        if (firstCycle && column + 1 < col.GetLength(1)) column++;
        else if (!firstCycle && col[row, column + 1] == 0) column++;
        j++;
        number++;
        st = true;
    }
    //direction down
    int i = row++;
    while (i < col.GetLength(0) && col[row, column] == 0)
    {
        col[row, column] = number;
        if (firstCycle && row + 1 < col.GetLength(0)) row++;
        else if (!firstCycle && col[row + 1, column] == 0) row++;
        i++;
        number++;
        st = true;
    }
    // direction left
    j = column--;
    while (j >= 0 && col[row, column] == 0)
    {
        col[row, column] = number;
        if (firstCycle && column - 1 >= 0) column--;
        else if (!firstCycle && col[row, column - 1] == 0) column--;
        j--;
        number++;
        st = true;
    }
    // direction up
    i = row--;
    while (i > 1 && col[row, column] == 0)
    {
        col[row, column] = number;
        if (firstCycle && row - 1 > 0) row--;
        else if (!firstCycle && col[row - 1, column] == 0) row--;
        i--;
        number++;
        st = true;
    }
    if (!st) return;
    else
    {
        CreateSpiralCollection(col, row, column, false, number, false);
    }
}

void PrintCollection(int[,] coll)
{
    for (int i = 0; i < coll.GetLength(0); i++)
    {
        for (int j = 0; j < coll.GetLength(1); j++)
        {
            Console.Write($"{coll[i, j].ToString().PadLeft(3, '0')} ");
        }
        Console.WriteLine();
    }
}