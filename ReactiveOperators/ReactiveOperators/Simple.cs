using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Text;

namespace ReactiveOperators
{
    class Simple
    {
        public void SimpleMethod()
        {
            var oneNumberPerSecond = Observable.Interval(TimeSpan.FromSeconds(1));

            var numbersTimesTwo = from n in oneNumberPerSecond
                                  where n<5
                                  select n *2 ;
            

            Console.WriteLine("Numbers * 2 :");

            numbersTimesTwo.Subscribe(num =>
            {
                Console.WriteLine(num);
            });

            //Console.ReadKey();
        }
        public void Range()
        {
                IObservable<int> source = Observable.Range(1, 10);
                IDisposable subscription = source.Subscribe(
                x => Console.WriteLine("OnNext: {0}", x),
                ex => Console.WriteLine("OnError: {0}", ex.Message),
                () => Console.WriteLine("OnCompleted"));
                Console.WriteLine("Press ENTER to unsubscribe...");
                Console.ReadLine();
                subscription.Dispose();
        }
        
    }
}
    

