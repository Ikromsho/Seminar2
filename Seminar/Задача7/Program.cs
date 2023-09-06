// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

using System.Runtime.Intrinsics.Arm;

System.Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine());

void getNum(int number)
{
    if (number < 99)
    {
        System.Console.WriteLine("Третей цифры нет");
    }
    else
    {
        while(number > 999)
        {
            number = number/10;
        }
    }
}
getNum(num);