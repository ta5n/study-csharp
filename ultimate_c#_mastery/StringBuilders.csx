#!/usr/bin/env dotnet-script

Console.WriteLine("*** StringBuilders ***\n");

var builder = new StringBuilder();

builder
    .Append('-', 10)
    .AppendLine()
    .Append("Title")
    .AppendLine()
    .Append('-', 10)
    .Replace('-', '*')
    .Remove(0, 10)
    .Insert(0, new string('-', 10));

Console.WriteLine($"builder: \n{builder}");
Console.WriteLine($"first character: {builder[0]}");

