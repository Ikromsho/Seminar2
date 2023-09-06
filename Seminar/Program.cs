// Напишите программу, 
// которая выводит случайное число из отрезка [10, 99] 
// и показывает наибольшую цифру числа.

// Например:
// 78 -> 8
// 12-> 2
// 85 -> 8

Console.WriteLine("Введите число: ");

Random rand = new Random();
int num = rand.Next(10, 100);

int num1 = num / 10;
int num2 = num % 10;
System.Console.WriteLine(num);
if (num1 > num2)
{
    System.Console.WriteLine(num1);
}
else
{
    System.Console.WriteLine(num2);
}
