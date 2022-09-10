// Урок 3. Массивы и функции в программировании


// Задача 19
// Напишите программу, которая принимает на вход пятизначное число 
// и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да


int numPalindrom()

{
    Console.WriteLine("Введите пятизначное число: ");
    int numbers = Convert.ToInt32(Console.ReadLine());
    foreach (int number in numbers)
    {
        if (number[0] == number[4] && number[1] == number[3]) Console.WriteLine($"Введенное число {numbers}, является палиндромом.");
        else Console.WriteLine($"Введенное число {numbers}, НЕ является палиндромом.");
    }
    return numbers;
}

int res = numPalindrom();
Console.WriteLine(res);
 


// var. может сделать из нее.
// int numPalindrom()


// int x = new Random().Next(10,100);
//     int x1 = x/10;
//     int x2 = x%10;
//     Console.WriteLine($"Сгенерировано случайное число {x} ");
//     if (x1>x2) Console.WriteLine("Первая цифра больше");
//     else if (x2>x1) Console.WriteLine("Вторая цифра больше");
//     else Console.WriteLine("Это паллиндром!");

// void CompareDigits()
// {
//     int x = new Random().Next(10,100);
//     int x1 = x/10;
//     int x2 = x%10;
//     Console.WriteLine($"Сгенерировано случайное число {x} ");
//     if (x1>x2) Console.WriteLine("Первая цифра больше");
//     else if (x2>x1) Console.WriteLine("Вторая цифра больше");
//     else Console.WriteLine("Это паллиндром!");
// }
//     CompareDigits();







////////////////////////////////////////////////////////////////////////////////

// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек 
// и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

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
// Console.WriteLine(sqr);



////////////////////////////////////////////////////////////////////////////////

// Задача 23
// Напишите программу, которая принимает на вход число (N) 
// и выдаёт таблицу (список) кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

// + подумать как вывести красивый вывод
//  string result = $"{num} -> 1";



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
//
// Console.WriteLine("Введите число N: ");
// int num = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(numSquares(num));