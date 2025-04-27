using BabyCare.Entities;
using FluentValidation;

namespace BabyCare.Validations
{
    public class TestimonialValidator : AbstractValidator<Testimonial>
    {
        public TestimonialValidator()
        {
            RuleFor(x => x.NameSurname).NotEmpty().WithMessage("İsim Soyisim boş bırakılamaz");
            RuleFor(x => x.NameSurname).MinimumLength(2).WithMessage("İsim Soyisim 2 karakterden fazla olmalıdır");
            RuleFor(x => x.Description).NotEmpty().WithMessage("Açıklama alanı boş bırakılamaz");
            RuleFor(x => x.Status).NotEmpty().WithMessage("Meslek Alanı boş bırakılamaz");
            RuleFor(x => x.ImageUrl).NotEmpty().WithMessage("Resim Alanı boş bırakılamaz");
            RuleFor(x => x.Stars).NotEmpty().WithMessage("Puan Alanı boş bırakılamaz");
        }
    }
}
