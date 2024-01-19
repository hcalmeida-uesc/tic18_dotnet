using TechMed.WebAPI.Infra.Data.Interfaces;
using TechMed.WebAPI.Model;

namespace TechMed.WebAPI.Infra.Data;
public class PacientesDB : IPacienteCollection
{
   private readonly List<Paciente> _pacientes = new List<Paciente>();
   private int _id = 0;   
   public void Create(Paciente paciente)
   {
      if(_pacientes.Count > 0)
         _id = _pacientes.Max(m => m.PacienteId);
      paciente.PacienteId = ++_id;
      _pacientes.Add(paciente);
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
