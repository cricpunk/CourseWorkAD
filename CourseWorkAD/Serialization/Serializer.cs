using CourseWorkAD.Model;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace CourseWorkAD.Serialization {

    class Serializer {

        private Stream stream;
        private BinaryFormatter formatter;

        public Serializer() { }

        public void SearilizeItems(string fileName, ItemsToSerialize items) {

            stream = File.Open(fileName, FileMode.Create);

            formatter = new BinaryFormatter();

            formatter.Serialize(stream, items);

            //stream = File.Open(fileName, FileMode.Open);

            stream.Close();

        }

        public ItemsToSerialize DeserializeItems(string fileName) {

            ItemsToSerialize itemsToSerialize;

            formatter = new BinaryFormatter();

            stream = File.Open(fileName, FileMode.Open);

            itemsToSerialize = (ItemsToSerialize)formatter.Deserialize(stream);

            stream.Close();

            return itemsToSerialize;
        }
    }

}

