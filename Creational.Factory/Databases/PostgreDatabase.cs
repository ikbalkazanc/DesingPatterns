using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creational.Factory.Databases
{
    public class PostgreDatabase : IDatabase
    {
        public string ConnectionString { get; set; }

        public void Connect()
        {
            Console.WriteLine("Connected PostgreSQL Database");
        }

        public object ExecuteQuery(string sql)
        {
            Console.WriteLine("Executing on PostgreSQL : " + sql);
            Task.Delay(1000);
            Console.WriteLine("Executed");
            return "Postgre";
        }
    }
}
