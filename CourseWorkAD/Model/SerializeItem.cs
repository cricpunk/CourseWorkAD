using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

/* METHODS AND IT'S CONTENTS
 * ****************************************************************************************************************
 * METHOD 1 : Serializble data (Allow to save file)
 * METHOD 2 : Deserializable data (Allow to retrive file)
 * ****************************************************************************************************************
 */

namespace CourseWorkAD.Model {

    // Making this class Serializable by implementing ISerializable interface
    [Serializable()]
    class SerializeItem : ISerializable {

        // Getter and setter for Generic List which store data type of Item class.
        // This list will be serialized.
        public List<Item> Items { get; set; }

        // Getter and setter for category name list.
        // This list will be serialized.
        public List<string> CategoryList { get; set; }

        // Getter setter for dictionary which hold item name as key and total revenue as value
        // This dictionary will be serialized.
        public Dictionary<string, int> TotalSalesCollection { get; set; }

        // Public empty constructor should be provided.
        public SerializeItem() { }

        /* METHOD : (1)
        * ********************************************************************************************************
        * This method will allow object data to serialize. 
        * This is serialization function which is going to store object data in a file.
        * SerializationInfo will hold key and value pairs of data from object.
        * ********************************************************************************************************
        */
        public void GetObjectData(SerializationInfo info, StreamingContext context) {
            info.AddValue("Items", Items);
            info.AddValue("CategoryName", CategoryList);
            info.AddValue("TotalSalesCollection", TotalSalesCollection);
        }

        /* METHOD : (2)
       * ********************************************************************************************************
       * Removing object instance from file and storing them back to properties
       * This method will deseialize data and set properties value
       * ********************************************************************************************************
       */
        public SerializeItem(SerializationInfo info, StreamingContext context) {
            this.Items = (List<Item>)info.GetValue("Items", typeof(List<Item>));
            this.CategoryList = (List<string>)info.GetValue("CategoryName", typeof(List<string>));
            this.TotalSalesCollection = (Dictionary<string, int>)info.GetValue("TotalSalesCollection", typeof(Dictionary<string, int>));
        }

    }

}
