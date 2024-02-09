using System.Data;
using System.Text.RegularExpressions;
using FluentValidation;
using TechMed.Application.InputModels;

namespace TechMed.Application.Validators;
public class CreatePacienteValidator : AbstractValidator<NewPacienteInputModel>
{
   public CreatePacienteValidator()
   {
      RuleFor(x => x.Nome).NotEmpty().WithMessage("Nome é obrigatório");
      RuleFor(x => x.Email).NotEmpty().WithMessage("Email é obrigatório");
      RuleFor(x => x.Email).EmailAddress().WithMessage("Email inválido");
      RuleFor(x => x.Cpf).NotEmpty().WithMessage("CPF é obrigatório");
      //RuleFor(x => x.Cpf).Length(11).WithMessage("CPF deve ter 11 caracteres");
      RuleFor(x => x.Cpf).Must(ValidCpf).WithMessage("Formato de CPF deve ser 000.000.000-00");
   }

   public static bool ValidCpf(string cpf){
      var regex = new Regex(@"^\d{3}\.\d{3}\.\d{3}\-\d{2}$");
       return regex.IsMatch(cpf);
   }
}
