Console.Write("Введите координату по оси оХ точки A: ");
int xA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату по оси оY точки A: ");
int yA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату по оси оZ точки A: ");
int zA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату по оси оХ точки B: ");
int xB = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату по оси оY точки B: ");
int yB = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату по оси оZ точки B: ");
int zB = Convert.ToInt32(Console.ReadLine());

double Distance = Math.Sqrt((Math.Pow(xA-xB,2))+(Math.Pow(yA-yB,2))+(Math.Pow(zA-zB,2)));
Console.WriteLine ($"Расстояние: {Math.Round(Distance,2)}");
