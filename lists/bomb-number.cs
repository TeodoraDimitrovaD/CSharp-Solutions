List<int> numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToList();
string[] input = Console.ReadLine().Split();

int bomb = int.Parse(input[0]);
int power = int.Parse(input[1]);
int finalSum = 0;

while (numbers.Contains(bomb))
{
    int index = numbers.IndexOf(bomb);

    for (int i = 1; i <= power; i++)
    {
        if (numbers.Count  > index + 1) 
        {
            numbers.RemoveAt(index + 1);
        }
    } // Изваждане на числа от дясно
    for (int i = 1; i <= power; i++)
    {
        if (index - i >= 0)
        {
            numbers.RemoveAt(index - i);
        }

    } // Изваждане на числа от ляво
    numbers.Remove(bomb); // Изваждане на бомбата
}

Console.WriteLine(numbers.Sum());
