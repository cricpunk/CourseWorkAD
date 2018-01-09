using System;
using System.Runtime.Serialization;

/* METHODS AND IT'S CONTENTS
 * ****************************************************************************************************************
 * METHOD 1 : Serializble data (Allow to save file)
 * METHOD 2 : Deserializable data (Allow to retrive file)
 * ****************************************************************************************************************
 */

namespace CourseWorkAD.Model {

    [Serializable()]
    class Item : ISerializable {

        public string ItemCode { get; set; }
        public string ItemName { get; set; }
        public string ItemRate { get; set; }
        public string ItemCategory { get; set; }

        // Empty constructor
        public Item() { }

        /* METHOD : (1)
        * ********************************************************************************************************
        * This method will allow object data to serialize. 
        * This is serialization function which is going to store object data in a file.
        * SerializationInfo will hold key and value pairs of data from object.
        * ********************************************************************************************************
        */
        public void GetObjectData(SerializationInfo info, StreamingContext context) {
            // Assigning key value pair for info.
            info.AddValue("ItemCode", ItemCode);
            info.AddValue("ItemName", ItemName);
            info.AddValue("ItemRate", ItemRate);
            info.AddValue("ItemCategory", ItemCategory);
        }

        /* METHOD : (2)
        * ********************************************************************************************************
        * Removing object instance from file and storing them back to properties
        * This method will deseialize data and set properties value
        * ********************************************************************************************************
        */
        public Item(SerializationInfo info, StreamingContext contex) {
            // Refrence key to class properties
            ItemCode = (string)info.GetValue("ItemCode", typeof(string));
            ItemName = (string)info.GetValue("ItemName", typeof(string));
            ItemRate = (string)info.GetValue("ItemRate", typeof(string));
            ItemCategory = (string)info.GetValue("ItemCategory", typeof(string));
        }
    }

}
