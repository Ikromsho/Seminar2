// Напишите программу, которая будет принимать 
// на вход два числа и выводить, является ли второе число кратным первому.
//  Если число 2 не кратно числу 1, то программа выводит остаток от деления.

System.Console.WriteLine("Введите два числа:");
int num1 = int.Parse(Console.ReadLine());
int num2 = int.Parse(Console.ReadLine());

if (num1 % num2 == 0)
{
    System.Console.WriteLine($"Число {num2} кратно {num1}.");
}
else
{
    System.Console.WriteLine($"Число {num2} не кратно {num1}.");
}


//Выполнил.Работает.