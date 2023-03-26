namespace Business.Common.Constants
{
    public class Constants
    {
        public static class ControllerMethods
        {
            public const string Create = "create";
            public const string Load = "load/{id}";
            public const string List = "list";
            public const string Update = "update";
            public const string Delete = "delete/{id}";
            public const string Set = "set";
        }
        public static class ProjectStatus
        {
            public const string InProcess = "InProcess";
            public const string Stopped = "Stopped";
            public const string Finished = "Finished";
        }
        public static class ProjectType
        {
            public const string Development = "Development";
            public const string Integration = "Integration";
            public const string ServiceSupport = "ServiceSupport";
        }

        public static class UserName
        {
            public const string System = "System";
        }
    }
}
