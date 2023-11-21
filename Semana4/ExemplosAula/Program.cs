using Semana4.ExemplosAula;
using System.Globalization;

CultureInfo.CurrentCulture = CultureInfo.CreateSpecificCulture("pt-BR");

List<Pessoa> people = App.AddPeople();

foreach (Pessoa person in people)
{
   Console.WriteLine($"Nome: {person.Name}");
   Console.WriteLine($"Documento: {person.Document}");
   Console.WriteLine($"Data de nascimento: {person.BirthDate.ToShortDateString()}");
   Console.WriteLine();
}
