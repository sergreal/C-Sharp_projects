//  ЗАДАЧА из домашки.


// int[,] FillMas(int n, int m)
// {
//     int[,] mas = new int[n, m];
//     for (int i = 0; i < n; i++)
//     {

//         for (int j = 0; j < m; j++)
//         {
//             mas[i, j] = new Random().Next(-10, 11);
//         }

//     }

//     return mas;
// }

// void PrintArray(int[,] arr)
// {
//     for (int i = 0; i < arr.GetLength(0); i++)
//     {
//         for (int j = 0; j < arr.GetLength(1); j++)
//         {
//             if (j != arr.GetLength(1) - 1) Console.Write($"{arr[i, j]}, ");
//             else if (i == arr.GetLength(0) - 1 && j == arr.GetLength(1) - 1) Console.WriteLine($"{arr[i, j]}");
//             else if (j == arr.GetLength(1) - 1) Console.WriteLine($"{arr[i, j]},");
//         }
//     }
// }

// System.Console.Write("Введите количество строк n = ");
// int n = Convert.ToInt32(Console.ReadLine());
// System.Console.Write("Введите количество столбцов m = ");
// int m = Convert.ToInt32(Console.ReadLine());

// int[,] newArray = FillMas(n, m);
// PrintArray(newArray);


//------------------------------------------------------------------------------
//------------------------------------------------------------------------------
//------------------------------------------------------------------------------

Задача 49: Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.
Например, изначально массив
 выглядел вот так:
1 4 7 2
5 9 2 3
8 4 2 4
Новый массив будет выглядеть 
вот так:
1 4 7 2
5 81 2 9
8 4 2 4

Задача 48: Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: Aₘₙ = m + n.Выведите полученный массив на экран.
m = 3, n = 4.
0 1 2 3
1 2 3 4
2 3 4 5
Задача 49: Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.
Например, изначально массив
 выглядел вот так:
1 4 7 2
5 9 2 3
8 4 2 4
Новый массив будет выглядеть 
вот так:
1 4 7 2
5 81 2 9
8 4 2 4


// int[,] FillMas(int n, int m)
// {
// int[,] mas = new int[n, m];

//     for (int i = 0; i < n; i++)
//         { 
//         for (int j = 0; j < m; j++)
//         {
//             mas[i, j] = i + j;
//     }
// }
// return mas;

// System.Console.Write("Введите количество строк n = ");
// int n = Convert.ToInt32(Console.ReadLine());
// System.Console.Write("Введите количество столбцов m = ");
// int m = Convert.ToInt32(Console.ReadLine());
// int[,] newArray = FillMas(n, m);
// PrintArray(newArray);


int[] FillMas(int n)
{
    int[] mas = new int[n];
    for (int i = 0; i < n; i++)
    {
        mas[i] += i;
    }
}
return mas;

Console.Write("Введите количество строк n = ");
int n = Convert.ToInt32(Console.ReadLine());

int[] newArray = FillMas(n);
PrintArray(newArray);







//------------------------------------------------------------------------------

// int[,] FillMas(int n, int m)
// {
//     int[,] mas = new int[n, m];
//     for (int i = 0; i < n; i++)
//     {
//         for (int j = 0; j < m; j++)
//         {
//             mas[i, j] = i+j;
//         }
//     }

//     return mas;
// }
// void PrintArray(int[,] arr)
// {
//     for (int i = 0; i < arr.GetLength(0); i++)
//     {
//         for (int j = 0; j < arr.GetLength(1); j++)
//         {
//             if (j != arr.GetLength(1) - 1)
//                 Console.Write($"{arr[i, j]}, ");
//             else if (i == arr.GetLength(0) - 1 && j == arr.GetLength(1) - 1)
//                 Console.WriteLine($"{arr[i, j]}");
//             else if (j == arr.GetLength(1) - 1)
//                 Console.WriteLine($"{arr[i, j]},");
//         }
//     }
// }
// System.Console.Write("Введите количество строк n = ");
// int n = Convert.ToInt32(Console.ReadLine());
// System.Console.Write("Введите количество столбцов m = ");
// int m = Convert.ToInt32(Console.ReadLine());
// int[,] newArray = FillMas(n, m);
// PrintArray(newArray);


