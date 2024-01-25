using TechMed.Application.Services.Interfaces;
using TechMed.Infrastructure.Persistence.Interfaces;

namespace TechMed.Application.Services;
public abstract class BaseService
{
   protected readonly ITechMedContext _context;
   protected BaseService(ITechMedContext context){
      _context = context;
   }
}
