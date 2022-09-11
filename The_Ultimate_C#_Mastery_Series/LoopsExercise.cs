using System;

class Loops
{
    /// <summary>
    /// Write a program to count how many numbers between 1 and 100 are divisible by 3 with no remainder. Display the count on the console.
    /// </summary>
    public void Exercise1()
    {
        var count = 0;
        for (var i = 1; i <= 100; i++)
        {
            if (i % 3 == 0)
            {
                count++;
            }
        }
        Console.WriteLine(count);
        Console.ReadLine();
    }

    /// <summary>
    /// Write a program and continuously ask the user to enter a number or "ok" to exit. Calculate the sum of all the previously entered numbers and display it on the console.
    /// </summary>
    public void Exercise2()
    {
        var sum = 0;
        while (true)
        {
            System.Console.WriteLine("Enter a number or \"ok\" to exit");
            var input = Console.ReadLine();
            if (input == "ok")
            {
                break;
            }
            sum += int.Parse(input);
        }
        System.Console.WriteLine($"sum = {sum}");
    }

    /// <summary>
    /// Write a program and ask the user to enter a number. Compute the factorial of the number and print it on the console. For example, if the user enters 5, the program should calculate 5 x 4 x 3 x 2 x 1 and display it as 5! = 120.
    /// </summary>
    public void Exercise3()
    {
        System.Console.WriteLine("Enter a number for factorial");
        var input = Console.ReadLine();
        var number = int.Parse(input);
        var factorial = 1;
        for (var i = 2; i <= number; i++)
        {
            factorial *= i;
        }
        System.Console.WriteLine($"factorial = {factorial}");
    }

    /// <summary>
    /// Write a program that picks a random number between 1 and 10. Give the user 4 chances to guess the number. If the user guesses the number, display “You won"; otherwise, display “You lost". (To make sure the program is behaving correctly, you can display the secret number on the console first.)
    /// </summary>
    public void Exercise4()
    {
        var random = new Random();
        var pick = random.Next(1, 10);
        var left = 4;
        var result = "You lost";
        System.Console.WriteLine(pick);
        for (var i = 0; i < left; i++)
        {
            System.Console.WriteLine("Enter a number between 1 and 10");
            var input = Console.ReadLine();
            var guess = int.Parse(input);
            if (guess == pick)
            {
                result = "You win";
                break;
            }
        }
        System.Console.WriteLine(result);
    }

    /// <summary>
    /// Write a program and ask the user to enter a series of numbers separated by comma. Find the maximum of the numbers and display it on the console. For example, if the user enters “5, 3, 8, 1, 4", the program should display 8.
    /// </summary>
    public void Exercise5()
    {
        Console.WriteLine("Enter a series of numbers separated by commas:\n\t");
        var input = Console.ReadLine();
        var numStr = input.Split(',');
        var max = Convert.ToInt32(numStr[0]);
        foreach (var str in numStr)
        {
            var n = Convert.ToInt32(str);
            if (n > max)
                max = n;
        }
        Console.WriteLine($"maximum number is {max}");
    }
}
