Console.WriteLine("Hello, World!");

#region  Teste de Tipos de Dados
   int tipoInteiro;
   double tipoDouble;
   string tipoString;
   long tipoLong;

   tipoInteiro = int.MaxValue;
   tipoLong = tipoInteiro;
  // tipoInteiro = tipoLong;

   tipoString = "100A";

   tipoInteiro = (int)(tipoString);

   Console.WriteLine("O máximo inteiro é "+tipoInteiro);

   Console.WriteLine("O máximo long é "+tipoLong);
#endregion

#region Operadores
   tipoDouble = tipoInteiro + tipoLong;
   tipoInteiro = tipoDouble + tipoLong;
   tipoLong = tipoDouble + tipoInteiro; 

   tipoInteiro = 10 > 5 ? 1 : 0;
#endregion