using business_logic.DTOs;
using FluentValidation;

namespace Bussiness_Logic.Validators;

public class VideoValidator: AbstractValidator<VideoDto>
{
    public VideoValidator()
    {
        RuleFor(x => x.Title).NotEmpty();
        RuleFor(x => x.Views).NotEmpty().GreaterThan(0);
        RuleFor(x => x.VideoUrl).NotEmpty();
        RuleFor(x => x.PublishDate).GreaterThan(DateTime.Now);
        
    }
}