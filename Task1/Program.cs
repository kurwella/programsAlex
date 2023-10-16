int number = new Random().Next(10, 100);
System.Console.WriteLine($"Ваше случайное число = {number}");
int digit1 = number / 10;
int digit2 = number % 10;

if (digit1 > digit2)
{
    Console.WriteLine(digit1);
}
else if (digit1 < digit2)
{
    Console.WriteLine(digit2);
}
else
{
    Console.WriteLine("Цифры равны");
}
