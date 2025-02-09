List<int> numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToList();
string[] input = Console.ReadLine().Split();

while (input[0] != "End")
{
    if (input[0] == "Remove")
    {
        int numberToRemove = int.Parse(input[1]);
        if (numberToRemove >= numbers.Count || numberToRemove < 0)
        {
            Console.WriteLine("Invalid index");
        }
        else
        {
            numbers.RemoveAt(numberToRemove);
        }

    }// removes index
    else if (input[0] == "Insert")
    {
        int numberToAdd = int.Parse(input[1]);
        int index = int.Parse(input[2]);
        if (index > numbers.Count|| index < 0)
        {
            Console.WriteLine("Invalid index");
        }
        else
        {
            numbers.Insert(index, numberToAdd);
        }
    } // inserts the number at the given index
    else if (input[0] == "Add")
    {
        int numberToAdd = int.Parse(input[1]);
        numbers.Add(numberToAdd);
    } // adds a number to the end of the list
    else if (input[0] == "Shift" && input[1] == "left")
    {
        int rotationLeft = int.Parse(input[2]);

        for (int i = rotationLeft; i > 0; i--)
        {
            int zatritotoMiChislo = numbers[0];
            for (int j = 0; j < numbers.Count - 1; j++)
            {
                numbers[j] = numbers[j + 1];
            }
            numbers[numbers.Count - 1] = zatritotoMiChislo;
        }
    } // shifts the first element to be the last one as many times as mentioned
    else if (input[0] == "Shift" && input[1] == "right")
    {
        int rotationRight = int.Parse(input[2]);

        for (int i = rotationRight; i > 0; i--)
        {
            int zatritotoMiChislo = numbers[numbers.Count - 1];
            for (int j = numbers.Count - 1; j > 0; j--)
            {
                numbers[j] = numbers[j - 1];
            }
            numbers[0] = zatritotoMiChislo;
        }
    } // shifts the last element to be the first one as many times as mentioned
    input = Console.ReadLine().Split();
}
Console.WriteLine(string.Join(" ", numbers));
