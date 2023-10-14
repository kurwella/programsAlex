void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1, 10);
        index++;
    }
}

void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}

int IndexOf(int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int position = 0;
    while (index < count)
    {
        if (collection[index] == find)
        {
            position = index;
            break;
        }
            index++;
    }
    return position;
}

int[] array = new int[10];
int number;

FillArray(array);
PrintArray(array);
Console.WriteLine();
Console.Write("Введите искомое число");
number = Convert.ToInt32(Console.ReadLine());

int pos = IndexOf(array, number);
bool number_exists = array.Contains(number);
if (number_exists == true)
{
    Console.WriteLine(pos);
}
else
{
    Console.WriteLine("Your number does not exists in array");
}