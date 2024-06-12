using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Shopfast.Entities
{
    public class Response
    {
        public int result { get; set; }
        public string message { get; set; }

        public Response() { }
    }
}