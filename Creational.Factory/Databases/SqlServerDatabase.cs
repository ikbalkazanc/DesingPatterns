using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creational.Factory.Databases
{
    public class SqlServerDatabase : IDatabase
    {
        public string ConnectionString { get; set; }

        public void Connect()
        {
            Console.WriteLine("Connected SqlServer Database");
        }

        public object ExecuteQuery(string sql)
        {
            Console.WriteLine("Executing on SqlServer : " + sql);
            Task.Delay(1000);
            Console.WriteLine("Executed");
            return "SqlServer";
        }
    }
}
