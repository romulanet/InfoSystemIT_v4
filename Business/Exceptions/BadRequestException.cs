namespace Business.Exceptions
{
    public abstract class BadRequestException : ApplicationException
    {
        protected BadRequestException(string message)
            : base("Ошибка запроса: ", message)
        {
        }
    }
}