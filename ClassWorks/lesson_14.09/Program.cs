﻿// Урок 4. Рекурсия и двумерные массивы. 



// string[,] table = new string[2, 5];
// // String.Empty
// // table[0,0] table[0,1] table[0,2] table[0,3] table[0,4]
// // table[1,0] table[1,1] table[1,2] table[1,3] table[1,4]

// table[1, 2] = "слово";

// for (int rows = 0; rows < 2; rows++)
// {
//     for (int columns = 0; columns < 5; columns++)
//     {
//         Console.WriteLine($"-{table[rows, columns]}-");
//     }
// }


//------------------------------------------------------------------------------


// void PrintArray(int[,] matr)
// {
//     for (int i = 0; i < matr.GetLength(0); i++)
//     {
//         for (int j = 0; j < matr.GetLength(1); j++)
//         {
//             Console.Write($"{matr[i, j]} ");
//         }
//         Console.WriteLine();
//     }
// }

// void FillArray(int[,] matr)
// {
//     for (int i = 0; i < matr.GetLength(0); i++)
//     {
//         for (int j = 0; j < matr.GetLength(1); j++)
//         {
//             matr[i,j] = new Random().Next(1,10); // интервал от 1 до 10
//         }
//     }
// }


// int[,] matrix = new int[3, 4];
// PrintArray(matrix);
// FillArray(matrix);
// Console.WriteLine();
// PrintArray(matrix);


//------------------------------------------------------------------------------

// здесь какаято билеберда
// void PrintImage(int[,] image)
// {
//     for (int i = 0; i < image.GetLength(0); i++)
//     {
//         for (int j = 0; j < image.GetLength(1); j++)
//         {
//             //Console.Write($"{image[i, j]} ");
//             if(image[i,j] == 0) Console.Write($" ");
//             else Console.Write($"+");
//         }
//         Console.WriteLine();
//     }
// }

// PrintImage();

//------------------------------------------------------------------------------

/*
int Factorial(int n)
{
    // 1! = 1
    if (n == 1) return 1;
    else return n * Factorial(n - 1);
}
Console.Write(Factorial(5)); // 3! = 3 * 2 * 1
// если нужно вычислить большое число, например факториал 30 или 50, использовать не int а double
*/

//------------------------------------------------------------------------------

// Фибоначи -   f(n) = f(n-1) + f(n-2)


// double Fibonacci(double n)
// {
//     if(n ==1 || n == 2) return 1;
//     else return Fibonacci(n - 1) + Fibonacci(n - 2);
// }

// for (double i = 1; i < 10; i++)
// {
//     Console.WriteLine($"f({i}) = {Fibonacci(i)}");
// }


int Fibonacci(int n){
if(n == 1 && n == 2) return 1;
else return Fibonacci(n-1) + Fibonacci(n-2);
}
for (int i = 1; i < 10; i++){
System.Console.WriteLine(Fibonacci(i));
}