namespace Semana5.Pagamento;
public static class App
{
   public static void Init()
   {
      CartaoCredito cartaoCredito = new CartaoCredito();
      TransferenciaBancaria transferenciaBancaria = new TransferenciaBancaria();
      PagamentoEmDinheiro pagamentoEmDinheiro = new PagamentoEmDinheiro();

      var AnaCaroline = new Cliente()
      {
         Nome = "Ana Caroline",
         Email = "anacaroline@gmail.com"
      };

      AnaCaroline.Pagar(cartaoCredito, 1000);
   
   }

}
