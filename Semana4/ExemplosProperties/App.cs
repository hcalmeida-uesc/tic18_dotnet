namespace Semana4.ExemplosAula;
public static class App{
   
   static Professors professors { get; set; } = new Professors();
   
   public static void Init(){
      do{
         Menu();
      }while(true);
   }

   private static void Menu()
   {
      int option = 0;
      do{
         Console.WriteLine("1 - Adicionar pessoas");
         Console.WriteLine("2 - Listar pessoas");
         Console.WriteLine("3 - Sair");

         int.TryParse(Console.ReadLine(), out option);
      }while(option < 1 || option > 3);
      switch(option){
         case 1:
            MenuAddPeople();
            break;
         case 2:
            Console.WriteLine(professors);
            break;
         case 3:
            Environment.Exit(0);
            break;
      }
   }
   private static void MenuAddPeople()
   {
      string answer="s";

      do
      {
         Console.WriteLine("Informe o nome da pessoa:");
         string name = Console.ReadLine()!;

         Console.WriteLine("Informe o documento de identificacao:");
         string document = Console.ReadLine()!;
         
         Console.WriteLine("Informe o número de matrícula:");
         string registration = Console.ReadLine()!;
         
         Console.WriteLine("Informe o título mais alto:");
         string title = Console.ReadLine()!;
         
         do{
            try{
               Console.WriteLine("Informe a data de nascimento (dd/mm/yyyy):");
               DateTime birthDate = DateTime.Parse(Console.ReadLine()!);
            
               Professor person = new Professor{
                  Name = name,
                  Document = document,
                  BirthDate = birthDate,
                  Registration = registration,
                  Title = title
               };
               professors.Add(person);
               break;
            }catch(FormatException){
               Console.WriteLine("Data de nascimento inválida!");
               continue;
            }catch(Exception ex){
               Console.WriteLine(ex.Message);
               continue;
            }
         }while(true);
         
         Console.WriteLine("Deseja inserir outra(o)? (s/n)");
         answer = Console.ReadLine()!;
      } while (answer.ToLower() == "s");
   }

public class Pessoa
{
    private int _idade;

    public int Idade
    {
        get { return _idade; }
        set
        {
            if (value > 0)
                _idade = value;
            else
                throw new ArgumentException("Idade deve ser maior que zero.");
        }
    }
}




}
