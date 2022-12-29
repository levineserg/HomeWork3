// Задача 19

// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет

// 12821 -> да

// 23432 -> да

Console.Write("Веедите 5-значное число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 100000 && number > 9999)
{
    string str = Convert.ToString(number);
    if (str[0] == str[0] && str[1] == str[3])
    {
        Console.WriteLine("Да");
    }
    else Console.WriteLine("Нет");
}
else Console.WriteLine("Это не 5-значное число");
