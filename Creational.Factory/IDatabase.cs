using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creational.Factory
{
    public interface IDatabase
    {
        public string ConnectionString { get; set; }
        public void Connect();

        public object ExecuteQuery(string sql);
    }
}
