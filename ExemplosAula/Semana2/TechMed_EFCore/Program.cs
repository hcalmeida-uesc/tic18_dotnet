using TechMed_EFCore.Models;

var context = new TechMedContext();

Console.WriteLine($"Lendo todos os médicos no banco de dados");
foreach (var med in context.Medicos.OrderBy(m => m.Nome))
{
    Console.WriteLine($"Id: {med.MedicoId} - Nome: {med.Nome} - CRM: {med.CRM}");
}

Console.WriteLine($"Lendo todos os pacientes no banco de dados");
foreach (var pac in context.Pacientes.OrderBy(m => m.Nome))
{
    Console.WriteLine($"Id: {pac.PacienteId} - Nome: {pac.Nome} - CRM: {pac.CPF}");
}


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


Console.WriteLine($"Atualizando o nome de um paciente no banco de dados");
var doente = context.Pacientes.Where(p => p.CPF == "101.202.303-00").FirstOrDefault();
doente.Nome = "João";
context.Pacientes.Update(doente);

context.SaveChanges();

Console.WriteLine($"Removendo o primeiro médico no banco de dados");
var primeiroMedico = context.Medicos.FirstOrDefault();
context.Medicos.Remove(primeiroMedico);

context.SaveChanges();

Console.WriteLine($"Finalizando o programa");

