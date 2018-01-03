using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace CourseWorkAD.Model {

    [Serializable()]
    class SerializeItem : ISerializable {

        public List<Item> Items { get; set; }

        public Dictionary<string, int> TotalSalesCollection { get; set; }

        public SerializeItem() { }

        /* METHOD : (1)
        * ********************************************************************************************************
        * 
        * ********************************************************************************************************
        */
        public void GetObjectData(SerializationInfo info, StreamingContext context) {
            info.AddValue("Items", Items);
            info.AddValue("TotalSalesCollection", TotalSalesCollection);
        }

        /* METHOD : (2)
        * ********************************************************************************************************
        * 
        * ********************************************************************************************************
        */
        public SerializeItem(SerializationInfo info, StreamingContext context) {
            this.Items = (List<Item>)info.GetValue("Items", typeof(List<Item>));
            this.TotalSalesCollection = (Dictionary<string, int>)info.GetValue("TotalSalesCollection", typeof(Dictionary<string, int>));
        }

    }

}
