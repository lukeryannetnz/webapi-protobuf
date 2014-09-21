using System;

namespace webapi_protobuf.contracts
{
    public class GetCoffeeRequest
    {
        public Guid? Id { get; set; }

        public Coffee.CoffeeSize? Size { get; set; }

        public string Name { get; set; }

        public bool? ContainsMilk { get; set; }
    }
}