using System.Diagnostics.Contracts;

namespace Semana5.Pagamento;
public class Cliente
{
   public string Nome { get; set; }
   public string Email { get; set; }

   public void Pagar(IPagamento pagamento, double valor){
      Console.WriteLine($"{Nome} está efetuando um pagamento");

      pagamento.RealizarPagamento(valor);
   }

}
