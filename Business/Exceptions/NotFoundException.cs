namespace Business.Exceptions
{
    public abstract class NotFoundException : ApplicationException
    {
        protected NotFoundException(string message)
            : base("Ошибка поиска: ", message)
        {
        }
    }
}
