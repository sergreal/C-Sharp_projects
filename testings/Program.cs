

// {
// int a = 5;
// int b = 3;
// if (a + b > 10)
//     Console.WriteLine("The answer is greater than 10");
// else
//     Console.WriteLine("The answer is not greater than 10");
// }


// int counter = 0;
// while (counter < 10)
// {
//     Console.WriteLine($"Hello World! The counter is {counter}");
//     counter++;
// }





/*

Console.WriteLine ("Введи имя: ");
string name = Console.ReadLine();
Console.Write ("Салют, "+name);


Console.WriteLine("Hello, World!");
Console.ReadLine();
int
string
new Random().Next()

if Console.WriteLine()


// ------------------------------------------


int x = new Random().Next(10,100);
    int x1 = x/10;
    int x2 = x%10;
    Console.WriteLine($"Сгенерировано случайное число {x} ");
    if (x1>x2) Console.WriteLine("Первая цифра больше");
    else if (x2>x1) Console.WriteLine("Вторая цифра больше");
    else Console.WriteLine("Это паллиндром!");


int num1 = new Random().Next();



void NewTask ()
{
int num = new Random().Next (100, 1000);

int res =  num/100;
int res1 = num%10;

Console.WriteLine(num);
Console.WriteLine($"{res}{res1}");
}

NewTask ();


*/



/*
void First ()
{

Console.WriteLine("Введите ваше имя: ");
string name = Console.ReadLine();

Console.WriteLine("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());

int num = new Random().Next(1,100); 


if (num > 50) Console.WriteLine($"{name} -рандомное {num}, ввели первое {num1}");
else if (num < 50) Console.WriteLine($"{name} -рандомное - {num}, ввели второе {num2}");
else Console.WriteLine($"И получается что {name}, рандомное {num}, а оба ввели {num1} и {num2}");
}

First ();

*/







//-----------------------------------------------
/*
Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3
*/

/*
void Task_2()
{
Console.Write("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine()); 
Console.Write("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine()); 
if (num1>num2) Console.WriteLine($"Из двух введенных чисел {num1} и {num2}, число {num1} большее, а число {num2} меньшее.");
else Console.WriteLine($"Из двух введенных чисел {num1} и {num2}, число {num2} большее, а число {num1} меньшее.");
}
Task_2();
*/


//-----------------------------------------------
/*
Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22
*/

/*
void Task_4()
{
Console.Write("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine()); 
Console.Write("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine()); 
Console.Write("Введите третье число: ");
int num3 = Convert.ToInt32(Console.ReadLine()); 

if (num1>num2 & num1>num3) Console.WriteLine($"Из трех введенных чисел {num1}, {num2} и {num3}, максимальное число - {num1}");
else if (num2>num3 & num2>num1) Console.WriteLine($"Из трех введенных чисел {num1}, {num2} и {num3}, максимальное число - {num2}");
else Console.WriteLine($"Из трех введенных чисел {num1}, {num2} и {num3}, максимальное число - {num3}");
}
Task_4();
*/


//-----------------------------------------------
/*
Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
4 -> да
-3 -> нет
7 -> нет
*/

/*
void Task_6()
{
Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
if (num % 2 == 0) Console.WriteLine($"Число {num} - является четным числом.");
else Console.WriteLine($"Число {num} - является нечетным числом.");
}
Task_6();
*/


//-----------------------------------------------
/*
Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
5 -> 2, 4
8 -> 2, 4, 6, 8
*/

/*
void Task_8()
{
    int num = 1;
    Console.Write("Введите число: ");
    int num0 = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Список четных чисел: ");
    while (num < num0)
    {
        if (num%2 == 0) Console.Write($"{num}, ");
        num = num + 1;
    }
    Console.Write("End.");

}
Task_8();
*/

// int num[] = int num1[0]
// while (num < )


//-----------------------------------------------
/*
Задача 10: Напишите программу, которая принимает на вход трёхзначное число 
и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1
*/

/*
void NumTwo()
{
Console.Write("Введите трехзначное число: ");
int num = Convert.ToInt32(Console.ReadLine());
int num1 = num/10;
int num2 = num1%10;
num = num2;
Console.WriteLine(num);
}
NumTwo();
*/


