using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creational.Builder
{
    public class HttpRequest
    {
        public string RequesyType { get; set; }
        public string Path { get; set; }
        public string HttpVersion { get; set; }
        public Dictionary<string,string> Headers { get; set; }
        public string Body { get; set; }

        public void Execute()
        {
            Console.WriteLine("HTTP : " + RequesyType + " " + Path + " " + HttpVersion + "\n");
        }

    }
}
