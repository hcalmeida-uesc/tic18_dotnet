namespace TechMed.Core.Exceptions;
public class MedicoAlreadyExistsException : Exception
{
   public MedicoAlreadyExistsException() :
      base("Já existe um médico com esses dados.")
   {
   }
}

public class MedicoNotFoundException : Exception
{
   public MedicoNotFoundException() :
      base("Médico não encontrado.")
   {
   }
}
