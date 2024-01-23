namespace TechMed.Core.Exceptions;
public class MedicoAlreadyExistsException : Exception
{
   public MedicoAlreadyExistsException() :
      base("Já existe um médico com esse CRM.")
   {
   }
}
