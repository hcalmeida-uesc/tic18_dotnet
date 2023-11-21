namespace Semana4.ExemplosAula;
public static class App{
   
   public static List<Pessoa> AddPeople()
   {
      List<Pessoa> people = new List<Pessoa>();

      string answer="s";

      do
      {
         Console.WriteLine("Informe o nome da pessoa:");
         string name = Console.ReadLine()!;

         Console.WriteLine("Informe o documento de identificacao:");
         string document = Console.ReadLine()!;
         
         try{
            Console.WriteLine("Informe a data de nascimento (dd/mm/yyyy):");
            DateTime birthDate = DateTime.Parse(Console.ReadLine()!);
         
            Pessoa person = new Pessoa(name, document, birthDate);
            people.Add(person);
         
         }catch(FormatException){
            Console.WriteLine("Data de nascimento inválida!");
            continue;
         }finally{
            Console.WriteLine("Deseja continuar? (s/n)");
            answer = Console.ReadLine()!;
         }

      } while (answer.ToLower() == "s");

      return people;
   }
}
