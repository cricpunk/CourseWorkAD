using System;
using System.Runtime.Serialization;

namespace CourseWorkAD.Model {

    [Serializable()]
    class Item : ISerializable {

        public string ItemCode { get; set; }
        public string ItemName { get; set; }
        public string ItemRate { get; set; }
        public string ItemCategory { get; set; }

        public Item() { }

        // Serializing
        /* METHOD : (1)
        * ********************************************************************************************************
        * 
        * ********************************************************************************************************
        */
        public void GetObjectData(SerializationInfo info, StreamingContext context) {
            info.AddValue("ItemCode", ItemCode);
            info.AddValue("ItemName", ItemName);
            info.AddValue("ItemRate", ItemRate);
            info.AddValue("ItemCategory", ItemCategory);
        }

        // Dserializing or remove
        /* METHOD : (2)
        * ********************************************************************************************************
        * 
        * ********************************************************************************************************
        */
        public Item(SerializationInfo info, StreamingContext contex) {
            ItemCode = (string)info.GetValue("ItemCode", typeof(string));
            ItemName = (string)info.GetValue("ItemName", typeof(string));
            ItemRate = (string)info.GetValue("ItemRate", typeof(string));
            ItemCategory = (string)info.GetValue("ItemCategory", typeof(string));
        }
    }

}
