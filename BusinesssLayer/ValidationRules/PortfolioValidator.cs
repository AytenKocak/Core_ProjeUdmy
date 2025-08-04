using EntityLayer.Concrete;
using FluentValidation;

namespace BusinesLayer.ValidationRules
{
    public class PortfolioValidator : AbstractValidator<Portfolio>
    {

        public PortfolioValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Proje Adı Boş Geçilemez");
            RuleFor(x => x.ImageUrl).NotEmpty().WithMessage("Görsel Alanı Boş Bırakılamaz");
            RuleFor(x => x.Image1).NotEmpty().WithMessage("Görsel Alanı Boş Bırakılamaz");
            RuleFor(x => x.Image2).NotEmpty().WithMessage("Görsel Alanı Boş Bırakılamaz");
            RuleFor(x => x.Value).NotEmpty().WithMessage("Değer Alanı Boş Bırakılamaz");
            RuleFor(x => x.Name).MinimumLength(5).WithMessage("Proje Adı  5 Karakterden daha az olamaz");
            RuleFor(x => x.Name).MaximumLength(100).WithMessage("Proje Adı 100 Karakterden daha fazla olamaz");
        }
    }
}
