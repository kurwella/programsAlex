int Prompt(string message)
{
    Console.Write(message);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}

int GetRank(int number)
{
    while (number > 999)
    {
        number /= 10;
        Console.WriteLine("Число больше, ты еблан");
    }
    return number % 10;
}

bool RankAuth(int number)
{
    if (number < 100)
    {
        System.Console.WriteLine("Число двухзначное");
        return false;
    }
    return true;
}

int number = Prompt("Введите число");
if (RankAuth(number))
{
    System.Console.WriteLine(GetRank(number));
}