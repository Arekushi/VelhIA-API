using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System;
using System.Net;
using System.Threading.Tasks;
using VelhIA_API.Domain.Responses.Exceptions;
using VelhIA_API.Middlewares.Exceptions;

namespace VelhIA_API.Middlewares.Middlewares
{
    public class ExceptionHandlerMiddleware
    {
        private readonly RequestDelegate next;
        private readonly ILogger logger;

        public ExceptionHandlerMiddleware(
            RequestDelegate next,
            ILoggerFactory loggerFactory)
        {
            this.next = next;
            logger = loggerFactory.CreateLogger<ExceptionHandlerMiddleware>();
        }

        public async Task InvokeAsync(HttpContext context)
        {
            try
            {
                await next(context);
            }
            catch (Exception e)
            {
                await HandleExceptionAsync(context, e);
            }
        }

        private Task HandleExceptionAsync(HttpContext context, Exception e)
        {
            BaseException exception = ParseToBaseException(e);

            logger.LogError($"ERROR:{exception.Code}");

            context.Response.Clear();
            context.Response.ContentType = "appication/json";
            context.Response.StatusCode = (int)exception.Code;

            return context.Response.WriteAsync(
                JsonConvert.SerializeObject(exception.Response, Formatting.Indented) as string
            );
        }

        private BaseException ParseToBaseException(Exception e)
        {
            if (e is BaseException)
            {
                return e as BaseException;
            }
            else
            {
                HttpStatusCode code = StatusCodeByException(e);

                return new BaseException()
                {
                    Code = code,
                    Response = new ExceptionResponse<Exception>()
                    {
                        Code = code,
                        Success = false,
                        Data = e,
                        ExceptionName = e.GetType().Name,
                        Message = e.Message
                    }
                };
            }
        }

        private HttpStatusCode StatusCodeByException(Exception e)
        {
            return e switch
            {
                _ => HttpStatusCode.InternalServerError
            };
        }
    }
}
