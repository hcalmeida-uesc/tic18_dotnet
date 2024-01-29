using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TechMed.Core.Entities;

namespace TechMed.Infrastructure.Persistence.Configurations;
public class AtendimentoConfigurations : IEntityTypeConfiguration<Atendimento>
{
   public void Configure(EntityTypeBuilder<Atendimento> builder)
   {
      //configurações de mapeamento da entidade Atendimento
      builder
         .ToTable("Atendimentos")
         .HasKey(m => m.AtendimentoId);

      builder
         .HasOne(m => m.Medico)
         .WithMany(m => m.Atendimentos)
         .HasForeignKey(m => m.MedicoId);

      builder
         .HasOne(m => m.Paciente)
         .WithMany(m => m.Atendimentos)
         .HasForeignKey(m => m.PacienteId);
   }
}
