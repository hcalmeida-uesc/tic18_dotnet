namespace TechMed.WebAPI.Model;
public class ServiceScoped
{
   private readonly ServiceSingleton _serviceSingleton;
   //esse ID muda a cada requisição, pois é scoped
   public Guid ScopedId { get; set; } = Guid.NewGuid();
   //esse ID é o mesmo do singleton, pois é singleton
   public Guid ScopedSingletonId => _serviceSingleton.SingletonId;
   
   public ServiceScoped(ServiceSingleton serviceSingleton) =>
      _serviceSingleton = serviceSingleton;
   
}
