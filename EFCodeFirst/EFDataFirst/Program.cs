using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;

namespace EFCodeFirst
{
    class CodeFirstApproach
    {
        static void Main(string[] args)
        {
            using (CodeFirstContext context = new CodeFirstContext())
            {
                Department dept = new Department()
                {
                    Dep = "Chemistry",
                    


                    Students = new List<Student>
                    {
                        new Student(){Name="David"},
                        new Student(){ Name = "Billa" },
                        new Student(){ Name = "John" },
                        

                    }
        };
            context.Departments.Add(dept);
            context.SaveChanges();
            Console.WriteLine("Data Entered Successfully");
            Console.ReadKey();

            }
        }
    }
}
