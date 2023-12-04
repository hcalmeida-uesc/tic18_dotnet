namespace ExemplosAula.Banco;
public interface ITributavel{
      public double Tributo { get; set; }
      double  CalcularTributo();
}

public interface IInternacional{
      double SaldoDolar { get; }
}

public interface IInvestimento{
      double  CalcularRentabilidadeMes();
}

public interface IPrintable{
      void Print();
}

public interface IAnimal
{
    void EmitirSom();
    void Mover();
}

