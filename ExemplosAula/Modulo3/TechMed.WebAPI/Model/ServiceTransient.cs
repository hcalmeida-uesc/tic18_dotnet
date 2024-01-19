namespace TechMed.WebAPI.Model;
public class ServiceTransient
{
   //esse ID muda a cada injeção, pois é transient
   public Guid TransientId { get; set; } = Guid.NewGuid();
   //esse ID muda a cada requisição, pois é scoped
   public Guid ScopedId => _serviceScoped.ScopedId;
   //esse ID permenace igual ao anterior, pois é scoped
   public Guid SecondScopedId => _secondServiceScoped.ScopedId;
   //esse ID é o mesmo do singleton, pois é singleton
   public Guid SingletonId => _serviceSingleton.SingletonId;
   private ServiceScoped _serviceScoped;
   private ServiceScoped _secondServiceScoped;
   private ServiceSingleton _serviceSingleton;
   public ServiceTransient(ServiceScoped serviceScoped, ServiceScoped secondServiceScoped, ServiceSingleton serviceSingleton)
   {
      _serviceScoped = serviceScoped;
      _secondServiceScoped = secondServiceScoped;
      _serviceSingleton = serviceSingleton;
   }
}
