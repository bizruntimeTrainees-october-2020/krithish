using System;
using System.Dynamic;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
c

namespace SerializeDeSerialize
{
    public class MovieDetails
    {


        class Movie
        {
            public int Id { get; set; }
            public string title { get; set; }
            public string ShowTimings { get; set; }
        }
        static void Main(string[] args)
            {
            Console.WriteLine("\n-->> SERIALIZATION <<--");
            Movie m = new Movie { Id = 1, title = "Billa", ShowTimings="Night-Show" };
            String result = JsonConvert.SerializeObject(m);
            Console.WriteLine(result);


            Console.WriteLine("\n-->>  DE-SERIALIZATION <<--");
            Movie mu = JsonConvert.DeserializeObject<Movie>(result);
            Console.WriteLine("Id is  : " + mu.Id);
            Console.WriteLine("Title is  : " + mu.title);
            Console.WriteLine("Show Timings is   : " + mu.ShowTimings);
        }
        }

    }
