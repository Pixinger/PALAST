using System;
using System.IO;
using System.Xml.Serialization;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PALAST.RSM.Service
{
    public class SerializationTools
    {
        public static void Save<T>(string filename, T instance) where T : class
        {
            XmlSerializer serializer = new XmlSerializer(typeof(T));
            using (StreamWriter streamWriter = new StreamWriter(filename, false, System.Text.Encoding.Unicode))
            {
                serializer.Serialize(streamWriter, instance, null);
                streamWriter.Close();
            }
        }

        public static T FromFilename<T>(string filename) where T : class
        {
            XmlSerializer serializer = new XmlSerializer(typeof(T));
            using (TextReader reader = new StreamReader(filename, System.Text.Encoding.Unicode))
            {
                return serializer.Deserialize(reader) as T;
            }
        }
    }
}
