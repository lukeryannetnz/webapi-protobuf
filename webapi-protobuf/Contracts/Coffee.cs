using System;

namespace webapi_protobuf.Contracts
{
    public class Coffee
    {
        /// <summary>
        /// Every good class has a guid id.
        /// </summary>
        public Guid Id { get; set; }

        public string Name { get; set; }

        public int SugarCount { get; set; }

        public bool ContainsMilk { get; set; }

        public CoffeeSize Size { get; set; }

        public enum CoffeeSize
        {
            Short = 0,
            Small = 1,
            Medium = 2,
            Large = 3
        }
    }
}