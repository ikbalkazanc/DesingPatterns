using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creational.Builder.Builders
{
    public class PaymentServiceHttpBuilder : HttpBuilder
    {
        public override void SetPath()
        {
            Request.Path = "www.iziyco.com/pay";
        }
        public override void SetRequestType()
        {
            Request.RequesyType = "PUT";
        }

        public override void SetHeader()
        {
            var headers = new Dictionary<string, string>();
            headers.Add("Content-Type", "application/json");
            Request.Headers = headers;
        }
    }
}
