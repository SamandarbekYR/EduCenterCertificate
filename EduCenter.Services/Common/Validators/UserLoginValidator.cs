using EduCenter.Services.DTOs;
using FluentValidation;

namespace EduCenter.Services.Common.Validators;

public class UserLoginValidator :  AbstractValidator<LoginDto>
{
    public UserLoginValidator()
    {
        RuleFor(dto => dto.Phone).Must(phone => PhoneValidator.IsValid(phone))
            .WithMessage("Phone number is invalid! ex: +998xxYYYAABB");
        RuleFor(dto => dto.Password).Must(passsword => PasswordValidator.IsStrongPassword(passsword).IsValid);
    }
}
