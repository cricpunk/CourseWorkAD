using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace CourseWorkAD {

    [Serializable()]
    class ItemsToSerialize : ISerializable {

        public List<Item> Items { get; set; }

        public ItemsToSerialize() { }

        public void GetObjectData(SerializationInfo info, StreamingContext context) {
            info.AddValue("Items", Items);
        }

        public ItemsToSerialize(SerializationInfo info, StreamingContext context) {
            this.Items = (List<Item>)info.GetValue("Items", typeof(List<Item>));
        }
    }

}
