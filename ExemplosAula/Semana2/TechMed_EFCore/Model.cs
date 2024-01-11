using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace TechMed_EFCore.Models;
public class TechMedContext : DbContext
{

    public DbSet<Medico> Medicos { get; set; }
    public DbSet<Paciente> Pacientes { get; set; }
    public DbSet<Atendimento> Atendimentos { get; set; }
    public DbSet<Exame> Exames { get; set; }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        base.OnConfiguring(optionsBuilder);
        var connectionString = "server=localhost;user=techmed;password=123456;database=techmed";
        var serverVersion = ServerVersion.AutoDetect(connectionString);
        
        optionsBuilder.UseMySql(connectionString, serverVersion);
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.Entity<Medico>().ToTable("Medicos").HasKey(m => m.MedicoId);
        modelBuilder.Entity<Paciente>().ToTable("Pacientes").HasKey(p => p.PacienteId);
    }
    // codigo omitido
}

public abstract class Pessoa{
    public required string Nome {get; set;}
    public required string CPF {get; set;}
}

public class Medico : Pessoa{
    public int MedicoId {get; set;}
    public required string CRM {get; set;}
    public string? Especialidade {get; set;}
    public required decimal Salario {get; set;}
}

public class Paciente : Pessoa{
    public int PacienteId {get; set;}
    public string? Endereco {get; set;}
    public string? Telefone {get; set;}
    public ICollection<Atendimento>? Atendimentos {get; set;}
}

public class Atendimento{
    public int AtendimentoId {get; set;}
    public required DateTime DataHora {get; set;}
    public required string Suspeita {get; set;}
    public string? Diagnostico {get; set;}
    
    public required int MedicoId {get; set;}
    public required Paciente Paciente {get; set;}

    public ICollection<Exame>? Exames {get; set;}
}

public class Exame{
    public int ExameId {get; set;}
    public required string Titulo {get; set;}
    public decimal Valor {get; set;}
    public string? Descricao {get; set;}
    public required int AtendimentoId {get; set;}
    public required Atendimento Atendimento {get; set;}
}
