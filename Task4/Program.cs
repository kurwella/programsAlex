﻿Console.WriteLine("Введите Число");
int number = Convert.ToInt32(Console.ReadLine());

if (number % 7 == 0 && number % 23 == 0)
{
    System.Console.WriteLine("Yes");
}
else
{
    System.Console.WriteLine("No");
}