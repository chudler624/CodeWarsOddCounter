Console.WriteLine("Pick a number");
int userInput = int.Parse(Console.ReadLine());


List<int> numbers = new List<int>();
for (int i = userInput-1; i > 0; i--)
{
    if (i %2 == 1)
    {
        numbers.Add(i);
    }
}
Console.WriteLine("number of odd numbers that are positive below your number");
Console.WriteLine(numbers.Count);

Console.WriteLine("these are the numbers that were added to the list");
foreach (var item in numbers)
{
    Console.WriteLine(item);
}