using System;
using System.Reactive;
using System.Reactive.Linq;
using System.Threading; 

namespace RXExample
{
     class ObservableExample
    {




        static void Main(string[] args)
        {
            //IObservable<int> iob = Observable.Range(1, 10);
            //iob.Subscribe(x => Console.WriteLine(x));
            var oneNumberPerSecond = Observable.Interval(TimeSpan.FromSeconds(1));

            var lowNums = from n in oneNumberPerSecond
                          where n < 5
                          select n;

            Console.WriteLine("Numbers < 5:");

            lowNums.Subscribe(lowNum =>
            {
                Console.WriteLine(lowNum);
            });

            Console.ReadKey();

        }



        
    }
}
