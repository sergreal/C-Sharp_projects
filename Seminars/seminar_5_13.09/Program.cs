// Задача 31: 
// Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. 
// Найдите сумму отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] 
// сумма положительных чисел равна 29, 
// сумма отрицательных равна -20.


int[] FillArray(int size)
{
    int[] mas = new int[size];
    for (int i=0; i<size; i++)
    {
        mas[i] = new Random().Next(-9, 10);
    }
    return mas;
}

void PrintArray(int[] mmm)
{
    for (int i=0; i < mmm.Length; i++)
    {
        if (i != mmm.Length - 1) Console.Write($"{mmm[i]}, ");
        else Console.WriteLine($"{mmm[i]}");
    }
}

int[] FindSums(int[] mmm)
{
    int[] sums = new int[2];
    foreach (int item in mmm)
    {
        if (item > 0) sums[1] += item;
        else sums[0] += item;
    }
    return sums;
}

int[] array = FillArray(12);
PrintArray(array);
int[] results = FindSums(array);
Console.WriteLine($"Сумма положительных элементов массива равна {results[1]}");
Console.WriteLine($"Сумма отрицательных элементов массива равна {results[0]}");






// Задача 32: Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2] 
// Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, 3] -> да



// int[] FillArray(int size)
// {
//     int[] mas = new int[size];

//     for (int i = 0; i < size; i++)
//     {
//         mas[i] = new Random().Next(-9, 10);
//     }
//     return mas;
// }

// int[] changeArray(int[] mas)
// {
//     for (int i = 0; i < mas.Length; i++)
//     {
//         mas[i] *= -1;
//     }
//     return mas;
// }

// void PrintArray(int[] mmm)
// {

//     for (int i = 0; i < mmm.Length; i++)
//     {
//         if (i != mmm.Length - 1) Console.Write($"{mmm[i]}, ");
//         else Console.WriteLine($"{mmm[i]}");
//     }

// }

// try
// {
//     int[] array = FillArray(12);
//     PrintArray(array);
//     PrintArray(changeArray(array));
// }
// catch
// {
//     Console.WriteLine("Что-то пошло не так!");
// }






//------------------------------------------------------------------------------
// наш сырой вариант. посмотреть и допилить. 
// int[] FillArray(int size)
//             {
//             int[] mas = new int[size];

//             for (int i=0;i<size;i++) 
//                 {
//                     mas[i]= new Random().Next(-9,10);
//                 }
//             return mas;
//             }

// void Change(int[] a)
//     {
//       for (int i = 0; i < a.Length; ++i)
//          a[i] = -a[i];
//     }

// int[] array = FillArray(8);
// PrintArray(array);
//         int[] FillArray = Change(array);
//         Console.WriteLine($"Сумма положительныъ элементов массива равна {results[1]}");
//         Console.WriteLine($"Сумма отрицательных элементов массива равна {results[0]}");
//------------------------------------------------------------------------------




задача 33.


// int[] arr = FillArray(15);

// string FindDigit(int[] array, int findNum){
//     // int[] result = new int[array.Length];
//     string result = String.Empty;
//     for (int i = 0; i < array.Length; i++){
//         if (array[i] == findNum) {
//             result = "Да";
//         } else result = "нет";
//     }
//     return result;
// }
// PrintArray(arr);
// Console.WriteLine(FindDigit(arr, 5));



// int[] arr = FillArray(15);

// string FindDigit(int[] array, int findNum){
//     // int[] result = new int[array.Length];
//     string result = "Нет";
//     for (int i = 0; i < array.Length; i++){
//         if (array[i] == findNum) 
//             result = "Да";
//     }
//     return result;
// }
// PrintArray(arr);
// Console.WriteLine(FindDigit(arr, 5));





// Задача 35: 
// Задайте одномерный массив из 15 случайных чисел от -100 до 100. 
// Найдите количество элементов массива, значения которых лежат в отрезке [10,99]. 
// Пример для массива из 5, элементов. В своём решении сделайте для 15 чисел.
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5

int[] FillArray(int size)
{
    int[] mas = new int[size];
    for (int i = 0; i < size; i++)
    {
        mas[i] = new Random().Next(-100, 100);
    }
    return mas;
}

void PrintArray(int[] mmm)
{
    for (int i = 0; i < mmm.Length; i++)
    {
        if (i != mmm.Length - 1) Console.Write($"{mmm[i]}, ");
        else Console.WriteLine($"{mmm[i]}");
    }
}

int[] arr = FillArray(15);
PrintArray(arr);
int count = 0;
for (int i = 0; i < arr.Length; i++)
{
    if (arr[i] > 10 && arr[i] < 100)
        count++;
}
Console.WriteLine($"В массиве {count} элементов лежит в отрезке от 10 до 99");





// Задача 37: 
// Найдите произведение пар чисел в одномерном массиве. 
// Парой считаем первый и последний элемент, второй и предпоследний и т.д. 
// Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6]-> 36 21


// var.1

int[] FillArrayTen(int size)

{
    int[] mas = new int[size];
    for (int i = 0; i < size; i++)
    {
        mas[i] = new Random().Next(-10, 11);
    }
    return mas;
}

int[] pair(int[] mas)
{
    int L = Convert.ToInt32(Math.Round(Convert.ToDouble(mas.Length / 2)));
    int[] result = new int[L + 1];
    for (int i = 0; i < mas.Length / 2; i++)
    {
        result[i] = mas[i] * mas[mas.Length - 1 - i];
    }
    result[L - 1] = mas[L];
    return result;
}

System.Console.WriteLine("Введите размерность массива");
int size = Convert.ToInt32(Console.ReadLine());
int[] inputTen = FillArrayTen(size);
System.Console.WriteLine(string.Join(",", inputTen));
System.Console.WriteLine(string.Join(",", pair(inputTen)));





// var.2 

// int[] GetArray(int[] array)

// {
//     int len = 0;
//     len = array.Length % 2 == 0 ? array.Length/2 : array.Length/2 + 1;
//     int[] result = new int[len];

//     for (int i = 0; i < len; i++)
//     {
//         if (i != (array.Length - 1 - i)) result[i] = array[i] * array[array.Length - 1 - i];
//         else result[i] = array[i];
//     }
//     return result;
// }

// int[] a = {1, 2, 3, 4, 5};
// PrintArray(GetArray(a));   // 5, 8, 3

// int[] b = {6, 7, 3, 6}; 
// PrintArray(GetArray(b));   // 36, 21

// int[] c = {2, 4, 30, 4, -5};
// PrintArray(GetArray(c));   // -10, 16, 30