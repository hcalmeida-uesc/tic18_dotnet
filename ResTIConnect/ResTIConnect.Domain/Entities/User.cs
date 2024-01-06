using ResTIConnect.Domain.Common;

namespace ResTIConnect.Domain.Entities;
public class User : BaseEntity
{
      required public string Name { get; set; }
      required public string Email { get; set; }
      required public string Password { get; set; }
}