/*
11. Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.
void NewTask ()
{
int num = new Random().Next (100, 1000);
int res =  num/10;
int res1 = num%10;

Console.WriteLine(num);
Console.WriteLine($"{res}{res1}");
}
NewTask ();
*/


/*
Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, 
что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/


/*     неправильное решение
void NumThird()
{
Console.Write("Введите число, от 1 до 100000:  ");
int num = Convert.ToInt32(Console.ReadLine());
int num2 = num%10; 
if (num2 == 0) Console.WriteLine("В введенном числе нет третьей цифры.");
else Console.WriteLine($"Третья цифра в числе {num} - {num2}.");
}
NumThird();
*/


//  приавильное решение
/*

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
string num2 = Convert.ToString(num);
if (num2.Length > 2) Console.Writ eLine($"В числе: {num}, третья цифра: {num2[2]}.");
else Console.WriteLine($"В числе: {num}, третьей цифры нет.");
*/




/*
Задача 15: Напишите программу, которая принимает на вход цифру, 
обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет
*/

/*
void WeekDay()
{
Console.Write("Введи день недели, цифрой: ");
int day = Convert.ToInt32(Console.ReadLine());
if (day == 6 | day == 7) Console.WriteLine("Выходной.");
else Console.WriteLine("Будний день.");
}
WeekDay();
*/






// void numMax()
// {
// Console.WriteLine("введите первое число a");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("введите второе число b");
// int b = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("введите третье число с");
// int c = Convert.ToInt32(Console.ReadLine());

// if ((b > a) && (b > c)) Console.WriteLine ($"max = {b}");
// else if (c>a && c>b) Console.WriteLine ($"max = {c}");
// else Console.WriteLine ($"max = {a}");
// }
// numMax();


//------------------------------------------------------------------------------



// try
// {
//     void Square()
//     {
//             int num = 1;
//             Console.Write("Введите целое число - ");
//             int N = Convert.ToInt32(Console.ReadLine());

//             Console.Write("Список чётных чисел - ");
//             while(num < N)
//             {
//                 if(num % 2 == 0) 
//                 Console.Write($"{num}, ");
//                 num++;
//             }
//     }
//     Square();
// }
// catch
// {
//     Console.Write("Напишите цифру");
// }


//------------------------------------------------------------------------------

// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, 
// является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да


// Console.WriteLine("Введите число из пяти цифр: ");
// int num = Convert.ToInt32(Console.ReadLine());
// string str = num.ToString();
// if (str[0] == str[4] && str[1] == str[3]) Console.WriteLine($"Введеное вами число {num} - является палиндромом. Это может быть заразно!");
// else Console.WriteLine($"Поздравляем! Вы ввели число из пяти цифр: {num}. А теперь, номер карточки и пин-код.");

//------------------------------------------------------------------------------



// int[] array ()

// {
//     int[] j = 0;
//     Console.WriteLine("Введите число от 1 до бесконечности: ");
//     int[] j = Convert.ToInt32(Console.ReadLine());
// }

// Console.WriteLine(array);









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
// ....записки
// int [] array = new int[2];    // так объявляется массив, говорящий о том что в массиве будет 2 элемента.
// array[1] =     //  а так, выводится 2й элемент из массива.
//------------------------------------------------------------------------------







// int numPalindrom()

// {
//     Console.WriteLine("Введите пятизначное число: ");
//     int numbers = Convert.ToInt32(Console.ReadLine());
//     string number = numbers.ToString();
//     foreach (string number in numbers)
//     {
//         if (number[0] == number[4] && number[1] == number[3]) Console.WriteLine($"Введенное число {numbers}, является палиндромом.");
//         else Console.WriteLine($"Введенное число {numbers}, НЕ является палиндромом.");
//     }
//     return numbers;
// }
// int res = numPalindrom();
// Console.WriteLine(res);

// foreach (string num in numbers)

//------------------------------------------------------------------------------


// Console.WriteLine("Введите число из нескольких цифр: ");
// int numbers = Convert.ToInt32(Console.ReadLine());
// int[] array = int {numbers};
// string number = numbers.ToString();

// num.sum = numbers[0];
// while (count <= number.Length)
// num.sum = 
// count++;

// {
// number = number[1]
// Sum = number[0] + number[1]
// number=number[1]++ 
// }





