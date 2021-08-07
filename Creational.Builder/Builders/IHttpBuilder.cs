using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creational.Builder.Builders
{
    public interface IHttpBuilder
    {
        public void Reset();
        public void SetHeader();
        public void SetRequestType();
        public void SetPath();
        public void SetHttpVersion();

        public HttpRequest GetRequest();
    }
}
