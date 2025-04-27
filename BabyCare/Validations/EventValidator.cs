using BabyCare.Entities;
using FluentValidation;

namespace BabyCare.Validations
{
    public class EventValidator : AbstractValidator<Event>
    {
        public EventValidator()
        {
            RuleFor(x => x.EventName).NotEmpty().WithMessage("Başlık boş bırakılamaz");
            RuleFor(x => x.EventName).MinimumLength(2).WithMessage("Başlık 2 karakterden fazla olmalıdır");
            RuleFor(x => x.EventDescription).NotEmpty().WithMessage("Açıklama alanı boş bırakılamaz");
            RuleFor(x => x.EventCity).NotEmpty().WithMessage("Şehir bilgisi boş bırakılamaz");
            RuleFor(x => x.EventImageUrl).NotEmpty().WithMessage("Resim yolu bilgisi boş bırakılamaz");
            RuleFor(x => x.EventDate).NotEmpty().WithMessage("Tarih alanı boş bırakılamaz");
            RuleFor(x => x.EventTime).NotEmpty().WithMessage("Saat alanı boş bırakılamaz");
        }
    }
}
