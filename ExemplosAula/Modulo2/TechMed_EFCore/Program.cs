using TechMed.Domain.Entities;
using TechMed.Infra.Data.Context;

var context = new TechMedContext();

context.Exames.RemoveRange(context.Exames);
context.Atendimentos.RemoveRange(context.Atendimentos);
context.Medicos.RemoveRange(context.Medicos);
context.Pacientes.RemoveRange(context.Pacientes);


context.SaveChanges();

Console.WriteLine($"Criar um médico no banco de dados");

var medico = new Medico{
    Nome = "Dr. Dexter",
    CPF = "123.456.789-00",
    CRM = "123456",
    Especialidade = "Clínico Geral",
    Salario = 10000
};
context.Medicos.Add(medico);

Console.WriteLine($"Criar um paciente no banco de dados");
var paciente = new Paciente{
    Nome = "Valber",
    CPF = "101.202.303-00",
    Endereco = "Rua A, 0",
    Telefone = "1234-5678"
};

context.Pacientes.Add(paciente);

context.SaveChanges();


Console.WriteLine($"Criar um atendimento no banco de dados");

var atendimento1 = new Atendimento{
    Medico = medico,
    Paciente = paciente,
    DataHora = DateTime.Now
};
var atendimento2 = new Atendimento{
    Medico = medico,
    Paciente = paciente,
    DataHora = DateTime.Now+TimeSpan.FromDays(-1)
};
var atendimento3 = new Atendimento{
    Medico = medico,
    Paciente = paciente,
    DataHora = DateTime.Now+TimeSpan.FromDays(-2)
};

context.Atendimentos.AddRange(atendimento1, atendimento2, atendimento3);

var exame1 = new Exame{
    Local = "Hospital",
    DataHora = DateTime.Now,
    Atendimentos = new List<Atendimento>{atendimento1, atendimento2}
};
var exame2 = new Exame{
    Local = "Clínica",
    DataHora = DateTime.Now+TimeSpan.FromDays(-1),
    Atendimentos = new List<Atendimento>{atendimento1, atendimento3}
};
var exame3 = new Exame{
    Local = "Consultório",
    DataHora = DateTime.Now+TimeSpan.FromDays(-2),
    Atendimentos = new List<Atendimento>{atendimento2, atendimento3}
};

context.Exames.AddRange(exame1, exame2, exame3);

context.SaveChanges();

Console.WriteLine($"Finalizando o programa");

var valber = context.Pacientes.Where(p => p.Nome == "Valber").FirstOrDefault();

valber.Atendimentos.ToList().ForEach(a => a.Exames.ToList().ForEach(e => Console.WriteLine($"Exame: {e.Local} - {e.DataHora}")));

var atendimentoHospital = context.Atendimentos.Where(a => a.Exames.Any(e => e.Local == "Hospital")).FirstOrDefault();

