
/* #region Foreach examples

string[] people = { "Maria", "João", "José", "Ana" };

foreach(string person in people)
{
    Console.WriteLine(person);
}
#endregion
 */

/* #region Fibonacci
int fib1 = 0;
int fib2 = 1;
int fib3;

Console.WriteLine(fib1);
Console.WriteLine(fib2);

fib3 = fib2+fib1;

while (fib3 <= 100)
{
    Console.WriteLine(fib3);
    fib1 = fib2;
    fib2 = fib3;
    fib3 = fib2 + fib1;
}
 #endregion */

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
names2.Add(new List<string>(){ "Alan", "Alessandro", "Ana Carolina"});
names2.Add(new List<string>(){ "Beatriz", "Brendom"});
names2.Add(new List<string>(){ "Caio"});
foreach(List<string> names3 in names2)
{
   foreach(string name in names3)
   {
      Console.WriteLine(name);
   }
}
#endregion */

#region DateTime examples
// Get the current date and time
DateTime now = DateTime.Now;
Console.WriteLine($"Current date and time: {now}");

// Get the current date
DateTime today = DateTime.Today;
Console.WriteLine($"Current date: {today}");

// Create a DateTime object for a specific date and time
DateTime christmas = new DateTime(2023, 12, 25, 0, 0, 0);
Console.WriteLine($"Christmas: {christmas.DayOfWeek}");

// Get the day of the week for a specific date
DateTime independenceDay = new DateTime(1822, 9, 7);
Console.WriteLine($"Independence Day was on a {independenceDay.DayOfWeek}");

// Add time to a DateTime object
DateTime newYear = new DateTime(2022, 1, 1);
DateTime newYearWithTime = newYear.AddHours(12).AddMinutes(30);
Console.WriteLine($"New Year's Day with time: {newYearWithTime}");

// Subtract two DateTime objects to get a TimeSpan object
DateTime start = new DateTime(2022, 1, 1, 0, 0, 0);
DateTime end = new DateTime(2022, 1, 1, 0, 30, 0);
TimeSpan duration = end - start;
Console.WriteLine($"Duration: {duration}");
#endregion