using Semana4.ExemplosAula;
using System.Globalization;

CultureInfo.CurrentCulture = CultureInfo.CreateSpecificCulture("pt-BR");

/* List<Person> people = App.AddPeople();

Person Valber = new Person("Valber", "123456789-00", new DateTime(1990, 10, 10));

people.Add(Valber);

foreach (Person person in people)
{
   Console.WriteLine($"ID: {person.Id}");
   Console.WriteLine($"Nome: {person.Name}");
   Console.WriteLine($"Documento: {person.Document}");
   Console.WriteLine($"Data de nascimento: {person.BirthDate.ToShortDateString()}");
   Console.WriteLine();
} */


#region Herança
try{
   ContaCorrente contaHelder = new ContaCorrente();
   contaHelder.setNumero(100);
   contaHelder.sacar(1000);
   contaHelder.Descricao = "Oi";
   Console.WriteLine($"{contaHelder.NumeroDescricao}");
  
   ContaPoupanca contaValber = new ContaPoupanca();
   contaValber.setNumero(171);
   contaValber.sacar(1000);
}
catch(Exception e){
   Console.WriteLine(e.Message);
}
abstract class Conta{
   public int Numero {get; private set;}
   protected double saldo;
   public string Descricao{get; set;}

   public string NumeroDescricao => $"{this.Numero} - {this.Descricao}";

   public Conta(){
      this.saldo = 0;
   }
   public void setNumero(int _numero){
      if(_numero > 0){
         this.Numero = _numero;
      }
      else{
         throw new Exception("Número inválido");
      }
   }
   
   public int getNumero(){
      return this.Numero;
   }

   public virtual double sacar(double valor){
      if(valor > 0 && valor <= this.saldo){
         this.saldo -= valor;
         return valor;
      }
      else{
         throw new Exception("Valor inválido");
      }
   }
}

class ContaCorrente : Conta{
   double limite;
   
   public ContaCorrente(){
      this.limite = 1000;
   }

   public override double sacar(double valor){
      if(valor > 0 && valor <= this.saldo + this.limite){
         this.saldo -= valor;
         return valor;
      }
      else{
         throw new Exception("Valor inválido");
      }
   }
}

class ContaPoupanca : Conta{
   double rendimento;
}

#endregion