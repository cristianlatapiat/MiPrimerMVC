using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Application
    {
        public string Name { get; set; }
        public List<Value> Values { get; set; }
    }

    public class Value
    {
        public string Server { get; set; }
        public string PathAssemblies { get; set; }
    }
}