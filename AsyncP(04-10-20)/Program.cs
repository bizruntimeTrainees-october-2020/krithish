using System;
using System.Threading.Tasks;

namespace AsyncP
{
    class AsyncDemo
    {
        public static async Task Method1()
        {
            await Task.Run(() =>
            {
                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine("METHOD 1 IS EXECUTING");
                }
            });
        }

        public static void Method2()
        {
            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine("METHOD 2 IS EXECUTING");
            }
        }

        public static  async Task Method3()
        {
            await Task.Run(() =>
            {
                for (int i = 0; i < 2; i++)
                {
                    Console.WriteLine("METHOD 3 IS EXECUTING");
                }
            });
        }
        static void Main(string[] args)
        {
            Method1();

            
            Method2();
            Method3();


        }
    }
}
