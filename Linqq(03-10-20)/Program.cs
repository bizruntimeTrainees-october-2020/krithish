using System;
using System.Linq;
using System.Collections.Generic;


namespace Linqq
{
    class Lqueries
    {
        public static void queryMethod()
        {
            string[] names = { "Christiano", "Steve", "Ronaldo", "Smith" };

            // LINQ Query 
            var myLinqQuery = from name in names
                              where name.Contains('a')
                              select name;

            // Query execution
            foreach (var name in myLinqQuery)
                Console.WriteLine(name + " ");
            
        }
        public static void queryMethod2() //USING IENUMERABLE
        {
            // string collection
            IList<string> stringList = new List<string>() {
            "C# Tutorials",
            "VB.NET Tutorials",
            "Learn C++",
            "MVC " ,
            "Java"
        };

            // LINQ Query Syntax
            var result = from s in stringList
                         where s.Contains("Tutorials")
                         select s;

            foreach (var str in result)
            {
                Console.WriteLine(str);
            }

            //LINQ METHOD SYNTAX 

            var results = stringList.Where(s => s.Contains("Java"));


            foreach (var str in results)
            {
                Console.WriteLine(str);
            }




        }

        public static void mixedMethod()
        {
            List<int> integerList = new List<int>()
            {
                10, 25,42 ,28,1, 2, 3, 4, 5, 6, 7, 8, 9, 10
            };
            //LINQ Query using Mixed Syntax
            var MethodSyntax = (from obj in integerList
                                where obj > 5
                                select obj).Sum();
            //Execution
            Console.WriteLine("Sum Is : " + MethodSyntax);
            //to show the min numbeer

            var Mini = (from obj1 in integerList
                        where obj1 >= 0
                        select obj1).Min();
            Console.WriteLine("Min Number is : " + Mini);

            var Maxi = (from obj2 in integerList
                          where obj2 >= 0
                          select obj2).Max();
            Console.WriteLine("Max Number is : " + Maxi);

            var Av = (from obj3 in integerList
                      where obj3 >= 0
                      select obj3).Average();

            Console.WriteLine("Average Number is :" + Av);

        }
        static void Main(string[] args) 
        {
            queryMethod();
            queryMethod2();
            mixedMethod();

        }
    }
}
