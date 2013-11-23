namespace Onion.Factory
{
    using System.Collections.Generic;

    public static class Database
    {
        private static readonly Dictionary<object, object> everything = new Dictionary<object, object>();

        public static void Insert(object id, object entity)
        {
            everything.Add(id, entity);
        }

        public static void Update(object id, object entity)
        {
            everything[id] = entity;
        }

        public static object Select(object id)
        {
            object value;
            everything.TryGetValue(id, out value);
            return value;
        }
    }
}