// может чтото отсюда...?
/*
Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, 
что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/

/*
void Task_13()
{
Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
string num2 = Convert.ToString(num);
if (num2.Length > 2) Console.WriteLine($"В числе: {num}, третья цифра: {num2[2]}.");
else Console.WriteLine($"В числе: {num}, третьей цифры нет.");
}
Task_13();
*/





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






----------------------------------------------------------------



// void Task_8()
// {
//     int num = 1;
//     Console.Write("Введите число: ");
//     int num0 = Convert.ToInt32(Console.ReadLine());

//     Console.WriteLine("Список четных чисел: ");
//     while (num < num0)
//     {
//         if (num%2 == 0) Console.Write($"{num}, ");
//         num = num + 1;
//     }
//     Console.Write("End.");

// }
// Task_8();




// int num[] = int num1[0]
// while (num < )



// string num
// string.Length 
// num[1]



----------------------------------------------------------



// int Sum(int[] numbers)
// {
//     int limit = 0;
//     int result = 0;
//     foreach (int number in numbers)
//     {
//         if (IsPassed(number)) result += number;
//     }
//     return result;

//     bool IsPassed(int number)
//     {
//         return number > limit;
//     }
// }

// int[] numbers1 = { -3, -2, -1, 0, 1, 2, 3 };
// int[] numbers2 = { 3, -4, 5, -6, 7 };

// Console.WriteLine(Sum(numbers1));
// Console.WriteLine(Sum(numbers2));



// ----------------------------------------------------------





//------------------------------------------------------------------------------
//------------------------------------------------------------------------------
//------------------------------------------------------------------------------
DZ-5;
//------------------------------------------------------------------------------
//------------------------------------------------------------------------------
//------------------------------------------------------------------------------
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
//------------------------------------------------------------------------------
//------------------------------------------------------------------------------

// void OutArray(int[] massiv)
// {
//     for (int i = 0; i < N - 1; i++)
//     {
//       Console.Write(massiv[i] +  ", ");
//     }
//     i = N - 1;
//     Console.Write(massiv[i]);
// }
// int[] massiv = new int[N];
// massiv = PrintArray();
// OutArray(massiv);




// int[] numbers = new int[size];
// FillArrayRandomNumbers(numbers);
// Console.WriteLine("Вот наш массив: ");

//------------------------------------------------------------------------------

// void FillArrayRandomNumbers(int[] numbers)
// {
//     for (int i = 0; i < numbers.Length; i++)
//     {
//         numbers[i] = new Random().Next(100, 1000);
//     }
// }

// void PrintArray(int[] numbers)
// {
//     Console.Write("[ ");
//     for (int i = 0; i < numbers.Length; i++)
//     {
//         Console.Write(numbers[i] + " ");
//     }
//     Console.Write("]");
//     Console.WriteLine();
// }

// Console.WriteLine("Введите размер массива");
// int size = Convert.ToInt32(Console.ReadLine());
// int[] numbers = new int[size];
// FillArrayRandomNumbers(numbers);
// Console.WriteLine("Вот наш массив: ");

// PrintArray(numbers);
// int count = 0;
// for (int z = 0; z < numbers.Length; z++)
//     if (numbers[z] % 2 == 0)
//         count++;

// Console.WriteLine($"всего {numbers.Length} чисел, {count} из них чётные");




// int[] FillArray(int size)
//             {
//             int[] mas = new int[size];
//             for (int i=0;i<size;i++) 
//                 {
//                     mas[i]= new Random().Next(-10,11);
//                 }
//             return mas;
//             }

//       void PrintArray(int[] mmm)
//             {
//                        for (int i=0;i<mmm.Length;i++) 
//                 {
//                     if (i!=mmm.Length-1) Console.Write($"{mmm[i]}, ");
//                     else Console.WriteLine($"{mmm[i]}");
//                 }
//             }


//       int[] array = FillArray(10);
//       PrintArray(array);



// Console.WriteLine(result);


// int[] nums2 = new int[4] { 1, 2, 3, 5 };

// int[] FillArray()
// {

