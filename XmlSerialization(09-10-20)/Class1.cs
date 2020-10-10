using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml.Serialization;

namespace XmlSerialization
{
    public class Class1
    {
        public int Age { get; set; }
        public bool Male { get; set; }
        [XmlAttribute]
        public string Name { get; set; }
        public void Save(string filename)
        {
            using (var stream = new FileStream(filename, FileMode.Create))
            {
                var XML = new XmlSerializer(typeof(Class1));
                XML.Serialize(stream, this);
            }

        }

        public Class1 LoadFromFile(string filename)
        {
            using (var stream = new FileStream(filename, FileMode.Open))
            {
                var XML = new XmlSerializer(typeof(Class1));
                return (Class1)XML.Deserialize(stream);
            }
        }
    }

}
