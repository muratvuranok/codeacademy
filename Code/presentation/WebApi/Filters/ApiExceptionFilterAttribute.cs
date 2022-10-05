using Code.Application.Common.Exceptions;
using Microsoft.AspNetCore.Mvc.Filters;

namespace Code.WebApi.Filters;

public class ApiExceptionFilterAttribute : ExceptionFilterAttribute
{
    private readonly IDictionary<Type, Action<ExceptionContext>> _exceptionHandlers;

    public ApiExceptionFilterAttribute()
    {
        _exceptionHandlers = new Dictionary<Type, Action<ExceptionContext>>
        {
            { typeof(NotFoundException) , HandleNotFoundException },
            { typeof(ValidationException) , HandleNotValidationException },
        };
    }

    public override void OnException(ExceptionContext context)
    {
        HandleException(context);
        base.OnException(context);
    }

    private void HandleException(ExceptionContext context)
    {
        Type type = context.Exception.GetType();

        if (_exceptionHandlers.ContainsKey(type))
        {
            _exceptionHandlers[type].Invoke(context);
            return;
        }
        else
        {
            // Custom Exception Metot Eklenecek
        }
    }

    private void HandleNotFoundException(ExceptionContext context)
    {
        var exception = (NotFoundException)context.Exception;

        if (!context.ExceptionHandled)
        {
            // Send mail, sms vs..
            context.ExceptionHandled = true;

            var details = new ProblemDetails
            {
                Type = "",
                Title = "Not Found Exception",
                Detail = exception.Message
            };

            context.Result = new NotFoundObjectResult(details);
        }
        // Not Found Exception


    }

    private void HandleNotValidationException(ExceptionContext context)
    {
        // Not Found Exception
    }
}
