using System;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Xml.Serialization;
using System.Xml;
using Newtonsoft.Json;

namespace XmlSerialization
{

    public class Program
    {
        #region properties

        public List<string> UIComponents { get; set; }
        public List<string> Settings { get; set; }

        #endregion

       
        static void Main(string[] args)
        {
            Class1 class1 = new Class1();
            class1.Age = 24;
            class1.Name = "Krithish";
            class1.Male = true;
            class1.Save("Example.xml");


        }

    }  }
