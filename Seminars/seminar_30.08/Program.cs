

// xz--------------------------------------------------------------


/*
9. Напишите программу, 
которая выводит случайное число из отрезка [10, 99] 
и показывает наибольшую цифру числа.
*/

int x = xa, y = xb;
int count = 0;
while(count < 10000)
{
    int what = new Random().Next(0, 3);       // 0,1,2 

    if(what == 0)
    {
        x = (x + xa) / 2;
        y = (y + ya) / 2;
    }

    if(what == 1)
    {
        x = (x + xb)/2;
        y = (y + yb)/2;
    }

    if(what == 2)
    {
        x = (x + xc)/2;
        y = (y + yc)/2;
    }
    Console.SetCursorPosition(x, y);
    Console.WriteLine("+");
    count = count + 1;
}

// --------------------------------------------------------------------

Console.Write ("Введите целое число ");
try
    {
        int x = Convert.ToInt32 (Console.ReadLine());
        Console.WriteLine ( x * 10 );
        }
        catch 
        {
            Console.WriteLine("надо было вводить именно целое число");
        }



/* 
11. Напишите программу, которая выводит 
случайное трёхзначное число 
и удаляет вторую цифру этого числа.
456 -> 46
782 -> 72
918 -> 98
*/


void NewTask ()
{
int num = new Random().Next (100, 1000);

int res =  num/100;
int res1 = num%10;

Console.WriteLine(num);
Console.WriteLine($"{res}{res1}");
}

NewTask ();


// var.

int x = new Random().Next(10,100);
    int x1 = x/10;
    int x2 = x%10;
    Console.WriteLine($"Сгенерировано случайное число {x} ");
    if (x1>x2) Console.WriteLine("Первая цифра больше");
    else if (x2>x1) Console.WriteLine("Вторая цифра больше");
    else Console.WriteLine("Это паллиндром!");


void CompareDigits()
{
    int x = new Random().Next(10,100);
    int x1 = x/10;
    int x2 = x%10;
    Console.WriteLine($"Сгенерировано случайное число {x} ");
    if (x1>x2) Console.WriteLine("Первая цифра больше");
    else if (x2>x1) Console.WriteLine("Вторая цифра больше");
    else Console.WriteLine("Это паллиндром!");
}

    CompareDigits();
    CompareDigits();


//----------------------------------------------------------------


/*
12. Напишите программу, которая будет принимать на вход два числа и выводить, 
является ли второе число кратным первому. 
Если число 2 не кратно числу 1, то программа выводит остаток от деления.
34, 5 -> не кратно, остаток 4 
16, 4 -> кратно
*/


// var.1
void Digits()
    {
    Console.WriteLine("Введите целое число");
    int x = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите еще одно целое число");
    int y = Convert.ToInt32(Console.ReadLine());
    if (x%y == 0) Console.WriteLine($"Число {y} кратно числу {x}");
    else Console.WriteLine($"Остаток деления {y} на {x} равен {y%x}");
    }
Digits();


// var.2 
void numbers(int num1, int num2)
{
    if (num1 % num2 == 0) Console.WriteLine("Первое число кратно второму");
    else Console.WriteLine($"Первое число не кратно второму, остаток {num1 % num2}");
}

Console.Write("Введите первое число: ");
int num1 = int.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
int num2 = int.Parse(Console.ReadLine());

numbers(num1, num2);
Console.WriteLine();


/*
14. Напишите программу, 
которая принимает на вход число и проверяет, 
кратно ли оно одновременно 7 и 23.
14 -> нет 
46 -> нет 
161 -> да
*/

void numbers(int num1)
{
    if (num1 % 7  == 0 && num1 % 23  == 0) Console.WriteLine($"Число {num1} кратно 7 и 23");
    else Console.WriteLine($"Число {num1} не кратно 7 и 23");
}

Console.Write("Введите  число: ");
int num1 = int.Parse(Console.ReadLine());

numbers(num1);
Console.WriteLine();

// ---------------------------------------------------------------------------


/*
16. Напишите программу, 
которая принимает на вход два числа и проверяет, 
является ли одно число квадратом другого.
5, 25  ->  да
-4, 16  ->  да
25, 5  ->  да
8,9  ->  нет
*/


// var.1
void numbers(int num1, int num2)
{
    if (Math.Pow(num1) == num2) Console.WriteLine($"{num1} является квадратом {num2}");
    else Console.WriteLine($"{num1} не является квадратом {num2}");
}

Console.Write("Введите первое число: ");
int num1 = int.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
int num2 = int.Parse(Console.ReadLine());

numbers(num1, num2);
Console.WriteLine();


// var.2
void Square (int num1, int num2)
{
    if (num1*num1 == num2) Console.WriteLine ($"Число {num2} является квадратом числа {num1} ");
    else if (num2*num2 == num1) Console.WriteLine ($"Число {num1} является квадратом числа {num2} ");
    else Console.WriteLine ($"Числа {num1} и {num2} не являются квадратами друг друга ");
}

Console.Write("Введите первое число: ");
int num1 = int.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
int num2 = int.Parse(Console.ReadLine());

Square (num1, num2);


// var.3
void Num (int number)
{
    if (number % 7 == 0 & number % 23 == 0)
    {
        Console.WriteLine($"Число {number} кратно 7 и 23");
    }
    else 
    {
        Console.WriteLine($"Число {number} НЕ кратно 7 и 23");
    }
}

Num(161);


//------------------------------------------------------------------------


int n, k, p, z = 1;
cin>>n>>k;
p = n;

while(p != 0){
    p = p / 10;
    z = z * 10;
}

switch(k){
    case 1: k = 10; break;
    case 2: k = 100; break;
    case 3: k = 1000; break;
    case 4: k = 10000; break;
    case 5: k = 100000; break;
}

z = z / k;
p = n;
p = p / z;


int x = 2179;
int y = int.Parse(x.ToString().Remove(0, 1));
Console.WriteLine(y);


