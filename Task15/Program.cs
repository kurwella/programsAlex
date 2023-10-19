int Prompt(string user_data)
{
    Console.Write(user_data);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}

bool IsWeekend(int day)
{
    if (day > 5)
    {
        return true;
    }
    else 
    {
        return false;
    }
}

bool Validate(int number)
{
    if (number > 0 && number <= 7)
    {
        return true;
    }
    System.Console.WriteLine("Это не день недели");
    return false;
}

int day = Prompt("Введите искомый день >>> ");
if (Validate(day))
{
    if (IsWeekend(day))
    {
        Console.WriteLine("Отдыхай бро");
    }
    else
    {
        Console.WriteLine("На завод пиздуй");
    }
}