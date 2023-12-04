namespace ExemplosAula.Banco;
public interface ITributavel{
      double  CalcularTributo();
}

public interface IInternacional{
      double SaldoDolar { get; }
}

public interface IInvestimento{
      double  CalcularRentabilidadeMes();
}
