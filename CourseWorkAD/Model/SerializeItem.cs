using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace CourseWorkAD.Model {

    // Making this class Serializable by implementing ISerializable interface
    [Serializable()]
    class SerializeItem : ISerializable {

        // Getter and setter for Generic List which store data type of Item class.
        // This list will be serialized.
        public List<Item> Items { get; set; }

        // Getter setter for dictionary which hold item name as key and total revenue as value
        // This dictionary will be serialized.
        public Dictionary<string, int> TotalSalesCollection { get; set; }

        // Public empty constructor should be provided.
        public SerializeItem() { }

        /* METHOD : (1)
        * ********************************************************************************************************
        * Implementing ISerializable interface method.
        * This method should be implemented comulsory.
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
