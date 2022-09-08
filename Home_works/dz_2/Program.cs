
/*
Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1
*/

/*
void Task_10()
{
Console.Write("Введите трехзначное число: ");
int num = Convert.ToInt32(Console.ReadLine());
int num1 = num/10;
int num2 = num1%10;
num = num2;
Console.WriteLine(num);
}
Task_10();
*/


//-----------------------------------------------
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


//-----------------------------------------------
/*
Задача 15: Напишите программу, которая принимает на вход цифру, 
обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет
*/


void WeekDay()
{
Console.Write("Введи день недели, цифрой: ");
int day = Convert.ToInt32(Console.ReadLine());
if (day == 6 | day == 7) Console.WriteLine("Выходной.");
else Console.WriteLine("Будний день.");
}
WeekDay();

