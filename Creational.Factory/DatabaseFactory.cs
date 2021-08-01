using Creational.Factory.Databases;

namespace Creational.Factory
{
    public class DatabaseFactory
    {
        public IDatabase CreateDatabase(QueryType queryType)
        {
            switch (queryType)
            {
                case QueryType.Log:
                    return new PostgreDatabase();
                case QueryType.UserCredentials:
                    return new SqlServerDatabase();
                case QueryType.Anothers:
                    return new OracleDatabase();
                default:
                    return new PostgreDatabase();
            }
        }
    }

    public enum QueryType
    {
        UserCredentials,
        Log,
        Anothers
    };
}
