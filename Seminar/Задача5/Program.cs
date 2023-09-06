// // Напишите программу, которая принимает на вход число и проверяет,
// //  кратно ли оно одновременно 
// // 7 и 23.

System.Console.WriteLine("Введите числo: ");
int num = int.Parse(Console.ReadLine());
if (num % 7 == 0 && num % 23 == 0)
{
    System.Console.WriteLine("число кратно.");
}
else
{
    System.Console.WriteLine("число не кратно.");
}

//Выполнил.Работает.
