#!dotnet-script

#r "nuget: Bogus, 29.0.2"
#load "Person.csx"

using Bogus;

var peopleGenerator = new Faker<Person>()
    .RuleFor(o => o.FirstName, f => f.Name.FirstName())
    .RuleFor(o => o.LastName, f => f.Name.LastName());

var person = peopleGenerator.Generate();
Console.WriteLine($"Hello, {person.FirstName} {person.LastName}");
// Console.ReadKey();

