namespace Business.Exceptions
{
    public sealed class EntityNotFoundException : NotFoundException
    {
        public EntityNotFoundException(Guid entityId)
            : base($"Не найден объект {entityId}")
        {
        }
    }
}
