using Microsoft.EntityFrameworkCore;

namespace ResTIConnect.Infra.Data.Context{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

    }

}
