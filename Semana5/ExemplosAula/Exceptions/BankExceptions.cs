namespace ExemplosAula.Banco;

public class NumeroContaInvalidoException : Exception{
   public override string Message { get; } = "Número de conta inválido";
}

public class SaldoInsuficienteException : Exception{
   public override string Message { get; } = "Saldo insuficiente";
}
public class SaldoNegativoException : Exception{
   public override string Message { get; } = "Saldo não pode ser negativo";
}

public class SaqueNegativoException : Exception{
   public override string Message { get; } = "Saque não pode ser negativo";
}

public class DepositoNegativoException : Exception{
   public override string Message { get; } = "Depósito não pode ser negativo";
}

public class LimiteNegativoException : Exception{
   public override string Message { get; } = "Limite não pode ser negativo";
}

public class RentabilidadeNegativaException : Exception{
   public override string Message { get; } = "Rentabilidade não pode ser negativa";
}

public class TaxaNegativaException : Exception{
   public override string Message { get; } = "Taxa não pode ser negativa";
}
