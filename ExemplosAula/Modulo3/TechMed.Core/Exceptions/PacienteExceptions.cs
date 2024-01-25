namespace TechMed.Core.Exceptions;

public class PacienteNotFoundException : Exception
{
   public PacienteNotFoundException() :
      base("Paciente não encontrado.")
   {
   }
}
