// Урок 9. Как не нужно писать код. Часть 3

// --------------------------------------------------------------------------------------
Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
Выполнить с помощью рекурсии.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

int N = EnterNum("Введите положительное число N: ");
int a = 1;
Console.WriteLine(CheckNum(N, a));

int CheckNum(int N, int a)
{
    if (N == a)
        return N;
    else
        Console.Write($"{CheckNum(N, a + 1)}, ");
    return a;
}

int EnterNum(string output)
{
    Console.Write(output);
    return int.Parse(Console.ReadLine());
}


// --------------------------------------------------------------------------------------
// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N. 
// Выполнить с помощью рекурсии.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int m = EnterNum("Введите число M: ");
int n = EnterNum("Введите число N: ");
Console.WriteLine($"Сумма чисел между {m} и {n} = {SumNum(m, n)}");

int EnterNum(string output)
{
    Console.Write(output);
    return int.Parse(Console.ReadLine());
}

int SumNum(int m, int n)
{
    if (m == n)
        return n;
    return n + SumNum(m, n - 1);
}


// --------------------------------------------------------------------------------------
// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29


Console.WriteLine("Введите два положительных числа:");
int m = EnterNum("- число M: ");
int n = EnterNum("- число N: ");
Console.WriteLine($"A({m}, {n}) = {funcAkkerman(m, n)}");

int EnterNum(string output)
{
    Console.Write(output);
    return int.Parse(Console.ReadLine());
}

int funcAkkerman(int m, int n)
{
    if (m == 0)
        return n + 1;
    if (m > 0 && n == 0)
        return funcAkkerman(m - 1, 1);
    else
        return funcAkkerman(m - 1, funcAkkerman(m, n - 1));
}


