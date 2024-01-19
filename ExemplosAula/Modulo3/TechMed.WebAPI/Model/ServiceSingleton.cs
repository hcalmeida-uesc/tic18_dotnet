namespace TechMed.WebAPI.Model;
public class ServiceSingleton
{
   //esse ID nunca muda, pois é singleton
   public Guid SingletonId { get; set; } = Guid.NewGuid();
}
