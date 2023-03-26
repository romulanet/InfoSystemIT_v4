namespace Persistence
{
    public class DbInitializer
    {
        public static void Initialize(DataDBContext context)
        {
            context.Database.EnsureCreated();
        }
    }
}
