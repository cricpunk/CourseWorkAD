using CourseWorkAD.Model;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

/* METHODS AND IT'S CONTENTS
 * ****************************************************************************************************************
 * METHOD 1 : Serialize data
 * METHOD 2 : Deserialize data
 * ****************************************************************************************************************
 */

namespace CourseWorkAD.Serialization {

    class Serializer {

        private Stream stream;
        private BinaryFormatter formatter;

        // Empty constructor
        public Serializer() { }

        /* METHOD : (1)
        * ********************************************************************************************************
        * Serialize data
        * Open file from location, if there isn’t any then create one and assign it to stream. 
        * Initialize binary formatter object. 
        * Serialize items by calling Serialize method using binary formatter object. 
        * Serialize method will accept two parameters first file location which is hold by stream and another is data i.e. items in this case. 
        * Finally, close stream.
        * ********************************************************************************************************
        */
        public void SearilizeItems(string fileName, SerializeItem items) {

            // Open file from location if there isnt any there then create one
            stream = File.Open(fileName, FileMode.Create);

            // Initialize binary formater object.
            formatter = new BinaryFormatter();

            // Ferialize data using binary formatter
            formatter.Serialize(stream, items);

            //stream = File.Open(fileName, FileMode.Open);

            // Close stream
            stream.Close();

        }

        /* METHOD : (2)
        * ********************************************************************************************************
        * De-Serialize data
        * Declare object of SerializeItem class. Initialize binary formatter object.
        * Open file and assign it to stream. 
        * Call Deserialize method using binary formatter object which will accept one parameter i.e. stream. 
        * Deserialize method will return list of object instance which will be assigned to SerializeItem class object. 
        * Finally, close stream and return SerializeItem class object.
        * ********************************************************************************************************
        */
        public SerializeItem DeserializeItems(string fileName) {

            // Declare  object
            SerializeItem serializeItem;

            // Initialize binary formater object.
            formatter = new BinaryFormatter();

            // Open file from location
            stream = File.Open(fileName, FileMode.Open);

            // Initialize serializeItem object with value reurned by formatter.
            serializeItem = (SerializeItem)formatter.Deserialize(stream);

            // Close stream
            stream.Close();

            // Return deserialized object
            return serializeItem;
            
        }

    }

}

