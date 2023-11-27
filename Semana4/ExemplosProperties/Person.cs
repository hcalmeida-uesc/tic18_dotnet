namespace Semana4.ExemplosAula{
    public abstract class Person{
        public Person(){
            Id = ++PeopleID;
        }
        
        private static int PeopleID { get; set; } = 2023000;
        public int Id { get; }
        public required string Name { get; set; }
        private string document = string.Empty;
        public required string Document {  get; set; }
        public required DateTime BirthDate { get; set; }
        public int Age => calculateAge(BirthDate); // readonly property
        
        public static int calculateAge(DateTime birthDate){
            int age = DateTime.Now.Year - birthDate.Year;
            if (DateTime.Now.DayOfYear < birthDate.DayOfYear)
                age--;
            return age;
        }
    }
    
}
