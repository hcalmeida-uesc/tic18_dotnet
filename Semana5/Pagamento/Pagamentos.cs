namespace Semana5.Pagamento;
public class CartaoCredito : IPagamento{
   public string NumeroCartao { get; set; }
   public void RealizarPagamento(double valor){
      Console.WriteLine($"Pagamento de {valor} realizado com cartão de crédito");
   }
}

public class TransferenciaBancaria: IPagamento{
   public void RealizarPagamento(double valor){
      Console.WriteLine($"Pagamento de {valor} realizado com transferência bancária");
   }
}

public class PagamentoEmDinheiro : IPagamento{
   public void RealizarPagamento(double valor){
      Console.WriteLine($"Pagamento de {valor} realizado em dinheiro");
   }
}
