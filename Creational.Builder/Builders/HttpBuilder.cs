using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creational.Builder.Builders
{
    public class HttpBuilder : IHttpBuilder
    {
        protected HttpRequest Request { get; set; } = new HttpRequest();

        public HttpRequest GetRequest()
        {
            return Request;
        }

        public void Reset()
        {
            Request = new HttpRequest();
        }

        public virtual void SetHeader()
        {
            Request.Headers = null;
        }

        public virtual void SetHttpVersion()
        {
            Request.HttpVersion = "1.1";
        }

        public virtual void SetPath()
        {
            Request.Path = "/";
        }

        public virtual void SetRequestType()
        {
            Request.RequesyType = "GET";
        }
    }
}
