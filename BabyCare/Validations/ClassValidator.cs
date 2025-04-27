using BabyCare.Entities;
using FluentValidation;

namespace BabyCare.Validations
{
    public class ClassValidator: AbstractValidator<Class>
    {
        public ClassValidator()
        {
            RuleFor(x => x.ClassTitle).NotEmpty().WithMessage("Başlık boş bırakılamaz");
            RuleFor(x => x.ClassTitle).MinimumLength(2).WithMessage("Başlık 2 karakterden fazla olmalıdır");
            RuleFor(x => x.ClassDescription).NotEmpty().WithMessage("Açıklama alanı boş bırakılamaz");
            RuleFor(x => x.Price).NotEmpty().WithMessage("Fiyat bilgisi boş bırakılamaz");
            RuleFor(x => x.ClassImageUrl).NotEmpty().WithMessage("Resim yolu bilgisi boş bırakılamaz");
            RuleFor(x => x.StudentCount).NotEmpty().WithMessage("Öğrenci sayısı alanı boş bırakılamaz");
            RuleFor(x => x.LessonCount).NotEmpty().WithMessage("Sınıf sayısı alanı boş bırakılamaz");
            RuleFor(x => x.ClassTime).NotEmpty().WithMessage("Ders saati alanı boş bırakılamaz");
            RuleFor(x => x.TeamId).NotEmpty().WithMessage("Öğretmen bilgisi boş bırakılamaz").GreaterThan(0).WithMessage("Geçerli bir öğretmen seçiniz");
        }
    }
}
