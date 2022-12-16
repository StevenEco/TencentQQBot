using System.Net;
using System.Security.Authentication;

namespace TencentQQBot.Sdk;
public class BotAuthenticationFailedException: AuthenticationException
{
    public BotAuthenticationFailedException() : base() { }
	public BotAuthenticationFailedException(string message):base(message) 
	{

    }
    public BotAuthenticationFailedException(string msg, Exception innerException) : base(msg, innerException)
    {
    }
}
public class NotFoundException:Exception
{
    public NotFoundException() : base() { }
    public NotFoundException(string message) : base(message)
    {

    }
    public NotFoundException(string msg, Exception innerException) : base(msg, innerException)
    {
    }
}
public class MethodNotAllowedException: Exception
{
    public MethodNotAllowedException() : base() { }
    public MethodNotAllowedException(string message) : base(message)
    {

    }
    public MethodNotAllowedException(string msg, Exception innerException) : base(msg, innerException)
    {
    }
}
public class SequenceNumberException : Exception
{
    public SequenceNumberException() : base() { }
    public SequenceNumberException(string message) : base(message)
    {

    }
    public SequenceNumberException(string msg, Exception innerException) : base(msg, innerException)
    {
    }
}
public class ServerException : Exception
{
    public ServerException() : base() { }
    public ServerException(string message) : base(message)
    {
    }
    public ServerException(string msg, Exception innerException) : base(msg, innerException)
    {
    }
}
public class ForbiddenException : Exception
{
    public ForbiddenException() : base() { }
    public ForbiddenException(string message) : base(message)
    {
    }
    public ForbiddenException(string msg, Exception innerException) : base(msg, innerException)
    {
    }
}

public static class ErrorDictionary
{
    private static readonly Dictionary<HttpStatusCode, Type>? httpErrorDictionary = new Dictionary<HttpStatusCode, Type>() 
    {
        {HttpStatusCode.Unauthorized,typeof(AuthenticationException) },
        {HttpStatusCode.NotFound,typeof(NotFoundException) },
        {HttpStatusCode.MethodNotAllowed,typeof(MethodAccessException) },
        {HttpStatusCode.Forbidden,typeof(ForbiddenException) },
        {HttpStatusCode.TooManyRequests,typeof(SequenceNumberException) },
        {HttpStatusCode.InternalServerError,typeof(ServerException) },
        {HttpStatusCode.GatewayTimeout,typeof(ServerException) },
    };
    public static Dictionary<HttpStatusCode, Type>? HttpErrorDictionary => httpErrorDictionary;
}