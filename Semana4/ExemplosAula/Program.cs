using Semana4.ExemplosAula;
using System.Globalization;

CultureInfo.CurrentCulture = CultureInfo.CreateSpecificCulture("pt-BR");

List<Person> people = App.AddPeople();

Person Valber = new Person("Valber", "123456789-00", new DateTime(1990, 10, 10));

people.Add(Valber);

foreach (Person person in people)
{
   Console.WriteLine($"ID: {person.Id}");
   Console.WriteLine($"Nome: {person.Name}");
   Console.WriteLine($"Documento: {person.Document}");
   Console.WriteLine($"Data de nascimento: {person.BirthDate.ToShortDateString()}");
   Console.WriteLine();
}