// }
// Console.Write(FillArray);
//------------------------------------------------------------------------------
// int[] array ()
// {
//     int[] j = 0;
//     Console.WriteLine("Введите число от 1 до бесконечности: ");
//     int[] j = Convert.ToInt32(Console.ReadLine());
// }
// Console.WriteLine(array);
//------------------------------------------------------------------------------
// matr[i,j] = new Random().Next(1,10); // интервал от 1 до 10
//------------------------------------------------------------------------------
// int x = new Random().Next(10,100);
//------------------------------------------------------------------------------
// ....записки
// int [] array = new int[2];    // так объявляется массив, говорящий о том что в массиве будет 2 элемента.
// array[1] =     //  а так, выводится 2й элемент из массива.
//------------------------------------------------------------------------------
// string[,] table = new string[2, 5];
//------------------------------------------------------------------------------
// int[] FillArray(int size)
// {
//     int size = 4;
//     int[] mas = new int[size];
//     for (int i=0; i<size; i++)
//     {
//         mas[i] = new Random().Next(100, 1000);
//     }
//     return mas;
// }

// void PrintArray(int[] mmm)
// {
//     for (int i=0; i < mmm.Length; i++)
//     {
//         if (i != mmm.Length - 1) Console.Write($"{mmm[i]}, ");
//         else Console.WriteLine($"{mmm[i]}");
//     }
// }

// int[] FindSums(int[] mmm)
// {
//     int[] sums = new int[2];
//     foreach (int item in mmm)
//     {
//         if (item > 0) sums[1] += item;
//         else sums[0] += item;
//     }
//     return sums;
// }

// int[] array = FillArray(12);
// PrintArray(array);
// int[] results = FindSums(array);
// Console.WriteLine($"Сумма положительных элементов массива равна {results[1]}");
// Console.WriteLine($"Сумма отрицательных элементов массива равна {results[0]}");

//------------------------------------------------------------------------------
//------------------------------------------------------------------------------
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
//------------------------------------------------------------------------------
//------------------------------------------------------------------------------

// void Main(string[] args)
// {
//     var rnd = new Random();
//     var arr = new int[1];

//     for (int i = 0; i < arr.Length; i++)
//         Console.Write("{0}\t", arr[i] = rnd.Next(-100, 100));
//     Console.WriteLine();

//     var even = arr.Where((element, index) => index % 2 != 0);
//     var odd = arr.Where((element, index) => index % 2 == 0);

//     Console.WriteLine("Чётные. Количество: {0}. Сумма: {1}.", even.Count(), even.Sum());
//     Console.WriteLine("Нечётные. Количество: {0}. Сумма: {1}.", odd.Count(), odd.Sum());

//     Console.ReadKey();
// }
// Main();



//------------------------------------------------------------------------------

// Найдите сумму чисел массива, которые стоят на нечетных местах 
// и при этом превосходят сумму крайних элементов массива


// void Main(string[] args)
// {
//     int n = 0;

//     while (n <= 4)   //спрашиваем длину массива у пользоватлея - требуем не менее 4-х
//     {
//         Console.WriteLine("Введите длину массива (не менее 4-х элементов)");
//         Int32.Parse(Console.ReadLine());
//     }

//     int[] nn = new int[n]; //Создаем массив заданной пользователем длины

//     for (int i = 0; i < n; i++)  //Пользователь вводит элементы массива
//     {
//         Console.WriteLine("Введите {0} элемент массива", i + 1);
//         nn[i] = Int32.Parse(Console.ReadLine());
//     }

//     Random r = new Random(DateTime.Now.Millisecond);  //Или через генератор случайных чисел
//     for (int i = 0; i < n; i++)
//     {
//         nn[i] = r.Next(1, 100); //Записать случайное число от 1 до 100 
//     }

//     int sr = nn[0] + nn[nn.Length - 1];
//     int sum = 0;
//     //Начинаем с 3-го (i=2) - заканчиваем предпоследним  (nn.Length-1), проходим через одного i+2
//     for (int i = 2; i < nn.Length - 1; i += 2)
//     {
//         if (nn[i] > sum)
//         {
//             sum += nn[i];
//         }
//     }
//     Console.WriteLine("Сумма {0}", sum);
//     Console.ReadKey();
// }

//------------------------------------------------------------------------------
//------------------------------------------------------------------------------
//------------------------------------------------------------------------------

// Задача 38: 
// Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
//------------------------------------------------------------------------------

// 1)
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

// // 2)
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



//------------------------------------------------------------------------------
//------------------------------------------------------------------------------
//------------------------------------------------------------------------------


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
//     Console.Write($"Сумма элементов, стоящих на нечётных позициях => {sum}");
// }

