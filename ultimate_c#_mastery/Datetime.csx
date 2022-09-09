#!/usr/bin/env dotnet-script

Console.WriteLine("*** DateTime ***\n");

var dateTime = new DateTime(2022, 8, 31);
Console.WriteLine("dateTime: {0}", dateTime);
var now = DateTime.Now;
Console.WriteLine($"now : {now}");
Console.WriteLine($"hr: {now.Hour}");
Console.WriteLine($"min: {now.Minute}");
var today = DateTime.Today;
Console.WriteLine($"today: {today}");

var tomorrow = now.AddDays(1);
Console.WriteLine($"tomorrow {tomorrow}");

var yesterday = now.AddDays(-1);
Console.WriteLine($"yesterday {yesterday}");

Console.WriteLine(now.ToLongDateString());
Console.WriteLine(now.ToShortDateString());
Console.WriteLine(now.ToLongTimeString());
Console.WriteLine(now.ToShortTimeString());
Console.WriteLine(now.ToString("yyyy-MM-dd HH:mm"));
