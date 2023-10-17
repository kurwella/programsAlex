Random rnd = new Random();
int guess = rnd.Next(1,11);

System.Console.WriteLine("Угадайте число от 1 до 10");
int guess_user = Convert.ToInt32(Console.ReadLine());

if (guess == guess_user)
{
    System.Console.WriteLine("Число угадано!");
}
else
{
    System.Console.WriteLine($"Число не угадано :(, загаданное число - {guess}");
}