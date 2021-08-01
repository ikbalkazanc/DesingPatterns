using System;

namespace Creational.Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            var factory = new DatabaseFactory();

            var db = factory.CreateDatabase(QueryType.UserCredentials);
            db.Connect();
            var result = db.ExecuteQuery("SELECT * FROM [dbo].[User]");

            db = factory.CreateDatabase(QueryType.Log);
            db.Connect();
            var result2 = db.ExecuteQuery("SELECT * FROM [dbo].[Log]");

            Console.WriteLine("HALT");
        }
    }
}
