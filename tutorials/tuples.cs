var person = (Name: "John", Age: 30);
Console.WriteLine($"Name: {person.Name}, Age: {person.Age}");

var (name, age) = person;
Console.WriteLine($"Name: {name}, Age: {age}");

var pt = (X: 10, Y: 20);
Console.WriteLine($"X: {pt.X}, Y: {pt.Y}");