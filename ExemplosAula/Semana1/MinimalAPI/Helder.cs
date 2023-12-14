using System.Text;

namespace Semana1.MinimalAPI;
public static class Helder{
      public static string Name => "Hélder Almeida";
      public static List<(string, int)> Skills => new List<(string, int)>{
            ("Fundamentos de C#", 5),
            ("Habilidades Gerais de Desenvolvimento",4),
            ("Fundamentos de Banco de Dados",5)
         };
      public static string View(){
            var sb = new StringBuilder();
            sb.AppendLine($"Nome: {Name}");
            sb.AppendLine();
            sb.AppendLine("Habilidades:");
            foreach(var skill in Skills){
                  sb.AppendLine($"\t{skill.Item1} - {skill.Item2} estrelas");
            }
            var sum = Skills.Sum(x => x.Item2);
            sb.AppendLine();
            sb.AppendLine($"Total de estrelas: {sum}");
            return sb.ToString();
      }
}
