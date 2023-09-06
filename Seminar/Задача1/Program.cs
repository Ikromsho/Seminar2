// // Напишите программу, которая выводит случайное трехзначное число 
// // и удаляет вторую цифру этого числа.

// // 456 -> 46
// // 782 -> 72
// // 918 -> 98

int randNum = new Random().Next(100,1000);
int num = randNum;
System.Console.WriteLine(num);

int formatNum = num/ 100 * 10 + num % 10;
System.Console.WriteLine(formatNum);


//Выполнено.Работает.