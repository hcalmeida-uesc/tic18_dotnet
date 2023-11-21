namespace Semana4.ExemplosAula
{
    public class Pessoa
    {
        public Pessoa(string name, string document, DateTime birthDate)
        {
            Id = ++PeopleID;
            Name = name;
            Document = document;
            BirthDate = birthDate;
        }
        private static int PeopleID { get; set; } = 2023000;
        public int Id { get; }
        public string Name { get; private set; }
        public string Document { get; private set; }
        public DateTime BirthDate { get; private set; }
    }
}
