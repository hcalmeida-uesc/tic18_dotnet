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

ContaCorrente contaDan = new ContaCorrente("100");
contaDan.sacar(500);
contaDan.NumeroSaldo = "100, saldo fake";
Console.WriteLine($"{contaDan.numero}");

ContaPoupanca contaPenedo = new ContaPoupanca("171",200);
contaPenedo.sacar(500);
Console.WriteLine($"{contaPenedo.numero}");

var contas = new List<Conta>();
contas.Add(contaDan);
contas.Add(contaPenedo);

Contato dan = new Contato(){
   Nome = "Dan",
   CPF = "123456789-00",
   DataNascimento = new DateTime(1990, 10, 10)
};

class Agenda{
   public List<Contato> Contatos {get; } = new List<Contato>();
   public void AdicionarContato(Contato contato){
      if(Contatos.Any(x => x.CPF == contato.CPF)){
         throw new Exception("Contato já existe");
      }
      this.Contatos.Add(contato);
   }
}

class Contato{
   public string Nome {get; set;}
   public string CPF {get; set;}
   public DateTime DataNascimento {get; set;}

}
abstract class Conta{
   private string _numero;
   protected string? titular;
   protected double saldo;

   public string Descricao => $"{this._numero} - {this.titular}";
   public string NumeroSaldo {set{Console.WriteLine($"{this._numero} - {value}");}
   }
   public string numero{
      get{ return this._numero; }
   }
   public Conta(string _numero, double _saldo=0){
      this._numero = _numero;
      this.saldo = _saldo;
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
   public ContaCorrente(string _numero, double _saldo=0):base(_numero, _saldo)  {
         this.limite = 1000;
         this.saldo = _saldo;
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

   public ContaPoupanca(string _numero, double _saldo=0):base(_numero, _saldo)  {
      this.rendimento = 0.0007;
      this.saldo = _saldo;
   }
}
#endregion

/* #region Herança
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
 */