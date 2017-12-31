using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace CourseWorkAD.Model {

    [Serializable()]
    class ItemsToSerialize : ISerializable {

        public List<Item> Items { get; set; }

        //public List<Dictionary<string, int>> TotalSalesCollection { get; set; }

        public ItemsToSerialize() { }

        public void GetObjectData(SerializationInfo info, StreamingContext context) {
            info.AddValue("Items", Items);
            //info.AddValue("TotalSalesCollection", TotalSalesCollection);
        }

        public ItemsToSerialize(SerializationInfo info, StreamingContext context) {
            this.Items = (List<Item>)info.GetValue("Items", typeof(List<Item>));
            //this.TotalSalesCollection = (List<Dictionary<string, int>>)info.GetValue("TotalSalesCollection", typeof(List<Dictionary<string, int>>));
        }

    }

}
