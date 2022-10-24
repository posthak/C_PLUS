Console.Clear(); 

int[] coordinateA = {0,0,0};
int[] coordinateB = {0,0,0};

Console.Write("Введите координат 1 точки А: ");
coordinateA[0] =  Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координат 2 точки А: ");
coordinateA[1] =  Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координат 3 точки А: ");
coordinateA[2] =  Convert.ToInt32(Console.ReadLine());

Console.Write("Введите координат 1 точки B: ");
coordinateB[0] =  Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координат 2 точки B: ");
coordinateB[1] =  Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координат 3 точки B: ");
coordinateB[2] =  Convert.ToInt32(Console.ReadLine());

double distance = Math.Round(Math.Sqrt(Math.Pow(coordinateB[0] - coordinateA[0],2) + 
    Math.Pow(coordinateB[1] - coordinateA[1],2) + Math.Pow(coordinateB[2] - coordinateA[2],2)),2);

Console.WriteLine($"A({coordinateA[0]},{coordinateA[1]},{coordinateA[2]}); B({coordinateB[0]},{coordinateB[1]},
    {coordinateB[2]}) ->  {distance}");
