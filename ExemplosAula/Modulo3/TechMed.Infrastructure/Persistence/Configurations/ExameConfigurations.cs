using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TechMed.Core.Entities;

namespace TechMed.Infrastructure.Persistence.Configurations;
public class ExameConfigurations : IEntityTypeConfiguration<Exame>
{
   public void Configure(EntityTypeBuilder<Exame> builder)
   {
      //configurações de mapeamento da entidade Exame
     builder
         .ToTable("Exames")
         .HasKey(m => m.ExameId);

      builder
         .HasOne(m => m.Atendimento)
         .WithMany(m => m.Exames)
         .HasForeignKey(m => m.AtendimentoId);
   }
}
