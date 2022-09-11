#!dotnet-script

Console.WriteLine("*** Lists ***\n");

var numbers = new List<int> { 3, 5, 7, 2, 14, 9 };
numbers.Add(4);
numbers.AddRange(new int[4] { 5, 2, 8, 6 });
foreach (var item in numbers)
{
    // if (item == 14) break;
    Console.Write($"{item} ");
}
Console.WriteLine();

Console.WriteLine($"index of 7: {numbers.IndexOf(7)}");
Console.WriteLine($"last index of 2: {numbers.LastIndexOf(2)}");

Console.WriteLine($"count of list: {numbers.Count}");

numbers.RemoveAll((n) => n == 2);
foreach (var item in numbers)
{
    // if (item == 14) break;
    Console.Write($"{item} ");
}
Console.WriteLine();



