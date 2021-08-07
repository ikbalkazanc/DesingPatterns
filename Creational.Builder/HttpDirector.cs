using Creational.Builder.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creational.Builder
{
    public class HttpDirector
    {
        private HttpBuilder Builder;

        public void SetBuilder(HttpBuilder builder)
        {
            Builder = builder;
        }

        public HttpRequest Build()
        {
            HttpRequest request = new HttpRequest();
            if(Builder != null)
            {
                Builder.SetHeader();
                Builder.SetHttpVersion();
                Builder.SetPath();
                Builder.SetRequestType();
                request = Builder.GetRequest();
                Builder.Reset();
            }
            return request;
        }
    }
}
