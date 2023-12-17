using CleanArchitecture.Domain.Entities;
using CleanArchitecture.Domain.Interfaces;
using CleanArchitecture.Persistence.Context;
using Microsoft.EntityFrameworkCore;

namespace CleanArchitecture.Persistence.Repositories;
public class UserRepository : BaseRepository<User>, IUserRepository
{
   public UserRepository(AppDbContext context) : base(context)
   {
   }

   public async Task<User> GetByEmail(string email, CancellationToken cancellationToken)
   {
      var entity = await Context.Users.FirstOrDefaultAsync(x => x.Email == email, cancellationToken);
      if (entity == null)
      {
         throw new Exception($"Entity {nameof(User)} with email {email} not found");
      }
      return entity;
   }
}
