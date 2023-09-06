// // Напишите программу, которая выводит случайное трехзначное число 
// // и удаляет вторую цифру этого числа.

// // 456 -> 46
// // 782 -> 72
// // 918 -> 98

// // Random rand = new Random();
// // int num = rand.Next(100,1000);
// // System.Console.WriteLine(num);

// // if (num>100 && num<1000)
// // {
// //     int num1 = num / 100;
// //     int num2 = num%10;
// //     int fullnum = (num*10)+num2;
// // }
// // System.Console.WriteLine(fullnum);


// // Напишите программу, которая будет принимать 
// // на вход два числа и выводить, является ли второе число кратным первому.
// //  Если число 2 не кратно числу 1, то программа выводит остаток от деления.

// // 34, 5 -> не кратно, остаток 4 
// // 16, 4 -> кратно

// // System.Console.WriteLine("Напишите два числа: ");
// // int num1 = Convert.ToInt32(Console.ReadLine());
// // int num2 = Convert.ToInt32(Console.ReadLine());
// // int newNum = num1 % num2;
// // if (newNum == 0)
// // {
// //     Console.WriteLine("Второе число кратно первому");
// // } 
// // else
// // {
// //     System.Console.WriteLine($"Второе число не кратно первому, остаток от деления = " + newNum);
// // }


// // Напишите программу, которая принимает на вход число и проверяет,
// //  кратно ли оно одновременно 
// // 7 и 23.

// // System.Console.WriteLine("Введите число:");
// // int num = Convert.ToInt32(System.Console.ReadLine());
// // if (num % 7 == 0  && num % 23 == 0)
// // {
// //     System.Console.WriteLine("Число кратно 7 и кратно 23.");
// // }
// // else
// // {
// //     System.Console.WriteLine("Число не кратно 7 и 23.");
// // }

// // Напишите программу,
// //  которая принимает на вход два числа и проверяет, 
// //  является ли одно число квадратом другого.

// // 5, 25  ->  да
// // -4, 16  ->  да
// // 25, 5  ->  да
// // 8,9  ->  нет

// Console.Write("Введите первое число :");
// string strNum1 = Console.ReadLine();
// int num1 = int.Parse(strNum1);
// Console.Write("Введите второе число :");
// string strNum2 = Console.ReadLine();
// int num2 = int.Parse(strNum2);
//  Console.WriteLine("Вы ввели числа : " + num1+ " и " + num2);

// if (num1 == num2*num2 || num2 == num1*num1){
//     Console.WriteLine("Да");
//  }
// else{
//      Console.WriteLine("Нет");
//  }

// System.Console.WriteLine();
// System.Console.WriteLine();

// Console.ReadLine();





// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6


System.Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

void getNum3(int number)

{
    if (number < 100)



    {
        System.Console.WriteLine("Третей цифры нет!");

    }
    else
    {
        while (number > 999)
        {
            number = number / 10;


        }
        Console.WriteLine($"Третяя цифра {number % 10}.");
    }
    
}
getNum3(num);

