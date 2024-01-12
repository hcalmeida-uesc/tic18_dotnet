namespace TechMed.Domain.Interfaces;
public interface IMedico<Medico> : IBaseEntity<Medico>
{
   Task<Medico> GetMedicoByCRm(string CRM);
}
