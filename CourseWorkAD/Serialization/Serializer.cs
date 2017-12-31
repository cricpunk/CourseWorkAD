using CourseWorkAD.Model;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace CourseWorkAD.Serialization {

    class Serializer {

        private Stream stream;
        private BinaryFormatter formatter;

        public Serializer() { }

        public void SearilizeItems(string fileName, SerializeItem items) {

            stream = File.Open(fileName, FileMode.Create);

            formatter = new BinaryFormatter();

            formatter.Serialize(stream, items);

            //stream = File.Open(fileName, FileMode.Open);

            stream.Close();

        }

        public SerializeItem DeserializeItems(string fileName) {

            SerializeItem serializeItem;

            formatter = new BinaryFormatter();

            stream = File.Open(fileName, FileMode.Open);

            serializeItem = (SerializeItem)formatter.Deserialize(stream);

            stream.Close();

            return serializeItem;
            
        }

    }

}

