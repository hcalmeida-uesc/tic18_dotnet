using ResTIConnect.Domain.Entities;

namespace ResTIConnect.Domain.Interfaces;
public interface IUserRepository<T> where T : User
{
   Task<T> Get(string email, CancellationToken cancellationToken);
}
