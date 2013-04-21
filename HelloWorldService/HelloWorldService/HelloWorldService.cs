using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace HelloWorldService
{
    public class HelloWorldService : IHelloWorldService
    {
        public string SayHello(Person person)
        {
            return string.Format("Hello, {0} {1}", person.Name, person.Surname);
        }
    }
}
