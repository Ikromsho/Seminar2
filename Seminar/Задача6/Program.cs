﻿// // Напишите программу,
// //  которая принимает на вход два числа и проверяет, 
// //  является ли одно число квадратом другого.

// // 5, 25  ->  да
// // -4, 16  ->  да
// // 25, 5  ->  да
// // 8,9  ->  нет

System.Console.Write("Введите два числа: ");
int num1 = Convert.ToInt32(Console.ReadLine());
int num2 = Convert.ToInt32(Console.ReadLine());
if (num1 == num2 * num2 || num2 == num1 * num1)
{
    System.Console.WriteLine("Одно число является квадратом второго.");
}
else
{
    System.Console.WriteLine("Ни одно число не является квадратом другого.");
}

//Выполнил.Работает.