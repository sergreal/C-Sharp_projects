

double distance()

{
    Console.Write("Введите координату первой точки по оси x: ");
    int x1 = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите координату первой точки по оси y: ");
    int y1 = Convert.ToInt32(Console.ReadLine());

    Console.Write("Введите координату второй точки по оси x: ");
    int x2 = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите координату второй точки по оси y: ");
    int y2 = Convert.ToInt32(Console.ReadLine());

    double num = (x2-x1)*(x2-x1) + (y2-y1)*(y2-y1);
    num = Math.Sqrt(num);
    return (num);
}

double sqr = distance();
Console.WriteLine(sqr);



////////////////////////////////////////////////////////////////////


double distance()

{
    Console.Write("Введите координату первой точки по оси x: ");
    int x1 = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите координату первой точки по оси y: ");
    int y1 = Convert.ToInt32(Console.ReadLine());

    Console.Write("Введите координату второй точки по оси x: ");
    int y2 = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите координату второй точки по оси y: ");
    int x2 = Convert.ToInt32(Console.ReadLine());

    double num = ((x2-x1) * (x2-x1) + (y2-y1) * (y2-y1));
    num = Math.Sqrt(num);
    return (num);
}

double sqr = distance();
Console.WriteLine(sqr);



////////////////////////////////////////////////////////////////////

double lengthBetween(int x1, int y1, int x2, int y2)
{
    // (x1 - x2) ^2
    // (y1 - y2) ^ 2
    // N мерное 
    double xres = (x1 - x2) * (x1 - x2);
    double yres = (y1 - y2) * (y1 - y2);
    double res = Math.Sqrt(xres + yres);
    return res;
}

Console.WriteLine("Введите координаты первой точки");
int x1 = Convert.ToInt32(Console.ReadLine());
int y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты второй точки");
int x2 = Convert.ToInt32(Console.ReadLine());
int y2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Расстояние между точками = {lengthBetween(x1,y1,x2,y2)}");


////////////////////////////////////////////////////////////////////


string squareTable(int num)
{
    string result = $"{num} -> 1";
    for (int i = 2; i <= num; i++)
    {
        result = result + $", {Math.Pow(i, 2)}";
    }
    return result;
}
try
{
    System.Console.Write("Введите число = ");
    int num = Math.Abs(Convert.ToInt32(Console.ReadLine()));
    System.Console.WriteLine(squareTable(num));
}
catch
{
    System.Console.WriteLine("Вводите целочисленное значение");
}


////////////////////////////////////////////////////////////////////


надо решать с массивами
надо решать с return !!!


////////////////////////////////////////////////////////////////////
