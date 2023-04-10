namespace Business.Exceptions
{
    public sealed class EntityNotFoundException : NotFoundException
    {
        public EntityNotFoundException(Guid entityId)
            : base($"The customer with the identifier {entityId} was not found.")
        {
        }
    }
}
