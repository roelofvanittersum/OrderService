using System.ComponentModel.DataAnnotations;
using System.Net;
using Rvi.OrderApi.ExceptionHandling;
using Rvi.OrderApi.ExceptionHandling.Models;

namespace Rvi.OrderApi.Middleware;

public class ExceptionMiddleware
{
    private readonly RequestDelegate next;
    private readonly ILogger logger;

    public ExceptionMiddleware(RequestDelegate next, ILogger logger)
    {
        this.next = next;
        this.logger = logger;
    }

    public async Task InvokeAsync(HttpContext httpContext)
    {
        try
        {
            await next(httpContext);
        }
        catch (ValidationException ex)
        {
            logger.LogError(ex, ex.Message);
            logger.LogError(ex.GetBaseException(), ex.Message);

            httpContext.Response.StatusCode = (int) HttpStatusCode.BadRequest;

            await httpContext.Response.WriteAsJsonAsync(new ErrorResponse(Errors.GenericValidation));
        }
        catch (ApiException ex)
        {
            logger.LogError(ex, ex.Message);
            logger.LogError(ex.GetBaseException(), ex.Message);

            httpContext.Response.StatusCode = (int) ex.StatusCode;

            await httpContext.Response.WriteAsJsonAsync(ex.ErrorResponse);
        }
        catch (Exception ex)
        {
            logger.LogError(ex, ex.Message);
            logger.LogError(ex.GetBaseException(), ex.Message);

            httpContext.Response.StatusCode = (int) HttpStatusCode.InternalServerError;

            await httpContext.Response.WriteAsJsonAsync(new ErrorResponse(Errors.DefaultError500));
        }
    }
}