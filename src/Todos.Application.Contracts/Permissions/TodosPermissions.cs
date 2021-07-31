namespace Todos.Permissions
{
    public static class TodosPermissions
    {
    
        public const string TodosGroup = "Todos";   

        public static class Todos
        {
            public const string Default = TodosGroup + ".Todos";
            public const string Create = Default + ".Create";
            public const string Update = Default+ ".Update";
            public const string Delete = Default + ".Delete";
        }


    }
}