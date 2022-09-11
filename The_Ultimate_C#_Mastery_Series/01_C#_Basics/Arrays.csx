#!dotnet-script

Console.WriteLine("Array methods");
var numbers = new[] { 3, 7, 9, 2, 14, 6 };
Console.WriteLine("{0}", numbers.Length);

// indexOf()
var index = Array.IndexOf(numbers, 9);
Console.WriteLine($"index of 9 is {index}");

// clear()
/* Array.Clear(numbers, 0, 2);
foreach (var n in numbers)
{
    Console.Write($"{n} ");
}
Console.WriteLine(); */

// Copy
int[] another = new int[4];
Array.Copy(numbers, another, 4);
Console.WriteLine($"copied 4 numbers to another");

foreach (var a in another)
{
    Console.Write($"{a} ");

}
Console.WriteLine();

// sort
Array.Sort(numbers);
Console.WriteLine($"Sorted numbers");

foreach (var n in numbers)
{
    Console.Write($"{n} ");

}
Console.WriteLine();

