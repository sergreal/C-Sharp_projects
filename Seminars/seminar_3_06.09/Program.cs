

// надо все решать с массивами !
// надо решать с return !



// задачи с семинара 06.09

//var.1, команда Мах + морской инженер
 
// void checkChetvert(int chetvert)
//     {
//         if (chetvert == 1) Console.WriteLine("+/+");
//         else if (chetvert == 2) Console.WriteLine("-/+");
//         else if (chetvert == 3) Console.WriteLine("-/-");
//         else if (chetvert == 4) Console.WriteLine("+/-");
//     }

// try
// {
//     Console.WriteLine("Введите номер четверти: ");
//     int chetvert = Convert.ToInt32(Console.ReadLine());
//     checkChetvert(chetvert);
// }

// catch
// {
//     Console.WriteLine("Введи целое число: ");
// }


//var.2, Дарья

// string CheckChetvert(int chet)
//
// {
//     string res;
//     if(chet == 1) res = "x > 0, y > 0";
//     else if (chet == 2) res = "x < 0, y > 0";
//     else if (chet == 3) res = "x < 0, y < 0";
//     else if (chet == 4) res = "x > 0, y < 0";
//     else res = "Incorrected number";
//     return res;
// }

// try
// {
//     Console.Write("Enter number from 1 to 4: ");
//     int chet = Convert.ToInt32(Console.ReadLine());
//     string res = CheckChetvert(chet);
//     Console.WriteLine(res);
// }

// catch
// {
//     Console.WriteLine("Надо было вводить именно целые числа.");
// }


//var.2

// string whatCoord(int num)
// {
//     switch(num)
//     {
//         case 1:
//         {
//             return "x > 0, y > 0";
//         }
//         case 2:
//         {
//             return "x < 0, y > 0";
//         }
//         case 3:
//         {
//             return "x < 0, y < 0";
//         }
//         case 4:
//         {
//             return "x > 0, y < 0";
//         }
//         default:
//         {
//             return "Нет такой четверти!";
//         }
//     }
// }

// try 
//     {
//     Console.WriteLine("Введите номер четверти ");
//     int quarter = Convert.ToInt32(Console.ReadLine());
//     Console.WriteLine(whatCoord(quarter));
//     }

// catch
//     {
//     Console.WriteLine("Нужно ввести целое число");
//     }




// Задача 21: Напишите программу, которая принимает на вход координаты двух точек 
// и находит расстояние между ними в 2D пространстве.
// A (3,6); B (2,1) -> 5,09
// A (7,-5); B (1,-1) -> 7,21


// dz_3
// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек 
// и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53


// double distance()

// {
//     Console.Write("Введите координату первой точки по оси x: ");
//     int x1 = Convert.ToInt32(Console.ReadLine());
//     Console.Write("Введите координату первой точки по оси y: ");
//     int y1 = Convert.ToInt32(Console.ReadLine());

//     Console.Write("Введите координату второй точки по оси x: ");
//     int x2 = Convert.ToInt32(Console.ReadLine());
//     Console.Write("Введите координату второй точки по оси y: ");
//     int y2 = Convert.ToInt32(Console.ReadLine());

//     double num = (x2-x1)*(x2-x1) + (y2-y1)*(y2-y1);
//     num = Math.Sqrt(num);
//     return (num);
// }

// double sqr = distance();
// Console.WriteLine(sqr);



////////////////////////////////////////////////////////////////////


// double distance()

// {
//     Console.Write("Введите координату первой точки по оси x: ");
//     int x1 = Convert.ToInt32(Console.ReadLine());
//     Console.Write("Введите координату первой точки по оси y: ");
//     int y1 = Convert.ToInt32(Console.ReadLine());

//     Console.Write("Введите координату второй точки по оси x: ");
//     int y2 = Convert.ToInt32(Console.ReadLine());
//     Console.Write("Введите координату второй точки по оси y: ");
//     int x2 = Convert.ToInt32(Console.ReadLine());

//     double num = ((x2-x1) * (x2-x1) + (y2-y1) * (y2-y1));
//     num = Math.Sqrt(num);
//     return (num);
// }

// double sqr = distance();
// Console.WriteLine(sqr);



////////////////////////////////////////////////////////////////////

