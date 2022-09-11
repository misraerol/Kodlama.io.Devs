using FluentValidation;

namespace Application.Features.ProgrammingLanguages.Commands.UpdateProgrammingLanguage
{
    public class UpdateProgrammingLanguageCommandValidator : AbstractValidator<UpdateProgrammingLanguageCommand>
    {
        public UpdateProgrammingLanguageCommandValidator()
        {
            RuleFor(P => P.Id).NotEmpty();
            RuleFor(P => P.Name).NotEmpty();
            RuleFor(p => p.Name).MinimumLength(2);
        }
    }
}
