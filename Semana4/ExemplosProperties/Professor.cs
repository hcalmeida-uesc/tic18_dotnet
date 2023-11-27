namespace Semana4.ExemplosAula
{
    public class Professor : Person
    {
        public required string Registration { get; set; }
        public required string Title { get; set; }
    }
    public class Professors : List<Professor>
    {
        public override string ToString()
        {
            string professorsStr = string.Empty;

            foreach (Professor professor in this)
            {
                professorsStr += $"ID: {professor.Id}" + Environment.NewLine;
                professorsStr += $"Nome: {professor.Name}" + Environment.NewLine;
                professorsStr += $"Documento: {professor.Document}" + Environment.NewLine;
                professorsStr += $"Data de nascimento: {professor.BirthDate.ToShortDateString()}" + Environment.NewLine;
                professorsStr += $"Idade: {professor.Age}" + Environment.NewLine;
                professorsStr += $"Matrícula: {professor.Registration}" + Environment.NewLine;
                professorsStr += $"Título: {professor.Title}" + Environment.NewLine;
            }

            return professorsStr;
        }
    }
}
