
// DZ-5;


//------------------------------------------------------------------------------
// Задача 34: 
// Задайте массив заполненный случайными положительными трёхзначными числами.  
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2
//------------------------------------------------------------------------------

// int[] FillArray(int size)
// {
//     int[] array = new int[size];  // задаем длинну массива
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = new Random().Next(100, 1000); //диапазон чисел в массиве
//         Console.Write(array[i] + ", ");
//     }
//     return array;
// }

// void PrintArray(int[] massiv)
// {
//     int count = 0;
//     for (int i = 0; i < massiv.Length; i++)
//     {
//         if (massiv[i] % 2 == 0)
//             count++;
//     }
//     Console.WriteLine();
//     Console.WriteLine($"Количество чётных чисел в массиве => {count}");
// }

// Console.Write("Введите размер массива: ");
// int size = Convert.ToInt32(Console.ReadLine());
// int[] array = FillArray(size);
// PrintArray(array);



//------------------------------------------------------------------------------
// Задача 36: 
// Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6]-> 0
//------------------------------------------------------------------------------

// int[] FillArray(int size)       // создали метод массив[], и сказали что он будет размера size
// {
//     int[] array = new int[size];     //задаем длинну массива, т.е. сколько в нем будет чисел
//     for (int i = 0; i < array.Length; i++)     // создали цикл, где в массив array будут складываться числа, пока i будет меньше длинны массива (size)
//     {
//         array[i] = new Random().Next(-100, 100);   // записываем в массив array все рандомные числа, в диапазоне от-до (Next())
//         Console.Write(array[i] + ", ");      // выводим на печать числа
//     }
//     return array;
// }

// void SumElements(int[] array) // метод для перебора чисел в массиве через одного и суммирования
// {
//     int sum = 0;
//     for (int i = 0; i < array.Length; i=i+2)  //Начинаем с 1-го (i=0), проходим через одного i+2
//     {
//         if (i < array.Length)  //суммируем в цикле 
//         {
//             sum = sum + array[i];
//         }
//     }
//     Console.WriteLine();
//     Console.Write($"Сумма элементов, стоящих на нечётных позициях => {sum}");
// }

// Console.Write($"Введите размер массива: ");      // запрашиваем на ввод определение кол-ва чисел в массиве
// int size = Convert.ToInt32(Console.ReadLine());      //  Console.ReadLine() считывает и кладет размер массива в переменную size
// int[] massiv = FillArray(size);       // запускаем метод FillArray(size) и результат кладем в переменную array
// SumElements(massiv); // запускаем метод SumElements и передаем ему на вход данные с предыдущего метода



//------------------------------------------------------------------------------
// Задача 38: 
// Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
//------------------------------------------------------------------------------

// double[] FillArray(int size)
// {
//     double[] numbers = new double[size];
//     Random random = new Random();
//     Console.Write($"Массив из {size} чисел:   ");
//     for (int i = 0; i < numbers.Length; i++)
//     {
//         numbers[i] = Math.Round(random.NextDouble() * ((-100) - 100) + 100, 2);
//         Console.Write(numbers[i] + ";  ");
//     }
//     return numbers;
// }

// 
// void FindDiff(double[] array)
// {
//     int min = 0;
//     int max = 0;
//     double diff = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] > array[max]) max = i;
//         else if (array[i] < array[min]) min = i;
//     }
//     Console.WriteLine();
//     Console.WriteLine($"Минимальный элемент массива: array[" + min + "] = " + array[min]);
//     Console.WriteLine($"Максимальный элемент массива: array[" + max + "] = " + array[max]);

//     double numMin = array[min];
//     double numMax = array[max];
//     diff = numMax - numMin;
//     Console.WriteLine($"Разница между максимальным и минимальным, элементами массива:  ");
//     Console.WriteLine($"{numMax} - {numMin} = {diff}");
// }

// Console.Write("Введите размер массива: ");
// int size = Convert.ToInt32(Console.ReadLine());
// double[] MinMax = FillArray(size);
// FindDiff(MinMax);

