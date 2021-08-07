using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creational.Builder.Builders
{
    public class NotificationServiceHttpBuilder : HttpBuilder
    {
        public override void SetPath()
        {
            Request.Path = "www.onesignal.com/send";
        }
        public override void SetRequestType()
        {
            Request.RequesyType = "POST";            
        }
    }
}