//------------------------------------------------------------------------------

int[,] Array(int n, int m)
{
    int[,] mas = new int[n, m];
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < m; j++)
        {
            mas[i, j] = i + j;
        }
    }
    return mas;
}
void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (j != arr.GetLength(1) - 1) Console.Write($"{arr[i, j]}, ");
            else if (i == arr.GetLength(0) - 1 && j == arr.GetLength(1) - 1) Console.WriteLine($"{arr[i, j]}");
            else if (j == arr.GetLength(1) - 1) Console.WriteLine($"{arr[i, j]},");
        }
    }
}

System.Console.Write("Введите количество строк n = ");
int n = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите количество столбцов m = ");
int m = Convert.ToInt32(Console.ReadLine());

int[,] newArray = Array(n, m);
PrintArray(newArray);


//------------------------------------------------------------------------------

int[,] FillMas(int n, int m)
{
    int[,] mas = new int[n, m];
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < m; j++)
        {
            mas[i, j] = new Random().Next(-10, 11);
        }
    }

    return mas;
}

int[,] EvenNum(int[,] mas)
{
    for (int i = 0; i < mas.GetLength(0); i++)
    {
        for (int j = 0; j < mas.GetLength(1); j++)
        {
            if (i % 2 != 0 && j % 2 != 0)
                mas[i, j] = (mas[i, j] * mas[i, j]);

        }
    }
    return mas;
}

void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (j != arr.GetLength(1) - 1)
                Console.Write($"{arr[i, j]}, ");
            else if (i == arr.GetLength(0) - 1 && j == arr.GetLength(1) - 1)
                Console.WriteLine($"{arr[i, j]}");
            else if (j == arr.GetLength(1) - 1)
                Console.WriteLine($"{arr[i, j]},");
        }
    }
}

System.Console.Write("Введите количество строк n = ");
int n = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите количество столбцов m = ");
int m = Convert.ToInt32(Console.ReadLine());
int[,] newArray = FillMas(n, m);
PrintArray(newArray);
Console.WriteLine("Измененный массив");
PrintArray(EvenNum(newArray));

//------------------------------------------------------------------------------

Задача 51: Задайте двумерный массив. 
Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1; 1) и т.д.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Сумма элементов главной диагонали: 1+9+2 = 12


int[,] FillMas(int n, int m)
{
    int[,] mas = new int[n, m];
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < m; j++)
        {
            mas[i, j] = new Random().Next(-10, 11);
        }
    }

    return mas;
}
void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (j != arr.GetLength(1) - 1)
                Console.Write($"{arr[i, j]}, ");
            else if (i == arr.GetLength(0) - 1 && j == arr.GetLength(1) - 1)
                Console.WriteLine($"{arr[i, j]}");
            else if (j == arr.GetLength(1) - 1)
                Console.WriteLine($"{arr[i, j]},");
        }
    }
}

int SumInd(int[,] mas)
{
    int sum = 0;
    for (int i = 0; i < mas.GetLength(0); i++)
    {
        for (int j = 0; j < mas.GetLength(1); j++)
        {
            if (i == j)
                sum = sum + mas[i, j];
        }
    }
    return sum;
}

System.Console.Write("Введите количество строк n = ");
int n = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите количество столбцов m = ");
int m = Convert.ToInt32(Console.ReadLine());
int[,] newArray = FillMas(n, m);
PrintArray(newArray);
int sum = SumInd(newArray);
Console.Write("Сумма= ");
Console.Write($"{sum}");




//------------------------------------------------------------------------------

Задача HARD SORT.

Задайте двумерный массив из целых чисел. 
Количество строк и столбцов задается с клавиатуры. 
Отсортировать элементы по возрастанию слева направо и сверху вниз.

Например, задан массив:
1 4 7 2
5 9 10 3

После сортировки
1 2 3 4
5 7 9 10
5 7 9 10







//------------------------------------------------------------------------------
int SumDiag(int[,] matr)
{
    int result = 0;
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            if (i == j) result += matr[i, j];
        }
    }
    return result;
}



//------------------------------------------------------------------------------