System.Console.WriteLine("Введите два числа в консоль: ");
int number1 = Convert.ToInt32(Console.ReadLine());
int number2 = Convert.ToInt32(Console.ReadLine());
int ostatok = number1%number2;
if (number1%number2 == 0)
{
    System.Console.WriteLine("Кратно");
}
else
{
    System.Console.WriteLine($"Не кратно, остаток {ostatok}");
}