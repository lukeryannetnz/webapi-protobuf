using System;
using ProtoBuf;

namespace webapi_protobuf.contracts
{
    [ProtoContract]
    public class Coffee
    {
        /// <summary>
        /// Every good class has a guid id.
        /// </summary>
        [ProtoMember(1)]
        public Guid Id { get; set; }

        [ProtoMember(2)]
        public string Name { get; set; }

        [ProtoMember(3)]
        public int SugarCount { get; set; }

        [ProtoMember(4)]
        public bool ContainsMilk { get; set; }

        [ProtoMember(5)]
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