using Rvi.OrderApi.ExceptionHandling.Models;

namespace Rvi.OrderApi.ExceptionHandling;

public class Errors
{   
    public static readonly Error GenericValidation =
        new("VALIDATION.000001", "Validation Error.");
    
    public static readonly Error DefaultError500 =
        new("GENERIC.000001", "An error occured");
}