// Console.Write($"Введите размер массива: ");      // запрашиваем на ввод определение кол-ва чисел в массиве
// int size = Convert.ToInt32(Console.ReadLine());      //  Console.ReadLine() считывает и кладет размер массива в переменную size
// int[] massiv = FillArray(size);       // запускаем метод FillArray(size) и результат кладем в переменную array
// SumElements(massiv); // запускаем метод SumElements и передаем ему на вход данные с предыдущего метода



// void FillArray(int size)
// {
//     int[] array = new int[size];

//     double min = 0;
//     double max = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] > array[max]) max = i;
//         else if (array[i] < array[min]) min = i;
//     }
//     Console.Write("min : array[" + min + "] = " + array[min]);
//     Console.Write("max : array[" + max + "] = " + array[max]);
// }
// Console.Write($"Введите размер массива: ");
// int size = Convert.ToInt32(Console.ReadLine());

// FillArray();





// void FindDiff()
// {
//     double difference = 0;
//     double array = new { 8, 3, 5, -1, 2 };
//     double min = array[0];
//     double max = min;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] < min) min = array[i];
//         else if (array[i] > max) max = array[i];
//     }
//     difference = double.of(max - min);
//     return difference;

// }
// FindDiff();

// {
//     OptionalInt range = OptionalInt.empty();
//     if (array != null && array.length > 0)
//     {
//         int min = array[0];
//         int max = min;
//         for (int n : array)
//         {
//             if (n < min)
//             {
//                 min = n;
//             }
//             else if (n > max)
//             {
//                 max = n;
//             }
//         }
//         range = OptionalInt.of(max - min);
//     }
//     return range;
// }







// int[] FillArray(int size)
// {
//     double[] array = new double[size];
//     Random random = new Random();
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = random.NextDouble();
//     }
//     Console.Write(array[i] + ", ");
//     return array;
// }

// Console.Write("Введите размер массива: ");
// int size = Convert.ToInt32(Console.ReadLine());
// FillArray(size);




// double[] array = new double[20];
// Random rand = new Random();
// for (int i = 0; i < array.Length; i++)
// {
//     array[i] = 5 - rand.Next(11) + rand.NextDouble();
// }

// Console.ReadLine();



// double[,] a = new double[5, 10];

// Random random = new Random();
// for (int i = 0; i < 5; i++)
// {
//     for (int j = 0; j < 10; j++)
//     {
//         a[i, j] = random.Next(100);
//         Console.Write("{0,4}", a[i, j]);
//     }
//     Console.WriteLine();
// }



//------------------------------------------------------------------------------

// using System;
// namespace Prim_Mas1
// {
//    class Program
//    {
//       public static void Main(string[] args)
//       {
//          double []x = new double[5];
//          int i, n = x.Length;
//          Console.WriteLine("Задайте {0} вещественных чисел:", n);
//          for(i = 0; i < n; i++)
//          {
//             Console.Write("x[{0}] = ", i);
//             x[i] = double.Parse(Console.ReadLine());
//          }
//          double s = 0;
//          for(i = 0; i < n; i++)
//             s += x[i];
//          s /= n; // это среднее значение
//          for(i = 0; i < n; i++)
//             x[i] -= s;
//          Console.WriteLine("Массив после обработки:");
//          foreach(double r in x)
//             Console.WriteLine(r);
//          Console.Write("Press any key to continue . . . ");
//          Console.ReadKey(true);
//       }
//    }
// }

//------------------------------------------------------------------------------

// int Max(int arg1, int arg2, int arg3)

// {
//     int result = arg1;
//     if (arg2 > result) result = arg2;
//     if (arg3 > result) result = arg3;
//     return result;
// }

// int a1 = 2;
// int b1 = 17;
// int c1 = 89;

// int a2 = 4;
// int b2 = 173;
// int c2 = 82;

// int max1 = Max(a1, b1, c1);
// int max2 = Max(a2, b2, c2);

// int max = Max(max1, max2, c1);

// Console.WriteLine(max);




//------------------------------------------------------------------------------
//------------------------------------------------------------------------------
//------------------------------------------------------------------------------
//------------------------------------------------------------------------------
//------------------------------------------------------------------------------
//------------------------------------------------------------------------------






