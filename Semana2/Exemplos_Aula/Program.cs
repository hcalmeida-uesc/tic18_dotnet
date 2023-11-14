 
/* #region ReadLine example

Console.WriteLine("Please enter your name:");
string? name = " \n\t";

Console.WriteLine(string.IsNullOrWhiteSpace(name));

Console.WriteLine($"Hello, {name.ToUpper()}!");
Console.WriteLine($"Hello, {name}!");
Console.WriteLine($"Tamanho, {name.Length}!");
string[] nameSplited = name.Split(" ");
foreach(string namePart in nameSplited)
{
    Console.WriteLine(namePart);
}

#endregion
 */
/* #region foreach example
string[] people = { "Alice", "Bob", "Charlie", "Dave" };

foreach (string person in people)
{
   Console.WriteLine(person);
}
#endregion
 */
/* #region List Example

// List of integers
List<int> numbers = new List<int>();
numbers.Add(1);
numbers.Add(2);
numbers.Add(3);
numbers.Add(4);
numbers.Add(5);

Console.WriteLine("List of integers:");
foreach (int number in numbers)
{
   Console.WriteLine(number);
}
Console.WriteLine($"Tamanho, {numbers.Count}!");
Console.WriteLine($"Contém 3?, {numbers.Contains(3)}!");



// List of strings
List<string> names = new List<string>();
names.Add("Alice");
names.Add("Bob");
names.Add("Charlie");
names.Add("Dave");
names.Add("Eve");

Console.WriteLine("List of strings:");
foreach (string name in names)
{
   Console.WriteLine(name);
}

List<List<string>> names2 = new List<List<string>>();
names2.Add(new List<string>(){ "Alberto", "Allana", "Álvaro"});
names2.Add(new List<string>(){ "Biancardy", "Bruno"});
names2.Add(new List<string>(){ "Carlos"});
foreach(List<string> names3 in names2)
{
   foreach(string name in names3)
   {
      Console.WriteLine(name);
   }
}
#endregion
 */
/* #region DateTime Example

DateTime now = DateTime.Now;
Console.WriteLine($"Current date and time: {now}");

 DateTime today = DateTime.Today;
 Console.WriteLine($"Today's date: {today}");

 DateTime tomorrow = now.AddDays(1);
 Console.WriteLine($"Tomorrow's date: {tomorrow}");

 DateTime yesterday = today.AddDays(-1);
 Console.WriteLine($"Yesterday's date: {yesterday}");

 DateTime specificDate = new DateTime(1987,09,24);
 Console.WriteLine($"Specific date: {specificDate}");
 Console.WriteLine($"Week Day: {specificDate.DayOfWeek}");

DateTime parsedDate = DateTime.Parse("2022-12-31");
Console.WriteLine($"Parsed date: {parsedDate}");

TimeSpan timeDifference = specificDate - now;
Console.WriteLine($"Time difference: {timeDifference.ToString()}");

 DateTime utcNow = DateTime.UtcNow;
 Console.WriteLine($"UTC date and time: {utcNow}");

 DateTime easternTime = TimeZoneInfo.ConvertTimeFromUtc(utcNow, TimeZoneInfo.FindSystemTimeZoneById("Eastern Standard Time"));
 Console.WriteLine($"Eastern Time: {easternTime}");
#endregion
 */
