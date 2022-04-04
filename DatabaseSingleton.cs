using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//creational design pattern
namespace Design_patterns
{
    public sealed class DatabaseSingleton
    {

        private static readonly Lazy<DatabaseSingleton> _instance = new Lazy<DatabaseSingleton>(() => new DatabaseSingleton());

        private DatabaseSingleton() { }
        public static DatabaseSingleton Instance 
        {
           get {
                return _instance.Value;
            }
        }

    }
}
