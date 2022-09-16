
// Урок 3. Массивы и функции в программировании


// Задача 19
// Напишите программу, которая принимает на вход пятизначное число 
// и проверяет, является ли оно палиндромом (с помощью цикла).
// 14212 -> нет
// 12821 -> да
// 23432 -> да


void Palindrom()
{
Console.WriteLine("Введите число из пяти цифр: ");
int num = Convert.ToInt32(Console.ReadLine());
string str = num.ToString();
if (str[0] == str[4] && str[1] == str[3]) Console.WriteLine($"Введеное вами число {num} - является палиндромом.");
else Console.WriteLine($"Поздравляем! Вы ввели число: {num}.");
}
Palindrom();








//------------------------------------------------------------------------------



// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек 
// и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

// void Dist()
// {
// Console.WriteLine("Введите координаты точки A: ");
// int x1 = Convert.ToInt32(Console.ReadLine());
// int y1 = Convert.ToInt32(Console.ReadLine());
// int z1 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите координаты точки B: ");
// int x2 = Convert.ToInt32(Console.ReadLine());
// int y2 = Convert.ToInt32(Console.ReadLine());
// int z2 = Convert.ToInt32(Console.ReadLine());

// double distance = Math.Round((Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2))),4);
// Console.WriteLine($"Расстояние между точками А и В, в 3D пространстве -> {distance}");
// }
// Dist();




// var.2
// double distance()
// {
//     Console.WriteLine("Введите координаты первой точки по оси x, y, z: ");
//     int x1 = Convert.ToInt32(Console.ReadLine());
//     int y1 = Convert.ToInt32(Console.ReadLine());
//     int z1 = Convert.ToInt32(Console.ReadLine());

//     Console.WriteLine("Введите координаты второй точки по оси x, y, z: ");
//     int x2 = Convert.ToInt32(Console.ReadLine());
//     int y2 = Convert.ToInt32(Console.ReadLine());
//     int z2 = Convert.ToInt32(Console.ReadLine());

//     double num = (x2-x1)*(x2-x1) + (y2-y1)*(y2-y1) + (z2-z1)*(z2-z1);
//     num = Math.Sqrt(num);
//     return (num);
// }

// double sqr = distance();
// Console.WriteLine($"Расстояние между точками A и B, в 3D пространстве -> {sqr}");


//------------------------------------------------------------------------------




// Задача 23
// Напишите программу, которая принимает на вход число (N) 
// и выдаёт таблицу (список) кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

// void Tabl()
// {
// Console.WriteLine("Введите число: ");
// int N = Convert.ToInt32(Console.ReadLine());

// double num = 0;
// string sum = string.Empty;
// for (int i = 1; i <= N;)
// {
//     num = Math.Pow(i, 3);
//     sum = sum + ", " + num;
//     i++;
// };
// Console.WriteLine($"{N} -> {sum}");
// }
// Tabl();






// var.2
// string numSquares(int num)
// {
//     int i = 2;
//     string squares = "1";
//     while (i <= num)
//     {
//         squares = squares + ", " + Convert.ToString(i * i * i);
//         i++;
//     }
//     return squares;
// }

// Console.WriteLine("Введите число N: ");
// int num = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine($"Вы ввели число: {num}.");
// Console.WriteLine($"Кубы чисел от 1 до {num}, составляют числа  ->  {numSquares(num)}.");


//------------------------------------------------------------------------------





