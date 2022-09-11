#!/usr/bin/env dotnet-script

Console.WriteLine("*** Strings ***\n");

var fullName = "Osman Taş  ";

// Console.WriteLine($"fullName : '{fullName}'");
// Console.WriteLine($"trim     : '{fullName.Trim()}'");
// Console.WriteLine($"ToUpper  : '{fullName.Trim().ToUpper()}'");

// var spacePos = fullName.IndexOf(' ');
// var firstName = fullName.Substring(0, spacePos);
// var lastName = fullName.Substring(spacePos + 1);

// Console.WriteLine($"firstName: _{firstName}_");
// Console.WriteLine($"lastName : _{lastName}_");

// var names = fullName.Split(' ');
// Console.WriteLine($"firstName: *{names[0]}*");
// Console.WriteLine($"lastName : *{names[1]}*");

// Console.WriteLine(fullName.Replace("Osman", "Matthew")); // immutable, new string returned

// either null, empty or space character it is captured
// String.IsNullOrEmpty() null or empty
// if (String.IsNullOrWhiteSpace(null)) Console.WriteLine($"** invalid");

// var str = "25";
// var age = Convert.ToByte(str); // Convert.ToInt32()
// Console.WriteLine($"age: {age}");


// var price = 29.95f;
// Console.WriteLine(price.ToString("C")); // $29.95
// Console.WriteLine(price.ToString("C0"));// $30


// problem summarize a blog text

var sentence = "Pariatur ea nulla nisi duis. Non voluptate consequat labore fugiat veniam cillum nisi nulla consectetur proident. Est deserunt commodo fugiat esse occaecat cillum nulla pariatur. Magna ex deserunt ea eiusmod dolor duis nostrud sit commodo esse ex. Tempor ad anim consectetur est. Officia qui aliqua eiusmod reprehenderit.";

Console.WriteLine(summarize(sentence, 60));


static string summarize(string text, int maxLength)
{
    if (text.Length < maxLength) return text;
    var words = text.Split(' ');
    var totalChars = 0;
    foreach (var word in words)
    {
        if (totalChars + word.Length > maxLength) break;
        totalChars += word.Length + 1;
    }
    return text.Substring(0, totalChars - 1) + "...";
}