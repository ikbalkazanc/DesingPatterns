using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creational.Factory.Databases
{
    public class OracleDatabase : IDatabase
    {
        public string ConnectionString { get; set; }

        public void Connect()
        {
            Console.WriteLine("Connected Oracle Database");
        }

        public object ExecuteQuery(string sql)
        {
            Console.WriteLine("Executing on Oracle : " + sql);
            Task.Delay(1000);
            Console.WriteLine("Executed");
            return "Oracle";
        }
    }
}
