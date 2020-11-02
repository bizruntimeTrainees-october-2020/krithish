using System;
using System.Reactive.Concurrency;
using System.Reactive.Subjects;
using System.Threading;
using System.Threading.Tasks;

namespace RxSubject
{
    class Program
    {

        static void Main(string[] args)
        {
            // CreatingSubject();
            //ReplayMethod();
            //AsyncMethod();
            ThreadMethod();
        }

        static void WriteSequenceToConsole(IObservable<String> Sequence)
        {
            Sequence.Subscribe(Console.WriteLine);
        }
        public static void CreatingSubject()
        {
            var Subject = new Subject<string>();
            WriteSequenceToConsole(Subject);
            Subject.OnNext("a");
            Subject.OnNext("b");
            Subject.OnNext("c");
            Console.ReadKey();
        }
        static void printTheseItems(IObservable<String> mySubject)
        {
            mySubject.Subscribe(Console.Write);
        }
        public static void ReplayMethod()
        {
            //var mySubject = new ReplaySubject<string>(2); //For Replay Method
            var mySubject = new BehaviorSubject<string>("A String"); //For Behaviour Methods
            mySubject.OnNext("This");
            mySubject.OnNext("is");
            mySubject.OnNext("my");
            mySubject.OnNext("Country");

            printTheseItems(mySubject);
            Console.ReadKey();

        }


        static void printItems(IObservable<String> mySubject)
        {
            mySubject.Subscribe(Console.Write);
        }
        public static void AsyncMethod()
        {

            var mySubject = new AsyncSubject<string>();
            mySubject.OnNext("This");
            //mySubject.OnCompleted();
            mySubject.OnNext("is");
            mySubject.OnNext("my");
            mySubject.OnCompleted();
            mySubject.OnNext("Country");

            printTheseItems(mySubject);
            Console.ReadKey();

        }

        public static void ThreadMethod()
        {
            Console.WriteLine("Starting on threadId:{0}", Thread.CurrentThread.ManagedThreadId);
            var subject = new Subject<object>();
            subject.Subscribe(
            o => Console.WriteLine("Received {1} on threadId:{0}",
            Thread.CurrentThread.ManagedThreadId,
            o));

            //Method that executes on Thread 
            ParameterizedThreadStart notify = obj =>
            {
                Console.WriteLine("OnNext({1}) on threadId:{0}",
                Thread.CurrentThread.ManagedThreadId,
                obj);
                subject.OnNext(obj);
            };
            notify(1);
            new Thread(notify).Start(2);
            new Thread(notify).Start(3);
        }





    }
}


