using System;
using System.Threading.Tasks;
using System.Threading;
using System.Security.Cryptography.X509Certificates;

namespace ThreadingExample

{
     
public class MyThread
    {
        public void Thread1()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(i);
                Thread.Sleep(400);


            }
            Task t = Task.Run(() =>
          

            {
                for (int x = 0; x < 6; x++)
                {
                   
                    Console.Write("Hi ");
                    Thread.Sleep(500);
                }
                
            });

            t.Wait();
        }
    }

    
    public class ThreadEx
    {
       
            public static void Main()
        {
            MyThread mt = new MyThread();
            Thread t1 = new Thread(new ThreadStart(mt.Thread1));
            Thread t2 = new Thread(new ThreadStart(mt.Thread1));
            Thread t3 = new Thread(new ThreadStart(mt.Thread1));
            t1.Start();
            t1.Join();
            t2.Start();
            
            t3.Start();


           
        }
    }

}

