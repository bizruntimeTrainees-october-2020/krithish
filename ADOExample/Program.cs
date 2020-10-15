using System;
using System.Data.SqlClient;
using Serilog;
using NLog.Fluent;

[assembly: log4net.Config.XmlConfigurator( Watch = true)]

namespace ADOExample
{
   
    public  class SqlDataBase 

    {

         public static void sqll()
        {

            var log = new LoggerConfiguration()
           .WriteTo.Console()
           .WriteTo.File(@"C:\Users\krith\source\repos\ADOExample\logfile.log")
           .CreateLogger();

            //log.Information("Hello, Serilog!");
            //try
            //{
            log.Information("Enter Employee ID : ");
            int empID = Convert.ToInt32(Console.ReadLine());

            log.Information("Enter Employee name : ");
            string name = Console.ReadLine();

            log.Information("Enter Employee Salarry : ");
            decimal salary = Convert.ToDecimal(Console.ReadLine());

            string query = "insert into  emp values(" + empID + " ,'" + name + " ', " + salary + ")";
            Console.WriteLine(query);
            //Sql Server Using Windows Authentication: 
            //string cs = "data source =.; database = emp; integrated security = SSPI";
            string cs = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\krith\source\repos\ADOExample\ADOExample\Database1.mdf;Integrated Security=True";
            SqlConnection cn = new SqlConnection(cs);
            cn.Open();
            Console.WriteLine("Connection Established ");

            SqlCommand cmd = new SqlCommand(query, cn);
            int result = cmd.ExecuteNonQuery();
            Console.WriteLine(result + "record/s inserted  in emp table");

            Console.WriteLine("-----FOR RETREIVING DATA------");
            query = "select * from emp";
            SqlCommand cmd1 = new SqlCommand(query, cn); //Seperate instance of sql command is used 
            SqlDataReader r = cmd1.ExecuteReader();
            while (r.Read() == true)
            {
                int eid = r.GetInt32(0);
                string nm = r.GetString(1);
                decimal sal = r.GetDecimal(2);
                Console.WriteLine("{0}\t{1}\t{2}", eid, nm, sal);



            }

            Console.WriteLine("-----FOR DELETING DATA------");
            query = "select * from emp where id = 1";
            SqlCommand cmd1 = new SqlCommand(query, cn); //Seperate instance of sql command is used 
            SqlDataReader r = cmd1.ExecuteReader();

            cn.Close();
            //}
            //  catch (Exception ex)
            //{
            // log.Information(ex.Message);
            //}

        }


        static void Main(string[] args)
        {
            sqll();


        }
    }
}
