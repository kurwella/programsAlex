int Prompt(string question)
{
    System.Console.WriteLine(question);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}

int number = Prompt("Введите трехзначное число");
if (number >= 1000 || number < 100)
{
    System.Console.WriteLine("Вы ввели не трехзначное число");
    return;
}
System.Console.WriteLine($"Исходное число - {number}");
int SecondNum = number / 10 % 10;
System.Console.WriteLine($"Вторая цифра данного числа: {SecondNum}");