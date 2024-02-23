namespace MvcMovie.Models;
public class Studio
{
   public int Id { get; set; }
   public required string Name { get; set; }
   public required string Country { get; set; }
   public string? Website { get; set; }
}
