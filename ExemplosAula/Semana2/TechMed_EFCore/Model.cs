using Microsoft.EntityFrameworkCore;

namespace TechMed_EFCore.Models;
public class TechMedContext : DbContext
{

    public DbSet<Medico> Medicos { get; set; }
    public DbSet<Paciente> Pacientes { get; set; }
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
        modelBuilder.Entity<Medico>().ToTable("Medicos").HasKey(m => m.Id);
        modelBuilder.Entity<Paciente>().ToTable("Pacientes").HasKey(p => p.Id);
    }
    // codigo omitido
}

public abstract class Pessoa{
    public int Id {get; set;}
    public string Nome {get; set;}
    public string CPF {get; set;}
}

public class Medico : Pessoa{
    public string CRM {get; set;}
    public string Especialidade {get; set;}
    public decimal Salario {get; set;}
}

public class Paciente : Pessoa{
    public string Endereco {get; set;}
    public string Telefone {get; set;}
}
