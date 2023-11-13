
#region ReadLine example

Console.WriteLine("Please enter your name:");
string name = Console.ReadLine();
Console.WriteLine($"Hello, {name}!");

#endregion

#region foreach example
string[] people = { "Alice", "Bob", "Charlie", "Dave" };

foreach (string person in people)
{
   Console.WriteLine(person);
}
#endregion

#region string examples
// Creating a string
string myString = "Hello, world!";

// String length
int length = myString.Length;
Console.WriteLine($"Length: {length}");

// String concatenation
string name = "John";
string greeting = "Hello, " + name + "!";
Console.WriteLine(greeting);

// String interpolation
int age = 30;
string message = $"My name is {name} and I'm {age} years old.";
Console.WriteLine(message);

// String methods
string myString2 = "   Hello, world!   ";
Console.WriteLine(myString2.Trim()); // Removes leading and trailing whitespace
Console.WriteLine(myString2.ToUpper()); // Converts to uppercase
Console.WriteLine(myString2.ToLower()); // Converts to lowercase
Console.WriteLine(myString2.Substring(7, 5)); // Extracts a substring
Console.WriteLine(myString2.Replace("world", "everyone")); // Replaces a substring

// String conversions
int num = 42;
string numString = num.ToString();
Console.WriteLine(numString);

string numString2 = "123";
int num2 = int.Parse(numString2);
Console.WriteLine(num2);
#endregion
