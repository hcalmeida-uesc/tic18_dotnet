using TechMed.Infrastructure.Persistence.Interfaces;
using TechMed.Core.Entities;

namespace TechMed.Infrastructure.Persistence;
public class PacientesDB : IPacienteCollection
{
   private readonly List<Paciente> _pacientes = new List<Paciente>();
   private int _id = 0;   
   public int Create(Paciente paciente)
   {
      if(_pacientes.Count > 0)
         _id = _pacientes.Max(m => m.PacienteId);
      paciente.PacienteId = ++_id;
      _pacientes.Add(paciente);
      return paciente.PacienteId;
   }
   public void Delete(int id)
   {
      _pacientes.RemoveAll(m => m.PacienteId == id);
   }
   public ICollection<Paciente> GetAll()
   {
      return _pacientes.ToArray();
   }
   public Paciente? GetById(int id)
   {
      return _pacientes.FirstOrDefault(m => m.PacienteId == id);
   }
   public void Update(int id, Paciente paciente)
   {
      var pacienteDB = _pacientes.FirstOrDefault(m => m.PacienteId == id);
      if(pacienteDB is not null)
      {
         pacienteDB.Nome = paciente.Nome;
      }
   }
}
