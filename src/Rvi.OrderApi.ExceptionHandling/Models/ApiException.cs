using System.Net;

namespace Rvi.OrderApi.ExceptionHandling.Models;

public class ApiException : Exception
{
    public HttpStatusCode StatusCode { get; }
        
    public ErrorResponse? ErrorResponse { get; }
        
    public ApiException(ErrorResponse errorResponse, HttpStatusCode statusCode) : base(errorResponse.Error.Description)
    {
        StatusCode = statusCode;
        ErrorResponse = errorResponse;
    }

    public ApiException(ErrorResponse errorResponse, HttpStatusCode statusCode, Exception innerException) : base(errorResponse.Error.Description,innerException)
    {
        StatusCode = statusCode;
        ErrorResponse = errorResponse;
    }
}