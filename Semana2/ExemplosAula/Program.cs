/* #region ReadLine Example
Console.WriteLine("Informe uma string:");
string? str = Console.ReadLine();
Console.WriteLine($"A string foi {str}");

string? teste = str.Substring(3);

Console.WriteLine($"A substring foi {teste}");

string[] strSplitted = str.Split(' ');

foreach(string s in strSplitted)
{
    Console.WriteLine($"A string foi {s}");
}

#endregion
 */
/* #region List Examples

      // Example of using List<int>
      List<int> numbers = new List<int>();
      numbers.Add(1);
      numbers.Add(2);
      numbers.Add(3);
      numbers.Add(4);
      numbers.Add(5);

      Console.WriteLine("Numbers:");
      foreach (int number in numbers)
      {
         Console.WriteLine(number);
      }

      // Example of using List<string>
      List<string> names = new List<string>();
      names.Add("Alice");
      names.Add("Bob");
      names.Add("Charlie");
      names.Add("David");
      names.Add("Eve");

      Console.WriteLine("Names:");
      foreach (string name in names)
      {
         Console.WriteLine(name);
      }

      List<List<string>> names2 = new List<List<string>>();
      names2.Add(new List<string>());
      names2[0].Add("Daniel");
      names2[0].Add("David");
      names2.Add(new List<string>() {"Paulo", "Senger", "Dórea"});
      foreach(List<string> list in names2)
      {
         foreach(string name in list)
         {
            Console.Write(name+" - ");
         }
         Console.WriteLine();
      }

#endregion
 */
#region DateTime Example
DateTime now = DateTime.Now;

Console.WriteLine($"Now: {now.DayOfWeek}");

DateTime gabrielBorn = new DateTime(2004,07,14);

Console.WriteLine($"Gabriel born: {gabrielBorn.DayOfWeek}");
DateTime SengerBorn = new DateTime(1996,04,13);

TimeSpan difference = SengerBorn - gabrielBorn;

Console.WriteLine($"Diferença: {difference.Days} dias");


#endregion