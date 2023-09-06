// Напишите программу, которая выводит случайное трехзначное число 
// и удаляет вторую цифру этого числа.

// 456 -> 46
// 782 -> 72
// 918 -> 98

int rand = new Random().Next(100, 1000);
int num = rand;
int num2 = num/100*10 + (num%10);
System.Console.WriteLine(num);
System.Console.WriteLine(num2);

//Выполнил.Работает.