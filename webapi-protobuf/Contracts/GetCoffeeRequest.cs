using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace webapi_protobuf.Contracts
{
    public class GetCoffeeRequest
    {
        public Guid? Id { get; set; }

        public Coffee.CoffeeSize? Size { get; set; }

        public string Name { get; set; }

        public bool? ContainsMilk { get; set; }
    }
}