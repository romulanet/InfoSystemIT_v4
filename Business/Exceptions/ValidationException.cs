namespace Business.Exceptions
{
    public sealed class ValidationException : ApplicationException
    {
        public ValidationException(IReadOnlyDictionary<string, string[]> errorsDictionary)
            : base("Ошибка Валидации", "Одна или несколько ошибок валидации")
            => ErrorsDictionary = errorsDictionary;

        public IReadOnlyDictionary<string, string[]> ErrorsDictionary { get; }
    }
}
