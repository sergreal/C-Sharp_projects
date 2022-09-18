// 17. Напишите программу, которая принимает на вход координаты точки 
// (X и Y), причём X ≠ 0 и Y ≠ 0 , и выдаёт номер четверти плоскости, 
// в которой находится эта точка.


// int CheckChetvert(int x, int y)
// {
//     int res;
//     if (x>0 && y>0) res=1;
//     else if (x>0 && y<0) res=4;
//     else if (x<0 && y<0) res=3;
//     else if (x<0 && y>0) res=2;
//     else res = 0;
//     return res;
// }

// try
// {
//     Console.Write("Введите координату х ");
//     int x = Convert.ToInt32(Console.ReadLine());
//     Console.Write("Введите координату y ");
//     int y = Convert.ToInt32(Console.ReadLine());
//     int rez = CheckChetvert(x,y);
//     if (rez!=0) Console.WriteLine($"Точка находится в четверти № {rez}");
//     else Console.WriteLine("Точка находится лежит на какой-то оси");
// }
// catch
// {
//     Console.WriteLine("Надо было вводить именно целые числа");
// }


//------------------------------------------------------------------------------

// Задача 24: 
// Напишите программу, которая принимает на вход число (А) 
// и выдаёт сумму чисел от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36

// int SummaFor (int N)
// {
//     int sum = 0;
//     for (int i=1; i<=N; i++) sum+=i;
//     return sum;
// }


// int SummaWile (int N)
// {
//     int sum = 0;
//     int i = 1;
//     while (i <= N)
//     {
//         sum += i;
//         i++;
//     }
//     return sum;
// }

// try
// {
//     Console.Write("Введите целое число: ");
//     int a = Convert.ToInt32(Console.ReadLine());
//     Console.WriteLine($"Сумма всех натуральных чисел от 1 до {a} через цикл FOR равна {SummaFor(a)}");
//     Console.WriteLine($"Сумма всех натуральных чисел от 1 до {a} через цикл WHILE равна {SummaWile(a)}");

// }

// catch (System.Exception)
// {
//     Console.WriteLine("Надо было вводить именно целое число.");
// }


//------------------------------------------------------------------------------


// Задача 26: 
// Напишите программу, которая принимает на вход число 
// и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5


// var.1
// int numCount(int num)
// {
//     int count = 0;
//     while(num > count)
//         {
//             num = num/10;
//             count++;
//         }
//     return count;
// }

// {
// Console.WriteLine("Введите число из нескольких цифр: ");
// int num = Convert.ToInt32(Console.ReadLine());
// int res = numCount(num);
// Console.WriteLine(res);
// }



//------------------------------------------------------------------------------

// var.2
// int Digit (int N)
// {

// int i = 0;
// while (N/((int)Math.Pow((Double)10,i))!=0) i++;
// return i;
// }
// try
// {
// Console.Write ("Введите целое число ");
// int a = Convert.ToInt32 (Console.ReadLine());
// Console.WriteLine($"Количество цифр в числе {a} равно {Digit(a)}");
// }
// catch (System.Exception)
// {

// Console.WriteLine("Надо было вводить именно целое число!");
// }


//------------------------------------------------------------------------------



// Console.Write( "Введите число : " );
// int num= int .Parse(Console.ReadLine());
// int i=0;
// while (num>0) {
// i++;
// num/=10;
// }
// Console.WriteLine( "Количество цифр введенного числа : {0}" , i);


// int SummaWile (int N)
// {
//     int sum = 0;
//     int i = 1;
//     while (i <= N)
//     {
//         sum += i;
//         i++;
//     }
//     return sum;
// }

// try
// {
//     Console.Write("Введите целое число: ");
//     int a = Convert.ToInt32(Console.ReadLine());
//     Console.WriteLine($"Сумма всех натуральных чисел от 1 до {a} через цикл FOR равна {SummaFor(a)}");
//     Console.WriteLine($"Сумма всех натуральных чисел от 1 до {a} через цикл WHILE равна {SummaWile(a)}");


//------------------------------------------------------------------------------

// var. морской инженер

// Задача 28: 
// Напишите программу, которая принимает на вход число N 
// и выдаёт произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120



int factorial(int N)

{
    int result = 1;
    for (int i = 1; i <= N; i++)
    {
        result = result * i; 
    }
    return result;
}


{
    n = 0;
    if (nameof )

}

try
{
    Console.WriteLine("Введите число от 1 до бесконечности: ");
    int a = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine(factorial(a));
}

catch
{
    Console.WriteLine("Введите правильное число.");
}



//------------------------------------------------------------------------------


// Задача 30: 
// Напишите программу, которая заполняет 
// и выводит массив из N элементов, N - задается с клавиатуры, 
// заполненный целыми случайными числами от 1 до 99. 


//------------------------------------------------------------------------------


int[] array ()


{
    int[] j = 0;
    Console.WriteLine("Введите число от 1 до бесконечности: ");
    int[] j = Convert.ToInt32(Console.ReadLine());
}

Console.WriteLine(array);