// double lengthBetween(int x1, int y1, int x2, int y2)
// {
//     // (x1 - x2) ^2
//     // (y1 - y2) ^ 2
//     // N мерное 
//     double xres = (x1 - x2) * (x1 - x2);
//     double yres = (y1 - y2) * (y1 - y2);
//     double res = Math.Sqrt(xres + yres);
//     return res;
// }

// Console.WriteLine("Введите координаты первой точки");
// int x1 = Convert.ToInt32(Console.ReadLine());
// int y1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите координаты второй точки");
// int x2 = Convert.ToInt32(Console.ReadLine());
// int y2 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine($"Расстояние между точками = {lengthBetween(x1,y1,x2,y2)}");





// double lengthBetween(int[] firstDot, int[] scndDot, int n)
// {
// // (x1 - x2) ^2
// // (y1 - y2) ^ 2
// // N мерное
// int sumDots = 0;
// for (int i = 0; i < n; i++ )
// {
// sumDots = sumDots + (firstDot[i] - scndDot[i]) * (firstDot[i] - scndDot[i]);
// }
// double res = Math.Sqrt(sumDots);
// return res;
// }
// Console.WriteLine("Введите размерность пространства");
// int n = Convert.ToInt32(Console.ReadLine());
// int[] firstDot = new int[n];
// int[] scndDot = new int[n];
// int i = 0;
// Console.WriteLine("Введите координаты первой точки");
// while (i < n)
// {
// firstDot[i] = Convert.ToInt32(Console.ReadLine());
// i++;
// }
// i = 0;
// Console.WriteLine("Введите координаты второй точки");
// while (i < n)
// {
// scndDot[i] = Convert.ToInt32(Console.ReadLine());
// i++;
// }
// Console.WriteLine($"Расстояние между точками = {lengthBetween(firstDot, scndDot, n)}");






// Задача 22: Напишите программу, которая принимает на вход число (N) 
// и выдаёт таблицу квадратов чисел от 1 до N.
// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4


// string squareTable(int num)
// {
//     string result = $"{num} -> 1";
//     for (int i = 2; i <= num; i++)
//     {
//         result = result + $", {Math.Pow(i, 2)}";
//     }
//     return result;
// }
// try
// {
//     System.Console.Write("Введите число = ");
//     int num = Math.Abs(Convert.ToInt32(Console.ReadLine()));
//     System.Console.WriteLine(squareTable(num));
// }
// catch
// {
//     System.Console.WriteLine("Вводите целочисленное значение");
// }



// string numSquares(int num)
// {
//     int i = 2;
//     string squares = "1";
//     while (i <= num)
//     {
//         squares = squares + ", " + Convert.ToString(i * i);
//         i++;
//     }
//     return squares;
// }

// Console.WriteLine("Введите число N: ");
// int num = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(numSquares(num));


// -------------------------------------------------------------------------


// 17. Напишите программу, которая принимает на вход координаты точки 
// (X и Y), причём X ≠ 0 и Y ≠ 0 , и выдаёт номер четверти плоскости, 
// в которой находится эта точка.


int CheckChetvert(int x, int y)
{
    int res;
    if (x>0 && y>0) res=1;
    else if (x>0 && y<0) res=4;
    else if (x<0 && y<0) res=3;
    else if (x<0 && y>0) res=2;
    else res = 0;
    return res;
}

try
{
    Console.Write ("Введите координату х ");
    int x = Convert.ToInt32 (Console.ReadLine());
    Console.Write ("Введите координату y ");
    int y = Convert.ToInt32 (Console.ReadLine());
    int rez = CheckChetvert(x,y);
    if (rez!=0) Console.WriteLine($"Точка находится в четверти № {rez}");
    else Console.WriteLine("Точка находится лежит на какой-то оси");
}
catch
{
    Console.WriteLine("Надо было вводить именно целые числа");
}



// -------------------------------------------------------------------------




string CheckChetvert(int chet)
{
string res;
if (chet == 1) res= "x > 0, y > 0";
else if (chet == 2) res="x < 0, y > 0";
else if (chet == 3) res= "x < 0, y < 0";
else if (chet == 4) res="x > 0, y < 0";
else res = "incorrect number";
return res;
}

try
{
Console.Write ("enter number from 1 to 4 ");
int chet = Convert.ToInt32 (Console.ReadLine());
string rez = CheckChetvert(chet);
Console.WriteLine (rez);
}
catch
{
Console.WriteLine("Надо было вводить именно целые числа");
}