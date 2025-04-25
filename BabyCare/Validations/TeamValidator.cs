using BabyCare.Entities;
using FluentValidation;

namespace BabyCare.Validations
{
    public class TeamValidator : AbstractValidator<Team>
    {
        public TeamValidator()
        {
            RuleFor(x => x.NameSurname).NotEmpty().WithMessage("İsim soyisim boş bırakılamaz");
            RuleFor(x => x.NameSurname).MinimumLength(2).WithMessage("İsim 2 karakterden fazla olmalıdır");
            RuleFor(x => x.NameSurname).MaximumLength(50).WithMessage("İsim 50 karakterden az olmalıdır");
            RuleFor(x => x.Age).NotEmpty().WithMessage("Yaş alanı boş bırakılamaz");
            RuleFor(x => x.City).NotEmpty().WithMessage("Şehir bilgisi boş bırakılamaz");
            RuleFor(x => x.ImageUrl).NotEmpty().WithMessage("Resim yolu bilgisi boş bırakılamaz");
            RuleFor(x => x.BranchId).NotEmpty().WithMessage("Branş alanı boş bırakılamaz");
        }
    }
}
