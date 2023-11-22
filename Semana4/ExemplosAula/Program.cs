using Semana4.ExemplosAula;
using System.Globalization;

CultureInfo.CurrentCulture = CultureInfo.CreateSpecificCulture("pt-BR");

List<Pessoa> people = App.AddPeople();

Pessoa Valber = new Pessoa("Valber", "123456789-00", new DateTime(1990, 10, 10));

people.Add(Valber);

foreach (Pessoa person in people)
{
   Console.WriteLine($"ID: {person.Id}");
   Console.WriteLine($"Nome: {person.Name}");
   Console.WriteLine($"Documento: {person.Document}");
   Console.WriteLine($"Data de nascimento: {person.BirthDate.ToShortDateString()}");
   Console.WriteLine();
}
