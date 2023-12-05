using System.Text;

namespace ExemplosAula.Banco;
public abstract class Conta : IPrintable{
      private static int _numeroContas = 0;
      private string _numero = string.Empty;
      required public string Numero { 
            get{return _numero;} 
            set{
                  if (!NumeroContaValido(value))                  {
                        throw new NumeroContaInvalidoException();
                  }
                  _numero = value;
            } 
      }
      private double _saldo;
      required public virtual double Saldo { 
            get{ return _saldo;} 
            set{
                  if (value < 0)
                  {
                        throw new SaldoNegativoException();
                  }
                  _saldo = value;
            }
      }
      public string Descricao { get; set; }=string.Empty;

      public Conta(){
            _numeroContas++;
      }
      public virtual double Depositar(double valor)
      {
            if (valor <= 0)
            {
                  throw new DepositoNegativoException();
            }
            Saldo += valor;
            return Saldo;
      }

      public virtual double Sacar(double valor)
      {
            if (valor <= 0)
            {
                  throw new SaqueNegativoException();
            }
            if (valor > Saldo)
            {
                  throw new SaldoInsuficienteException();
            }
            Saldo -= valor;
            return Saldo;
      }
      public override bool Equals(object? obj)
      {
            if (obj is null || obj is not Conta)
            {
                  return false;
            }
            return Numero == ((Conta)obj).Numero;
      }
    public override string ToString()
      {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Número: {Numero}");
                  sb.AppendLine($"Descrição: {Descricao}");
                  sb.AppendLine($"Saldo: {Saldo}");
            return sb.ToString();
      }

    protected virtual bool NumeroContaValido(string numero){
            return numero.Length >= 3 &&
                   numero.Length <= 6 &&
                   numero.All(char.IsDigit);
      }

    public override int GetHashCode()
    {
        return base.GetHashCode();
    }

    public void Print(){
        Console.WriteLine($"{ToString()}");
    }
}

public class ContaCorrente : Conta{
      private double _limite;
      required public double Limite { 
            get{return _limite;}
            set{
                  if (value < 0)
                  {
                        throw new LimiteNegativoException();
                  }
                  _limite = value;
            }
      }
      required public override double Saldo{
            get{
                  return base.Saldo + Limite;
            }
            set{
                  base.Saldo = value;
            }
      }
      public ContaCorrente() : base(){}
      public override double Sacar(double valor)
      {
            if (valor <= 0)
            {
                  throw new SaqueNegativoException();
            }
            if (valor > Saldo + Limite)
            {
                  throw new SaldoInsuficienteException();
            }
            Saldo -= valor;
            return Saldo;
      }
}

public class ContaPoupanca : Conta, ITributavel{
      private double _rentabilidadeMes;
      public double Tributo { get; set; } = 0.05;
      required public double RentabilidadeMes {
            get{ return _rentabilidadeMes;}
            set{
                  if (value < 0){
                        throw new RentabilidadeNegativaException();
                  }
                  _rentabilidadeMes = value;
            }
      }
      public ContaPoupanca() : base(){ }

    public double CalcularTributo(){
        return Saldo * Tributo;
    }
}

public class ContaInvestimento : Conta, ITributavel, IInternacional{
    
    public double SaldoDolar => Saldo * 5.5;

    public double Tributo { get; set; } = 0.02;
    List<IInvestimento> Investimentos { get; set; } = new List<IInvestimento>();

    public double CalcularTributo(){
        return Saldo * Tributo;
    }
}

public class Gato : IAnimal{
    public void EmitirSom(){
        Console.WriteLine("Miau!");
    }

    public void Mover(){
        Console.WriteLine("O gato se move graciosamente.");
    }
}

