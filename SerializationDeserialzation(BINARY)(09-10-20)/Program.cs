using System;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
namespace SerializationDemo
{
    class program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student();
            s1.rno = 1;
            s1.name = "John Smith";
            s1.marks = 87.5;
            IFormatter f = new BinaryFormatter();
            Stream str = new FileStream(@"C:\Users\krithish\source\repos\SerializationDeserialzation\Test.txt", FileMode.Create, FileAccess.Write);
            f.Serialize(str, s1);

            str.Close();
            str = new FileStream(@"C:\Users\krithish\source\repos\SerializationDeserialzation\Test.txt", FileMode.Open, FileAccess.Read);
            Student s2 = (Student)f.Deserialize(str);

            Console.WriteLine("Roll Number: {0}", s2.rno);
            Console.WriteLine("Name: {0}", s2.name);
            Console.WriteLine("Marks: {0}", s2.marks);
        }
    }
    [Serializable]
    class Student
    {
        public int rno;
        public String name;
        public double marks;
    }
}