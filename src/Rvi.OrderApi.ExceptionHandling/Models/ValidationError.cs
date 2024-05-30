namespace Rvi.OrderApi.ExceptionHandling.Models;

public class ValidationError : Error
{
    public string Property { get; set; }

    public ValidationError()
    {
    }

    public ValidationError(string code, string description, string property) : base(code, description)
    {
        Property = property;
    }

    public override string ToString()
    {
        return $"{base.ToString()}, Property: {Property}";
    }
}