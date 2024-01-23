namespace TechMed.Core.Entities;
public abstract class BaseEntity
{
   public DateTimeOffset CreatedAt { get; set; }
   public DateTimeOffset? UpdatedAt { get; set; }
   public DateTimeOffset? DeletedAt { get; set; }
}
