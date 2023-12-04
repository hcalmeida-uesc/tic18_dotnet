namespace ExemplosAula.Banco;
public static class App{
   public static void Init(){
      InitTest();
   }
   private static void InitTest(){
      ContaCorrente contaCorrente = new ContaCorrente(){
            Numero = "123",
            Descricao = "Conta Corrente",
            Saldo = 1000,
            Limite = 1000
      };
      ContaPoupanca contaPoupanca = new ContaPoupanca(){
            Numero = "456",
            Descricao = "Conta Poupança",
            Saldo = 1000,
            RentabilidadeMes = 0.05
      };
      ContaInvestimento contaInvestimento = new ContaInvestimento(){
            Numero = "789",
            Descricao = "Conta Investimento",
            Saldo = 1000
      };

      List<Conta> contas = new List<Conta>(){
            contaCorrente,
            contaPoupanca,
            contaInvestimento
      };

      contas.ForEach(x => Console.WriteLine(x));
   }

}
