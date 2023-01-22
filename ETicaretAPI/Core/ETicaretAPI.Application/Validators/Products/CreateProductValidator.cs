using System;
using FluentValidation;
using ETicaretAPI.Application.ViewModels.Products;

namespace ETicaretAPI.Application.Validators.Products
{
    public class CreateProductValidator : AbstractValidator<VM_Create_Product>
    {
        public CreateProductValidator()
        {
            RuleFor(p => p.Name)
                .NotEmpty()
                .NotNull()
                .WithMessage("Lütfen ürün adını boş geçmeyiniz")
            .MaximumLength(150)
            .MaximumLength(5)
            .WithMessage("5 ile 150 karakter arasında giriniz");

            RuleFor(p => p.Stock)
               .NotEmpty()
               .NotNull()
               .WithMessage("stok bilgisi boş geçilmez")
               .Must(s => s >= 0)
           .WithMessage("stok bilgisi negatif olmaz");
            RuleFor(p => p.Price)
               .NotEmpty()
               .NotNull()
               .WithMessage("price bilgisi boş geçilmezz")
               .Must(s => s >= 0)
           .WithMessage("price bilgisi negatif olmaz");
        }
    }
}

