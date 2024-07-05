using Bussiness_Logic.DTOs;
using FluentValidation;

namespace Bussiness_Logic.Validators;

public class CommentValidator: AbstractValidator<CommentDto>
{
    public CommentValidator()
    {
        RuleFor(x => x.Content).MinimumLength(3);
    }
}