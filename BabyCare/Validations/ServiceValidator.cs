using BabyCare.Entities;
using FluentValidation;

namespace BabyCare.Validations
{
    public class ServiceValidator : AbstractValidator<Service>
    {
        public ServiceValidator()
        {
            RuleFor(x => x.ServiceTitle).NotEmpty().WithMessage("Başlık boş bırakılamaz");
            RuleFor(x => x.ServiceTitle).MinimumLength(2).WithMessage("Başlık 2 karakterden fazla olmalıdır");
            RuleFor(x => x.ServiceDescription).NotEmpty().WithMessage("Açıklama alanı boş bırakılamaz");
            RuleFor(x => x.ServiceIconUrl).NotEmpty().WithMessage("Icon yolu bilgisi boş bırakılamaz");
        }
    }
}
