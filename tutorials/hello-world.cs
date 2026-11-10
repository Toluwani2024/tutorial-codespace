// Console.WriteLine("Hello, World!");

// string name = "Joebnxn";
// Console.WriteLine(name);

// string aFriend = "John";
// int age = 25;
// Console.WriteLine(aFriend);
// Console.WriteLine(age);
// aFriend="Joe";
// Console.WriteLine(aFriend);
// Console.WriteLine("Hello, " + aFriend + "!");
// Console.WriteLine($"Hello, {aFriend}!");
// Console.WriteLine($"Hello, {aFriend}. I am {age} years old.");

// string firstName = "John";
// string lastName = "Doe";
// Console.WriteLine($"Hello , my Friend's are {firstName} and {lastName}.");
// Console.WriteLine($"The name {firstName} has {firstName.Length} letters.");


string firstName = "John";
int birthYear = 1998;
int currentYear = DateTime.Now.Year;
int age = currentYear - birthYear;
Console.WriteLine($"Hello, {firstName}. You are {age} years old.");