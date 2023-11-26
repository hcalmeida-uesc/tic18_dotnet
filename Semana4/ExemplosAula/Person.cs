namespace Semana4.ExemplosAula
{
    public class Person
    {
        public Person(string name, string document, DateTime birthDate)
        {
            Id = ++PeopleID;
            Name = name;
            Document = document;
            BirthDate = birthDate;
        }
        private static int PeopleID { get; set; } = 2023000;
        public int Id { get; }
        public string Name { get; private set; }
        private string document = string.Empty;
        public string Document { 
            get{
                return document;
            }
            private set{
                document = value ?? string.Empty;
            }
        }
        public DateTime BirthDate { get; private set; }
    }    
}
