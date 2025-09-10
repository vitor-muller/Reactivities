using Application.Activities.DTOs;
using FluentValidation;

namespace Application.Activities.Validators;

public class BaseActivityValidator<T, TDto> : AbstractValidator<T> where TDto : BaseActivityDto
{
    public BaseActivityValidator(Func<T, TDto> selector)
    {
        RuleFor(x => selector(x).Title)
            .NotEmpty().WithMessage("Title is required")
            .MaximumLength(80).WithMessage("Title length must be less than 80 characters");
        
        RuleFor(x => selector(x).Description)
            .NotEmpty().WithMessage("Description is required")
            .MaximumLength(200).WithMessage("Title length must be less than 200 characters");
        
        RuleFor(x => selector(x).Date)
            .GreaterThan(DateTime.Now).WithMessage("Date must be in the future");

        RuleFor(x => selector(x).Category)
            .NotEmpty().WithMessage("Category is required");

        RuleFor(x => selector(x).City)
            .NotEmpty().WithMessage("City is required");
        
        RuleFor(x => selector(x).Venue)
            .NotEmpty().WithMessage("Venue is required");
        
        RuleFor(x => selector(x).Latitude)
            .NotEmpty().WithMessage("Latitude is required")
            .InclusiveBetween(-90, 90).WithMessage("Value must be between -90 and 90 degrees");
        
        RuleFor(x => selector(x).Longitude)
            .NotEmpty().WithMessage("Longitude is required")
            .InclusiveBetween(-180, 180).WithMessage("Value must be between -180 and 180 degrees");
    }
}