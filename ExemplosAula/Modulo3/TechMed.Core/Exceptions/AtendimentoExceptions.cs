namespace TechMed.Core.Exceptions;
public class AtendimentoNotFoundException : Exception
{
   public AtendimentoNotFoundException() :
      base("Atendimento não encontrado")
   {
   }
}
