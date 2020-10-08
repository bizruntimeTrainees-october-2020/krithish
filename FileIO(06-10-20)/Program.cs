using System;
using System.IO;
using System.Security.Cryptography.X509Certificates;

namespace Filessss
{
    class Mainn
    {
        public static void Fileacess()
        {
            string path = @"c:\temp\HelloFile.txt";
            if (!File.Exists(path))
            {
                // Create a file to write to.
                using (StreamWriter sw = File.CreateText(path))
                {
                    sw.Write("Hello !!");
                    sw.Write(" How ");
                    sw.Write("are");
                    sw.Write(" You");

                    string path2 = @"c:\temp\HelloFile.txt";

                    string lines;
                    lines = File.ReadAllText(path2);
                    Console.WriteLine(lines);


                }

               

            }

            using (StreamWriter ss = File.AppendText(path))
            {
                ss.WriteLine("   Yes Im Fine");



                DateTime lastWriteTime = File.GetLastWriteTime(@"c:\temp\HelloFile.txt");



            }

            

           

            // Open the file to read from.
            using (StreamReader sr = File.OpenText(path))
            {
                string s="";
                while ((s = sr.ReadLine()) != null)
                {
                    Console.WriteLine(s);
                }
            }

        }
     
    
            static void Main(string[] args)
            {

                Fileacess();
            


            }     
        
        
    }
}
