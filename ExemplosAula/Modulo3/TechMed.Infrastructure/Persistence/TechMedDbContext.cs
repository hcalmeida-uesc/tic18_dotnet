using Microsoft.EntityFrameworkCore;
using TechMed.Core.Entities;

namespace TechMed.Infrastructure.Persistence;
public class TechMedDbContext : DbContext
{
   public DbSet<Medico> Medicos { get; set; }
   public DbSet<Paciente> Pacientes { get; set; }
   public DbSet<Atendimento> Atendimentos { get; set; }
   public DbSet<Exame> Exames { get; set; }

   public TechMedDbContext(DbContextOptions<TechMedDbContext> options) : base(options)
   {
      Database.EnsureCreated();
   }

   protected override void OnModelCreating(ModelBuilder modelBuilder)
   {
      base.OnModelCreating(modelBuilder);

      //configurações de mapeamento da entidade Medico
      modelBuilder.Entity<Medico>()
         .ToTable("Medicos")
         .HasKey(m => m.MedicoId);

      //configurações de mapeamento da entidade Paciente
      modelBuilder.Entity<Paciente>()
         .ToTable("Pacientes")
         .HasKey(m => m.PacienteId);

      //configurações de mapeamento da entidade Atendimento
      modelBuilder.Entity<Atendimento>()
         .ToTable("Atendimentos")
         .HasKey(m => m.AtendimentoId);

      modelBuilder.Entity<Atendimento>()
         .HasOne(m => m.Medico)
         .WithMany(m => m.Atendimentos)
         .HasForeignKey(m => m.MedicoId);

      modelBuilder.Entity<Atendimento>()
         .HasOne(m => m.Paciente)
         .WithMany(m => m.Atendimentos)
         .HasForeignKey(m => m.PacienteId);

      //configurações de mapeamento da entidade Exame
      modelBuilder.Entity<Exame>()
         .ToTable("Exames")
         .HasKey(m => m.ExameId);

      modelBuilder.Entity<Exame>()
         .HasOne(m => m.Atendimento)
         .WithMany(m => m.Exames)
         .HasForeignKey(m => m.AtendimentoId);
   }

   protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
   {
      base.OnConfiguring(optionsBuilder);

      var connectionString = "server=localhost;user=techmed;password=123456;database=techmed";

      var serverVersion = ServerVersion.AutoDetect(connectionString);

      optionsBuilder.UseMySql(connectionString, serverVersion);

   }
}
