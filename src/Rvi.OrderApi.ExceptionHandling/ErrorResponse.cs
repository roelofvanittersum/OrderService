using Rvi.OrderApi.ExceptionHandling.Models;

namespace Rvi.OrderApi.ExceptionHandling;


public class ErrorResponse
{
    public Error Error { get; }

    public List<ValidationError> ValidationErrors { get; }

    public ErrorResponse(Error error)
    {
        Error = error;
        ValidationErrors = new List<ValidationError>();
    }

    public void AddValidationError(Error error, string propertyName)
    {
        ValidationErrors.Add(new ValidationError
        {
            Property = propertyName,
            Code = error.Code,
            Description = error.Description
        });
    }

    public void AddValidationError(ValidationError error)
    {
        ValidationErrors.Add(error);
    }

    public bool HasValidationErrors()
    {
        return ValidationErrors.Any();
    }

    public override string ToString()
    {
        return $"{nameof(Error)}: {Error}, {nameof(ValidationErrors)}: {ValidationErrors}";
    }
}